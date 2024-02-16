namespace Hastane
{
    partial class FrmSekreterDetay
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
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTC = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RchDuyuru = new RichTextBox();
            BtnDuyuruOlustur = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            TxtId = new TextBox();
            MskTarih = new MaskedTextBox();
            MskSaat = new MaskedTextBox();
            CmdBrans = new ComboBox();
            CmdDoktor = new ComboBox();
            MskTC = new MaskedTextBox();
            ChkDurum = new CheckBox();
            BtnKaydet = new Button();
            BtnGuncelle = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            BtnDoktorPanel = new Button();
            BtnBransPanel = new Button();
            BtnRandevuListe = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 154);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgisi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LblAdSoyad.Location = new Point(161, 100);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(93, 28);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(29, 100);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LblTC.Location = new Point(161, 58);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(144, 28);
            LblTC.TabIndex = 1;
            LblTC.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(50, 58);
            label1.Name = "label1";
            label1.Size = new Size(87, 28);
            label1.TabIndex = 0;
            label1.Text = "TC NO: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnDuyuruOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(12, 185);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(336, 276);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(20, 35);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(296, 188);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // BtnDuyuruOlustur
            // 
            BtnDuyuruOlustur.Location = new Point(20, 229);
            BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            BtnDuyuruOlustur.Size = new Size(296, 41);
            BtnDuyuruOlustur.TabIndex = 1;
            BtnDuyuruOlustur.Text = "Oluştur";
            BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnGuncelle);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(ChkDurum);
            groupBox3.Controls.Add(MskTC);
            groupBox3.Controls.Add(CmdDoktor);
            groupBox3.Controls.Add(CmdBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(TxtId);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(372, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 449);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = " Randevu Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(27, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 1;
            label2.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(23, 93);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 2;
            label4.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(52, 51);
            label5.Name = "label5";
            label5.Size = new Size(36, 28);
            label5.TabIndex = 3;
            label5.Text = "Id:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(44, 265);
            label7.Name = "label7";
            label7.Size = new Size(44, 28);
            label7.TabIndex = 5;
            label7.Text = "TC:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(4, 223);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 6;
            label8.Text = "Doktor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(16, 181);
            label9.Name = "label9";
            label9.Size = new Size(72, 28);
            label9.TabIndex = 7;
            label9.Text = "Branş:";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(94, 43);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(125, 36);
            TxtId.TabIndex = 8;
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(94, 85);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(125, 36);
            MskTarih.TabIndex = 9;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(94, 127);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(125, 36);
            MskSaat.TabIndex = 10;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // CmdBrans
            // 
            CmdBrans.FormattingEnabled = true;
            CmdBrans.Location = new Point(94, 173);
            CmdBrans.Name = "CmdBrans";
            CmdBrans.Size = new Size(151, 36);
            CmdBrans.TabIndex = 11;
            // 
            // CmdDoktor
            // 
            CmdDoktor.FormattingEnabled = true;
            CmdDoktor.Location = new Point(94, 215);
            CmdDoktor.Name = "CmdDoktor";
            CmdDoktor.Size = new Size(151, 36);
            CmdDoktor.TabIndex = 12;
            // 
            // MskTC
            // 
            MskTC.Location = new Point(94, 257);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(125, 36);
            MskTC.TabIndex = 13;
            MskTC.ValidatingType = typeof(int);
            // 
            // ChkDurum
            // 
            ChkDurum.AutoSize = true;
            ChkDurum.Location = new Point(94, 299);
            ChkDurum.Name = "ChkDurum";
            ChkDurum.Size = new Size(105, 32);
            ChkDurum.TabIndex = 14;
            ChkDurum.Text = " Durum";
            ChkDurum.UseVisualStyleBackColor = true;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(16, 337);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(229, 41);
            BtnKaydet.TabIndex = 15;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(16, 384);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(229, 41);
            BtnGuncelle.TabIndex = 16;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(653, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(535, 293);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(529, 258);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.Location = new Point(656, 311);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(535, 258);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(529, 223);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnRandevuListe);
            groupBox6.Controls.Add(BtnBransPanel);
            groupBox6.Controls.Add(BtnDoktorPanel);
            groupBox6.Location = new Point(16, 473);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(631, 96);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // BtnDoktorPanel
            // 
            BtnDoktorPanel.Location = new Point(6, 35);
            BtnDoktorPanel.Name = "BtnDoktorPanel";
            BtnDoktorPanel.Size = new Size(194, 41);
            BtnDoktorPanel.TabIndex = 16;
            BtnDoktorPanel.Text = "Doktor Paneli";
            BtnDoktorPanel.UseVisualStyleBackColor = true;
            // 
            // BtnBransPanel
            // 
            BtnBransPanel.Location = new Point(216, 35);
            BtnBransPanel.Name = "BtnBransPanel";
            BtnBransPanel.Size = new Size(190, 41);
            BtnBransPanel.TabIndex = 17;
            BtnBransPanel.Text = "Branş Paneli";
            BtnBransPanel.UseVisualStyleBackColor = true;
            // 
            // BtnRandevuListe
            // 
            BtnRandevuListe.Location = new Point(412, 35);
            BtnRandevuListe.Name = "BtnRandevuListe";
            BtnRandevuListe.Size = new Size(213, 41);
            BtnRandevuListe.TabIndex = 18;
            BtnRandevuListe.Text = "Randevu Liste";
            BtnRandevuListe.UseVisualStyleBackColor = true;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1200, 577);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmSekreterDetay";
            Text = "FrmSekreterDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private Button BtnDuyuruOlustur;
        private RichTextBox RchDuyuru;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button BtnKaydet;
        private CheckBox ChkDurum;
        private MaskedTextBox MskTC;
        private ComboBox CmdDoktor;
        private ComboBox CmdBrans;
        private MaskedTextBox MskSaat;
        private MaskedTextBox MskTarih;
        private TextBox TxtId;
        private Button BtnGuncelle;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private Button BtnRandevuListe;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        private Button BtnBransPanel;
        private Button BtnDoktorPanel;
    }
}