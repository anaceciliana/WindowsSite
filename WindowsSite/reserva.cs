using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSite
{
    public partial class reserva : Form
    {
        public reserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string checkin = cin.Text;
            string checkout = cout.Text;
            string qntcrianca = crianca.Text;
            string qntadulto = adultos.Text;

            MessageBox.Show(
                "Check-in: " + checkin +
                "\nCheck-out: " + checkout +
                "\nQuantidade de crianças: " + qntcrianca +
                "\nQuantidade de adultos: " + qntadulto);

            

        }
    }
}
