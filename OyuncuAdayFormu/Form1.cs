namespace OyuncuAdayFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
    
            private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string yasText = textBox2.Text;
            string boyText = textBox3.Text;
            string sac = comboBox1.Text;
            string goz = comboBox2.Text;
            string fiziksel = textBox4.Text;

            // Başlangıçta hata mesajı boş
            string hataMesaji = "";

            // Yaş ve boy sayısal mı?
            bool yasValid = int.TryParse(yasText, out int yas);
            bool boyValid = int.TryParse(boyText, out int boy);

            if (!yasValid || !boyValid)
            {
                MessageBox.Show("Lütfen yaş ve boy alanlarına sayısal değer giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Uygunluk kontrolleri
            if (yas > 18)
                hataMesaji += "UYARI: Yaş 18'den büyük olduğu için adaylığa kabul edilemez.\n";

            if (boy < 80 || boy > 200)
                hataMesaji += "UYARI: Boy 80-200 cm arasında olmalıdır.\n";

            // Bilgileri topla
            string mesaj = $"Adı: {ad}\nYaş: {yas}\nBoy: {boy} cm\nSaç Rengi: {sac}\nGöz Rengi: {goz}\nFiziksel Özellikler: {fiziksel}";

            // Uyarı varsa mesajın altına ekle
            if (!string.IsNullOrEmpty(hataMesaji))
            {
                mesaj += "\n\n" + hataMesaji;
            }
            else
            {
                mesaj += "\n\n✅ Adaylık için tüm kriterler uygundur.";
            }

            // Mesajı göster
            MessageBox.Show(mesaj, "Aday Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}











