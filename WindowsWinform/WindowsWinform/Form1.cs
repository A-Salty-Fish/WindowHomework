using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SynPing(outputTextBox, inputTextBox.Text, 9);
        }
        string DefaultTargetUrl = "www.whu.edu.cn";
        private void SynPing(TextBox textBox, string targetUrl, int nums)//同步ping方法
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
        //清除按钮
        private void button3_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = null;
            cmdOutput = null;
        }

        //异步响应方式所需要的重定向输入输出流对象
        public static Process cmdP;
        public static StreamWriter cmdStreamInput;
        private static StringBuilder cmdOutput = new StringBuilder("");

        //自定义窗体消息
        public const int TRAN_FINISHED = 0x500;

        //SendMessage方法需要的handle值
        public static IntPtr main_whandle;//主窗体
        public static IntPtr text_whandle;//文本控件

        //此函数重定向进程的输入输出
        private void StartCmd(string cmdFile)
        {
            if (cmdP!=null)//已经创建过
            {
                if (!cmdP.HasExited)
                {
                    cmdP.Close();
                }
            }
            cmdP = new Process();
            //设定进程名
            cmdP.StartInfo.FileName = cmdFile;
            cmdP.StartInfo.CreateNoWindow = true;
            cmdP.StartInfo.UseShellExecute = false;
            //重定向输入输出流
            cmdP.StartInfo.RedirectStandardOutput = true;
            cmdP.StartInfo.RedirectStandardInput = true;
            cmdOutput = new StringBuilder("");
            //输出数据异步事件
            cmdP.OutputDataReceived += new DataReceivedEventHandler(strOutputHandler);
            //异步处理中通知进程已退出
            cmdP.EnableRaisingEvents = true;
            string strCmd = "ping " +
                (inputTextBox.Text == null || inputTextBox.Text == "" ? "www.baidu.com" : inputTextBox.Text) +
                " -n  9";
            cmdP.Start();
            cmdP.StandardInput.WriteLine(strCmd);
            //重定向进程输入流
            cmdStreamInput = cmdP.StandardInput;
            //开始异步输出的读入
            cmdP.BeginOutputReadLine();
        }
        //回调函数
        private static void strOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            //将每次输出产生的数据附加到结果字符串中
            cmdOutput.Append(outLine.Data);
            //换行
            cmdOutput.Append("\r\n");
            //设置输出文本框内容
            SendMessage(main_whandle, TRAN_FINISHED, 0, 0);
        }
        //通知窗体更新数据的内核函数
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll", EntryPoint = "RedrawWindow")]
        public static extern bool RedrawWindow(IntPtr hWnd, IntPtr prect, IntPtr hrgnUpdate, GraphicsUnit flags);
        public const int WM_VSCROLL = 0x0115;
        public const int SB_BOTTOM = 0x0007;
        public static int WM_SETREDRAW = 0x0B;


        private void button2_Click(object sender, EventArgs e)
        {
            StartCmd("cmd.exe");
        }
        //窗体加载时获得窗体和文本框对象的handle值
        private void Form1_Load(object sender, EventArgs e)
        {
            main_whandle = this.Handle;
            text_whandle = outputTextBox.Handle;
        }

        //重载窗体消息处理
        protected override void DefWndProc(ref Message m)
        {
            switch(m.Msg)
            {
                case TRAN_FINISHED:
                    SendMessage(text_whandle, WM_SETREDRAW, 0, 0);
                    outputTextBox.Text = cmdOutput.ToString();
                    SendMessage(text_whandle, WM_VSCROLL, SB_BOTTOM, 50);
                    SendMessage(text_whandle, WM_SETREDRAW, 1, 0);
                    RedrawWindow(text_whandle, IntPtr.Zero, IntPtr.Zero, (GraphicsUnit)(1 | 4 | 128));
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }
        //普通异步
        public delegate void DelReadStdOutput(string result);
        public delegate void DelReadErrOutput(string result);
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        private void Init()
        {
            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }
        private void RealAction(string StartFileName, string StartFileArg = "www.baidu.com")
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  

            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                                                                //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
            // CmdProcess.WaitForExit();       
        }
        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            this.outputTextBox.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            this.outputTextBox.AppendText(result + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = null;
            RealAction("ping.exe", inputTextBox.Text + " -n 9");
        }
        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
        }
    }
}
