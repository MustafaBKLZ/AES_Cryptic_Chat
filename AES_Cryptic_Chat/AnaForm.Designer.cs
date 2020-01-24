namespace AES_Cryptic_Chat
{
    partial class AnaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kul1 = new System.Windows.Forms.Button();
            this.btn_kul2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Kul_1_Public_Key = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Kul_2_Public_Key = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Baslatma_Vektoru_IV = new System.Windows.Forms.TextBox();
            this.txt_Ortak_Anahtar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::AES_Cryptic_Chat.Properties.Resources.mustafabukulmez_com_logo_128x256_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şifreli Mesajlaşma - Diffie Hellman + AES";
            // 
            // btn_kul1
            // 
            this.btn_kul1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kul1.Location = new System.Drawing.Point(14, 481);
            this.btn_kul1.Name = "btn_kul1";
            this.btn_kul1.Size = new System.Drawing.Size(372, 53);
            this.btn_kul1.TabIndex = 2;
            this.btn_kul1.Text = "1. Kişi";
            this.btn_kul1.UseVisualStyleBackColor = true;
            this.btn_kul1.Click += new System.EventHandler(this.btn_kul1_Click);
            // 
            // btn_kul2
            // 
            this.btn_kul2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kul2.Location = new System.Drawing.Point(416, 481);
            this.btn_kul2.Name = "btn_kul2";
            this.btn_kul2.Size = new System.Drawing.Size(371, 53);
            this.btn_kul2.TabIndex = 3;
            this.btn_kul2.Text = "2. Kişi";
            this.btn_kul2.UseVisualStyleBackColor = true;
            this.btn_kul2.Click += new System.EventHandler(this.btn_kul2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Açık Anahtar (Public Key):";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "1. Kişi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Kul_1_Public_Key
            // 
            this.txt_Kul_1_Public_Key.Location = new System.Drawing.Point(14, 349);
            this.txt_Kul_1_Public_Key.Multiline = true;
            this.txt_Kul_1_Public_Key.Name = "txt_Kul_1_Public_Key";
            this.txt_Kul_1_Public_Key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Kul_1_Public_Key.Size = new System.Drawing.Size(372, 126);
            this.txt_Kul_1_Public_Key.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Açık Anahtar (Public Key):";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(416, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(371, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "2. Kişi";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Kul_2_Public_Key
            // 
            this.txt_Kul_2_Public_Key.Location = new System.Drawing.Point(416, 349);
            this.txt_Kul_2_Public_Key.Multiline = true;
            this.txt_Kul_2_Public_Key.Name = "txt_Kul_2_Public_Key";
            this.txt_Kul_2_Public_Key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Kul_2_Public_Key.Size = new System.Drawing.Size(371, 126);
            this.txt_Kul_2_Public_Key.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ortak anahtar (common key):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "AES başlatma vektörü (initialization vector - IV):";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(773, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "ORTAK";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Baslatma_Vektoru_IV
            // 
            this.txt_Baslatma_Vektoru_IV.Location = new System.Drawing.Point(249, 257);
            this.txt_Baslatma_Vektoru_IV.Name = "txt_Baslatma_Vektoru_IV";
            this.txt_Baslatma_Vektoru_IV.Size = new System.Drawing.Size(538, 20);
            this.txt_Baslatma_Vektoru_IV.TabIndex = 27;
            // 
            // txt_Ortak_Anahtar
            // 
            this.txt_Ortak_Anahtar.Location = new System.Drawing.Point(249, 230);
            this.txt_Ortak_Anahtar.Name = "txt_Ortak_Anahtar";
            this.txt_Ortak_Anahtar.Size = new System.Drawing.Size(538, 20);
            this.txt_Ortak_Anahtar.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(14, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "Tek Formda Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Baslatma_Vektoru_IV);
            this.Controls.Add(this.txt_Ortak_Anahtar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Kul_2_Public_Key);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Kul_1_Public_Key);
            this.Controls.Add(this.btn_kul2);
            this.Controls.Add(this.btn_kul1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Kul_1_Public_Key;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt_Kul_2_Public_Key;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txt_Baslatma_Vektoru_IV;
        public System.Windows.Forms.TextBox txt_Ortak_Anahtar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_kul1;
        public System.Windows.Forms.Button btn_kul2;
        public System.Windows.Forms.Button button1;
    }
}