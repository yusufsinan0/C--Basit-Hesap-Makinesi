namespace Egitim2
{
    public partial class Form1 : Form
    {
        int sayi1;
        int sayi2;
        char islem;
        bool ekranTemizleme;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(ekran.Text=="0") ekran.Text ="";
            ekran.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ekran.Text == "0") ekran.Text = "";
            ekran.Text += "0";
        }

        private void buttonKapatma_Click(object sender, EventArgs e)
        {
            ekran.Text = "";
        }

        private void buttonToplama_Click(object sender, EventArgs e)
        {
            ekranTemizleme = true;
            islem = '+';
            sayi1 = Convert.ToInt32(ekran.Text);
            if (ekranTemizleme) ekran.Text = "";


        }

        private void buttonCikarma_Click(object sender, EventArgs e)
        {
            ekranTemizleme = true;
            islem = '-';
            sayi1 = Convert.ToInt32(ekran.Text);
            if (ekranTemizleme) ekran.Text = "";

        }

        private void buttonCarpma_Click(object sender, EventArgs e)
        {
            ekranTemizleme = true;
            islem = '*';
            sayi1 = Convert.ToInt32(ekran.Text);
            if (ekranTemizleme) ekran.Text = "";

        }

        private void buttonBolme_Click(object sender, EventArgs e)
        {
            ekranTemizleme = true;
            islem = '/';
            sayi1 = Convert.ToInt32(ekran.Text);
            if (ekranTemizleme) ekran.Text = "";
        }

        private void buttonEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToInt32(ekran.Text);
            int sonuc;

            switch (islem) { 
                case '+':
                    sonuc = sayi1+sayi2;
                    break;

                case '-':
                    sonuc = sayi1-sayi2;
                    break;

                case '*':
                    sonuc = sayi1*sayi2;
                    break;
                
                case '/':
                    sonuc = sayi1/sayi2;
                    break;

                        default:sonuc = 0;break;
                

            }
            ekran.Text = Convert.ToString(sonuc);
        }
    }
}