namespace FonkisyonGrafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool koyumod = false;
        int[] katsayilar = new int[2] { 0, 0 };
        //kaysayilar[0] ---> 0.derecenin katsayi degerini saklar

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void TXT_Resetle()
        {
            der0_txtbox.Text = "";
            der1_txtbox.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        void koordinatSistem()
        {
            Label lbl3 = new Label();
            lbl3.Text = "";
            lbl3.Name = "Orijin";
            lbl3.Size = new Size(2, 1);
            lbl3.BackColor = Color.Black;
            lbl3.Location = new Point(665, 330);
            this.Controls.Add(lbl3);

            //orjin noktasi lbl3 tur. en once onu olusturuyoruz ki ilk o gorunsun.

            Label lbl = new Label();
            lbl.Text = "";
            lbl.Name = "xAxis";
            lbl.BackColor = Color.Red;
            lbl.Size = new Size(750, 2);
            lbl.Location = new Point(290, 330);
            this.Controls.Add(lbl);
            Label lbl2 = new Label();
            lbl2.Text = "";
            lbl2.Name = "yAxis";
            lbl2.BackColor = Color.Red;
            lbl2.Size = new Size(2, 700);
            lbl2.Location = new Point(665, 9);
            this.Controls.Add(lbl2);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            koordinatSistem();
            Fonksiyon_lbl.Text = "";

        }

        private void ciz_btn_Click(object sender, EventArgs e)
        {
            katsayilar[0] = Convert.ToInt32(der0_txtbox.Text);
            katsayilar[1] = Convert.ToInt32(der1_txtbox.Text);
            if (katsayilar[1] != 0)
            {
                Fonksiyon_lbl.Text += katsayilar[1].ToString();
                Fonksiyon_lbl.Text += "x^1";
            }
            if (katsayilar[0] != 0)
            {
                Fonksiyon_lbl.Text += " +";
                Fonksiyon_lbl.Text += katsayilar[0].ToString();
                Fonksiyon_lbl.Text += "x^0";
            }

            TXT_Resetle();
            int xAxis = 665, yAxis = 330;
            int sonuc;
            for (int x = -100; x < 100; x++)
            {
                sonuc = FonksiyonHesapla(x);
                Label cizim = new Label();
                cizim.Text = "";
                cizim.Name = "";
                cizim.BackColor = Color.Blue;
                cizim.Size = new System.Drawing.Size(3, 3);

                cizim.Location = new System.Drawing.Point(xAxis + 3*x, yAxis - 3*sonuc);
                this.Controls.Add(cizim);

            }
            ciz_btn.Enabled = false;
        }
        int FonksiyonHesapla(int x)
        {
            int sonuc = 0;
            for (int i = 0; i <= 1; i++)
            {
                sonuc += katsayilar[i] * UsAlma(x, i);
            }
            return sonuc;
        }
        int UsAlma(int x, int derece)
        {
            if (derece == 0)
            { return 1; }
            return x;

        }

        private void Fonksiyon_lbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (koyumod == false)
            {
                
                BackColor = Color.Black;
                koyumod_btn.BackColor = Color.Black;
                koyumod_btn.ForeColor = Color.White;
                koyumod = true;
            }
            else if(koyumod==true)
            {
                
                BackColor = Color.White;
                koyumod_btn.BackColor = Color.White;
                koyumod_btn.ForeColor = Color.Black;
                koyumod = false;
            }
        }
    }
}