﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeEstudantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListarEstudantes formListarEstudante = new FormListarEstudantes();
            formListarEstudante.Show(this);
        }

        private void novoEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante formInserirEstudante = new FormInserirEstudante();
            formInserirEstudante.Show(this);
        }

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarRemoverToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
