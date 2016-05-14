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
            // zdrojText
            // 
            this.zdrojText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdrojText.Location = new System.Drawing.Point(231, 27);
            this.zdrojText.Name = "zdrojText";
            this.zdrojText.Size = new System.Drawing.Size(453, 35);
            this.zdrojText.TabIndex = 0;
            // 
            // btnZdroj
            // 
            this.btnZdroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZdroj.Location = new System.Drawing.Point(23, 23);
            this.btnZdroj.Name = "btnZdroj";
            this.btnZdroj.Size = new System.Drawing.Size(185, 46);
            this.btnZdroj.TabIndex = 1;
            this.btnZdroj.Text = "Vybrat zdroj";
            this.btnZdroj.UseVisualStyleBackColor = true;
            this.btnZdroj.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCil
            // 
            this.btnCil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCil.Location = new System.Drawing.Point(23, 93);
            this.btnCil.Name = "btnCil";
            this.btnCil.Size = new System.Drawing.Size(185, 46);
            this.btnCil.TabIndex = 3;
            this.btnCil.Text = "Vybrat cíl";
            this.btnCil.UseVisualStyleBackColor = true;
            this.btnCil.Click += new System.EventHandler(this.button2_Click);
            // 
            // cilText
            // 
            this.cilText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cilText.Location = new System.Drawing.Point(231, 97);
            this.cilText.Name = "cilText";
            this.cilText.Size = new System.Drawing.Size(453, 35);
            this.cilText.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 311);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(661, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // pripona
            // 
            this.pripona.FormattingEnabled = true;
            this.pripona.Items.AddRange(new object[] {
            "*.pdf",
            "*.slprt",
            "*.pdf a *.slprt",
            "*.*"});
            this.pripona.Location = new System.Drawing.Point(231, 162);
            this.pripona.Name = "pripona";
            this.pripona.Size = new System.Drawing.Size(453, 33);
            this.pripona.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(30, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Typ souboru";
            // 
            // btnKopirovat
            // 
            this.btnKopirovat.BackColor = System.Drawing.Color.Red;
            this.btnKopirovat.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKopirovat.Location = new System.Drawing.Point(23, 218);
            this.btnKopirovat.Name = "btnKopirovat";
            this.btnKopirovat.Size = new System.Drawing.Size(661, 79);
            this.btnKopirovat.TabIndex = 7;
            this.btnKopirovat.Text = "Kopírovat soubory";
            this.btnKopirovat.UseVisualStyleBackColor = false;
            this.btnKopirovat.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 359);
            this.Controls.Add(this.btnKopirovat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pripona);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCil);
            this.Controls.Add(this.cilText);
            this.Controls.Add(this.btnZdroj);
            this.Controls.Add(this.zdrojText);
            this.Name = "Form1";
            this.Text = "Kopírování souborů";
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

