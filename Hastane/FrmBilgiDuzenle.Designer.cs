namespace Hastane
{
    partial class FrmBilgiDuzenle
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
            BtnBilgiGuncelle = new Button();
            label6 = new Label();
            CmdCinsiyet = new ComboBox();
            MskTelefon = new MaskedTextBox();
            TxtAd = new TextBox();
            label5 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            TxtSifre = new TextBox();
            label1 = new Label();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.BackColor = Color.FromArgb(255, 128, 128);
            BtnBilgiGuncelle.Location = new Point(224, 288);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(124, 41);
            BtnBilgiGuncelle.TabIndex = 31;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 249);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 30;
            label6.Text = "Cinsiyet:";
            // 
            // CmdCinsiyet
            // 
            CmdCinsiyet.FormattingEnabled = true;
            CmdCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmdCinsiyet.Location = new Point(224, 246);
            CmdCinsiyet.Name = "CmdCinsiyet";
            CmdCinsiyet.Size = new Size(124, 36);
            CmdCinsiyet.TabIndex = 29;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(224, 162);
            MskTelefon.Margin = new Padding(2);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(124, 36);
            MskTelefon.TabIndex = 28;
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(224, 23);
            TxtAd.Margin = new Padding(2);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(124, 36);
            TxtAd.TabIndex = 27;
            TxtAd.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 31);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 26;
            label5.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(224, 67);
            TxtSoyad.Margin = new Padding(2);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(124, 36);
            TxtSoyad.TabIndex = 25;
            TxtSoyad.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 24;
            label4.Text = "Soyad:";
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(224, 202);
            TxtSifre.Margin = new Padding(2);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(124, 36);
            TxtSifre.TabIndex = 23;
            TxtSifre.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 22;
            label1.Text = "Tc Kimlik No:";
            // 
            // MskTc
            // 
            MskTc.Location = new Point(224, 115);
            MskTc.Margin = new Padding(2);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(124, 36);
            MskTc.TabIndex = 21;
            MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 205);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 20;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 19;
            label2.Text = "Telefon Numarası:";
            // 
            // FrmBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(434, 372);
            Controls.Add(BtnBilgiGuncelle);
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
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmBilgiDuzenle";
            Text = "FrmBilgiDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBilgiGuncelle;
        private Label label6;
        private ComboBox CmdCinsiyet;
        private MaskedTextBox MskTelefon;
        private TextBox TxtAd;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label4;
        private TextBox TxtSifre;
        private Label label1;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
    }
}