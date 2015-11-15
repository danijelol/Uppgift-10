using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_10
{

    public partial class Form1 : Form
    {
        Random slump = new Random();
        int slumptal;
        int antalgissningar = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slumptal = slump.Next(1000);
            antalgissningar = 1;
            MessageBox.Show("Nu är talet slumpat. Varsågod att börja gissa!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            int gissning = int.Parse(txtBoxGissa.Text);
            

            if (gissning > slumptal && (gissning - slumptal) >= 100)
            {
                txtBoxKommentar.Text = "Talet är mycket lägre!";
            }
            if (gissning < slumptal && (slumptal - gissning) >= 100)
            {
                txtBoxKommentar.Text = "Talet är mycket högre!";
            }
            if (gissning > slumptal && (gissning - slumptal) < 100)
            {
                txtBoxKommentar.Text = "Talet är lägre.";
            }
            if (gissning < slumptal && (slumptal - gissning) < 100)
            {
                txtBoxKommentar.Text = "Talet är högre.";
            }
            if (gissning == slumptal)
            {
                MessageBox.Show("Grattis, du gissade rätt! Det tog dig " + antalgissningar + " försök att gissa rätt.");
                txtBoxKommentar.Text = "Rätt svar var: " + slumptal;
            }
            else if (gissning != slumptal)
            {
                antalgissningar++;
            }

                      
        }

        private void txtBoxKommentar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
