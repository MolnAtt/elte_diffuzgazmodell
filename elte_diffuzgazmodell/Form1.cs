using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elte_diffuzgazmodell
{
    public partial class Form1 : Form
    {
        DiffuzGazModell dgm;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void gomb_vege_Click(object sender, EventArgs e)
        {
            dgm.szimuláció_fut = false;
        }

        private void gomb_folytonos_Click(object sender, EventArgs e)
        {
            dgm.szimuláció_fut = true;
            dgm.Teszt();
        }

        private void gomb_lepesenkent_Click(object sender, EventArgs e)
        {
            if (dgm == null)
            {
                MessageBox.Show("Előbb az új gombra kell kattintani, hogy legyen mit futtatni.");
            }
            else
            {
                dgm.Egyet_lép();
            }
        }

        private void gomb_uj_Click(object sender, EventArgs e)
        {

            vaszon.Width = (int)numericUpDown1.Value;
            vaszon.Height = (int)numericUpDown2.Value;
            Bitmap bmp = new Bitmap(vaszon.Width, vaszon.Height);
            vaszon.Image = bmp;
            int molekulaszám = (int)tb_molekulaszám.Value;
            dgm = new DiffuzGazModell(vaszon.Width, vaszon.Height, 0, molekulaszám, vaszon, bmp, checkBox1);
            dgm.Inicializál();
            dgm.Egész_kirajzolása();
        }
    }
}
