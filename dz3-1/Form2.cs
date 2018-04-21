using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_1
{
    public partial class Form2 : Form
    {
        private string searchPath;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            searchPath = folder.SelectedPath;
            textBox1.Text = searchPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] dirs;
            string mask = textBox2.Text;
            if (mask != "")
            {
                try
                {
                    dirs = Directory.GetFiles(searchPath,mask);
                    foreach (string dir in dirs)
                    {
                        listBox1.Items.Add(dir);
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine("The process failed: {0}", ee.ToString());
                }

            }
        }
    }
}
