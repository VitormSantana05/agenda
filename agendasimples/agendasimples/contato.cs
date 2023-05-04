using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendasimples
{
    internal class contato
    {

        private string primeiroNome;
        private string SobreNome;
        private string telefone;

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }

            set
            {
                primeiroNome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return SobreNome;
            }

            set
            {
                SobreNome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000";
                }
                
            }
        }
        public contato()
        {
            PrimeiroNome = "João";
            SobreNome = "Da Silvas";
            Telefone = " 11-98765-0990";

        }
        public contato(string primeiroNome, string sobreNome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Telefone = telefone;
        }
        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, SobreNome);
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0, 1), Telefone.Substring(2, 6), Telefone.Substring(7, 10));
        }

    }

}
