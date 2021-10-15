using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAtletiMVC.Models
{
    public class Atleta
    {
        private int _codice;
        private string _cognome;
        private string _nome;
        private string _cf;
        private DateTime _dataNascita;
        private Disciplina _disciplina;

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

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
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

        public string CF
        {
            get
            {
                return _cf;
            }
            set
            {
                _cf = value;
            }
        }

        public DateTime DataNascita
        {
            get
            {
                return _dataNascita;
            }
            set
            {
                _dataNascita = value;
            }
        }

        public Disciplina Disciplina
        {
            get
            {
                return _disciplina;
            }
            set
            {
                _disciplina = value;
            }
        }

        public Atleta(int Codice, string Cognome, string Nome, string CF, DateTime DataNascita, Disciplina Disciplina)
        {
            this.Codice = Codice;
            this.Cognome = Cognome;
            this.Nome = Nome;
            this.CF = CF;
            this.DataNascita = DataNascita;
            this.Disciplina = Disciplina;
        }
    }
}
