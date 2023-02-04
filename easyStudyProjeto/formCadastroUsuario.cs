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
    public partial class formCadastroUsuario : Form
    {
        public formCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnUsuarioCadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txtUsuarioNome.Text;
            string Sobrenome = txtUsuarioSobrenome.Text;
            string Email = txtUsuarioEmail.Text;
            string Senha = txtUsuarioSenha.Text;

            if (string.IsNullOrEmpty(Nome))
            {
                MessageBox.Show("Digite suas informações para continuar.");
            } else {
                Usuario CadastroUsuario = new Usuario();

                CadastroUsuario.setNome(Nome);
                CadastroUsuario.setSobrenome(Sobrenome);
                CadastroUsuario.setEmail(Email);
                CadastroUsuario.setSenha(Senha);

                MessageBox.Show($"Olá {Nome} sua conta foi criada com sucesso, realize o login para continuar.");

                this.Close();
            }
                
        }

        private void formCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
