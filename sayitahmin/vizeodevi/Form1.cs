namespace vizeodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        int deneme =0;
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            int kontrol;
            kontrol=Convert.ToInt32(textBox1.Text);
            if (sayi < kontrol)
            {
                button3.BackColor = Color.Green;
                deneme++;
                
            }
            
            if (sayi > kontrol)
            {
                button2.BackColor = Color.Green;
                deneme++;
                
                
            }
            
            if (sayi == kontrol)
            {
                
                MessageBox.Show("Tebrikler sayiyi buldunuz.Sayi:" + sayi+"Deneme:" + deneme);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                
                button3.BackColor = Color.Gray;
            }
            if (sayac == 3)
            {
                button2.BackColor=Color.Gray;
                sayac = 0;
            }
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            sayi = r.Next(0, 10);
            MessageBox.Show("Dogru sayiyi bulana kadar kutuya tahmininizi yazin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }
    }
}