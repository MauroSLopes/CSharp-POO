using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooControleDeNotas
{
    interface InterfaceAluno
    {
        string Nome { get; set; }
        string Email { get; set; }

        void ExibirDados();
    }
}
