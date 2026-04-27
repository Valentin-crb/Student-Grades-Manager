using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager
{
    internal class Student
    {
        public string Nume {  get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string An {  get; set; }
        public int Grupa { get; set; }

        public Student(string nume, string prenume, string cnp, string an, int grupa)
        {
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            An = an;
            Grupa = grupa;
        }

        public override string ToString()
        {
            return $"Nume: {Nume}, Prenume: {Prenume}" +
                $", CNP: {CNP}, An: {An}, Grupa: {Grupa}";
        }
    }
}
