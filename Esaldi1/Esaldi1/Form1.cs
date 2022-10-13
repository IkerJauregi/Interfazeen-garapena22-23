
using EsaldiaLotzeko;

namespace Esaldi1
{
    public partial class Form1 : Form
    {
        Esaldia esaldia = new Esaldia();
        public Form1()
        {
            InitializeComponent();
        }
        private bool Balidatu(Button botoi1, Button botoi2)
        {
            if(textBox1.Text != "")
            {
                botoi1.Enabled = false;
                botoi2.Enabled = true;
                esaldia.Zatia = textBox1.Text;
                textBox1.Focus();
                return true;
            }
            else
            {
                return false;
            }
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
            textBox1.Enabled = true;
            esaldi1.Enabled = true;
            lotu.Enabled = false;
            textBox1.Focus();
            esaldia.EsaldiaBatuta = "";
        }

        private void irten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}