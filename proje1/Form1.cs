namespace proje1
{
    public partial class menu_projesec : Form
    {
        public menu_projesec()
        {
            InitializeComponent();
        }

        private void btn_hesapmakinesi_Click(object sender, EventArgs e)
        {
            form_hesapmakinesi yeni = new form_hesapmakinesi();
            //Form olu�turdum ve formu yeni adl� de�i�kene atad�m
            yeni.Show();
            //Show metodu ile formu kullan�c�ya g�sterdim
            this.Hide();
            //Form 2 a��l�nca form 1 i saklad�m
        }

        private void btn_notdefteri_Click(object sender, EventArgs e)
        {
            form_notdefteri yeni1 = new form_notdefteri();
            //Form olu�turdum ve formu yeni1 adl� de�i�kene atad�m
            yeni1.Show();
            //Show metodu ile formu kullan�c�ya g�sterdim
            this.Hide();
            //Form 3 a��l�nca form 1 i saklad�m
        }

        private void btn_askerdagitim_Click(object sender, EventArgs e)
        {
            form_askerdagitim yeni2 = new form_askerdagitim();
            //Form olu�turdum ve formu yeni2 adl� de�i�kene atad�m
            yeni2.Show();
            this.Hide();
            //Form 4 a��l�nca form 1 i saklad�m.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_buyukkucuk_uyum yeni3 = new form_buyukkucuk_uyum();
            //Form olu�turdum ve formu yeni3 adl� de�i�kene atad�m
            yeni3.Show();
            this.Hide();
            //Form 5 a��l�nca form 1 i saklad�m.
        }

        private void btn_poker_Click(object sender, EventArgs e)
        {
            form_poker yeni5 = new form_poker();
            //Form olu�turdum ve formu yeni5 adl� de�i�kene atad�m
            yeni5.Show();
            this.Hide();
            //Form 7 a��l�nca form 1 i saklad�m
        }

        private void btn_slotmakine_Click(object sender, EventArgs e)
        {
            form_slotmakine yeni6 = new form_slotmakine();
            //Form olu�turdum ve formu yeni6 adl� de�i�kene atad�m
            yeni6.Show();
            this.Hide();
            //Form 8 a��l�nca form 1 i saklad�m
        }

        private void btn_pckapa_Click(object sender, EventArgs e)
        {
            Form6 yeni7 = new Form6();
            //Form olu�turdum ve formu yeni7 adl� de�i�kene atad�m
            yeni7.Show();
            this.Hide();
            //Form 6 a��l�nca form 1 i saklad�m
        }

        private void btn_satranc_Click(object sender, EventArgs e)
        {
            Form9 yeni8 = new Form9();
            //Form olu�turdum ve formu yeni8 adl� de�i�kene atad�m
            yeni8.Show();
            this.Hide();
            //Form 9 a��l�nca form 1 i saklad�m
        }
    }
}