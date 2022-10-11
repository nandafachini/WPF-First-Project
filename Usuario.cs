using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject
{
    public class Usuario
    {
        private string name;

        private string endereco;

        private string cpf;
        public Usuario()
        {

        }

        public Usuario(string name, string endereco, string cpf)
        {
            this.name = name;
            this.endereco = endereco;
            this.cpf = cpf;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}

