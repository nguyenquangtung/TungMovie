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
	public partial class Moviedetail : Form
	{
		public Moviedetail()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textBox1.Text.ToString());
			SqlConnection conn = new SqlConnection(@"Data Source=PC;Initial Catalog=Movie_ticket_management;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //chuỗi kết nối
			SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[fu_See_movie_detail] ("+id+") ", conn);
			//cmd.Parameters.AddWithValue("(@movieId", name);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			DataTable x = dt;
			dataGridView1.DataSource = x;
		}
	}
}
