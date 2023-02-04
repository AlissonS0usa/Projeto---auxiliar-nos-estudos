namespace easyStudyProjeto
{
    partial class formPainelTarefas
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
            this.btnPainelDeletar = new System.Windows.Forms.Button();
            this.lblPainelTotal = new System.Windows.Forms.Label();
            this.lblPainelProgresso = new System.Windows.Forms.Label();
            this.lblPainelTarefas = new System.Windows.Forms.Label();
            this.lblPainelConcluidas = new System.Windows.Forms.Label();
            this.checkBoxConcluida2 = new System.Windows.Forms.CheckBox();
            this.checkBoxConcluida1 = new System.Windows.Forms.CheckBox();
            this.progressPainelTarefas = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPainelTitulo2 = new System.Windows.Forms.Label();
            this.lblPainelDescricao2 = new System.Windows.Forms.Label();
            this.btnPainelConcluir2 = new System.Windows.Forms.Button();
            this.btnPainelConcluir3 = new System.Windows.Forms.Button();
            this.lblPainelDescricao3 = new System.Windows.Forms.Label();
            this.lblPainelTitulo3 = new System.Windows.Forms.Label();
            this.btnPainelConcluir1 = new System.Windows.Forms.Button();
            this.lblPainelDescricao1 = new System.Windows.Forms.Label();
            this.lblPainelTitulo1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPainelDeletar
            // 
            this.btnPainelDeletar.Location = new System.Drawing.Point(372, 230);
            this.btnPainelDeletar.Name = "btnPainelDeletar";
            this.btnPainelDeletar.Size = new System.Drawing.Size(123, 37);
            this.btnPainelDeletar.TabIndex = 35;
            this.btnPainelDeletar.Text = "Deletar Tarefas";
            this.btnPainelDeletar.UseVisualStyleBackColor = true;
            this.btnPainelDeletar.Click += new System.EventHandler(this.btnPainelDeletar_Click);
            // 
            // lblPainelTotal
            // 
            this.lblPainelTotal.AutoSize = true;
            this.lblPainelTotal.Location = new System.Drawing.Point(372, 183);
            this.lblPainelTotal.Name = "lblPainelTotal";
            this.lblPainelTotal.Size = new System.Drawing.Size(116, 15);
            this.lblPainelTotal.TabIndex = 34;
            this.lblPainelTotal.Text = "Total de tarefas: NaN";
            // 
            // lblPainelProgresso
            // 
            this.lblPainelProgresso.AutoSize = true;
            this.lblPainelProgresso.Location = new System.Drawing.Point(10, 183);
            this.lblPainelProgresso.Name = "lblPainelProgresso";
            this.lblPainelProgresso.Size = new System.Drawing.Size(118, 15);
            this.lblPainelProgresso.TabIndex = 33;
            this.lblPainelProgresso.Text = "Progresso das tarefas";
            // 
            // lblPainelTarefas
            // 
            this.lblPainelTarefas.AutoSize = true;
            this.lblPainelTarefas.Location = new System.Drawing.Point(13, 17);
            this.lblPainelTarefas.Name = "lblPainelTarefas";
            this.lblPainelTarefas.Size = new System.Drawing.Size(95, 15);
            this.lblPainelTarefas.TabIndex = 32;
            this.lblPainelTarefas.Text = "Tarefas a realizar:";
            // 
            // lblPainelConcluidas
            // 
            this.lblPainelConcluidas.AutoSize = true;
            this.lblPainelConcluidas.Location = new System.Drawing.Point(370, 17);
            this.lblPainelConcluidas.Name = "lblPainelConcluidas";
            this.lblPainelConcluidas.Size = new System.Drawing.Size(111, 15);
            this.lblPainelConcluidas.TabIndex = 31;
            this.lblPainelConcluidas.Text = "Tarefas Concluídas: ";
            // 
            // checkBoxConcluida2
            // 
            this.checkBoxConcluida2.AutoSize = true;
            this.checkBoxConcluida2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxConcluida2.Checked = true;
            this.checkBoxConcluida2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConcluida2.Location = new System.Drawing.Point(376, 69);
            this.checkBoxConcluida2.Name = "checkBoxConcluida2";
            this.checkBoxConcluida2.Size = new System.Drawing.Size(114, 19);
            this.checkBoxConcluida2.TabIndex = 29;
            this.checkBoxConcluida2.Text = "Tarefa Concluída";
            this.checkBoxConcluida2.UseVisualStyleBackColor = false;
            // 
            // checkBoxConcluida1
            // 
            this.checkBoxConcluida1.AutoSize = true;
            this.checkBoxConcluida1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxConcluida1.Checked = true;
            this.checkBoxConcluida1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConcluida1.Location = new System.Drawing.Point(376, 45);
            this.checkBoxConcluida1.Name = "checkBoxConcluida1";
            this.checkBoxConcluida1.Size = new System.Drawing.Size(114, 19);
            this.checkBoxConcluida1.TabIndex = 28;
            this.checkBoxConcluida1.Text = "Tarefa Concluída";
            this.checkBoxConcluida1.UseVisualStyleBackColor = false;
            // 
            // progressPainelTarefas
            // 
            this.progressPainelTarefas.Location = new System.Drawing.Point(10, 201);
            this.progressPainelTarefas.Name = "progressPainelTarefas";
            this.progressPainelTarefas.Size = new System.Drawing.Size(478, 23);
            this.progressPainelTarefas.TabIndex = 27;
            this.progressPainelTarefas.Value = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblPainelTitulo2);
            this.panel1.Controls.Add(this.lblPainelDescricao2);
            this.panel1.Controls.Add(this.btnPainelConcluir2);
            this.panel1.Controls.Add(this.btnPainelConcluir3);
            this.panel1.Controls.Add(this.lblPainelDescricao3);
            this.panel1.Controls.Add(this.lblPainelTitulo3);
            this.panel1.Controls.Add(this.btnPainelConcluir1);
            this.panel1.Controls.Add(this.lblPainelDescricao1);
            this.panel1.Controls.Add(this.lblPainelTitulo1);
            this.panel1.Location = new System.Drawing.Point(7, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 142);
            this.panel1.TabIndex = 37;
            // 
            // lblPainelTitulo2
            // 
            this.lblPainelTitulo2.AutoSize = true;
            this.lblPainelTitulo2.Location = new System.Drawing.Point(135, 24);
            this.lblPainelTitulo2.Name = "lblPainelTitulo2";
            this.lblPainelTitulo2.Size = new System.Drawing.Size(37, 15);
            this.lblPainelTitulo2.TabIndex = 22;
            this.lblPainelTitulo2.Text = "Título";
            // 
            // lblPainelDescricao2
            // 
            this.lblPainelDescricao2.AutoSize = true;
            this.lblPainelDescricao2.Location = new System.Drawing.Point(136, 55);
            this.lblPainelDescricao2.Name = "lblPainelDescricao2";
            this.lblPainelDescricao2.Size = new System.Drawing.Size(58, 15);
            this.lblPainelDescricao2.TabIndex = 23;
            this.lblPainelDescricao2.Text = "Descrição";
            // 
            // btnPainelConcluir2
            // 
            this.btnPainelConcluir2.Location = new System.Drawing.Point(128, 101);
            this.btnPainelConcluir2.Name = "btnPainelConcluir2";
            this.btnPainelConcluir2.Size = new System.Drawing.Size(75, 23);
            this.btnPainelConcluir2.TabIndex = 24;
            this.btnPainelConcluir2.Text = "Concluir";
            this.btnPainelConcluir2.UseVisualStyleBackColor = true;
            // 
            // btnPainelConcluir3
            // 
            this.btnPainelConcluir3.Location = new System.Drawing.Point(243, 101);
            this.btnPainelConcluir3.Name = "btnPainelConcluir3";
            this.btnPainelConcluir3.Size = new System.Drawing.Size(75, 23);
            this.btnPainelConcluir3.TabIndex = 21;
            this.btnPainelConcluir3.Text = "Concluir";
            this.btnPainelConcluir3.UseVisualStyleBackColor = true;
            // 
            // lblPainelDescricao3
            // 
            this.lblPainelDescricao3.AutoSize = true;
            this.lblPainelDescricao3.Location = new System.Drawing.Point(250, 55);
            this.lblPainelDescricao3.Name = "lblPainelDescricao3";
            this.lblPainelDescricao3.Size = new System.Drawing.Size(58, 15);
            this.lblPainelDescricao3.TabIndex = 20;
            this.lblPainelDescricao3.Text = "Descrição";
            // 
            // lblPainelTitulo3
            // 
            this.lblPainelTitulo3.AutoSize = true;
            this.lblPainelTitulo3.Location = new System.Drawing.Point(248, 24);
            this.lblPainelTitulo3.Name = "lblPainelTitulo3";
            this.lblPainelTitulo3.Size = new System.Drawing.Size(37, 15);
            this.lblPainelTitulo3.TabIndex = 19;
            this.lblPainelTitulo3.Text = "Título";
            // 
            // btnPainelConcluir1
            // 
            this.btnPainelConcluir1.Location = new System.Drawing.Point(16, 101);
            this.btnPainelConcluir1.Name = "btnPainelConcluir1";
            this.btnPainelConcluir1.Size = new System.Drawing.Size(75, 23);
            this.btnPainelConcluir1.TabIndex = 3;
            this.btnPainelConcluir1.Text = "Concluir";
            this.btnPainelConcluir1.UseVisualStyleBackColor = true;
            // 
            // lblPainelDescricao1
            // 
            this.lblPainelDescricao1.AutoSize = true;
            this.lblPainelDescricao1.Location = new System.Drawing.Point(24, 58);
            this.lblPainelDescricao1.Name = "lblPainelDescricao1";
            this.lblPainelDescricao1.Size = new System.Drawing.Size(58, 15);
            this.lblPainelDescricao1.TabIndex = 2;
            this.lblPainelDescricao1.Text = "Descrição";
            // 
            // lblPainelTitulo1
            // 
            this.lblPainelTitulo1.AutoSize = true;
            this.lblPainelTitulo1.Location = new System.Drawing.Point(25, 24);
            this.lblPainelTitulo1.Name = "lblPainelTitulo1";
            this.lblPainelTitulo1.Size = new System.Drawing.Size(37, 15);
            this.lblPainelTitulo1.TabIndex = 1;
            this.lblPainelTitulo1.Text = "Título";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(364, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 142);
            this.panel2.TabIndex = 38;
            // 
            // formPainelTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 279);
            this.Controls.Add(this.btnPainelDeletar);
            this.Controls.Add(this.lblPainelTotal);
            this.Controls.Add(this.lblPainelProgresso);
            this.Controls.Add(this.lblPainelTarefas);
            this.Controls.Add(this.lblPainelConcluidas);
            this.Controls.Add(this.checkBoxConcluida2);
            this.Controls.Add(this.checkBoxConcluida1);
            this.Controls.Add(this.progressPainelTarefas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "formPainelTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de Tarefas";
            this.Load += new System.EventHandler(this.formPainelTarefas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPainelDeletar;
        private Label lblPainelTotal;
        private Label lblPainelProgresso;
        private Label lblPainelTarefas;
        private Label lblPainelConcluidas;
        private CheckBox checkBoxConcluida2;
        private CheckBox checkBoxConcluida1;
        private ProgressBar progressPainelTarefas;
        private Panel panel1;
        private Label lblPainelTitulo2;
        private Label lblPainelDescricao2;
        private Button btnPainelConcluir2;
        private Button btnPainelConcluir3;
        private Label lblPainelDescricao3;
        private Label lblPainelTitulo3;
        private Button btnPainelConcluir1;
        private Label lblPainelDescricao1;
        private Label lblPainelTitulo1;
        private Panel panel2;
    }
}