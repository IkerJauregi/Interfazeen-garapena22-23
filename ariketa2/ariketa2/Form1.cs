namespace ariketa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hurrengokoa_Click(object sender, EventArgs e)
        {
            switch (this.zen1.Text)
            {
                case "zenbakia 1":

            }
        }

        private void garbitu_Click(object sender, EventArgs e)
        {
            zen1.Focus();
            zen1.Clear();
            zen2.Focus();
            zen2.Clear();
            zen3.Focus();
            zen3.Clear();
        }

        private void irten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zen2_TextChanged(object sender, EventArgs e)
        {

        }

        private void zen3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}