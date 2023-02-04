namespace easyStudyProjeto
{
    partial class formCadastroUsuario
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
            this.btnUsuarioCadastrar = new System.Windows.Forms.Button();
            this.txtUsuarioSobrenome = new System.Windows.Forms.TextBox();
            this.txtUsuarioNome = new System.Windows.Forms.TextBox();
            this.txtUsuarioEmail = new System.Windows.Forms.TextBox();
            this.txtUsuarioSenha = new System.Windows.Forms.TextBox();
            this.lblUsuarioNome = new System.Windows.Forms.Label();
            this.lblUsuarioSobrenome = new System.Windows.Forms.Label();
            this.lblUsuarioEmail = new System.Windows.Forms.Label();
            this.lblUsuarioSenha = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsuarioCadastrar
            // 
            this.btnUsuarioCadastrar.Location = new System.Drawing.Point(229, 227);
            this.btnUsuarioCadastrar.Name = "btnUsuarioCadastrar";
            this.btnUsuarioCadastrar.Size = new System.Drawing.Size(156, 37);
            this.btnUsuarioCadastrar.TabIndex = 0;
            this.btnUsuarioCadastrar.Text = "Cadastrar ";
            this.btnUsuarioCadastrar.UseVisualStyleBackColor = true;
            this.btnUsuarioCadastrar.Click += new System.EventHandler(this.btnUsuarioCadastrar_Click);
            // 
            // txtUsuarioSobrenome
            // 
            this.txtUsuarioSobrenome.Location = new System.Drawing.Point(242, 89);
            this.txtUsuarioSobrenome.Name = "txtUsuarioSobrenome";
            this.txtUsuarioSobrenome.Size = new System.Drawing.Size(173, 23);
            this.txtUsuarioSobrenome.TabIndex = 1;
            // 
            // txtUsuarioNome
            // 
            this.txtUsuarioNome.Location = new System.Drawing.Point(214, 48);
            this.txtUsuarioNome.Name = "txtUsuarioNome";
            this.txtUsuarioNome.Size = new System.Drawing.Size(201, 23);
            this.txtUsuarioNome.TabIndex = 2;
            // 
            // txtUsuarioEmail
            // 
            this.txtUsuarioEmail.Location = new System.Drawing.Point(214, 130);
            this.txtUsuarioEmail.Name = "txtUsuarioEmail";
            this.txtUsuarioEmail.Size = new System.Drawing.Size(201, 23);
            this.txtUsuarioEmail.TabIndex = 3;
            // 
            // txtUsuarioSenha
            // 
            this.txtUsuarioSenha.Location = new System.Drawing.Point(214, 170);
            this.txtUsuarioSenha.Name = "txtUsuarioSenha";
            this.txtUsuarioSenha.Size = new System.Drawing.Size(201, 23);
            this.txtUsuarioSenha.TabIndex = 4;
            // 
            // lblUsuarioNome
            // 
            this.lblUsuarioNome.AutoSize = true;
            this.lblUsuarioNome.Location = new System.Drawing.Point(160, 51);
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            this.lblUsuarioNome.Size = new System.Drawing.Size(48, 15);
            this.lblUsuarioNome.TabIndex = 5;
            this.lblUsuarioNome.Text = "*Nome:";
            // 
            // lblUsuarioSobrenome
            // 
            this.lblUsuarioSobrenome.AutoSize = true;
            this.lblUsuarioSobrenome.Location = new System.Drawing.Point(160, 92);
            this.lblUsuarioSobrenome.Name = "lblUsuarioSobrenome";
            this.lblUsuarioSobrenome.Size = new System.Drawing.Size(76, 15);
            this.lblUsuarioSobrenome.TabIndex = 6;
            this.lblUsuarioSobrenome.Text = "*Sobrenome:";
            // 
            // lblUsuarioEmail
            // 
            this.lblUsuarioEmail.AutoSize = true;
            this.lblUsuarioEmail.Location = new System.Drawing.Point(160, 133);
            this.lblUsuarioEmail.Name = "lblUsuarioEmail";
            this.lblUsuarioEmail.Size = new System.Drawing.Size(44, 15);
            this.lblUsuarioEmail.TabIndex = 7;
            this.lblUsuarioEmail.Text = "*Email:";
            // 
            // lblUsuarioSenha
            // 
            this.lblUsuarioSenha.AutoSize = true;
            this.lblUsuarioSenha.Location = new System.Drawing.Point(160, 173);
            this.lblUsuarioSenha.Name = "lblUsuarioSenha";
            this.lblUsuarioSenha.Size = new System.Drawing.Size(47, 15);
            this.lblUsuarioSenha.TabIndex = 8;
            this.lblUsuarioSenha.Text = "*Senha:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(447, 312);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(124, 15);
            this.lblAviso.TabIndex = 9;
            this.lblAviso.Text = "* campos obrigatórios";
            // 
            // formCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 336);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lblUsuarioSenha);
            this.Controls.Add(this.lblUsuarioEmail);
            this.Controls.Add(this.lblUsuarioSobrenome);
            this.Controls.Add(this.lblUsuarioNome);
            this.Controls.Add(this.txtUsuarioSenha);
            this.Controls.Add(this.txtUsuarioEmail);
            this.Controls.Add(this.txtUsuarioNome);
            this.Controls.Add(this.txtUsuarioSobrenome);
            this.Controls.Add(this.btnUsuarioCadastrar);
            this.Name = "formCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.formCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUsuarioCadastrar;
        private TextBox txtUsuarioSobrenome;
        private TextBox txtUsuarioNome;
        private TextBox txtUsuarioEmail;
        private TextBox txtUsuarioSenha;
        private Label lblUsuarioNome;
        private Label lblUsuarioSobrenome;
        private Label lblUsuarioEmail;
        private Label lblUsuarioSenha;
        private Label lblAviso;
    }
}