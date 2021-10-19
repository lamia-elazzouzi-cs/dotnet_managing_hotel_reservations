using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class Acceuil : Form
    {

        // forms déclarations:
        Utilisateurs fu = new Utilisateurs();
        Chambres fc = new Chambres();
        Reservations fr = new Reservations();




        public Acceuil()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            fu.Show();
            fr.Hide();
            fc.Hide();
        }

        private void btn_chambres_Click(object sender, EventArgs e)
        {
            Hide();
            fc.Show();
            fr.Hide();
            fu.Hide();
        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            Hide();
            fr.Show();
            fu.Hide();
            fc.Hide();
        }
    }
}
