using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace TF2Config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        Dictionary<string, string> cfgPathAndNameLog = new Dictionary<string, string>();
        Dictionary<string, string> CommandsLog = new Dictionary<string, string>();

        private void ButtonOpenCFGfile_Click(object sender, EventArgs e)
        {
            ofd.Filter = ".cfg|*cfg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!cfgPathAndNameLog.ContainsKey(ofd.FileName))
                {
                    ListBoxCFGcontainer.Items.Add(ofd.SafeFileName);
                    cfgPathAndNameLog.Add(ofd.FileName, ofd.SafeFileName);
                }
                else
                {
                    MessageBox.Show("File already added");
                }
            }
        }

        private void ListBoxCFGcontainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonOpenSelected_Click(object sender, EventArgs e)
        {
            string OpenFilePath = cfgPathAndNameLog.
                                  ElementAt(ListBoxCFGcontainer.SelectedIndex).Key;

            string[] inputData = File.ReadAllLines(OpenFilePath);
            string FormattedCommand = string.Empty;
            string FormattedValue = string.Empty;

            for (int i = 0; i < inputData.Length; i++)
            {
                string[] ArrayCommand = inputData[i].Split(' ');
                if (ArrayCommand.Length == 3)
                {
                    FormattedCommand = string.Join(" ", ArrayCommand.Take(ArrayCommand.Length - 2));
                    FormattedValue = ArrayCommand.Last();
                }
                else if (ArrayCommand.Length == 2)
                {
                    FormattedCommand = ArrayCommand[0];
                    FormattedValue = ArrayCommand[1];
                }
                else if (ArrayCommand.Length == 1)
                {
                    FormattedCommand = ArrayCommand[0];
                    FormattedValue = string.Empty;
                }
                else
                {
                    FormattedValue = "LONGER THAN 3";
                }

                if (CommandsLog.ContainsKey(FormattedCommand))
                {
                    CommandsLog[FormattedCommand] = FormattedValue;
                }
                else
                {
                    CommandsLog.Add(FormattedCommand, FormattedValue);
                }
                
            }





        }
    }
}
