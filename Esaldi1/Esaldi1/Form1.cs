namespace Esaldi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esaldi1_Click(object sender, EventArgs e)
        {
            esaldi1.Enabled = false;
            esaldi2.Enabled = true;
        }

        private void esaldi2_Click(object sender, EventArgs e)
        {
            esaldi2.Enabled = false;
            esaldi3.Enabled = true;
        }

        private void esaldi3_Click(object sender, EventArgs e)
        {
            esaldi3.Enabled = false;
            esaldi4.Enabled = true; 
        }

        private void esaldi4_Click(object sender, EventArgs e)
        {
            esaldi4.Enabled=false;
            esaldi5.Enabled = true;
        }

        private void esaldi5_Click(object sender, EventArgs e)
        {
            esaldi5.Enabled = false;
            lotu.Enabled = true;
        }

        private void lotu_Click(object sender, EventArgs e)
        {
            lotu.Enabled = false;
        }

        private void garbitu_Click(object sender, EventArgs e)
        {

        }

        private void irten_Click(object sender, EventArgs e)
        {

        }
    }
}