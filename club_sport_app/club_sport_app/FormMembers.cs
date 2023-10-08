using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace club_sport_app


{

    public partial class FormMembers : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\BOUTAIBNETFRAM\club_sport_app\club_sport_app\Database1.mdf;Integrated Security = True");
        public FormMembers()
        {
            InitializeComponent();
        }

        private void FormMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adherentsDataSet.Adherents' table. You can move, or remove it, as needed.
            //this.adherentsTableAdapter.Fill(this.adherentsDataSet.Adherents);
            display_data();

        }

        private void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Adherents]";
            cmd.ExecuteNonQuery();
            connection.Close();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            metroGrid.DataSource = dta;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dta;
            metroGrid.DataSource = bindingSource;
            string recherche = textBox.Text;
            // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
            bindingSource.Filter = string.Format("Nom LIKE '%{0}%' OR Prenom LIKE '%{0}%' OR Genre LIKE '%{0}%' OR Email LIKE '%{0}%' OR Telephone LIKE '%{0}%'", recherche);
            bindingSource.ResetBindings(false);


        }


        private SelectedRow selectedRow = new SelectedRow();
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormNewMember form = new FormNewMember();

            form.Show();
        }



        private void metroGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérez la valeur de la cellule sélectionnée
                DataGridViewCell cell = metroGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = cell.Value.ToString();

                // Faites quelque chose avec la valeur de la cellule (par exemple, affichez-la dans un MessageBox)
                MessageBox.Show("La cellule sélectionnée contient la valeur : " + cellValue);
            }


        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            FormNewMember form = new FormNewMember(selectedRow);

            form.Show();
        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Adherents]";
            cmd.ExecuteNonQuery();
            connection.Close();

            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection);
            dataadp.Fill(dta);
            metroGrid.DataSource = dta;
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dta;
            metroGrid.DataSource = bindingSource;
            string recherche = textBox.Text;
            // Appliquer un filtre à la source de données en fonction de la chaîne de recherche
            bindingSource.Filter = string.Format("Nom LIKE '%{0}%' OR Prenom LIKE '%{0}%' OR Genre LIKE '%{0}%' OR Email LIKE '%{0}%' OR Telephone LIKE '%{0}%'", recherche);
            bindingSource.ResetBindings(false);
        }
    }
}