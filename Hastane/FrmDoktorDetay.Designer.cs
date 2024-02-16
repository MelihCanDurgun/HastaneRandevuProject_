namespace Hastane
{
    partial class FrmDoktorDetay
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
            label1 = new Label();
            LblTC = new Label();
            label3 = new Label();
            LblAdSoyad = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            RchSikayet = new RichTextBox();
            groupBox4 = new GroupBox();
            BtnGuncelle = new Button();
            BtnDuyurular = new Button();
            BtnCıkıs = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
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
            groupBox1.Size = new Size(493, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Doktor Bilgisi";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(12, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(529, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(838, 663);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(832, 628);
            dataGridView1.TabIndex = 0;
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(20, 35);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(446, 214);
            RchSikayet.TabIndex = 0;
            RchSikayet.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnCıkıs);
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnGuncelle);
            groupBox4.Location = new Point(12, 523);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(493, 152);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnGuncelle.Location = new Point(20, 26);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(216, 47);
            BtnGuncelle.TabIndex = 0;
            BtnGuncelle.Text = "Bilgi Düzenle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnDuyurular.Location = new Point(250, 26);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(216, 47);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            // 
            // BtnCıkıs
            // 
            BtnCıkıs.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnCıkıs.Location = new Point(20, 79);
            BtnCıkıs.Name = "BtnCıkıs";
            BtnCıkıs.Size = new Size(446, 47);
            BtnCıkıs.TabIndex = 2;
            BtnCıkıs.Text = "Çıkış";
            BtnCıkıs.UseVisualStyleBackColor = true;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1390, 722);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTC;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox RchSikayet;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private Button BtnCıkıs;
        private Button BtnDuyurular;
        private Button BtnGuncelle;
    }
}