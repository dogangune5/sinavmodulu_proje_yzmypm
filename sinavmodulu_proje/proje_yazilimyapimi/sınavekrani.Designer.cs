namespace proje_yazilimyapimi
{
    partial class sınavekrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sınavekrani));
            this.btnAnalizRaporu = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSinavaBasla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnAnalizRaporu
            // 
            this.btnAnalizRaporu.BackColor = System.Drawing.SystemColors.Info;
            this.btnAnalizRaporu.Location = new System.Drawing.Point(102, 585);
            this.btnAnalizRaporu.Name = "btnAnalizRaporu";
            this.btnAnalizRaporu.Size = new System.Drawing.Size(176, 46);
            this.btnAnalizRaporu.TabIndex = 0;
            this.btnAnalizRaporu.Text = "Analiz raporu";
            this.btnAnalizRaporu.UseVisualStyleBackColor = false;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAyarlar.Location = new System.Drawing.Point(102, 334);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(182, 46);
            this.btnAyarlar.TabIndex = 1;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Location = new System.Drawing.Point(102, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eksiklerini gider";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnSinavaBasla
            // 
            this.btnSinavaBasla.BackColor = System.Drawing.SystemColors.Info;
            this.btnSinavaBasla.Location = new System.Drawing.Point(102, 220);
            this.btnSinavaBasla.Name = "btnSinavaBasla";
            this.btnSinavaBasla.Size = new System.Drawing.Size(182, 46);
            this.btnSinavaBasla.TabIndex = 3;
            this.btnSinavaBasla.Text = "Sınava başla";
            this.btnSinavaBasla.UseVisualStyleBackColor = false;
            this.btnSinavaBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.ImageKey = "png-clipart-computer-keyboard-backspace-arrow-computer-icons-arrow-cdr-angle-thum" +
    "bnail.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 42);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "png-clipart-computer-keyboard-backspace-arrow-computer-icons-arrow-cdr-angle-thum" +
        "bnail.png");
            // 
            // sınavekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 756);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSinavaBasla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnAnalizRaporu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sınavekrani";
            this.Text = "sınavekrani";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAnalizRaporu;
        private Button btnAyarlar;
        private Button button3;
        private Button btnSinavaBasla;
        private Button button2;
        private ImageList ımageList1;
    }
}