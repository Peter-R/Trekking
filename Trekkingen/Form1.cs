using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trekkingen
{
    public partial class Form1 : Form
    {
        private Trekking trekking;

        public Form1()
        {
            InitializeComponent();           
        }

        private void btAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btTrekVolgendGetal.Enabled = false;
            btToonInfo.Enabled = false;
            btTrekEnToonAlles.Enabled = false;
        }

        private void btMaakTrekkingObject_Click(object sender, EventArgs e)
        {
            if (tbAantalGewenst.Text == string.Empty || tbMaximaleWaarde.Text == string.Empty)
            {
                MessageBox.Show("Een of meerdere parameters die noodzakelijk zijn voor het aanmaken van een trekking-object ontbreken!", "Foutmelding:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                int maximaleWaarde;
                int gewenstAantal;

                try
                {
                    maximaleWaarde = Convert.ToInt32(tbMaximaleWaarde.Text);
                    gewenstAantal = Convert.ToInt32(tbAantalGewenst.Text);
                }
                catch
                {
                    MessageBox.Show("Er zijn geen geldige parameters meegegeven om een trekking-object mee aan te maken!", "Foutmelding:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (maximaleWaarde < 0 || gewenstAantal < 0)
                {
                    MessageBox.Show("Er mogen alleen positieve waardes worden opgegeven!", "Foutmelding:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (gewenstAantal > maximaleWaarde)
                {
                    MessageBox.Show("Het gewenste aantal mag niet groter zijn dan de maximale waarde!", "Foutmelding:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btTrekVolgendGetal.Enabled = true;
                    btToonInfo.Enabled = true;
                    btTrekEnToonAlles.Enabled = true;

                    trekking = new Trekking(maximaleWaarde, gewenstAantal);
                }                
            }
        }

        private void btTrekVolgendGetal_Click(object sender, EventArgs e)
        {
            if (trekking.IsTenEinde)
            {                
                btTrekVolgendGetal.Enabled = false;
                btTrekEnToonAlles.Enabled = false;

                MessageBox.Show("Het maximaal te trekken getallen is al bereikt!", "Waarschuwing:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                trekking.TrekGetal();
            }
        }

        private void btToonInfo_Click(object sender, EventArgs e)
        {
            string info = "Trekkingsinformatie:" + Environment.NewLine + Environment.NewLine +
                          "Maximale waarde: " + trekking.MaximaleWaarde + Environment.NewLine +
                          "Aantal gewenst: " + trekking.AantalGewenst + Environment.NewLine +
                          "Aantal getrokken: " + trekking.AantalGetrokken + Environment.NewLine +
                          "Getrokken getallen: ";            

            for (int i = 0; i < trekking.AantalGetrokken; i++)
                info += trekking.GeefGetal(i) + (i < trekking.AantalGetrokken - 1 ? ", " : ";");

            tbInfo.Text = info;
        }

        private void btTrekEnToonAlles_Click(object sender, EventArgs e)
        {
            for (int i = trekking.AantalGetrokken; i < trekking.AantalGewenst; i++)
                trekking.TrekGetal();            
            
            btTrekVolgendGetal.Enabled = false;
            btTrekEnToonAlles.Enabled = false;
            btToonInfo.Enabled = false;

            trekking.Sorteer();

            btToonInfo_Click(this, null);
        }
    }
}
