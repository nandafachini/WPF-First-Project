using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProject
{
    public class Acai
    {
        private string tamanho;

        private string fruta;

        private string complemento;

        public Acai()
        {

        }

        public Acai(string tamanho, string fruta, string complemento)
        {
            this.tamanho = tamanho;
            this.fruta = fruta;
            this.complemento = complemento;
        }

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public string Fruta
        {
            get { return fruta; }
            set { fruta = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
    }
}
