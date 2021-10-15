using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAtletiMVC.Models
{
    public class Discipline
    {
        private List<Disciplina> discipline;

        public Discipline()
        {
            discipline = new List<Disciplina>();
            discipline.Add(new Disciplina(3, "Nuoto"));
            discipline.Add(new Disciplina(4, "Basket"));
            discipline.Add(new Disciplina(1, "Atletica"));
        }

        public List<Disciplina> getAll()
        {
            return discipline;
        }

        public Disciplina getOne(int codice)
        {
            return discipline.First(a => a.Codice == codice);
        }

        public void Add(Disciplina d)
        {
            //calcolo il codice da utilizzare = max codice già usato + 1
            /*int massimo = 0;
            foreach( Disciplina disciplina in discipline)
            {
                if (disciplina.Codice > massimo) massimo = disciplina.Codice;
            }*/


            /*int massimo = discipline.Max(aaa);
            massimo = discipline.Max(delegate (Disciplina d) { return d.Codice; });
            massimo = discipline.Max(d => { return d.Codice; });
            
            massimo = discipline.Max(d => d.Codice);*/
            
            
            d.Codice = discipline.Max(d => d.Codice) + 1;
            discipline.Add(d);
        }

        /*public int aaa(Disciplina d)
        {
            return d.Codice;
        }*/

        public void Delete(Disciplina disciplinaDaCancellare)
        {
            //1 - Cerco nella lista di discipline l'elemento con codice disciplinaDaCancellare.Codice
            //2 - Elimino l'elemento trovato
            discipline.Remove(discipline.First(d => d.Codice == disciplinaDaCancellare.Codice));
        }

        public void Update(Disciplina disciplinaAggiornata)
        {
            //1 - Cerco nella lista di discipline l'elemento con codice disciplinaDaCancellare.Codice
            Disciplina daAggiornare = discipline.First(d => d.Codice == disciplinaAggiornata.Codice);
            //2 - Aggiorno i campi (NO CODICE)
            daAggiornare.Nome = disciplinaAggiornata.Nome;
        }   
    }
}
