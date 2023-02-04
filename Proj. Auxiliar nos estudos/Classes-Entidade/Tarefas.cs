using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyStudyProjeto
{
    public class Tarefas
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime Prazo { get; set; }
        public int GrauPrioridade { get; set; }
        public bool ReceberLembretes { get; set; }
    }
}
