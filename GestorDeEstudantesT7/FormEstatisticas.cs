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

        
        private void panelTotalDeEstudantes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalEstudantes_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = corPainelTotal;
            labelTotalEstudantes.ForeColor = Color.Gray;
        }

        private void labelTotalEstudantes_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Gray;
            labelTotalEstudantes.ForeColor = corPainelTotal;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Gray;
            labelMeninos.ForeColor = corPainelMenino;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            labelMeninos.ForeColor = Color.Gray;
            panelMeninos.BackColor = corPainelMenino;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Gray;
            labelMeninas.ForeColor = corPainelMenina;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            labelMeninas.ForeColor = Color.Gray;
            panelMeninas.BackColor = corPainelMenina;
        }
    }
}
