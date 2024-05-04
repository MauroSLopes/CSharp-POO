using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooContaBancaria
{
    public class ContaBancaria
    {
        public Cliente Correntista { get; set; }

        public ContaBancaria() 
        {
            this.saldo = 0;
            this.Correntista = new Cliente();
        }

        protected Double saldo;

        public Double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(Double valor)
        {
            this.saldo += valor;
            Console.WriteLine("Saldo atual: " + this.Saldo);
        }

        public virtual Double Retirar(Double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
            }
            else
            {
                throw new Exception("Saldo Insuficiente");
            }

            return this.saldo;
        }

        public virtual void ExibirDadosBancarios()
        {
            Console.WriteLine("Dados do Cliente");
            Console.WriteLine("Nome: " + this.Correntista.Nome);
            Console.WriteLine("Saldo: " + this.Saldo);
        }


    }
}
