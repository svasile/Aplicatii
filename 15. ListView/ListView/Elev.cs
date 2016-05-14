using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Nota { get; set; }
        public static List<Elev> CitesteElevi()
        {
            List<Elev> elevi = new List<Elev>();
            elevi.Add(new Elev()
            {
                Nume = "Nume 1",
                Prenume = "Prenume 1",
                Nota = 9
            });
            elevi.Add(new Elev()
            {
                Nume = "Nume 2",
                Prenume = "Prenume 2",
                Nota = 10
            });
            elevi.Add(new Elev()
            {
                Nume = "Nume 3",
                Prenume = "Prenume 3",
                Nota = 8
            });
            elevi.Add(new Elev()
            {
                Nume = "Nume 4",
                Prenume = "Prenume 4",
                Nota = 9
            });
            return elevi;
        }
    }
}
