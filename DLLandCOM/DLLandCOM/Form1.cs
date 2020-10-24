using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCOM;

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

        Class1 class1 = new Class1();
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


    }
}
