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
	public partial class ListMV : Form
	{
		MovieInfo mi = new MovieInfo();
		public ListMV()
		{
			InitializeComponent();
		}
		public void ListMV_grid_Load()
		{
			gridListMV.RowTemplate.Height = 45;
			gridListMV.DataSource = mi.getmovielist();
			gridListMV.Columns[0].Width = 70;
			gridListMV.Columns[1].Width = 80;
			gridListMV.Columns[2].Width = 60;
			gridListMV.Columns[3].Width = 60;
			gridListMV.Columns[4].Width = 60;
			gridListMV.Columns[5].Width = 80;
			gridListMV.AllowUserToResizeColumns = false;
		}
		private void ListMV_Load(object sender, EventArgs e)
		{
			ListMV_grid_Load();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "find by id")
			{
				int id = Convert.ToInt32(txtSearch.Text.ToString());
				SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
				SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE movieid LIKE '%" + id + "%' ", conn);
				cmd.Parameters.AddWithValue("@movieid", id);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataTable x = dt;
				gridListMV.DataSource = x;
			}
			else if (comboBox1.Text == "find by name")
			{
				string name = txtSearch.Text.ToString();
				SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
				SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE name LIKE '%" + name + "%' ", conn);
				cmd.Parameters.AddWithValue("@name", name);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				DataTable x = dt;
				gridListMV.DataSource = x;
			}
		}

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
		if (comboBox1.Text == "find by id")
		{
			if(txtSearch.Text == string.Empty)
                	{
				ListMV_grid_Load();
				return;
                	}
			int id = Convert.ToInt32(txtSearch.Text.ToString());
			SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
			SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE movieid LIKE '%" + id + "%' ", conn);
			cmd.Parameters.AddWithValue("@movieid", id);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			DataTable x = dt;
			gridListMV.DataSource = x;
		}
		else if (comboBox1.Text == "find by name")
		{
			string name = txtSearch.Text.ToString();
			SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
			SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE name LIKE '%" + name + "%' ", conn);
			cmd.Parameters.AddWithValue("@name", name);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			DataTable x = dt;
			gridListMV.DataSource = x;
		}
        }
	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			txtSearch.Enabled = true;
	}
    }
}
