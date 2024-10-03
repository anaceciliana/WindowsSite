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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameBox.Text + "\n"+ telBox.Text + "\n" + cpfBox.Text + "\n" + emailBox.Text + "\n" + endBox.Text + "\n" + "SEU CADASTRO FOI CONCLUÍDO COM SUCESSO!");
          
        }
    }
}
