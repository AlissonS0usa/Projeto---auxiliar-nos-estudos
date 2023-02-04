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
    public partial class formMetaEstudos : Form
    {
        public formMetaEstudos()
        {
            InitializeComponent();
        }

        private void formMetaEstudos_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarMeta_Click(object sender, EventArgs e)
        {
            Meta Metas = new Meta();
            Metas.Materia = "Portunhol";
            Metas.Horas = "01:00";
            //Metas.setHoras(10);
            Metas.ReceberLembretes = false;

            MessageBox.Show("Meta(s) Adicionada(s).");
            this.Hide();
        }
    }
}
