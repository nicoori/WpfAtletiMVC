using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAtletiMVC.Models
{
    public class Atleti
    {
        private List<Atleta> atleti;
        private List<Disciplina> discipline;

        public Atleti()
        {
            Discipline model = new Discipline();
            discipline = model.getAll();


            atleti = new List<Atleta>();
            atleti.Add(new Atleta(1,"Pellegrini", "Federica", "PLLFDR80..", new DateTime(1980, 08, 05), discipline.First(d => d.Codice == 3)));
            atleti.Add(new Atleta(2, "J", "M", "", new DateTime(1963, 02, 17), discipline.First(d => d.Codice == 4)));
        }

        public List<Atleta> getAll()
        {
            return atleti;
        }

        public Atleta getOne(int codice)
        {
            return atleti.First(a => a.Codice == codice);
        }

        public void Add(Atleta a)
        {
            a.Codice = atleti.Max(a => a.Codice) + 1;
            atleti.Add(a);
        }
    }
}
