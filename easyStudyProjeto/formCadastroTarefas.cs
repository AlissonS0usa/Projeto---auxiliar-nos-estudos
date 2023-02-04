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
    public partial class formCadastroTarefas : Form
    {
        public formCadastroTarefas()
        {
            InitializeComponent();
        }

        private void btnTarefaAdicionar_Click(object sender, EventArgs e)
        {
            formPainelTarefas meuFormPainelTarefas = new formPainelTarefas();
            meuFormPainelTarefas.Show();
        }

        private void formCadastroTarefas_Load(object sender, EventArgs e)
        {

        }

        private void btnTarefaAdicionar_Click_1(object sender, EventArgs e)
        {
            Tarefas Tarefa = new Tarefas();
            Tarefa.Titulo = "Seminário";
            Tarefa.Descricao = "Seminário sobre meio ambiente";
            Tarefa.Prazo = new DateTime(2022, 11, 09, 9, 15, 0);
            Tarefa.GrauPrioridade = 1;
            Tarefa.ReceberLembretes = true;

            MessageBox.Show("Tarefa Adicionada.");
            this.Hide();

            //formUsuarioVisualizar meuFormularioUsuarioVisualizar = new formUsuarioVisualizar();
            //meuFormularioUsuarioVisualizar.Usuario = objNeymar;
            //meuFormularioUsuarioVisualizar.Show();
        }
    }
}
