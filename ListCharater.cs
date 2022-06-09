using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TungMovie
{
    public partial class ListCharater : Form
    {
        CharacterInfo ch = new CharacterInfo();
        SqlConnection connection;
        //SqlCommand command;
        string str2 = @"Data Source=LAPTOP-47SVL2BP;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet dt;
        public ListCharater()
        {
            InitializeComponent();
        }
        public void ListCh_grid_Load()
        {
            //gridListChr.RowTemplate.Height = 45;
            //gridListChr.DataSource = ch.getcharacterlist();
            //gridListChr.Columns[0].Width = 70;
            //gridListChr.Columns[1].Width = 80;
            //gridListChr.Columns[2].Width = 60;
            //gridListChr.Columns[3].Width = 60;
            //gridListChr.AllowUserToResizeColumns = false;
        }
        private void ListCh_Load(object sender, EventArgs e)
        {
            //ListCh_grid_Load();
        }

        private void ListCharater_Load(object sender, EventArgs e)
        {
            //connection = new SqlConnection(str2);
            //connection.Open();
            if (connection == null)
            {
                connection = new SqlConnection(str2);
            }

            string query = "select * from [Character]";

            adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dt = new DataSet();
            adapter.Fill(dt, "tblCharacter");

            gridListChr.DataSource = dt.Tables["tblCharacter"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(str2);
            }
            if (comboBox1.SelectedIndex == 0)
            {

                //sqlCmd.CommandType = CommandType.Text;
                //sqlCmd.CommandText = "select * from [Character] where characterid = @id";

                //SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
                //parId.Value = Convert.ToInt32(txtSearch.Text.Trim());
                //sqlCmd.Parameters.Add(parId);

                //sqlCmd.Connection = connection;

                //SqlDataReader reader = sqlCmd.ExecuteReader();

                //SqlCommand sqlCmd = new SqlCommand();
                int id = Convert.ToInt32(txtSearch.Text.Trim());
                string query = "select * from [Character] where characterid = '" + id + "'";

                //SqlParameter parId = new SqlParameter("@id", SqlDbType.Int);
                //parId.Value = Convert.ToInt32(txtSearch.Text.Trim());
                //sqlCmd.Parameters.Add(parId);

                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dt = new DataSet();
                adapter.Fill(dt, "tblCharacter");

                gridListChr.DataSource = dt.Tables["tblCharacter"];
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                string name = txtSearch.Text.Trim();
                string query = "select * from [Character] where fullname = '" + name + "'";

                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                dt = new DataSet();
                adapter.Fill(dt, "tblCharacter");

                gridListChr.DataSource = dt.Tables["tblCharacter"];
            }
        }
        
    }
}
