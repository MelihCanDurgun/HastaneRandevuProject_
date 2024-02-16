namespace Hastane
{
    partial class FrmHastaDetay
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
            label5 = new Label();
            LblTC = new Label();
            label2 = new Label();
            LblAdSoyad = new Label();
            groupBox2 = new GroupBox();
            CmbBrans = new ComboBox();
            label4 = new Label();
            RchSikayet = new RichTextBox();
            BtnRandevuAl = new Button();
            label6 = new Label();
            CmbDoktor = new ComboBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            LnkBilgiDuzenle = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(LblTC);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(11, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 32);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 14;
            label5.Text = "Tc No:";
            // 
            // LblTC
            // 
            LblTC.AutoSize = true;
            LblTC.Location = new Point(134, 32);
            LblTC.Margin = new Padding(2, 0, 2, 0);
            LblTC.Name = "LblTC";
            LblTC.Size = new Size(144, 28);
            LblTC.TabIndex = 14;
            LblTC.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 14;
            label2.Text = "Ad Soyad:";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(134, 72);
            LblAdSoyad.Margin = new Padding(2, 0, 2, 0);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(93, 28);
            LblAdSoyad.TabIndex = 14;
            LblAdSoyad.Text = "Null Null";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LnkBilgiDuzenle);
            groupBox2.Controls.Add(BtnRandevuAl);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Location = new Point(11, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 361);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(134, 35);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(180, 36);
            CmbBrans.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 43);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 15;
            label4.Text = "Branş:";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(134, 164);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(180, 82);
            RchSikayet.TabIndex = 2;
            RchSikayet.Text = "";
            // 
            // BtnRandevuAl
            // 
            BtnRandevuAl.Location = new Point(134, 275);
            BtnRandevuAl.Name = "BtnRandevuAl";
            BtnRandevuAl.Size = new Size(180, 36);
            BtnRandevuAl.TabIndex = 3;
            BtnRandevuAl.Text = "Randevu Al";
            BtnRandevuAl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 111);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 17;
            label6.Text = "Doktor:";
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(134, 103);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(180, 36);
            CmbDoktor.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 164);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 28);
            label7.TabIndex = 18;
            label7.Text = "Şikayet:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(364, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(856, 288);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(364, 306);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(856, 318);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(850, 253);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 32);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(850, 283);
            dataGridView2.TabIndex = 1;
            // 
            // LnkBilgiDuzenle
            // 
            LnkBilgiDuzenle.AutoSize = true;
            LnkBilgiDuzenle.Location = new Point(134, 330);
            LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            LnkBilgiDuzenle.Size = new Size(180, 28);
            LnkBilgiDuzenle.TabIndex = 19;
            LnkBilgiDuzenle.TabStop = true;
            LnkBilgiDuzenle.Text = "Bilgilerini Düzenle";
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1232, 649);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmHastaDetay";
            Text = "HastaDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label LblTC;
        private Label label5;
        private Label LblAdSoyad;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private RichTextBox RchSikayet;
        private ComboBox CmbDoktor;
        private Label label4;
        private ComboBox CmbBrans;
        private Button BtnRandevuAl;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private DataGridView dataGridView2;
        private LinkLabel LnkBilgiDuzenle;
    }
}