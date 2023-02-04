namespace easyStudyProjeto
{
    partial class formResumoGeral
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.progressResumoTarefas = new System.Windows.Forms.ProgressBar();
            this.painelResumoLembretes = new System.Windows.Forms.Panel();
            this.lblResumoLembretes = new System.Windows.Forms.Label();
            this.lblResumoProgresso = new System.Windows.Forms.Label();
            this.lblResumoEficiencia = new System.Windows.Forms.Label();
            this.painelResumoLembretes.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(305, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            // 
            // progressResumoTarefas
            // 
            this.progressResumoTarefas.Location = new System.Drawing.Point(154, 74);
            this.progressResumoTarefas.Name = "progressResumoTarefas";
            this.progressResumoTarefas.Size = new System.Drawing.Size(228, 23);
            this.progressResumoTarefas.TabIndex = 20;
            this.progressResumoTarefas.Value = 30;
            // 
            // painelResumoLembretes
            // 
            this.painelResumoLembretes.BackColor = System.Drawing.SystemColors.Window;
            this.painelResumoLembretes.Controls.Add(this.lblResumoLembretes);
            this.painelResumoLembretes.Location = new System.Drawing.Point(26, 126);
            this.painelResumoLembretes.Name = "painelResumoLembretes";
            this.painelResumoLembretes.Size = new System.Drawing.Size(222, 162);
            this.painelResumoLembretes.TabIndex = 19;
            // 
            // lblResumoLembretes
            // 
            this.lblResumoLembretes.AutoSize = true;
            this.lblResumoLembretes.Location = new System.Drawing.Point(71, 7);
            this.lblResumoLembretes.Name = "lblResumoLembretes";
            this.lblResumoLembretes.Size = new System.Drawing.Size(62, 15);
            this.lblResumoLembretes.TabIndex = 4;
            this.lblResumoLembretes.Text = "Lembretes";
            // 
            // lblResumoProgresso
            // 
            this.lblResumoProgresso.AutoSize = true;
            this.lblResumoProgresso.Location = new System.Drawing.Point(26, 74);
            this.lblResumoProgresso.Name = "lblResumoProgresso";
            this.lblResumoProgresso.Size = new System.Drawing.Size(122, 15);
            this.lblResumoProgresso.TabIndex = 18;
            this.lblResumoProgresso.Text = "Progresso das Tarefas:";
            // 
            // lblResumoEficiencia
            // 
            this.lblResumoEficiencia.AutoSize = true;
            this.lblResumoEficiencia.Location = new System.Drawing.Point(26, 37);
            this.lblResumoEficiencia.Name = "lblResumoEficiencia";
            this.lblResumoEficiencia.Size = new System.Drawing.Size(143, 15);
            this.lblResumoEficiencia.TabIndex = 17;
            this.lblResumoEficiencia.Text = "Eficiência de Estudos: %%";
            // 
            // formResumoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 321);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.progressResumoTarefas);
            this.Controls.Add(this.painelResumoLembretes);
            this.Controls.Add(this.lblResumoProgresso);
            this.Controls.Add(this.lblResumoEficiencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formResumoGeral";
            this.Text = "Resumo de Estudos Geral";
            this.Load += new System.EventHandler(this.formResumoGeral_Load);
            this.painelResumoLembretes.ResumeLayout(false);
            this.painelResumoLembretes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ProgressBar progressResumoTarefas;
        private Panel painelResumoLembretes;
        private Label lblResumoLembretes;
        private Label lblResumoProgresso;
        private Label lblResumoEficiencia;
    }
}