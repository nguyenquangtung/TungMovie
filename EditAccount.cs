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
	public partial class EditAccount : Form
	{
		public EditAccount()
		{
			InitializeComponent();
		}
		SqlConnection connection;
		SqlCommand command;
		string str2 = @"Data Source=PC;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();
        private void btnClear_Click(object sender, EventArgs e)
		{
            table.Clear();

            dataGridView1.DataSource = table;
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtFullname.Text = "";
			txtAddress.Text = "";
			txtBalance.Text = "";
			txtEmail.Text = "";
			txtModifiedbu.Text = "";
			txtphone.Text = "";
			txtRolecode.Text = "";
			txtBirthday.Text = "";
			txtUsername.Focus();


		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			connection = new SqlConnection(str2);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "select * from [User]";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			connection = new SqlConnection(str2);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "proc_Add_account";
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddWithValue("username", txtUsername.Text);
			command.Parameters.AddWithValue("password", txtPassword.Text);
			command.Parameters.AddWithValue("fullname", txtFullname.Text);
			command.Parameters.AddWithValue("address", txtAddress.Text);
			command.Parameters.AddWithValue("phone", txtphone.Text);
			command.Parameters.AddWithValue("birthday", txtBirthday.Text);
			command.Parameters.AddWithValue("email", txtEmail.Text);
			command.Parameters.AddWithValue("balance", txtBalance.Text);
			command.Parameters.AddWithValue("rolecode", txtRolecode.Text);
			command.Parameters.AddWithValue("createdBy", "admin");
			command.ExecuteNonQuery(); ;
			command = connection.CreateCommand();
			command.CommandText = "select * from [User]";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			connection = new SqlConnection(str2);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "proc_Delete_account";
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddWithValue("username", txtUsername.Text);
			command.ExecuteNonQuery(); ;
			command = connection.CreateCommand();
			command.CommandText = "select * from [User]";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			connection = new SqlConnection(str2);
			connection.Open();
			command = connection.CreateCommand();
			command.CommandText = "proc_Edit_account ";
			command.CommandType = CommandType.StoredProcedure;
			command.Parameters.AddWithValue("username", txtUsername.Text);
			command.Parameters.AddWithValue("password", txtPassword.Text);
			command.Parameters.AddWithValue("fullname", txtFullname.Text);
			command.Parameters.AddWithValue("address", txtAddress.Text);
			command.Parameters.AddWithValue("phone", txtphone.Text);
			command.Parameters.AddWithValue("birthday", txtBirthday.Text);
			command.Parameters.AddWithValue("email", txtEmail.Text);
			command.Parameters.AddWithValue("balance", txtBalance.Text);
			command.Parameters.AddWithValue("rolecode", txtRolecode.Text);
			command.Parameters.AddWithValue("modifiedBy", "admin");
			command.ExecuteNonQuery(); ;
			command = connection.CreateCommand();
			command.CommandText = "select * from [User]";
			adapter.SelectCommand = command;
			table.Clear();
			adapter.Fill(table);
			dataGridView1.DataSource = table;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.CurrentCell.Selected = true;
			txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
			txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells["password"].Value.ToString();
			txtFullname.Text = dataGridView1.Rows[e.RowIndex].Cells["fullname"].Value.ToString();
			txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
			txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
			txtBirthday.Text = dataGridView1.Rows[e.RowIndex].Cells["birthday"].Value.ToString();
			txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
			txtBalance.Text = dataGridView1.Rows[e.RowIndex].Cells["balance"].Value.ToString();
			txtRolecode.Text = dataGridView1.Rows[e.RowIndex].Cells["role_code"].Value.ToString();
			txtModifiedbu.Text = dataGridView1.Rows[e.RowIndex].Cells["modified_by"].Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			//Menu menu = new Menu();
			//menu.Show();
		}
	}
}
