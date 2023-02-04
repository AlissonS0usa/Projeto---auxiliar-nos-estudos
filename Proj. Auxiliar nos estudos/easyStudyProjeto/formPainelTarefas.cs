using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyStudyProjeto
{
    public partial class formPainelTarefas : Form
    {
        public formPainelTarefas()
        {
            InitializeComponent();
        }

        public Tarefas TarefaCadastrada1 { get; set; }
        public Tarefas TarefaCadastrada2 { get; set; }
        public Tarefas TarefaCadastrada3 { get; set; }
        public Tarefas TarefaCadastrada4 { get; set; }
        public Tarefas TarefaCadastrada5 { get; set; }

        private void btnPainelDeletar_Click(object sender, EventArgs e)
        {
            formConfirmOperation formConfirmOperation = new formConfirmOperation();

            if (formConfirmOperation.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("Tarefa(s) removida(s).");
                this.Close();
            } else {
                MessageBox.Show("Operação cancelada.");
            }  
        }

        private void formPainelTarefas_Load(object sender, EventArgs e)
        {
            this.lblPainelTitulo1.Text = this.TarefaCadastrada1.Titulo;
            this.lblPainelDescricao1.Text = this.TarefaCadastrada1.Descricao;

            this.lblPainelTitulo2.Text = this.TarefaCadastrada2.Titulo;
            this.lblPainelDescricao2.Text = this.TarefaCadastrada2.Descricao;

            this.lblPainelTitulo3.Text = this.TarefaCadastrada3.Titulo;
            this.lblPainelDescricao3.Text = this.TarefaCadastrada3.Descricao;

            this.checkBoxConcluida1.Text = this.TarefaCadastrada4.Titulo;
            this.checkBoxConcluida2.Text = this.TarefaCadastrada5.Titulo;

        }
    }
}
