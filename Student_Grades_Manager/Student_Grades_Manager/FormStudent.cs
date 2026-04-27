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

        private void btnAdauga_Click(object sender, EventArgs e)
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

            if (valid)
            {
                Student studentNou = new Student(tbNume.Text, tbPrenume.Text, tbCNP.Text,
                    comboBoxAn.Text, Grupa);
                studenti.Add(studentNou);
                var item = new ListViewItem(tbNume.Text);
                item.SubItems.Add(tbPrenume.Text);
                item.SubItems.Add(tbCNP.Text);
                item.SubItems.Add(comboBoxAn.Text);
                item.SubItems.Add(tbGrupa.Text);
                listView1.Items.Add(item);
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
                listView1.SelectedItems[0].Remove();
        }
    }
}
