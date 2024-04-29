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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtPalavra1.Text == "" || txtPalavra2.Text == "")
            {
                MessageBox.Show("Palavras não podem ser vazio");
            }
            else
            {
                txtPalavra1.Text = txtPalavra1.Text.ToUpper();
                txtPalavra2.Text = txtPalavra2.Text.ToUpper();

                txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
            }
        }

        private void btnInverte_Click(object sender, EventArgs e)
        {
            char[] vetor = txtPalavra1.Text.ToCharArray();
            Array.Reverse(vetor); 
            
            txtPalavra2.Text = new string(vetor);
        }
    }
}
