namespace Hastane
{
    partial class FrmSekreterGiris
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(241, 201);
            button1.Name = "button1";
            button1.Size = new Size(111, 34);
            button1.TabIndex = 13;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(358, 157);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(81, 29);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üye Ol";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 36);
            textBox1.TabIndex = 11;
            textBox1.Text = " ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(204, 107);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(148, 36);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 157);
            label3.Name = "label3";
            label3.Size = new Size(71, 29);
            label3.TabIndex = 9;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 110);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 8;
            label2.Text = "Tc Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(472, 67);
            label1.TabIndex = 7;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(510, 247);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmSekreterGiris";
            Text = "FrmSekreter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}