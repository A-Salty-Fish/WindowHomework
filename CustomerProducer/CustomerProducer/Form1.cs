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
                CreateThreadCount++;
                outPutTextBox.Text += "New Thread:" + CreateThreadCount + "\r\n";
            });
            thread.Start();
        }

        private void FrontThreadButton_Click(object sender, EventArgs e)
        {

        }

        private void BackThreadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
