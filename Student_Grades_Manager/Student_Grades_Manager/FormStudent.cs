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
        List<Student> studenti = new List<Student>();
        public FormStudent()
        {
            InitializeComponent();
        }

        private bool valideaza()
        {
            bool valid = true;
            if (string.IsNullOrWhiteSpace(tbNume.Text))
            {
                errorProvider1.SetError(tbNume, "Numele e obligatoriu");
                valid = false;
            }
            else
                errorProvider1.SetError(tbNume, "");
            if (string.IsNullOrWhiteSpace(tbPrenume.Text))
            {
                errorProvider1.SetError(tbPrenume, "Prenumele e obligatoriu");
                valid = false;
            }
            else
                errorProvider1.SetError(tbPrenume, "");

            if (string.IsNullOrEmpty(tbCNP.Text) || tbCNP.Text.Length != 13)
            {
                errorProvider1.SetError(tbCNP, "CNP invalid");
                valid = false;
            }
            else
                errorProvider1.SetError(tbCNP, "");

            if (string.IsNullOrEmpty(comboBoxAn.Text))
            {
                errorProvider1.SetError(comboBoxAn, "Selectati un an!");
                valid = false;
            }
            else
                errorProvider1.SetError(comboBoxAn, "");


            if (!int.TryParse(tbGrupa.Text, out int Grupa))
            {
                errorProvider1.SetError(tbGrupa, "Grupa trebuie sa fie un numar");
                valid = false;
            }
            else
                errorProvider1.SetError(tbGrupa, "");

            return valid;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            
            if (valideaza())
            {
                Student studentNou = new Student(tbNume.Text, tbPrenume.Text, tbCNP.Text,
                    comboBoxAn.Text, int.Parse(tbGrupa.Text));
                studenti.Add(studentNou);
                var item = new ListViewItem(tbNume.Text);
                item.SubItems.Add(tbPrenume.Text);
                item.SubItems.Add(tbCNP.Text);
                item.SubItems.Add(comboBoxAn.Text);
                item.SubItems.Add(tbGrupa.Text);
                item.Tag = studentNou;
                listView1.Items.Add(item);

                // golire campuri
                tbNume.Text = "";
                tbPrenume.Text = "";
                tbCNP.Text = "";
                comboBoxAn.Text = "";
                tbGrupa.Text = "";
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                studenti.RemoveAt(listView1.SelectedIndices[0]);
                listView1.SelectedItems[0].Remove();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selectati un student din lista");
                return;
            }

            if (!valideaza()) return;

            int index = listView1.SelectedIndices[0];
            studenti[index].Nume = tbNume.Text;
            studenti[index].Prenume = tbPrenume.Text;
            studenti[index].CNP = tbCNP.Text;
            studenti[index].An = comboBoxAn.Text;
            studenti[index].Grupa = int.Parse(tbGrupa.Text);

            listView1.Items[index].Text = tbNume.Text;
            listView1.Items[index].SubItems[1].Text = tbPrenume.Text;
            listView1.Items[index].SubItems[2].Text = tbCNP.Text;
            listView1.Items[index].SubItems[3].Text = comboBoxAn.Text;
            listView1.Items[index].SubItems[4].Text = tbGrupa.Text;

            listView1.Items[index].Tag = studenti[index];
            tbNume.Text = "";
            tbPrenume.Text = "";
            tbCNP.Text = "";
            comboBoxAn.Text = "";
            tbGrupa.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                Student studentLocal = lvi.Tag as Student;
                tbNume.Text = studentLocal.Nume;
                tbPrenume.Text = studentLocal.Prenume;
                tbCNP.Text = studentLocal.CNP;
                comboBoxAn.Text = studentLocal.An;
                tbGrupa.Text = studentLocal.Grupa.ToString();
            }
            else
            {
                tbNume.Text = "";
                tbPrenume.Text = "";
                tbCNP.Text = "";
                comboBoxAn.Text = "";
                tbGrupa.Text = "";
            }
        }
    }
}
