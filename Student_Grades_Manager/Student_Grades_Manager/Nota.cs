using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager
{
    internal class Nota
    {
        public Student Student {  get; set; }
        public Disciplina Disciplina { get; set; }
        public int Valoare { get; set; }
        public DateTime Data { get; set; }

        public Nota(Student student, Disciplina disciplina, int valoare, DateTime data)
        {
            Student = student;
            Disciplina = disciplina;
            Valoare = valoare;
            Data = data;
        }

        public override string ToString()
        {
            return $"Student: {Student}, Disciplina: {Disciplina}," +
                $" Nota: {Valoare}, Data: {Data}";
        }
    }
}
