using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class ContaEstudante:ContaBancaria
    {

        public ContaEstudante() : base()
        {
            this.limite = 500.00;
        }

        private Double limite;

        public Double Limite
        {
            get { return limite; }
        }

        public override double Retirar(double valor)
        {
            if ((this.Saldo - valor) >= -this.limite)
            {
                this.saldo -= valor;
                Console.WriteLine("Saldo Atual: "+ this.Saldo);
            }
            else
            {
                throw new Exception("Limite Insuficiente");
            }
            return this.Saldo;
        }

        public override void ExibirDadosBancarios()
        {
            base.ExibirDadosBancarios();
            Console.WriteLine("Limite: " + this.Limite);
        }

    }
}
