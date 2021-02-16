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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
      

        }

        private void ButtonDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta Unos = new UnosNovogStudenta();
            Unos.Show();
        }
    }
}
