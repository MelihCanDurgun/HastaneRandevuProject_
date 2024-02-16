namespace Hastane
{
    partial class FrmDoktorBilgiDuzenle
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
            TxtAd = new TextBox();
            label5 = new Label();
            TxtSoyad = new TextBox();
            label4 = new Label();
            label1 = new Label();
            MskTc = new MaskedTextBox();
            TxtSifre = new TextBox();
            label3 = new Label();
            CmdBrans = new ComboBox();
            label2 = new Label();
            BtnBilgiGuncelle = new Button();
            SuspendLayout();
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(180, 36);
            TxtAd.Margin = new Padding(2);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(151, 36);
            TxtAd.TabIndex = 33;
            TxtAd.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 44);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 28);
            label5.TabIndex = 32;
            label5.Text = "Ad:";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(180, 80);
            TxtSoyad.Margin = new Padding(2);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(151, 36);
            TxtSoyad.TabIndex = 31;
            TxtSoyad.Text = " ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 88);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 30;
            label4.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 131);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 29;
            label1.Text = "Tc Kimlik No:";
            // 
            // MskTc
            // 
            MskTc.Location = new Point(180, 128);
            MskTc.Margin = new Padding(2);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(151, 36);
            MskTc.TabIndex = 28;
            MskTc.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(180, 235);
            TxtSifre.Margin = new Padding(2);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(151, 36);
            TxtSifre.TabIndex = 35;
            TxtSifre.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 238);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 34;
            label3.Text = "Şifre :";
            // 
            // CmdBrans
            // 
            CmdBrans.FormattingEnabled = true;
            CmdBrans.Location = new Point(180, 185);
            CmdBrans.Name = "CmdBrans";
            CmdBrans.Size = new Size(151, 36);
            CmdBrans.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 193);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 37;
            label2.Text = "Branş:";
            // 
            // BtnBilgiGuncelle
            // 
            BtnBilgiGuncelle.BackColor = Color.FromArgb(255, 128, 128);
            BtnBilgiGuncelle.Location = new Point(180, 292);
            BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            BtnBilgiGuncelle.Size = new Size(151, 41);
            BtnBilgiGuncelle.TabIndex = 38;
            BtnBilgiGuncelle.Text = "Güncelle";
            BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(418, 373);
            Controls.Add(BtnBilgiGuncelle);
            Controls.Add(label2);
            Controls.Add(CmdBrans);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Controls.Add(TxtSoyad);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(MskTc);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmDoktorBilgiDuzenle";
            Text = "FrmDoktorBilgiDuzenle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAd;
        private Label label5;
        private TextBox TxtSoyad;
        private Label label4;
        private Label label1;
        private MaskedTextBox MskTc;
        private TextBox TxtSifre;
        private Label label3;
        private ComboBox CmdBrans;
        private Label label2;
        private Button BtnBilgiGuncelle;
    }
}