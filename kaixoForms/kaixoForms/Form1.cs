using kaixoDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaixoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnErakutsi_Click(object sender, EventArgs e)
        {
            Kaixo kaixo = new Kaixo();
            MessageBox.Show();
        }
    }
}
