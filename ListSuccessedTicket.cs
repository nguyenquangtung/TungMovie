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
	public partial class ListSuccessedTicket : Form
	{
		public ListSuccessedTicket()
		{
			InitializeComponent();
		}
		SqlConnection connection;
		SqlCommand command;
		string str2 = @"Data Source=PC;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
		private void ListSuccessedTicket_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Menu menu = new Menu();
			//menu.Show();
		}


		private void btnClear_Click(object sender, EventArgs e)
		{
			table.Clear();

			dataGridView1.DataSource = table;
			txtId.Text = "";
			txtPrice.Text = "";
			txtBookingdate.Text = "";
			txtCreatedate.Text = "";
			txtScheduleid.Text = "";
			txtSeat.Text = "";
			txtStatitics.Text = "";
			txtId.Focus();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.CurrentCell.Selected = true;
			txtBookingdate.Text = dataGridView1.Rows[e.RowIndex].Cells["booking_date"].Value.ToString();
			txtCreatedate.Text = dataGridView1.Rows[e.RowIndex].Cells["created_date"].Value.ToString();
			txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["ticketid"].Value.ToString();
			txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
			txtScheduleid.Text = dataGridView1.Rows[e.RowIndex].Cells["schedule_id"].Value.ToString();
			txtSeat.Text = dataGridView1.Rows[e.RowIndex].Cells["seat_id"].Value.ToString();
			txtStatitics.Text = dataGridView1.Rows[e.RowIndex].Cells["statistics_id"].Value.ToString();
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			connection = new SqlConnection(str2);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "select * from [Ticket]";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}


		private void btnPrint_Click_1(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtId.Text.ToString());
			SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
			SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[fu_Print_ticket] (" + id + ") ", conn);

			//cmd.Parameters.AddWithValue("(@movieId", name);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			DataTable x = dt;
			dataGridView1.DataSource = x;
		}
	}
}
