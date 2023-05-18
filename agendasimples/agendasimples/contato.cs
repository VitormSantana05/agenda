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
        private string email;

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
            public string Email
        {
            get { return email; }
            set { if(value.Contains("@"))
                {
                    email = value;
                }
            else
                {
                    email = "email@email.com";
                
             }
            }
        }
        
        public contato()
        {
            PrimeiroNome = "João";
            SobreNome = "Da Silvas";
            Telefone = " 11-98765-0990";
            Email= "email@email.com";

        }
        public contato(string primeiroNome, string sobreNome, string telefone, string email)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
            Telefone = telefone;
            Email = email;
        }
        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, SobreNome);
            saida += String.Format("{0}-{1}-{2}", Telefone.Substring(0, 1), Telefone.Substring(2, 6), Telefone.Substring(7, 10));

            return saida;
        }
        
    }

}
