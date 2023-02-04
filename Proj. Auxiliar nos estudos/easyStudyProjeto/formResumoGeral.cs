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
    public partial class formResumoGeral : Form
    {
        public formResumoGeral()
        {
            InitializeComponent();
        }

        private void btnResumoAcessarMetas_Click(object sender, EventArgs e)
        {
            formPainelMetas meuformPainelMetas = new formPainelMetas();
            meuformPainelMetas.Show();
        }

        private void formResumoGeral_Load(object sender, EventArgs e)
        {

        }
    }
}
