namespace HESAP_MAKİNESİ
{
    public partial class Form1 : Form
    {

        private Operatorler operatorler;
        public Form1()
        {
            InitializeComponent();
           this.operatorler = new Operatorler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int Sayi1 = Convert.ToInt32(txtSayi1.Text);
            int Sayi2 = Convert.ToInt32(txtSayi2.Text);
            int Toplam =this.operatorler.Toplama(Sayi1, Sayi2);
            double karekok =this.operatorler.karekok(Toplam);
            int sonuc= Convert.ToInt32(karekok);
            txtSonuc.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
