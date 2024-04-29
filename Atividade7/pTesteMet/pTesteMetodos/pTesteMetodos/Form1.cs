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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu copiar");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu colar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio2>().Count() > 0)
            {
                //Application.OpenForms["frmExercicio2"].BringToFront();

                Application.OpenForms["frmExercicio2"].Activate();
            }
            else
            {
                frmExercicio2 objForm2 = new frmExercicio2();
                objForm2.MdiParent = this;
                objForm2.WindowState = FormWindowState.Maximized;
                objForm2.Show();
            }

            frmExercicio2 objFrm2 = new frmExercicio2();
            objFrm2.MdiParent = this;
            objFrm2.WindowState = FormWindowState.Maximized;
            objFrm2.Show();

        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio3>().Count() > 0)
            {
                //Application.OpenForms["frmExercicio3"].BringToFront();

                Application.OpenForms["frmExercicio3"].Activate();
            }
            else
            {
                frmExercicio3 objForm3 = new frmExercicio3();
                objForm3.MdiParent = this;
                objForm3.WindowState = FormWindowState.Maximized;
                objForm3.Show();
            }

            frmExercicio3 objFrm3 = new frmExercicio3();
            objFrm3.MdiParent = this;
            objFrm3.WindowState = FormWindowState.Maximized;
            objFrm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                //Application.OpenForms["frmExercicio4"].BringToFront();

                Application.OpenForms["frmExercicio4"].Activate();
            }
            else
            {
                frmExercicio4 objForm4 = new frmExercicio4();
                objForm4.MdiParent = this;
                objForm4.WindowState = FormWindowState.Maximized;
                objForm4.Show();
            }

            frmExercicio4 objFrm4 = new frmExercicio4();
            objFrm4.MdiParent = this;
            objFrm4.WindowState = FormWindowState.Maximized;
            objFrm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio5>().Count() > 0)
            {
                //Application.OpenForms["frmExercicio5"].BringToFront();

                Application.OpenForms["frmExercicio5"].Activate();
            }
            else
            {
                frmExercicio5 objForm5 = new frmExercicio5();
                objForm5.MdiParent = this;
                objForm5.WindowState = FormWindowState.Maximized;
                objForm5.Show();
            }

            frmExercicio5 objFrm5 = new frmExercicio5();
            objFrm5.MdiParent = this;
            objFrm5.WindowState = FormWindowState.Maximized;
            objFrm5.Show();
        }
    }
}
