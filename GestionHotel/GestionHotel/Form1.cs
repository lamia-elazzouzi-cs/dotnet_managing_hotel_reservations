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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textboxnom.Text;
            string mdp = textboxmdp.Text;
            if (login == "ok" && mdp == "ok")
            {
                Acceuil f = new Acceuil();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login et/ou MDP érronés !");
                textboxnom.Clear();
                textboxmdp.Clear();
            }
        }
    }
}
