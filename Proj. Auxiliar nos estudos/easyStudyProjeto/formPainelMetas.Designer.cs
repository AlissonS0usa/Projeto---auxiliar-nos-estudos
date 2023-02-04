namespace easyStudyProjeto
{
    partial class formPainelMetas
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
            this.dataSource = new System.Windows.Forms.DataGridView();
            this.btnMetaDeletar = new System.Windows.Forms.Button();
            this.lblMetasResultado = new System.Windows.Forms.Label();
            this.progressMetas = new System.Windows.Forms.ProgressBar();
            this.classColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkHours = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSource
            // 
            this.dataSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classColumn,
            this.hours,
            this.checkHours});
            this.dataSource.Location = new System.Drawing.Point(-6, -3);
            this.dataSource.Name = "dataSource";
            this.dataSource.RowTemplate.Height = 25;
            this.dataSource.Size = new System.Drawing.Size(343, 276);
            this.dataSource.TabIndex = 30;
            // 
            // btnMetaDeletar
            // 
            this.btnMetaDeletar.Location = new System.Drawing.Point(382, 151);
            this.btnMetaDeletar.Name = "btnMetaDeletar";
            this.btnMetaDeletar.Size = new System.Drawing.Size(123, 31);
            this.btnMetaDeletar.TabIndex = 21;
            this.btnMetaDeletar.Text = "Deletar Meta";
            this.btnMetaDeletar.UseVisualStyleBackColor = true;
            this.btnMetaDeletar.Click += new System.EventHandler(this.btnMetaDeletar_Click);
            // 
            // lblMetasResultado
            // 
            this.lblMetasResultado.AutoSize = true;
            this.lblMetasResultado.Location = new System.Drawing.Point(392, 67);
            this.lblMetasResultado.Name = "lblMetasResultado";
            this.lblMetasResultado.Size = new System.Drawing.Size(100, 15);
            this.lblMetasResultado.TabIndex = 22;
            this.lblMetasResultado.Text = "Meta de estudos: ";
            // 
            // progressMetas
            // 
            this.progressMetas.Location = new System.Drawing.Point(360, 89);
            this.progressMetas.Name = "progressMetas";
            this.progressMetas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressMetas.Size = new System.Drawing.Size(156, 23);
            this.progressMetas.TabIndex = 23;
            this.progressMetas.Tag = "";
            this.progressMetas.Value = 30;
            // 
            // classColumn
            // 
            this.classColumn.DataPropertyName = "Materia";
            this.classColumn.HeaderText = "Matérias de  Estudo";
            this.classColumn.Name = "classColumn";
            this.classColumn.ReadOnly = true;
            // 
            // hours
            // 
            this.hours.DataPropertyName = "Horas";
            this.hours.HeaderText = "Horas planejadas p/ Estudo";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            // 
            // checkHours
            // 
            this.checkHours.DataPropertyName = "Concluida";
            this.checkHours.HeaderText = "Estudo Concluído";
            this.checkHours.Name = "checkHours";
            // 
            // formPainelMetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 267);
            this.Controls.Add(this.dataSource);
            this.Controls.Add(this.progressMetas);
            this.Controls.Add(this.lblMetasResultado);
            this.Controls.Add(this.btnMetaDeletar);
            this.Name = "formPainelMetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel de meta de estudos";
            this.Load += new System.EventHandler(this.formPainelMetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataSource;
        private Button btnMetaDeletar;
        private Label lblMetasResultado;
        private ProgressBar progressMetas;
        private DataGridViewTextBoxColumn classColumn;
        private DataGridViewTextBoxColumn hours;
        private DataGridViewCheckBoxColumn checkHours;
    }
}