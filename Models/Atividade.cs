using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Atividade
    {
        public int Id { get; set; }
        public int rm { get; set; }
        public string nome { get; set; }
        public string urlGitHub { get; set; }
        public int numAtividade { get; set; }
    }
}
