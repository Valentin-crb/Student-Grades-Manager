using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Grades_Manager
{
    public partial class FormDisciplina : Form
    {

        List<Disciplina> discipline = new List<Disciplina>();

        public FormDisciplina()
        {
            InitializeComponent();
        }

        private bool valideazaD()
        {
            bool valid = true;

            if (!int.TryParse(tbCod.Text, out int Cod))
            {
                valid = false;
                errorProvider1.SetError(tbCod, "Codul trebuie sa fie un numar");
            }
            else
                errorProvider1.SetError(tbCod, "");

            if (!int.TryParse(tbNrCredite.Text, out int NrCredite))
            {
                valid = false;
                errorProvider1.SetError(tbNrCredite, "Numarul de credite trebuie sa fie un numar");
            }
            else
                errorProvider1.SetError(tbNrCredite, "");

            if (string.IsNullOrEmpty(tbDenumire.Text))
            {
                errorProvider1.SetError(tbDenumire, "Denumirea este obligatorie");
                valid = false;
            }
            else
                errorProvider1.SetError(tbDenumire, "");

            return valid;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (valideazaD())
            {
                Disciplina d = new Disciplina(int.Parse(tbCod.Text),
                    tbDenumire.Text, int.Parse(tbNrCredite.Text));
                discipline.Add(d);
                ListViewItem item = new ListViewItem(tbCod.Text);
                item.SubItems.Add(tbDenumire.Text);
                item.SubItems.Add(tbNrCredite.Text);
                item.Tag = d;
                listView1.Items.Add(item);

                tbCod.Text = "";
                tbDenumire.Text = "";
                tbNrCredite.Text = "";
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                discipline.RemoveAt(listView1.SelectedIndices[0]);
                listView1.SelectedItems[0].Remove();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selectati o disciplina din lista");
                return;
            }

            if (!valideazaD()) return;

            int index = listView1.SelectedIndices[0];
            discipline[index].Cod = int.Parse(tbCod.Text);
            discipline[index].Denumire = tbDenumire.Text;
            discipline[index].NrCredite = int.Parse(tbNrCredite.Text);

            listView1.Items[index].Text = tbCod.Text;
            listView1.Items[index].SubItems[1].Text = tbDenumire.Text;
            listView1.Items[index].SubItems[2].Text = tbNrCredite.Text;
            listView1.Items[index].Tag = discipline[index];

            tbCod.Text = "";
            tbDenumire.Text = "";
            tbNrCredite.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                Disciplina disciplinaLocala = lvi.Tag as Disciplina;
                tbCod.Text = disciplinaLocala.Cod.ToString();
                tbDenumire.Text = disciplinaLocala.Denumire;
                tbNrCredite.Text = disciplinaLocala.NrCredite.ToString();
            }
            else
            {
                tbCod.Text = "";
                tbDenumire.Text = "";
                tbNrCredite.Text = "";
            }
        }
    }
}
