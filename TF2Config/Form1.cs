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
            FileStream OpenedFile = File.Open(OpenFilePath,FileMode.Open);
            OpenedFile.Close();
        }
    }
}
