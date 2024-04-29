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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0,numero = 0;

            while (i < rchtxtTexto.Text.Length) {
                if (Char.IsNumber(rchtxtTexto.Text[i]))
                    numero++;   
                
                i++;
            }
            MessageBox.Show("Quantidade de números: " + numero);
        }

        private void btnPrimeroBranco_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i <  rchtxtTexto.Text.Length; i++) 
            {
                if (char.IsWhiteSpace(rchtxtTexto.Text[i]))
                {
                    i++;
                    MessageBox.Show("Posição primeiro branco: " + i);
                    break;
                }
            }
        }

        private void btnQtdLetra_Click(object sender, EventArgs e)
        {
            int numero = 0;

            foreach (var i in rchtxtTexto.Text) 
            {
                if (char.IsLetter(i))
                {
                    numero++;
                }
            }
            MessageBox.Show("Quantidade de caracteres: " + numero);
        }
    }
}
