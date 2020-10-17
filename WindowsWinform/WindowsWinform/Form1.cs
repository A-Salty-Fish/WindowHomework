using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SynPing(outputTextBox, inputTextBox.Text, 9);
        }
        string DefaultTargetUrl = "www.whu.edu.cn";
        private void SynPing(TextBox textBox, string targetUrl, int nums)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            // 是否使用外壳程序   
            process.StartInfo.UseShellExecute = false;
            // 是否在新窗口中启动该进程的值   
            process.StartInfo.CreateNoWindow = true;
            // 重定向输入流  
            process.StartInfo.RedirectStandardInput = true;
            // 重定向输出流
            process.StartInfo.RedirectStandardOutput = true;
            //使ping命令执行nums次
            string strCmd = "ping " +
                ((targetUrl == null || targetUrl == "") ? DefaultTargetUrl : targetUrl)
                 + " -n " + nums;
            process.Start();
            process.StandardInput.WriteLine(strCmd);
            process.StandardInput.WriteLine("exit");
            // 获取输出信息   
            textBox.Text = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = null;
        }
    }
}
