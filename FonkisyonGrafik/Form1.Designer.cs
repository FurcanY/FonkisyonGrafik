namespace FonkisyonGrafik
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label1 = new Label();
            Fonksiyon_lbl = new Label();
            ciz_btn = new Button();
            fx = new Label();
            der0_txtbox = new TextBox();
            label8 = new Label();
            der1_txtbox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            koyumod_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Fonksiyon_lbl);
            panel1.Controls.Add(ciz_btn);
            panel1.Controls.Add(fx);
            panel1.Controls.Add(der0_txtbox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(der1_txtbox);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 176);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Alef", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 17;
            label1.Text = "Katsayilari Giriniz.";
            // 
            // Fonksiyon_lbl
            // 
            Fonksiyon_lbl.AutoSize = true;
            Fonksiyon_lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Fonksiyon_lbl.Location = new Point(195, 110);
            Fonksiyon_lbl.Name = "Fonksiyon_lbl";
            Fonksiyon_lbl.Size = new Size(64, 30);
            Fonksiyon_lbl.TabIndex = 3;
            Fonksiyon_lbl.Text = "5x^2";
            Fonksiyon_lbl.Click += Fonksiyon_lbl_Click;
            // 
            // ciz_btn
            // 
            ciz_btn.BackColor = Color.White;
            ciz_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ciz_btn.Location = new Point(239, 11);
            ciz_btn.Name = "ciz_btn";
            ciz_btn.Size = new Size(185, 54);
            ciz_btn.TabIndex = 16;
            ciz_btn.Text = "Fonksiyonu Ciz !";
            ciz_btn.UseVisualStyleBackColor = false;
            ciz_btn.Click += ciz_btn_Click;
            // 
            // fx
            // 
            fx.AutoSize = true;
            fx.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            fx.Location = new Point(122, 110);
            fx.Name = "fx";
            fx.Size = new Size(67, 30);
            fx.TabIndex = 2;
            fx.Text = "F(x)=";
            // 
            // der0_txtbox
            // 
            der0_txtbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            der0_txtbox.Location = new Point(112, 55);
            der0_txtbox.Multiline = true;
            der0_txtbox.Name = "der0_txtbox";
            der0_txtbox.Size = new Size(44, 37);
            der0_txtbox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Alef", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(153, 55);
            label8.Name = "label8";
            label8.Size = new Size(61, 37);
            label8.TabIndex = 14;
            label8.Text = "x^0";
            // 
            // der1_txtbox
            // 
            der1_txtbox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            der1_txtbox.Location = new Point(16, 55);
            der1_txtbox.Multiline = true;
            der1_txtbox.Name = "der1_txtbox";
            der1_txtbox.Size = new Size(44, 36);
            der1_txtbox.TabIndex = 13;
            der1_txtbox.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Alef", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(55, 55);
            label5.Name = "label5";
            label5.Size = new Size(56, 37);
            label5.TabIndex = 12;
            label5.Text = "x^1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(18, 571);
            label2.Name = "label2";
            label2.Size = new Size(240, 22);
            label2.TabIndex = 2;
            label2.Text = "Github: github.com/FurcanY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(18, 540);
            label3.Name = "label3";
            label3.Size = new Size(166, 22);
            label3.TabIndex = 3;
            label3.Text = "Instagram: y.furcan";
            // 
            // koyumod_btn
            // 
            koyumod_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            koyumod_btn.Location = new Point(12, 194);
            koyumod_btn.Margin = new Padding(0);
            koyumod_btn.Name = "koyumod_btn";
            koyumod_btn.Size = new Size(147, 40);
            koyumod_btn.TabIndex = 6;
            koyumod_btn.Text = "Koyu Mod";
            koyumod_btn.UseVisualStyleBackColor = true;
            koyumod_btn.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1116, 602);
            Controls.Add(koyumod_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            ShowIcon = false;
            Text = "Fonksiyon Grafik";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private TextBox der0_txtbox;
        private Label label8;
        private TextBox der1_txtbox;
        private Button ciz_btn;
        private Label fx;
        private Label Fonksiyon_lbl;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Button koyumod_btn;
    }
}