namespace AES_Cryptic_Chat
{
    partial class Kullanici_2_Ekran
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gelen_sifreli = new System.Windows.Forms.TextBox();
            this.txt_gelen_normal = new System.Windows.Forms.TextBox();
            this.txt_gonderilecek = new System.Windows.Forms.TextBox();
            this.btn_Gonder_Kul_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Red;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(375, 25);
            this.label15.TabIndex = 62;
            this.label15.Text = "2. Kişi";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Gelen Mesaj (Şifreli)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Gelen Mesaj";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mesaj";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_gelen_sifreli
            // 
            this.txt_gelen_sifreli.Location = new System.Drawing.Point(12, 74);
            this.txt_gelen_sifreli.Multiline = true;
            this.txt_gelen_sifreli.Name = "txt_gelen_sifreli";
            this.txt_gelen_sifreli.ReadOnly = true;
            this.txt_gelen_sifreli.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gelen_sifreli.Size = new System.Drawing.Size(372, 60);
            this.txt_gelen_sifreli.TabIndex = 66;
            // 
            // txt_gelen_normal
            // 
            this.txt_gelen_normal.Location = new System.Drawing.Point(12, 165);
            this.txt_gelen_normal.Multiline = true;
            this.txt_gelen_normal.Name = "txt_gelen_normal";
            this.txt_gelen_normal.ReadOnly = true;
            this.txt_gelen_normal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gelen_normal.Size = new System.Drawing.Size(372, 60);
            this.txt_gelen_normal.TabIndex = 67;
            // 
            // txt_gonderilecek
            // 
            this.txt_gonderilecek.Location = new System.Drawing.Point(12, 281);
            this.txt_gonderilecek.Multiline = true;
            this.txt_gonderilecek.Name = "txt_gonderilecek";
            this.txt_gonderilecek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_gonderilecek.Size = new System.Drawing.Size(372, 120);
            this.txt_gonderilecek.TabIndex = 68;
            // 
            // btn_Gonder_Kul_1
            // 
            this.btn_Gonder_Kul_1.Location = new System.Drawing.Point(271, 407);
            this.btn_Gonder_Kul_1.Name = "btn_Gonder_Kul_1";
            this.btn_Gonder_Kul_1.Size = new System.Drawing.Size(116, 29);
            this.btn_Gonder_Kul_1.TabIndex = 69;
            this.btn_Gonder_Kul_1.Tag = "1";
            this.btn_Gonder_Kul_1.Text = "GÖNDER";
            this.btn_Gonder_Kul_1.UseVisualStyleBackColor = true;
            this.btn_Gonder_Kul_1.Click += new System.EventHandler(this.btn_Gonder_Kul_1_Click);
            // 
            // Kullanici_2_Ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 455);
            this.Controls.Add(this.btn_Gonder_Kul_1);
            this.Controls.Add(this.txt_gonderilecek);
            this.Controls.Add(this.txt_gelen_normal);
            this.Controls.Add(this.txt_gelen_sifreli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Name = "Kullanici_2_Ekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2. Kişi Ekranı";
            this.Load += new System.EventHandler(this.Kullanici_1_Ekran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_gelen_sifreli;
        public System.Windows.Forms.TextBox txt_gelen_normal;
        public System.Windows.Forms.TextBox txt_gonderilecek;
        public System.Windows.Forms.Button btn_Gonder_Kul_1;
    }
}