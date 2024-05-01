using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntasRespostas
{
    public class Perguntas
    {
        public Perguntas(string texto = "", string resposta = "") 
        {
           this.Texto = texto;
           this.Resposta = resposta.ToLower();
        }
 		public string Texto { get; set; }

        public string Resposta { get; set; }

    }
}
