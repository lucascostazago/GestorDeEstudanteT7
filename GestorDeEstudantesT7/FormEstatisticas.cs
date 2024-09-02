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
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        // Variáveis que SERÃO usadas para guardar as cores dos paineis (panel).
        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            // GUARDA as cores dos paineis (panel) no momento da inicialização
            // (não confundir com 'label').
            corPainelTotal = panelTotalDeEstudantes.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
            
            // Exibe os valores (total geral, total de meninos, meninas etc)
            Estudante estudante = new Estudante();
            
            double totalEstudantes = 
                Convert.ToDouble(estudante.totalDeEstudantes());
            double totalMeninos = 
                Convert.ToDouble(estudante.totalDeEstudantesMeninos());
            double totalMeninas = 
                Convert.ToDouble(estudante.totalDeEstudantesMeninas());

            // Contar a porcentagem (%).
            double porcentagemDeMeninos
                = totalMeninos * 100 / totalEstudantes;
            double porcentagemDeMeninas
                = totalMeninas * 100 / totalEstudantes;

            labelTotalDeEstudantes.Text = "Total de Estudantes: "
                + totalEstudantes.ToString();
            labelMeninos.Text = "% de Meninos: " 
                + porcentagemDeMeninos.ToString("0.00") + "%";
            labelMeninas.Text = "% de Meninas: "
                + porcentagemDeMeninas.ToString("0.00") + "%";
        }
















        private void labelTotalDeEstudantes_MouseEnter(object sender, EventArgs e)
        {
            // Ao passar o mouse sobre o texto, salva altera a cor do PAINEL
            // para preto e a cor do texto para a cor do PAINEL.
            panelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_MouseLeave(object sender, EventArgs e)
        {
            // Ao tirar o mouse do texto, altera a cor do PAINEL para a cor original
            // do PAINEL e a cor do texto para a cor preta.
            panelTotalDeEstudantes.BackColor = corPainelTotal;
            labelTotalDeEstudantes.ForeColor = Color.Black;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelMeninos;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = corPainelMeninos;
            labelMeninos.ForeColor = Color.Black;
        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelMeninas;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninas.BackColor = corPainelMeninas;
            labelMeninas.ForeColor = Color.Black;
        }
    }
}
