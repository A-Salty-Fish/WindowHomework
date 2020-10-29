using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddMul = MyCOM.Class1;

using MsWord = Microsoft.Office.Interop.Word;


namespace DLLandCOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManagedFacButton_Click(object sender, EventArgs e)
        {
            long input;
            bool isInputLegal = long.TryParse(FacInputTextBox.Text, out input);
            if (!isInputLegal) FacOutputTextBox.Text = "Illegal input";
            else
            {
                Assembly assembly = Assembly.LoadFrom("FacFab.dll");
                foreach (var t in assembly.GetTypes())
                {
                    if (t.IsClass && !t.IsAbstract)
                    {
                        MethodInfo fac = t.GetMethod("fac");
                        Object o = Activator.CreateInstance(t);
                        Object[] parameters = new Object[1];
                        parameters[0] = input;
                        string result = String.Format("{0}", (long)fac.Invoke(o, parameters));
                        FacOutputTextBox.Text = result;
                    }
                }
            }
        }

        private void ManagedFabButton_Click(object sender, EventArgs e)
        {
            long input;
            bool isInputLegal = long.TryParse(FabInputTextBox.Text, out input);
            if (!isInputLegal) FabOutputTextBox.Text = "Illegal input";
            else
            {
                Assembly assembly = Assembly.LoadFrom("FacFab.dll");
                foreach (var t in assembly.GetTypes())
                {
                    if (t.IsClass && !t.IsAbstract)
                    {
                        MethodInfo fab = t.GetMethod("fab");
                        Object o = Activator.CreateInstance(t);
                        Object[] parameters = new Object[1];
                        parameters[0] = input;
                        string result = String.Format("{0}", (long)fab.Invoke(o, parameters));
                        FabOutputTextBox.Text = result;
                    }
                }
            }
        }
        [DllImport("CPlusFabFac.dll", EntryPoint= "_fab@4")]
        public static extern int fab(int n);
        [DllImport("CPlusFabFac.dll", EntryPoint = "_fac@4")]
        public static extern int fac(int n);
        private void UnmanagedFacButton_Click(object sender, EventArgs e)
        {
            int input;
            bool isInputLegal = int.TryParse(FacInputTextBox.Text, out input);
            if (!isInputLegal) FacOutputTextBox.Text = "Illegal input";
            else
            {
                int result = fac(input);
                FacOutputTextBox.Text = "" + result;
            }
        }

        private void UnmanagedFabButton_Click(object sender, EventArgs e)
        {
            int input;
            bool isInputLegal = int.TryParse(FabInputTextBox.Text, out input);
            if (!isInputLegal) FabOutputTextBox.Text = "Illegal input";
            else
            {
                int result = fab(input);
                FabOutputTextBox.Text = "" + result;
            }
        }


        AddMul class1 = new AddMul();
        private void label5_Click(object sender, EventArgs e)
        {
            int input1, input2;
            if (!int.TryParse(SumInput1TextBox.Text,out input1) || !int.TryParse(SumInput2TextBox.Text, out input2))
            {
                SumOutputTextBox.Text = "Illegal Input";
            }
            else
            {
                SumOutputTextBox.Text = "" + class1.Add(input1, input2);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            int input1, input2;
            if (!int.TryParse(MulInput1TextBox.Text, out input1) || !int.TryParse(MulInput2TextBox.Text, out input2))
            {
                MulOutputTextBox.Text = "Illegal Input";
            }
            else
            {
                MulOutputTextBox.Text = "" + class1.Mul(input1, input2);
            }
        }

        private void NewWordButton_Click(object sender, EventArgs e)
        {
            MsWord.Application oWordApplic;
            MsWord.Document oDoc;
            try
            {
                string doc_file_name = @"\content.doc";
                //存在旧word文档则删除
                if (File.Exists(doc_file_name))
                {
                    File.Delete(doc_file_name);
                }
                oWordApplic = new MsWord.Application();
                object missing = System.Reflection.Missing.Value;//参数默认值
                //创建word文档的小节
                MsWord.Range curRange;
                object curTxt;
                int curSectionNum = 1;
                oDoc = oWordApplic.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                oDoc.Activate();
                Console.WriteLine("正在生成文档小节");
                object section_nextPage = MsWord.WdBreakType.wdSectionBreakNextPage;
                object page_break = MsWord.WdBreakType.wdPageBreak;
                for (int si = 0;si <4;si++)
                {
                    oDoc.Paragraphs[1].Range.InsertParagraphAfter();
                    oDoc.Paragraphs[1].Range.InsertBreak(ref section_nextPage);
                }
                //保存文件
                oDoc.Fields[1].Update();
                object fileName = doc_file_name;
                oDoc.SaveAs2(ref fileName);
                oDoc.Close();
                //释放Document对象和Application对象
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oDoc);
                oDoc = null;
                oWordApplic.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oWordApplic);
                oWordApplic = null;
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
    }
}
