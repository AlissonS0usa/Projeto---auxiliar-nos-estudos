namespace easyStudyProjeto
{
    partial class formCadastroTarefas
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
            this.checkBoxLembrete = new System.Windows.Forms.CheckBox();
            this.btnTarefaAdicionar = new System.Windows.Forms.Button();
            this.txtTarefaDescricao = new System.Windows.Forms.TextBox();
            this.txtTarefaTitulo = new System.Windows.Forms.TextBox();
            this.lblTarefaNivel = new System.Windows.Forms.Label();
            this.lblTarefaPrioridade = new System.Windows.Forms.Label();
            this.lblTarefaPrazo = new System.Windows.Forms.Label();
            this.lblTarefaDescricao = new System.Windows.Forms.Label();
            this.lblTarefaTitulo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // checkBoxLembrete
            // 
            this.checkBoxLembrete.AutoSize = true;
            this.checkBoxLembrete.Location = new System.Drawing.Point(321, 122);
            this.checkBoxLembrete.Name = "checkBoxLembrete";
            this.checkBoxLembrete.Size = new System.Drawing.Size(123, 19);
            this.checkBoxLembrete.TabIndex = 21;
            this.checkBoxLembrete.Text = "Receber lembretes";
            this.checkBoxLembrete.UseVisualStyleBackColor = true;
            // 
            // btnTarefaAdicionar
            // 
            this.btnTarefaAdicionar.Location = new System.Drawing.Point(308, 155);
            this.btnTarefaAdicionar.Name = "btnTarefaAdicionar";
            this.btnTarefaAdicionar.Size = new System.Drawing.Size(153, 39);
            this.btnTarefaAdicionar.TabIndex = 20;
            this.btnTarefaAdicionar.Text = "Adicionar Tarefa";
            this.btnTarefaAdicionar.UseVisualStyleBackColor = true;
            this.btnTarefaAdicionar.Click += new System.EventHandler(this.btnTarefaAdicionar_Click_1);
            // 
            // txtTarefaDescricao
            // 
            this.txtTarefaDescricao.Location = new System.Drawing.Point(22, 111);
            this.txtTarefaDescricao.Name = "txtTarefaDescricao";
            this.txtTarefaDescricao.Size = new System.Drawing.Size(229, 23);
            this.txtTarefaDescricao.TabIndex = 19;
            // 
            // txtTarefaTitulo
            // 
            this.txtTarefaTitulo.Location = new System.Drawing.Point(22, 44);
            this.txtTarefaTitulo.Name = "txtTarefaTitulo";
            this.txtTarefaTitulo.Size = new System.Drawing.Size(227, 23);
            this.txtTarefaTitulo.TabIndex = 18;
            // 
            // lblTarefaNivel
            // 
            this.lblTarefaNivel.AutoSize = true;
            this.lblTarefaNivel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTarefaNivel.Location = new System.Drawing.Point(288, 44);
            this.lblTarefaNivel.Name = "lblTarefaNivel";
            this.lblTarefaNivel.Size = new System.Drawing.Size(146, 15);
            this.lblTarefaNivel.TabIndex = 17;
            this.lblTarefaNivel.Text = "1- Alto, 2- Médio, 3- Baixo";
            // 
            // lblTarefaPrioridade
            // 
            this.lblTarefaPrioridade.AutoSize = true;
            this.lblTarefaPrioridade.Location = new System.Drawing.Point(287, 23);
            this.lblTarefaPrioridade.Name = "lblTarefaPrioridade";
            this.lblTarefaPrioridade.Size = new System.Drawing.Size(108, 15);
            this.lblTarefaPrioridade.TabIndex = 16;
            this.lblTarefaPrioridade.Text = "Grau de prioridade:";
            // 
            // lblTarefaPrazo
            // 
            this.lblTarefaPrazo.AutoSize = true;
            this.lblTarefaPrazo.Location = new System.Drawing.Point(22, 153);
            this.lblTarefaPrazo.Name = "lblTarefaPrazo";
            this.lblTarefaPrazo.Size = new System.Drawing.Size(147, 15);
            this.lblTarefaPrazo.TabIndex = 15;
            this.lblTarefaPrazo.Text = "Prazo de entrega da tarefa:";
            // 
            // lblTarefaDescricao
            // 
            this.lblTarefaDescricao.AutoSize = true;
            this.lblTarefaDescricao.Location = new System.Drawing.Point(19, 93);
            this.lblTarefaDescricao.Name = "lblTarefaDescricao";
            this.lblTarefaDescricao.Size = new System.Drawing.Size(108, 15);
            this.lblTarefaDescricao.TabIndex = 14;
            this.lblTarefaDescricao.Text = "Descrição da Tarefa";
            // 
            // lblTarefaTitulo
            // 
            this.lblTarefaTitulo.AutoSize = true;
            this.lblTarefaTitulo.Location = new System.Drawing.Point(22, 23);
            this.lblTarefaTitulo.Name = "lblTarefaTitulo";
            this.lblTarefaTitulo.Size = new System.Drawing.Size(95, 15);
            this.lblTarefaTitulo.TabIndex = 13;
            this.lblTarefaTitulo.Text = "*Título da Tarefa:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 23);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(394, 20);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(97, 23);
            this.domainUpDown1.TabIndex = 23;
            // 
            // formCadastroTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 249);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBoxLembrete);
            this.Controls.Add(this.btnTarefaAdicionar);
            this.Controls.Add(this.txtTarefaDescricao);
            this.Controls.Add(this.txtTarefaTitulo);
            this.Controls.Add(this.lblTarefaNivel);
            this.Controls.Add(this.lblTarefaPrioridade);
            this.Controls.Add(this.lblTarefaPrazo);
            this.Controls.Add(this.lblTarefaDescricao);
            this.Controls.Add(this.lblTarefaTitulo);
            this.Name = "formCadastroTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Tarefas";
            this.Load += new System.EventHandler(this.formCadastroTarefas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox checkBoxLembrete;
        private Button btnTarefaAdicionar;
        private TextBox txtTarefaDescricao;
        private TextBox txtTarefaTitulo;
        private Label lblTarefaNivel;
        private Label lblTarefaPrioridade;
        private Label lblTarefaPrazo;
        private Label lblTarefaDescricao;
        private Label lblTarefaTitulo;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown domainUpDown1;
    }
}