namespace Kopie
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zdrojAdresar = new System.Windows.Forms.FolderBrowserDialog();
            this.zdrojText = new System.Windows.Forms.TextBox();
            this.btnZdroj = new System.Windows.Forms.Button();
            this.btnCil = new System.Windows.Forms.Button();
            this.cilText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cilAdresar = new System.Windows.Forms.FolderBrowserDialog();
            this.pripona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKopirovat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zdrojAdresar
            // 
            resources.ApplyResources(this.zdrojAdresar, "zdrojAdresar");
            // 
            // zdrojText
            // 
            resources.ApplyResources(this.zdrojText, "zdrojText");
            this.zdrojText.Name = "zdrojText";
            this.zdrojText.ReadOnly = true;
            this.zdrojText.TextChanged += new System.EventHandler(this.zmenaTextu);
            // 
            // btnZdroj
            // 
            resources.ApplyResources(this.btnZdroj, "btnZdroj");
            this.btnZdroj.Name = "btnZdroj";
            this.btnZdroj.UseVisualStyleBackColor = true;
            this.btnZdroj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCil
            // 
            resources.ApplyResources(this.btnCil, "btnCil");
            this.btnCil.Name = "btnCil";
            this.btnCil.UseVisualStyleBackColor = true;
            this.btnCil.Click += new System.EventHandler(this.button2_Click);
            // 
            // cilText
            // 
            resources.ApplyResources(this.cilText, "cilText");
            this.cilText.Name = "cilText";
            this.cilText.ReadOnly = true;
            this.cilText.TextChanged += new System.EventHandler(this.zmenaTextu);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Name = "progressBar1";
            // 
            // cilAdresar
            // 
            resources.ApplyResources(this.cilAdresar, "cilAdresar");
            // 
            // pripona
            // 
            resources.ApplyResources(this.pripona, "pripona");
            this.pripona.FormattingEnabled = true;
            this.pripona.Items.AddRange(new object[] {
            resources.GetString("pripona.Items"),
            resources.GetString("pripona.Items1"),
            resources.GetString("pripona.Items2"),
            resources.GetString("pripona.Items3")});
            this.pripona.Name = "pripona";
            this.pripona.SelectedIndexChanged += new System.EventHandler(this.zmenaTextu);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnKopirovat
            // 
            resources.ApplyResources(this.btnKopirovat, "btnKopirovat");
            this.btnKopirovat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKopirovat.Name = "btnKopirovat";
            this.btnKopirovat.UseVisualStyleBackColor = false;
            this.btnKopirovat.Click += new System.EventHandler(this.button3_Click);
            this.btnKopirovat.MouseHover += new System.EventHandler(this.zmenaTextu);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKopirovat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pripona);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCil);
            this.Controls.Add(this.cilText);
            this.Controls.Add(this.btnZdroj);
            this.Controls.Add(this.zdrojText);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.zmenaTextu);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog zdrojAdresar;
        private System.Windows.Forms.TextBox zdrojText;
        private System.Windows.Forms.Button btnZdroj;
        private System.Windows.Forms.Button btnCil;
        private System.Windows.Forms.TextBox cilText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog cilAdresar;
        private System.Windows.Forms.ComboBox pripona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKopirovat;
    }
}

