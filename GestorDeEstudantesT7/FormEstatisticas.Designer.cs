namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTotalDeEstudantes = new System.Windows.Forms.Panel();
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelTotalEstudantes = new System.Windows.Forms.Label();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelTotalDeEstudantes.SuspendLayout();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalDeEstudantes
            // 
            this.panelTotalDeEstudantes.BackColor = System.Drawing.Color.Lime;
            this.panelTotalDeEstudantes.Controls.Add(this.labelTotalEstudantes);
            this.panelTotalDeEstudantes.Location = new System.Drawing.Point(12, 12);
            this.panelTotalDeEstudantes.Name = "panelTotalDeEstudantes";
            this.panelTotalDeEstudantes.Size = new System.Drawing.Size(772, 226);
            this.panelTotalDeEstudantes.TabIndex = 0;
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(399, 244);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(385, 194);
            this.panelMeninas.TabIndex = 1;
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.Blue;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Location = new System.Drawing.Point(12, 244);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(385, 194);
            this.panelMeninos.TabIndex = 1;
            // 
            // labelTotalEstudantes
            // 
            this.labelTotalEstudantes.AutoSize = true;
            this.labelTotalEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.26F);
            this.labelTotalEstudantes.Location = new System.Drawing.Point(196, 101);
            this.labelTotalEstudantes.Name = "labelTotalEstudantes";
            this.labelTotalEstudantes.Size = new System.Drawing.Size(350, 36);
            this.labelTotalEstudantes.TabIndex = 2;
            this.labelTotalEstudantes.Text = "Total De Estudantes: 999";
            this.labelTotalEstudantes.Click += new System.EventHandler(this.label1_Click);
            this.labelTotalEstudantes.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.labelTotalEstudantes.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.26F);
            this.labelMeninos.Location = new System.Drawing.Point(81, 77);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(198, 36);
            this.labelMeninos.TabIndex = 3;
            this.labelMeninos.Text = "Meninos 50%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26F);
            this.labelMeninas.Location = new System.Drawing.Point(131, 83);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(166, 29);
            this.labelMeninas.TabIndex = 4;
            this.labelMeninas.Text = "Meninas 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // FormEstatisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelMeninas);
            this.Controls.Add(this.panelTotalDeEstudantes);
            this.Name = "FormEstatisticas";
            this.Text = "FormEstatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load);
            this.panelTotalDeEstudantes.ResumeLayout(false);
            this.panelTotalDeEstudantes.PerformLayout();
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalDeEstudantes;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotalEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
    }
}