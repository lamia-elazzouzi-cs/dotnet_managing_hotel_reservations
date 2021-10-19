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
    public partial class Utilisateurs : Form
    {
        int uniID; // ID de l'operation Modifier
        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void btn_acceuil_Click(object sender, EventArgs e)
        {
            Acceuil a = new Acceuil();
            Close();
            a.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                //fill the text boxes:
                uniID = int.Parse(item.Text);
                textboxnom.Text=item.SubItems[1].Text;
                textboxadr.Text = item.SubItems[2].Text;
                textboxtype.Text = item.SubItems[3].Text;
                textboxnum.Text= item.SubItems[4].Text;

            }
        }

        private void btn_ajoutter_Click(object sender, EventArgs e)
        {
            string nom = textboxnom.Text;
            string adr = textboxadr.Text;
            string type = textboxtype.Text;
            string num = textboxnum.Text;
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            string query = "insert into utilisateurs (`id_u`,`nom_u`,`adr_u`,`type_u`,`num_u`) values (NULL,\""+nom+"\",\""+adr+"\",\""+type+"\",\""+num+"\")";
            
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


            textboxnom.Clear();
            textboxadr.Clear();
            textboxtype.Clear();
            textboxnum.Clear();
            
            btn_actualiser_Click(sender, e);
            
        }

        private void btn_actualiser_Click(object sender, EventArgs e)
        {
            textboxnom.Clear();
            textboxadr.Clear();
            textboxtype.Clear();
            textboxtype.Clear();

            listView1.Items.Clear();
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

            string nom = textboxnom.Text;
            string adr = textboxadr.Text;
            string type = textboxtype.Text;
            string num = textboxnum.Text;
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            string query = "update `utilisateurs` set nom_u=\""+nom+"\",adr_u=\""+adr+"\",type_u=\""+type+"\",num_u=\""+num+"\" where id_u="+uniID;
            
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

            textboxnom.Clear();
            textboxadr.Clear();
            textboxtype.Clear();
            textboxnum.Clear();
            btn_actualiser_Click(sender, e); 
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=gestion_hotel_exam;Uid=root;Pwd=;";
            string query = "delete from `utilisateurs` where id_u=" + uniID;


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

            textboxnom.Clear();
            textboxadr.Clear();
            textboxtype.Clear();
            textboxnum.Clear();
            btn_actualiser_Click(sender, e);
        }
    }
}
