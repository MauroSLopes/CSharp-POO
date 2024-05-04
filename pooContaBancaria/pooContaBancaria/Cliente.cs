using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class Cliente
    {

        public Cliente()
        {
            this.ID = 0;
            this.Nome = "";
            this.CPF = "";
        }

        public int ID { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
    }
}
