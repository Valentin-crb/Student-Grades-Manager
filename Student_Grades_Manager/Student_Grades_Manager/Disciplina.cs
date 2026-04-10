using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager
{
    internal class Disciplina
    {
        public int Cod {  get; set; }
        public string Denumire { get; set; }
        public int NrCredite { get; set; }

        public Disciplina(int cod, string denumire, int nrCredite)
        {
            Cod = cod;
            Denumire = denumire;
            NrCredite = nrCredite;
        }
        public override string ToString()
        {
            return $"Cod: {Cod}, Denumire: {Denumire}" +
                $", NrCredite: {NrCredite}";
        }
    }
}
