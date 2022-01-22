using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showPlanetbutton_Click(object sender, EventArgs e)
        {
            string planetName = planetListComboBox.Text;

            if(planetName == "Planet")
            {
                MessageBox.Show("it is in 3rd position");
            }
            else if (planetName == "Saturn")
            {
                MessageBox.Show("it is in 6th position");
            }
            else if (planetName == "Mars")
            {
                MessageBox.Show("it is in 4th position");
            }
            else
            {
                MessageBox.Show("I don't know");
            }
        }
    }
}
