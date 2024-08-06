using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Color corPainelTotal;
        Color corPainelMenino;
        Color corPainelMenina;
        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalDeEstudantes.BackColor;
            corPainelMenino = panelMeninos.BackColor;
            corPainelMenina = panelMeninas.BackColor;

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
