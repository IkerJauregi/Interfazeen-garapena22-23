namespace Zenbakiak
{
    public partial class Form1 : Form
    {
        List<Zenbakiak> zen = new List<Zenbakiak>();
        public Form1()
        {
            InitializeComponent();
        }
        //public Zenbakiak zenbakiak = new Zenbakiak();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            switch (this.lblZenbakia.Text.ToLower())
            {
                case "zenbakia 1":
                    zen.Add(new Zenbakiak());
                    try
                    {
                        zen[0].zenb = float.Parse(this.txtZenb.Text);
                        this.lblZenbakia.Text = "Zenbakia 2";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message);
                    }
                    break;
                case "zenbakia 2":
                    zen.Add(new Zenbakiak());
                    try
                    {
                        zen[1].zenb2 = float.Parse(this.txtZenb.Text);
                        this.lblZenbakia.Text = "Zenbakia 3";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message);
                    }
                    break;
                case "zenbakia 3":
                    zen.Add(new Zenbakiak());
                    try
                    {
                        zen[2].zenb3 = float.Parse(this.txtZenb.Text);
                        this.lblZenbakia.Text = "Zenbakia 4";
                        this.txtZenb.Text = "";
                        this.txtZenb.Focus();
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message); 
                    }
                    break;
                case "zenbakia 4":
                    zen.Add(new Zenbakiak());
                    try
                    {
                        zen[3].zenb4 = float.Parse(this.txtZenb.Text);
                        this.txtZenb.Text = "";
                        this.lblZenbakia.Text = "Eragiketa";
                        this.txtZenb.Text = "(" + zen[0].zenb + " + " + "(2 x " + zen[1].zenb2 + ") +" + "(3 x " + zen[2].zenb3 + ") + " + "(4 x " + zen[3].zenb4 + ")) / 4 = " + Zenbakiak.eragiketa(zen);
                    }
                    catch (Exception ex)
                    { 
                        MessageBox.Show("zenbaki bat sartu behar dozu. " + ex.Message);
                    }
                    break;
            }
        }
        private void txtZenb_KeyPress(object sender, KeyPressEventArgs e) //Controlar que el usuario no pueda meter letras, solo números.
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
                    if (txtZenb.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtZenb.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}