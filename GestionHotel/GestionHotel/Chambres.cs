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
    public partial class Chambres : Form
    {
        // id_c--num_c--etage_c--type_c--status_c	
        int uniID; // ID de l'operation Modifier
        public Chambres()
        {
            InitializeComponent();
        }

        private void btn_acceuil_Click(object sender, EventArgs e)
        {
            Acceuil a = new Acceuil();
            Close();
            a.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ajoutter_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxnum.Text);
            int etage = int.Parse(tboxetage.Text);
            string type=tboxtype.Text; 
            string status=tboxstatus.Text;
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";

            string query = "insert into chambres (`id_c`,`num_c`,`etage_c`,`type_c`,`status_c`) values (NULL,\""+num+"\",\""+etage+"\",\""+type+"\",\""+status+"\")";

            
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
            tboxnum.Clear();
            tboxetage.Clear();
            tboxstatus.Clear();
            tboxtype.Clear();
            btn_actualiser_Click(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                //fill the text boxes:
                uniID = int.Parse(item.Text);
                tboxnum.Text=item.SubItems[1].Text;
                tboxetage.Text = item.SubItems[2].Text;
                tboxtype.Text = item.SubItems[3].Text;
                tboxstatus.Text = item.SubItems[4].Text;

            }
        }

        private void btn_actualiser_Click(object sender, EventArgs e)
        {
            tboxnum.Clear();
            tboxetage.Clear();
            tboxstatus.Clear();
            tboxtype.Clear();

            listView1.Items.Clear();
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";

            string query = "SELECT * FROM chambres";
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
                        listView1.Items.Add(listViewItem);
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

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tboxnum.Text);
            int etage = int.Parse(tboxetage.Text);
            string type = tboxtype.Text;
            string status = tboxstatus.Text;
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            //id_c	num_c	etage_c	type_c	status_c	
            string query = "update `chambres` set num_c=\""+num+"\", etage_c=\""+etage+"\", type_c=\""+type+"\",status_c=\""+status+"\" where id_c=" +uniID;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully updated

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }

            tboxnum.Clear();
            tboxetage.Clear();
            tboxstatus.Clear();
            tboxtype.Clear();
            btn_actualiser_Click(sender, e);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            string query = "delete from `chambres` where id_c=" + uniID;


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }

            tboxnum.Clear();
            tboxetage.Clear();
            tboxstatus.Clear();
            tboxtype.Clear();
            btn_actualiser_Click(sender, e);
        }
    }
}
