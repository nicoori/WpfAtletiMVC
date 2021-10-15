using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAtletiMVC.Models
{
    public class Disciplina
    {
        private int _codice;
        private string _nome;

        public int Codice
        {
            get
            {
                return _codice;
            }
            set 
            {
                _codice = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public Disciplina(int Codice, string Nome)
        {
            this.Codice = Codice;
            this.Nome = Nome;
        }
    }
}
