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
    public partial class formPainelMetas : Form
    {
        public formPainelMetas()
        {
            InitializeComponent();
        }

        //Construtores e Gridviews

        List<Meta>? Metas;

        public void setMetas(List<Meta> metas)
        {
            this.Metas = metas;
        }

        private void btnMetaDeletar_Click(object sender, EventArgs e)
        {
            formConfirmOperation formConfirmOperation = new formConfirmOperation();
            
            if (formConfirmOperation.ShowDialog() == DialogResult.OK){
                MessageBox.Show("Meta(s) removida(s).");

                this.Close();
            } else {
                MessageBox.Show("Operação cancelada.");
            }  
        }

        private void formPainelMetas_Load(object sender, EventArgs e)
        {


            this.dataSource.DataSource = this.Metas;

        }
    }
}
