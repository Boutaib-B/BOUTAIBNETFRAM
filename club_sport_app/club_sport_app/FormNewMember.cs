using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MetroFramework;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using MetroFramework.Controls;

namespace club_sport_app
{

    
    public partial class FormNewMember : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");

        public FormNewMember()
        {
            InitializeComponent();
        }

        
        private SelectedRow selectedRow;

        public FormNewMember(SelectedRow Row)
        {
            
            InitializeComponent();
            selectedRow = Row;

            if (selectedRow.SelectedIndex != -1)
            {

                TextboxNom.Text = selectedRow.nom;
                TextboxPrenom.Text = selectedRow.prenom;
                
                if (selectedRow.genre == "H")
                {
                    radioButtonHomme.Checked = true;
                }
                else
                {
                    radioButtonFemme.Checked = true;
                }
                
                TextboxEmail.Text = selectedRow.email;
                TextboxTel.Text = selectedRow.tel;
            }

        }

        private void FormNewMember_Load(object sender, EventArgs e)
        {

                      
        }

        

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            String genre ="";
            if (radioButtonFemme.Checked)
            {
                genre = "F";
            }
            else if (radioButtonHomme.Checked)
            {
                genre = "H";
            }
           
            

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Adherents] (Nom,Prenom,Telephone,Email,Genre) values ('" + TextboxNom.Text + "','" + TextboxPrenom.Text + "','" + TextboxTel.Text + "','" + TextboxEmail.Text + "','" + genre + "')";
            cmd.ExecuteNonQuery();
            connection.Close();

            TextboxNom.Clear();
            TextboxPrenom.Clear();
           
            TextboxEmail.Clear();
            TextboxTel.Clear();
            radioButtonHomme.Checked = true;

            MessageBox.Show("Le membre a été ajouté avec succès");

           
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMembers form = new FormMembers();
            form.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            ////int rowID = selectedRow.rowID;

            ////connection.Open();
            ////SqlCommand cmd = connection.CreateCommand();
            ////cmd.CommandType = CommandType.Text;
            ////cmd.CommandText = "update [Etudiant] set Nom = '" + TextboxNom.Text + "' , Prenom = '" + TextboxPrenom.Text + "' , CNE = '" + TextboxCNE.Text + "' , Age = '" + metroTextBoxCNE.Text + "' where Id = '" + rowID + "'";
            ////cmd.ExecuteNonQuery();

            ////connection.Close();
        }
    }
}
