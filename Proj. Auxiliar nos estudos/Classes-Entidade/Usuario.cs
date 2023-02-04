using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyStudyProjeto
{
    public class Usuario
    {
        string? Nome;
        string? Sobrenome;
        private string? Email;
        private string? Senha;


         public void setNome(string Nome)
         {
            this.Nome = Nome;
         }

        public string getNome()
        {
            return Nome;
        }

        public void setSobrenome(string Sobrenome)
        {
            this.Sobrenome = Sobrenome;
        }

        public string getSobrenome()
        {
            return Sobrenome;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setSenha(string Senha)
        {
            this.Senha = Senha;
        }

        public string getSenha()
        {
            return Senha;
        }

    }
}
