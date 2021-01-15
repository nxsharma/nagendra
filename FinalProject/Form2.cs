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

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2(string fileName)
        {
            InitializeComponent();

            if(fileName == String.Empty)
            {
                txtDisplay.Text = "No file to read.";
            }
            else if(!File.Exists(fileName))
            {
                txtDisplay.Text = "File does not exist.";
            }
            else
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string line;

                while((line = sr.ReadLine()) != null)
                {
                    txtDisplay.Text += $"{line}\n";
                }

                sr.Close();
                fs.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
