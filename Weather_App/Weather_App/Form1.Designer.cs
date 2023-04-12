namespace Weather_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label2;
            exitbutton = new Button();
            label1 = new Label();
            cityinput = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            durumtext = new Label();
            detaytext = new Label();
            ruzgarhizitext = new Label();
            basinctext = new Label();
            sicakliktext = new Label();
            durumimage = new PictureBox();
            citytext = new Label();
            saat = new Label();
            label6 = new Label();
            hissedilentext = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)durumimage).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.NavajoWhite;
            label2.Location = new Point(109, 516);
            label2.Name = "label2";
            label2.Size = new Size(104, 31);
            label2.TabIndex = 8;
            label2.Text = "Sıcaklık:";
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Transparent;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exitbutton.ForeColor = Color.Transparent;
            exitbutton.Location = new Point(1047, 652);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(98, 29);
            exitbutton.TabIndex = 0;
            exitbutton.Text = "Exit";
            exitbutton.TextAlign = ContentAlignment.BottomCenter;
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(573, 66);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 1;
            label1.Text = "Şehir :";
            // 
            // cityinput
            // 
            cityinput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cityinput.ForeColor = Color.NavajoWhite;
            cityinput.Location = new Point(677, 66);
            cityinput.Name = "cityinput";
            cityinput.Size = new Size(217, 34);
            cityinput.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.NavajoWhite;
            button1.Location = new Point(913, 64);
            button1.Name = "button1";
            button1.Size = new Size(99, 39);
            button1.TabIndex = 3;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.NavajoWhite;
            label3.Location = new Point(109, 417);
            label3.Name = "label3";
            label3.Size = new Size(95, 31);
            label3.TabIndex = 5;
            label3.Text = "Durum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.NavajoWhite;
            label4.Location = new Point(109, 471);
            label4.Name = "label4";
            label4.Size = new Size(82, 31);
            label4.TabIndex = 4;
            label4.Text = "Detay:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.NavajoWhite;
            label5.Location = new Point(605, 471);
            label5.Name = "label5";
            label5.Size = new Size(144, 31);
            label5.TabIndex = 9;
            label5.Text = "Rüzgar Hızı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.NavajoWhite;
            label7.Location = new Point(605, 516);
            label7.Name = "label7";
            label7.Size = new Size(89, 31);
            label7.TabIndex = 10;
            label7.Text = "Basınç:";
            // 
            // durumtext
            // 
            durumtext.AutoSize = true;
            durumtext.BackColor = Color.Transparent;
            durumtext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            durumtext.ForeColor = Color.NavajoWhite;
            durumtext.Location = new Point(210, 417);
            durumtext.Name = "durumtext";
            durumtext.Size = new Size(56, 31);
            durumtext.TabIndex = 11;
            durumtext.Text = "null";
            // 
            // detaytext
            // 
            detaytext.AutoSize = true;
            detaytext.BackColor = Color.Transparent;
            detaytext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            detaytext.ForeColor = Color.NavajoWhite;
            detaytext.Location = new Point(191, 471);
            detaytext.Name = "detaytext";
            detaytext.Size = new Size(56, 31);
            detaytext.TabIndex = 12;
            detaytext.Text = "null";
            // 
            // ruzgarhizitext
            // 
            ruzgarhizitext.AutoSize = true;
            ruzgarhizitext.BackColor = Color.Transparent;
            ruzgarhizitext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ruzgarhizitext.ForeColor = Color.NavajoWhite;
            ruzgarhizitext.Location = new Point(755, 471);
            ruzgarhizitext.Name = "ruzgarhizitext";
            ruzgarhizitext.Size = new Size(56, 31);
            ruzgarhizitext.TabIndex = 14;
            ruzgarhizitext.Text = "null";
            // 
            // basinctext
            // 
            basinctext.AutoSize = true;
            basinctext.BackColor = Color.Transparent;
            basinctext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            basinctext.ForeColor = Color.NavajoWhite;
            basinctext.Location = new Point(713, 516);
            basinctext.Name = "basinctext";
            basinctext.Size = new Size(56, 31);
            basinctext.TabIndex = 15;
            basinctext.Text = "null";
            // 
            // sicakliktext
            // 
            sicakliktext.AutoSize = true;
            sicakliktext.BackColor = Color.Transparent;
            sicakliktext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            sicakliktext.ForeColor = Color.NavajoWhite;
            sicakliktext.Location = new Point(219, 516);
            sicakliktext.Name = "sicakliktext";
            sicakliktext.Size = new Size(56, 31);
            sicakliktext.TabIndex = 16;
            sicakliktext.Text = "null";
            // 
            // durumimage
            // 
            durumimage.BackColor = Color.Transparent;
            durumimage.Location = new Point(109, 329);
            durumimage.Name = "durumimage";
            durumimage.Size = new Size(125, 61);
            durumimage.TabIndex = 17;
            durumimage.TabStop = false;
            // 
            // citytext
            // 
            citytext.AutoSize = true;
            citytext.BackColor = Color.Transparent;
            citytext.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            citytext.ForeColor = Color.NavajoWhite;
            citytext.Location = new Point(109, 71);
            citytext.Name = "citytext";
            citytext.Size = new Size(84, 45);
            citytext.TabIndex = 18;
            citytext.Text = "null";
            // 
            // saat
            // 
            saat.AutoSize = true;
            saat.BackColor = Color.Transparent;
            saat.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            saat.ForeColor = Color.NavajoWhite;
            saat.Location = new Point(109, 123);
            saat.Name = "saat";
            saat.Size = new Size(84, 45);
            saat.TabIndex = 19;
            saat.Text = "null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.NavajoWhite;
            label6.Location = new Point(605, 417);
            label6.Name = "label6";
            label6.Size = new Size(221, 31);
            label6.TabIndex = 20;
            label6.Text = "Hissedilen Sıcaklık:";
            // 
            // hissedilentext
            // 
            hissedilentext.AutoSize = true;
            hissedilentext.BackColor = Color.Transparent;
            hissedilentext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            hissedilentext.ForeColor = Color.NavajoWhite;
            hissedilentext.Location = new Point(832, 417);
            hissedilentext.Name = "hissedilentext";
            hissedilentext.Size = new Size(56, 31);
            hissedilentext.TabIndex = 21;
            hissedilentext.Text = "null";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.kai_oberhauser_BKAaLmT0tIs_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1147, 683);
            Controls.Add(hissedilentext);
            Controls.Add(label6);
            Controls.Add(saat);
            Controls.Add(citytext);
            Controls.Add(durumimage);
            Controls.Add(sicakliktext);
            Controls.Add(basinctext);
            Controls.Add(ruzgarhizitext);
            Controls.Add(detaytext);
            Controls.Add(durumtext);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cityinput);
            Controls.Add(label1);
            Controls.Add(exitbutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)durumimage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitbutton;
        private Label label1;
        private TextBox cityinput;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label durumtext;
        private Label detaytext;
        private Label ruzgarhizitext;
        private Label basinctext;
        private Label sicakliktext;
        private PictureBox durumimage;
        private Label citytext;
        private Label saat;
        private Label label6;
        private Label hissedilentext;
    }
}