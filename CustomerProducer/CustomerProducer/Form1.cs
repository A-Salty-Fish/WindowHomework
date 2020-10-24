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
        static AutoResetEvent TextBoxResetEvent = new AutoResetEvent(true);
        public void ThreadTextBox(string input)//线程安全化文本框输入
        {
            TextBoxResetEvent.WaitOne();
            outPutTextBox.Text += input;
            TextBoxResetEvent.Set();
        }
        static int CreateThreadCount = 0;
        private void CreateThreadButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                CreateThreadCount++;
                ThreadTextBox("New Thread:" + CreateThreadCount + "\r\n");
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
       
        private void BackThreadButton_Click(object sender, EventArgs e)
        {
            Thread foregroundThread =
                new Thread(()=> {
                    RunLoop(10);
                });
            Thread backgroundThread =
                new Thread(() => {
                    RunLoop(20);
                });
            backgroundThread.IsBackground = true;

            foregroundThread.Start();
            backgroundThread.Start();
        }
        public void RunLoop(int maxIterations)
        {
            for (int i = 0; i < maxIterations; i++)
            {
                ThreadTextBox((Thread.CurrentThread.IsBackground ?
                       "Background Thread" : "Foreground Thread") +
                       " count: " + i + "\r\n");
                Thread.Sleep(1000);
            }
            ThreadTextBox((Thread.CurrentThread.IsBackground ?
                              "Background Thread" : "Foreground Thread") +
                              " finished counting." + "\r\n");
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
                ThreadTextBox("Before Joining" + "\r\n");
                Thread.Sleep(2000);
            });
            Thread thread2 = new Thread(() =>
            {
                thread1.Join();
                ThreadTextBox("After Joining" + "\r\n");
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
                ThreadTextBox("BeforeReset:" + count + "\r\n");
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
                ThreadTextBox("AfterReset1:" + count + "\r\n");
                autoResetEvent.WaitOne();
                ThreadTextBox("AfterReset1:" + count + "\r\n");
            });

            Thread thread3 = new Thread(() =>
            {
                autoResetEvent.WaitOne();
                ThreadTextBox("AfterReset2:" + count + "\r\n");
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
                ThreadTextBox("BeforeReset:" + count + "\r\n");
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
                ThreadTextBox("AfterReset1:" + count + "\r\n");
                manualResetEvent.WaitOne();
                ThreadTextBox("AfterReset1:" + count + "\r\n");
            });
            Thread thread3 = new Thread(() =>
            {
                manualResetEvent.WaitOne();
                Thread.Sleep(1000);
                ThreadTextBox("AfterReset2:" + count + "\r\n");
            });
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        static readonly int BUFFER_SIZE = 5;
        static Mutex bufferMutex = new Mutex();
        static Semaphore fillCount = new Semaphore(0, BUFFER_SIZE);
        static Semaphore emptyCount = new Semaphore(BUFFER_SIZE, BUFFER_SIZE);
        private void CusProButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //生成2-4个生产消费者
            int CustomerNum = random.Next() % 3 + 2;
            int ProducerNum = CustomerNum;
            ThreadTextBox("生产者数量:" + CustomerNum + "\r\n");
            ThreadTextBox("消费者数量:" + ProducerNum + "\r\n");
            Queue<int> products = new Queue<int>();

            Thread[] producerThreads = new Thread[ProducerNum];
            Thread[] customerThreads = new Thread[CustomerNum];

            for (int i =0;i<ProducerNum;i++)
            {
                producerThreads[i] = new Thread((n) =>
                {
                    ThreadTextBox("生产者:" + n + " 准备生产" + "\r\n");
                    emptyCount.WaitOne();
                    bufferMutex.WaitOne();
                    int product = random.Next() % 100 + 100;
                    ThreadTextBox("生产者:" + n + "生产:" + product + "\r\n");
                    products.Enqueue(product);
                    Thread.Sleep(1000);
                    bufferMutex.ReleaseMutex();
                    fillCount.Release();
                });
            }

            for (int i=0;i<CustomerNum;i++)
            {
                customerThreads[i] = new Thread((n) =>
                {
                    ThreadTextBox("消费者:" + n + " 准备消费" + "\r\n");
                    fillCount.WaitOne();
                    bufferMutex.WaitOne();
                    int product = products.Dequeue();
                    ThreadTextBox("消费者:" + n + " 消费:" + product + "\r\n");
                    Thread.Sleep(1000);
                    bufferMutex.ReleaseMutex();
                    emptyCount.Release();
                });
            }
            for (int i = 0; i < ProducerNum; i++) producerThreads[i].Start(i);
            for (int i = 0; i < CustomerNum; i++) customerThreads[i].Start(i);
        }
    }
}
