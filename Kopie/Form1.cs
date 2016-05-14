using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zdrojAdresar.ShowDialog();
            zdrojText.Text = zdrojAdresar.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cilAdresar.ShowDialog();
            cilText.Text = cilAdresar.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(zdrojAdresar.SelectedPath) && Directory.Exists(cilAdresar.SelectedPath) && pripona.SelectedIndex != -1)
            {
                foreach(string podslozka in Directory.EnumerateDirectories(zdrojAdresar.SelectedPath))
                {
                    foreach(string soubor in Directory.EnumerateFiles(podslozka))
                    {
                        File.Copy(soubor, cilAdresar.SelectedPath);
                    }
                }
            }
        }
    }
}
