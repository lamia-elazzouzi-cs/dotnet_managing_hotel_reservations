using MySql.Data.MySqlClient;
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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }

        private void btn_acceuil_Click(object sender, EventArgs e)
        {
            Acceuil a = new Acceuil();
            Close();
            a.Show();
        }

        private void btn_actualiser_Click(object sender, EventArgs e)
        {

            tboxidchambre.Clear();
            tboxiduser.Clear();
            tboxduree.Clear();
            //----------------------------------------------------------Utilissateurs
            listViewUtilisateur.Items.Clear();
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";

            string query = "SELECT * FROM utilisateurs";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Success, now list 

                // If there are available rows
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        string[] row = {
                            reader.GetString(0), reader.GetString(1), reader.GetString(2),
                            reader.GetString(3),reader.GetString(4)};

                        var listViewItem = new ListViewItem(row);
                        listViewUtilisateur.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //----------------------------------------------------------chambres
            listViewChambre.Items.Clear();

            connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";

            query = "SELECT * FROM chambres";
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader1;
            try
            {
                databaseConnection.Open();
                reader1 = commandDatabase.ExecuteReader();
                // Success, now list 

                // If there are available rows
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {

                        string[] row = {
                            reader1.GetString(0), reader1.GetString(1), reader1.GetString(2),
                            reader1.GetString(3),reader1.GetString(4)};

                        var listViewItem = new ListViewItem(row);
                        listViewChambre.Items.Add(listViewItem);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_ajoutter_Click(object sender, EventArgs e)
        {
            int iduser = int.Parse(tboxiduser.Text);
            int idchambre = int.Parse(tboxidchambre.Text);
            string duree = tboxduree.Text;


            DateTime mydate = dateTimePicker1.Value;
            string mydatesql = mydate.Date.ToString("yyyy-MM-dd");

            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            //id_r	id_u	id_c	duree_r	date_r
            string query = "insert into reservations (`id_r`,`id_u`,`id_c`,`duree_r`,`date_r`) values (NULL,\""+iduser+"\", \""+idchambre+"\",\""+duree+"\",\""+mydate+"\")";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }


            tboxduree.Clear();
            tboxidchambre.Clear();
            tboxiduser.Clear();
            btn_actualiser_Click(sender, e);
        }

        private void listViewChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewChambre.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewChambre.SelectedItems[0];

                //fill the text boxes:
                tboxidchambre.Text= int.Parse(item.Text).ToString();
            }
        }

        private void listViewUtilisateur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUtilisateur.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewUtilisateur.SelectedItems[0];

                //fill the text boxes:
                tboxiduser.Text = int.Parse(item.Text).ToString();
            }
        }
    }
}
