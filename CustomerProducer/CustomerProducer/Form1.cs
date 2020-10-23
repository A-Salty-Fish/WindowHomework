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

        private void BackThreadButton_Click(object sender, EventArgs e)
        {
            Thread foregroundThread =
                new Thread(()=> {
                    //Action action = () => { RunLoop(10); };
                    //this.Invoke(action);
                    RunLoop(10);
                });
            Thread backgroundThread =
                new Thread(() => {
                    //Action action = () => { RunLoop(50); };
                    //this.Invoke(action);
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
                outPutTextBox.Text += (Thread.CurrentThread.IsBackground ?
                       "Background Thread" : "Foreground Thread") +
                       " count: " + i + "\r\n";
                Thread.Sleep(100);
            }
            outPutTextBox.Text += (Thread.CurrentThread.IsBackground ?
                              "Background Thread" : "Foreground Thread") +
                              " finished counting." + "\r\n";
            //for (int i = 0; i < maxIterations; i++)
            //{
            //    Console.WriteLine("{0} count: {1}",
            //        Thread.CurrentThread.IsBackground ?
            //           "Background Thread" : "Foreground Thread", i);
            //    Thread.Sleep(250);
            //}
            //Console.WriteLine("{0} finished counting.",
            //                  Thread.CurrentThread.IsBackground ?
            //                  "Background Thread" : "Foreground Thread");
        }

        private void outPutTextBox_TextChanged(object sender, EventArgs e)
        {
            outPutTextBox.SelectionStart = outPutTextBox.Text.Length; //Set the current caret position at the end
            outPutTextBox.ScrollToCaret(); //Now scroll it automatically
        }
    }
}
