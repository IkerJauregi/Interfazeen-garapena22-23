namespace ariketa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void kategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gorde_Click(object sender, EventArgs e)
        {
            Kontaktua kontak= new Kontaktua();
            kontak.izena = izena.Text;
            kontak.abizena = abizena.Text;
            kontak.nan = nan.Text;
            kontak.email = email.Text;
            kontak.Gorde();
        }
        private void BezeroaSortu()
        {
            Kontaktua kontak = new Kontaktua();
            kontak.izena = izena.Text;
            kontak.abizena = abizena.Text;
            kontak.nan = nan.Text;
            kontak.email = email.Text;
            kontak.Gorde();
        }
        private void LangileaSortu()
        {
            Langilea langilea = new Langilea();
            langilea.izena = izena.Text;
            langilea.abizena = abizena.Text;
            langilea.nan = nan.Text;
            langilea.email = email.Text;
            langilea.Soldata = soldata.Text;
            langilea.SegurtasunSoziala = segurtasunSoziala.Text;
            langilea.Gorde();
        }
        private void irten_Click(object sender, EventArgs e)
        {

        }
    }
}