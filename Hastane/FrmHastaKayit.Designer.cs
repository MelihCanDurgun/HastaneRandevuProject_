namespace Hastane
{
    partial class FrmHastaKayit
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
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            TxtSifre = new TextBox();
            label1 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            TxtAd = new TextBox();
            label5 = new Label();
            MskTelefon = new MaskedTextBox();
            CmdCinsiyet = new ComboBox();
            label6 = new Label();
            BtnKayitYap = new Button();
            SuspendLayout();
            // 
            // MskTc
            // 
            MskTc.Location = new Point(162, 99);
            MskTc.Margin = new Padding(2, 2, 2, 2);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(124, 27);
            MskTc.TabIndex = 7;
            MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 168);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 5;
            label2.Text = "Telefon Numarası:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(162, 161);
            TxtSifre.Margin = new Padding(2);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(124, 27);
            TxtSifre.TabIndex = 10;
            TxtSifre.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 106);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 9;
            label1.Text = "Tc Kimlik No:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(162, 67);
            TxtSoyad.Margin = new Padding(2);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(124, 27);
            TxtSoyad.TabIndex = 12;
            TxtSoyad.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 74);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Soyad:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(162, 34);
            TxtAd.Margin = new Padding(2);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(124, 27);
            TxtAd.TabIndex = 14;
            TxtAd.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 41);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 13;
            label5.Text = "Ad:";
            label5.Click += this.label5_Click;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(162, 132);
            MskTelefon.Margin = new Padding(2);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(124, 27);
            MskTelefon.TabIndex = 15;
            // 
            // CmdCinsiyet
            // 
            CmdCinsiyet.FormattingEnabled = true;
            CmdCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmdCinsiyet.Location = new Point(162, 193);
            CmdCinsiyet.Name = "CmdCinsiyet";
            CmdCinsiyet.Size = new Size(124, 28);
            CmdCinsiyet.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 201);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 17;
            label6.Text = "Cinsiyet:";
            // 
            // BtnKayitYap
            // 
            BtnKayitYap.BackColor = Color.FromArgb(128, 255, 128);
            BtnKayitYap.Location = new Point(162, 237);
            BtnKayitYap.Name = "BtnKayitYap";
            BtnKayitYap.Size = new Size(124, 29);
            BtnKayitYap.TabIndex = 18;
            BtnKayitYap.Text = "Kayıt Yap";
            BtnKayitYap.UseVisualStyleBackColor = false;
            // 
            // FrmHastaKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(318, 287);
            Controls.Add(BtnKayitYap);
            Controls.Add(label6);
            Controls.Add(CmdCinsiyet);
            Controls.Add(MskTelefon);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(TxtSifre);
            Controls.Add(label1);
            Controls.Add(MskTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FrmHastaKayit";
            Text = "FrmUyeKayit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private TextBox TxtSifre;
        private Label label1;
        private TextBox TxtSoyad;
        private Label label4;
        private TextBox TxtAd;
        private Label label5;
        private MaskedTextBox MskTelefon;
        private ComboBox CmdCinsiyet;
        private Label label6;
        private Button BtnKayitYap;
    }
}