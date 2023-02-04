namespace easyStudyProjeto
{
    partial class formLoginUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUsuarioLogin = new System.Windows.Forms.Button();
            this.btnUsuarioCadastrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuarioSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarioLogin
            // 
            this.btnUsuarioLogin.Location = new System.Drawing.Point(286, 224);
            this.btnUsuarioLogin.Name = "btnUsuarioLogin";
            this.btnUsuarioLogin.Size = new System.Drawing.Size(162, 43);
            this.btnUsuarioLogin.TabIndex = 0;
            this.btnUsuarioLogin.Text = "Login";
            this.btnUsuarioLogin.UseVisualStyleBackColor = true;
            this.btnUsuarioLogin.Click += new System.EventHandler(this.btnUsuarioLogin_Click);
            // 
            // btnUsuarioCadastrar
            // 
            this.btnUsuarioCadastrar.Location = new System.Drawing.Point(151, 224);
            this.btnUsuarioCadastrar.Name = "btnUsuarioCadastrar";
            this.btnUsuarioCadastrar.Size = new System.Drawing.Size(119, 43);
            this.btnUsuarioCadastrar.TabIndex = 1;
            this.btnUsuarioCadastrar.Text = "Cadastrar";
            this.btnUsuarioCadastrar.UseVisualStyleBackColor = true;
            this.btnUsuarioCadastrar.Click += new System.EventHandler(this.btnUsuarioCadastrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(179, 126);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Email";
            this.txtUsuario.Size = new System.Drawing.Size(227, 23);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtUsuarioSenha
            // 
            this.txtUsuarioSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuarioSenha.Location = new System.Drawing.Point(179, 166);
            this.txtUsuarioSenha.Name = "txtUsuarioSenha";
            this.txtUsuarioSenha.PlaceholderText = "Senha";
            this.txtUsuarioSenha.Size = new System.Drawing.Size(227, 23);
            this.txtUsuarioSenha.TabIndex = 3;
            this.txtUsuarioSenha.TextChanged += new System.EventHandler(this.txtUsuarioSenha_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 59);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(232, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "EasyStudy";
            // 
            // formLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 336);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsuarioSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnUsuarioCadastrar);
            this.Controls.Add(this.btnUsuarioLogin);
            this.Name = "formLoginUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyStudy - Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUsuarioLogin;
        private Button btnUsuarioCadastrar;
        private TextBox txtUsuario;
        private TextBox txtUsuarioSenha;
        private Panel panel1;
        private Label label1;
    }
}