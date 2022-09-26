namespace Kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }
        private bool Balioak()
        {
            bool error = false;
            try
            {
                kalkulagailua.Zenbaki1 = float.Parse(zen1.Text);
                kalkulagailua.Zenbaki2 = float.Parse(zen2.Text);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                error = true;
            }
            return error;
        }
        private void Hasieratu()
        {
            zen1.Text = ""; 
            zen2.Text = "";
        }
        private void gehiketa_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
                //Objetuaren metodoa erabiltzen
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
                Hasieratu();
            }
        }

        private void biderketa_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
            //Objetuaren metodoa erabiltzen
            MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
            Hasieratu();
            }
        }

        private void kenketa_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
                //Objetuaren metodoa erabiltzen
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                Hasieratu();
            }
        }

        private void zatiketa_Click(object sender, EventArgs e)
        {
            if (!Balioak())
            {
            //Objetuaren metodoa erabiltzen
            MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
            Hasieratu();
            }
        }
        private void zen1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (zen1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (zen1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
        private void zen2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
                && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
                && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
                && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (zen2.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (zen2.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
        private void zen2_TextChanged(object sender, EventArgs e)
        {

        }
        private void zen1_TextChanged(object sender, EventArgs e)
        {

        }
        private void irten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}