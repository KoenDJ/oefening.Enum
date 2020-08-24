using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oefening.Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemer> lijstWerknemers = new List<Werknemer>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemer werknemer = new Werknemer("Geert", new Salaris(typeContract: "weekcontract"));
            Werknemer werknemer1 = new Werknemer("Daniel",new Salaris(typeContract: "weekcontract"), landVanHerkomst: "Nederland");
            Werknemer werknemer2 = new Werknemer("Frank", new Salaris(brutoBedrag:2200.00));
            Werknemer werknemer3 = new Werknemer("Sofia", new Salaris(brutoBedrag:3110.00), "Nederland");

            lijstWerknemers.Add(werknemer);
            lijstWerknemers.Add(werknemer1);
            lijstWerknemers.Add(werknemer2);
            lijstWerknemers.Add(werknemer3);

            HerladenLijstWerknemers();
        }

        private void HerladenLijstWerknemers()
        {
            cbWerknemers.DataSource = null;
            cbWerknemers.DataSource = lijstWerknemers;
        }

        private void cbWerknemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Werknemer geselecteerdeWerknemer = cbWerknemers.SelectedItem as Werknemer;
            lblNaam.Text = geselecteerdeWerknemer.Naam;
            lblHerkomst.Text = geselecteerdeWerknemer.LandVanHerkomst;
            lblSalaris.Text = geselecteerdeWerknemer.Lonen.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNaam_Click(object sender, EventArgs e)
        {

        }

        private void lblHerkomst_Click(object sender, EventArgs e)
        {

        }

        private void lblSalaris_Click(object sender, EventArgs e)
        {

        }
    }
}
