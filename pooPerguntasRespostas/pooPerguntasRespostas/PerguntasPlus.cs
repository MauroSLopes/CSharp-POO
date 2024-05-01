using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPerguntasRespostas
{
    public class PerguntasPlus:Perguntas
    {
        public PerguntasPlus(string texto = "", string resposta = "", string dica = ""):base(texto,resposta) {
            this.Dica = dica;
        }

        public String Dica { get; set; }
    }
}
