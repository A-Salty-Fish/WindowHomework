using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
