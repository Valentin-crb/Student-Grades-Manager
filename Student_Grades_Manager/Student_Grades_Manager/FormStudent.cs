using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grades_Manager
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string Nume = txtNume.Text;
            string Prenume = txtPrenume.Text;
            string CNP = txtCNP.Text;
            if (!int.TryParse(txtAn.Text, out int An))
            {
                MessageBox.Show("Anul trebuie să fie un număr!");
                return;
            }
            if (!int.TryParse(txtGrupa.Text, out int Grupa))
            {
                MessageBox.Show("Grupa trebuie să fie un număr!");
                return;
            }
            Student s = new Student(Nume, Prenume, CNP, An, Grupa);
            
            lstStudenti.Items.Add(s);
        }
    }
}
