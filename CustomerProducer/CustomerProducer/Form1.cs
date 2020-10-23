using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerProducer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        static int CreateThreadCount = 0;
        private void CreateThreadButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Action action = () =>
                {
                    CreateThreadCount++;
                    outPutTextBox.Text += "New Thread:" + CreateThreadCount + "\r\n";
                };
                this.Invoke(action);
            });
            thread.Start();
        }

        private void FrontThreadButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(()=>
            {
               RunLoop(10);
            });
            thread.IsBackground = false;
            thread.Start();
        }
        static AutoResetEvent BackFrontResetEvent = new AutoResetEvent(true);
        private void BackThreadButton_Click(object sender, EventArgs e)
        {
            Thread foregroundThread =
                new Thread(()=> {
                    RunLoop(10);
                });
            Thread backgroundThread =
                new Thread(() => {
                    RunLoop(50);
                });
            backgroundThread.IsBackground = true;

            foregroundThread.Start();
            backgroundThread.Start();
        }
        public void RunLoop(int maxIterations)
        {
            for (int i = 0; i < maxIterations; i++)
            {
                BackFrontResetEvent.WaitOne();
                outPutTextBox.Text += (Thread.CurrentThread.IsBackground ?
                       "Background Thread" : "Foreground Thread") +
                       " count: " + i + "\r\n";
                Thread.Sleep(100);
                BackFrontResetEvent.Set();
            }
            BackFrontResetEvent.WaitOne();
            outPutTextBox.Text += (Thread.CurrentThread.IsBackground ?
                              "Background Thread" : "Foreground Thread") +
                              " finished counting." + "\r\n";
            BackFrontResetEvent.Set();
        }

        private void outPutTextBox_TextChanged(object sender, EventArgs e)
        {
            outPutTextBox.SelectionStart = outPutTextBox.Text.Length; //Set the current caret position at the end
            outPutTextBox.ScrollToCaret(); //Now scroll it automatically
        }

        private void JoinThreadButton_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(() =>
            {
                outPutTextBox.Text += "Before Joining" + "\r\n";
                Thread.Sleep(2000);
            });
            Thread thread2 = new Thread(() =>
            {
                thread1.Join();
                outPutTextBox.Text += "After Joining" + "\r\n";
            });
            thread1.Start();
            thread2.Start();
        }
       
        private void AutoResetButton_Click(object sender, EventArgs e)
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            int count = 0;
            Thread thread1 = new Thread(() =>
            {
                outPutTextBox.Text += "BeforeReset:" + count + "\r\n";
                Thread.Sleep(1000);
                count = 1;
                autoResetEvent.Set();
                Thread.Sleep(1000);
                count = 2;
                autoResetEvent.Set();
            });

            Thread thread2 = new Thread(() =>
            {
                autoResetEvent.WaitOne();
                outPutTextBox.Text += "AfterReset1:" + count + "\r\n";
            });

            Thread thread3 = new Thread(() =>
            {
                autoResetEvent.WaitOne();
                outPutTextBox.Text += "AfterReset2:" + count + "\r\n";
            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void ManualResetButton_Click(object sender, EventArgs e)
        {
            ManualResetEvent manualResetEvent = new ManualResetEvent(false);
            int count = 10;
            Thread thread1 = new Thread(() =>
            {
                outPutTextBox.Text += "BeforeReset:" + count + "\r\n";
                Thread.Sleep(1000);
                count = 11;
                manualResetEvent.Set();
                Thread.Sleep(1000);
                
                count = 12;
                manualResetEvent.Set();
            });
            Thread thread2 = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                outPutTextBox.Text += "AfterReset1:" + count + "\r\n";
            });
            Thread thread3 = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                Thread.Sleep(1000);
                outPutTextBox.Text += "AfterReset2:" + count + "\r\n";
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void CusProButton_Click(object sender, EventArgs e)
        {
            ManualResetEvent BufferEvent = new ManualResetEvent(false);
            ManualResetEvent EemptyEvent = new ManualResetEvent(false);

            Random random = new Random();
            int CustomerNum = random.Next() % 5 + 1;
            int ProducerNum = random.Next() % 5 + 1;

            int[] buffer = new int[100];
            int index = -1;

            Thread[] CustomerThreads = new Thread[CustomerNum];
            Thread[] ProducerThreads = new Thread[ProducerNum];
            for (int i = 0; i < CustomerNum; i++)
            {
                CustomerThreads[i] = new Thread(() =>
                {
                    int num = i;
                    outPutTextBox.Text += "Cusomer" + num + " wants to eat" + "\r\n";
                    EemptyEvent.WaitOne();
                    BufferEvent.WaitOne();
                    outPutTextBox.Text += "Cusomer" + num + " has eaten " + i + 
                    ":" + buffer[i] + "\r\n";
                    index--;
                    if (index < 0) EemptyEvent.Reset();
                    BufferEvent.Set();
                });
            }

            for (int i = 0; i < ProducerNum; i++)
            {
                ProducerThreads[i] = new Thread(() =>
                {
                    int num = i;
                    int product = random.Next() % 100 + 100;
                    outPutTextBox.Text += "Producer" + num + " begin to produce" + product + "\r\n";
                    BufferEvent.WaitOne();
                    buffer[++index] = product;
                    Thread.Sleep(1000);
                    BufferEvent.Set();
                    outPutTextBox.Text += "Producer" + num + " has produced" + "\r\n";
                });
            }
            for (int i = 0; i < ProducerNum; i++)
                ProducerThreads[i].Start();
            for (int i = 0; i < CustomerNum; i++)
                CustomerThreads[i].Start();
        }
    }
}
