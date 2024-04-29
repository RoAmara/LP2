using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTesteMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero1.Text, out int ch1))
            {
                if(int.TryParse(txtNumero2.Text, out int ch2))
                { 
                    if (ch2 > ch1)
                    {
                        Random obj = new Random();
                        double aleatorio = obj.Next(ch1, ch2);
                        MessageBox.Show("Número aleatório: " + aleatorio);
                    }
                    else
                    {
                        MessageBox.Show("Número 2 deve ser maior que número 1");
                    }
                }
                else
                {
                    MessageBox.Show("Número inválido");
                    txtNumero2.Clear();
                    txtNumero2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Número 1 inválido");
                txtNumero1.Clear();
                txtNumero1.Focus();
            }

        }
    }
}
