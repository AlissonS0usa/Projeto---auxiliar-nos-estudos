namespace easyStudyProjeto
{
    public partial class formLoginUsuario : Form
    {
        public formLoginUsuario()
        {
            InitializeComponent();
        }

        private void btnUsuarioLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string senha = txtUsuarioSenha.Text;

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Digite seu email para realizar o login.");
            } 
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Digite sua senha para realizar o login.");
            }
            else
            {
                this.Hide();
            }
        }

        private void btnUsuarioCadastrar_Click(object sender, EventArgs e)
        {
                formCadastroUsuario meuFormCadastroUsuario = new formCadastroUsuario();
                meuFormCadastroUsuario.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}