using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        private String mensageText;

        public void showMessage()
        {
            Console.WriteLine(this.mensageText);
        }

        //public string getMensageText()
        //{
        //    return this.mensageText;
        //}

        //public void setMensageText(string value)
        //{
        //    this.mensageText = value.ToUpper();
        //}

        public string MensageText
        {
            get 
            { 
                return mensageText; 
            }
            set 
            { 
                this.mensageText = value.ToUpper(); 
            }
        }
    }
}
