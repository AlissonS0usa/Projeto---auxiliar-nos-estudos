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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
            formLoginUsuario MeuFormLoginUsuario = new formLoginUsuario();
            MeuFormLoginUsuario.ShowDialog();

            formResumoGeral principal = new formResumoGeral();
            principal.MdiParent = this;
            principal.Show();
        }


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMetaEstudos MeuFormMetasEstudos = new formMetaEstudos();
            MeuFormMetasEstudos.ShowDialog();
        }

        private void painelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Meta> Metas = new List<Meta>();

            Meta LPRC4 = new Meta();
            LPRC4.Materia = "LPRC4";
            LPRC4.Horas = "10:00";
            LPRC4.Concluida = true;
            Metas.Add(LPRC4);

            Meta Portunhol = new Meta();
            Portunhol.Materia = "Portunhol";
            Portunhol.Horas = "01:30";
            Portunhol.Concluida = false;
            Metas.Add(Portunhol);

            Meta Ciencias = new Meta();
            Ciencias.Materia = "Ciências";
            Ciencias.Horas = "03:00";
            Ciencias.Concluida = true;
            Metas.Add(Ciencias);

            Meta Geografia = new Meta();
            Geografia.Materia = "Geografia";
            Geografia.Horas = "07:00";
            Geografia.Concluida = false;
            Metas.Add(Geografia);

            Meta Ingles = new Meta();
            Ingles.Materia = "Inglês";
            Ingles.Horas = "02:30";
            Ingles.Concluida = true;
            Metas.Add(Ingles);

            Metas.Remove(Portunhol);

            formPainelMetas MeuFormPainelMetas = new formPainelMetas();
            MeuFormPainelMetas.setMetas(Metas);
            MeuFormPainelMetas.ShowDialog();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCadastroTarefas MeuFormCadastroTarefas = new formCadastroTarefas();
            MeuFormCadastroTarefas.ShowDialog();
        }

        private void painelToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            //Tarefas a Realizar
            Tarefas objTarefa1 = new Tarefas();
            objTarefa1.Titulo = "Física";
            objTarefa1.Descricao = "Seminário";

            Tarefas objTarefa2 = new Tarefas();
            objTarefa2.Titulo = "Geografica";
            objTarefa2.Descricao = "Artigo";

            Tarefas objTarefa3 = new Tarefas();
            objTarefa3.Titulo = "Matemática";
            objTarefa3.Descricao = "Lista de Ex.";

            //Tarefas Concluidas
            Tarefas objTarefa4 = new Tarefas();
            objTarefa4.Titulo = "Ciência";

            Tarefas objTarefa5 = new Tarefas();
            objTarefa5.Titulo = "Informática";

            formPainelTarefas MeuFormPainelTarefas = new formPainelTarefas();
            MeuFormPainelTarefas.TarefaCadastrada1 = objTarefa1;

            MeuFormPainelTarefas.TarefaCadastrada2 = objTarefa2;

            MeuFormPainelTarefas.TarefaCadastrada3 = objTarefa3;

            MeuFormPainelTarefas.TarefaCadastrada4 = objTarefa4;

            MeuFormPainelTarefas.TarefaCadastrada5 = objTarefa5;

            MeuFormPainelTarefas.ShowDialog();
        }


        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario obgJosefina = new Usuario();
            obgJosefina.setNome("Josefina");
            obgJosefina.setSobrenome("Perna fina");
            obgJosefina.setEmail("josefinaCalibrada@hotmail.com");

            infoUsuario informacoes = new infoUsuario();
            informacoes.UsuarioSelecionadoDoListar = obgJosefina;

            informacoes.ShowDialog();
            
        }
    }
}
