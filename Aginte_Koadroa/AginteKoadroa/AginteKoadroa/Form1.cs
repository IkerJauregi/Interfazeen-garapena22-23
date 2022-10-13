using AginteKoadroa.models;
using GrafikoaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AginteKoadroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SalmentaDbContext())
            {
                //bigarren grafikoa
                var bezeroaData = db.Bezeroa
                    .Include("Saltzailea")
                    .GroupBy(b => b.Saltzailea.Izena)
                    .ToDictionary(g => g.Key, g => g.Count());
                if (bezeroaData != null)
                {
                    if (bezeroaData.Count > 0)
                    {
                            grafikoa1.DataSource = bezeroaData;
                            grafikoa1.Series[0].YValueMembers = "Value";
                            grafikoa1.Series[0].XValueMember = "Key";
                            grafikoa1.DataBind();
                        
                    }
                }
            }
            using (var db = new SalmentaDbContext())
            {
                //bigarren grafikoa
                var salmentaData = db.Salmenta
                    .GroupBy(b => b.BezeroaID)
                    .ToDictionary(g => g.Key, g => g.Sum(b => b.Zenbatekoa));
                if (salmentaData != null)
                {
                    if (salmentaData.Count > 0)
                    {
                        var kontrolak = grafikoa2.Controls.OfType<System.Windows.Forms.DataVisualization.Charting.Chart>(); foreach (var kontrola in kontrolak)
                        {
                            kontrola.Titles[0].Text = "SALMENTA GEHIENGO BEZEROAK";
                            kontrola.DataSource = salmentaData;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }
            }
        }
        private void grafikoa1_Load(object sender, EventArgs e)
        {

        }
    }
}
