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
    public partial class infoUsuario : Form
    {
        public Usuario UsuarioSelecionadoDoListar { get; set; }
        public infoUsuario()
        {
            InitializeComponent();
        }

        private void infoUsuario_Load(object sender, EventArgs e)
        {
            this.labelNome.Text = this.UsuarioSelecionadoDoListar.getNome();
            this.labelSobrenome.Text = this.UsuarioSelecionadoDoListar.getSobrenome();
            this.labelEmail.Text = this.UsuarioSelecionadoDoListar.getEmail();
        }
    }
}
