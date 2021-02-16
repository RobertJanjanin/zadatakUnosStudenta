using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatakk
{
    public partial class UnosNovogStudenta : Form
    {
        List<Student> Lista = new List<Student>();
        public UnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void ComboBoxSmjer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSnimi_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxIme.Text, textBoxPrezime.Text, comboBoxSmjer.Text, Convert.ToInt32(textBoxBrojIndeksa.Text), Convert.ToDateTime(dateTimePickerDatumRodjenja.Text));

            Lista.Add(student);

            this.Close();

            
        }
    }
}
