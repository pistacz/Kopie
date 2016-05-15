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
            zmenaTextu(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cilAdresar.ShowDialog();
            cilText.Text = cilAdresar.SelectedPath;
            zmenaTextu(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(zdrojAdresar.SelectedPath) && Directory.Exists(cilAdresar.SelectedPath) && pripona.SelectedIndex != -1)
            {
                btnKopirovat.Text = "Kopíruji …";
                progressBar1.Step = 1;
                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = Directory.EnumerateFileSystemEntries(zdrojAdresar.SelectedPath).Count();
                //progressBar1.Visible = true;
                int poradi = 0;
                foreach (string soubory in Directory.EnumerateFiles(zdrojAdresar.SelectedPath))
                {
                    progressBar1.PerformStep();
                    FileInfo infoSoub = new FileInfo(soubory);
                    switch (pripona.SelectedItem.ToString())
                    {
                        case "*.pdf":
                            if (infoSoub.Extension == ".pdf")
                                File.Copy(soubory, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                            break;
                        case "*.slprt":
                            if (infoSoub.Extension == ".slprt")
                                File.Copy(soubory, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                            break;
                        case "*.pdf a *.slprt":
                            if (infoSoub.Extension == ".slprt" || infoSoub.Extension == ".pdf")
                                File.Copy(soubory, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                            break;
                        case "*.*":
                        default:
                            File.Copy(soubory, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                            break;
                    }
                }
                foreach (string podslozka in Directory.EnumerateDirectories(zdrojAdresar.SelectedPath))
                {
                    poradi += 1;
                    progressBar1.PerformStep();
                    foreach(string soubor in Directory.EnumerateFiles(podslozka))
                    {
                        FileInfo infoSoub = new FileInfo(soubor);
                        switch(pripona.SelectedItem.ToString())
                        {
                            case "*.pdf":
                                if (infoSoub.Extension == ".pdf")
                                    File.Copy(soubor, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                                break;
                            case "*.slprt":
                                if (infoSoub.Extension == ".slprt")
                                    File.Copy(soubor, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                                break;
                            case "*.pdf a *.slprt":
                                if (infoSoub.Extension == ".slprt" || infoSoub.Extension == ".pdf")
                                    File.Copy(soubor, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                                break;
                            case "*.*":
                            default:
                                File.Copy(soubor, cilAdresar.SelectedPath + "\\" + poradi + "_" + infoSoub.Name, true);
                                break;
                        }
                    }
                }
                
                zdrojAdresar.SelectedPath = cilAdresar.SelectedPath = zdrojText.Text = cilText.Text = "";
                pripona.SelectedIndex = -1;
                btnKopirovat.Text = "Kopírovat soubory";
                zmenaTextu(sender, e);
            }
        }

        private void zmenaTextu(object sender, EventArgs e)
        {
            //if (zdrojText != null && zdrojText.Text != "" && cilText != null && cilText.Text != "" && pripona.SelectedIndex != -1)
            if (zdrojAdresar.SelectedPath != null && cilAdresar.SelectedPath != null && zdrojAdresar.SelectedPath != "" && cilAdresar.SelectedPath != "" && pripona.SelectedIndex != -1)
            {
                btnKopirovat.BackColor = Color.Green;
                btnKopirovat.Enabled = true;
            }
            else
            {
                btnKopirovat.BackColor = Color.Red;
                btnKopirovat.Enabled = false;
                progressBar1.Value = 0;
            }
        }
    }
}
