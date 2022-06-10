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
		ListMovie listMovie = new ListMovie();
		DB db = new DB();
		string getmoviename;
		int getmovieid;

		public ListMV()
		{
			InitializeComponent();
		}
		public void ListMV_grid_Load()
		{
			gridListMV.RowTemplate.Height = 45;
			gridListMV.DataSource = listMovie.getmovielist();
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
				gridListMV.DataSource = listMovie.GetMovieById(id);
			}
			else if (comboBox1.Text == "find by name")
			{
				string name = txtSearch.Text.ToString();
				gridListMV.DataSource = listMovie.GetMovieByName(name);
			}
        	}

        private void gridListMV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && gridListMV.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                int movieid = Convert.ToInt32(gridListMV.Rows[e.RowIndex].Cells[0].Value.ToString());
				DataTable dt = listMovie.getMovieIdAndNameById(movieid);
				getmovieid = Convert.ToInt32(dt.Rows[0][0].ToString());
				getmoviename = dt.Rows[0][1].ToString();
			}
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
			if(getmoviename != null)
            {
				new BuyTicket(getmovieid,getmoviename).Show();
            }
			else
            {
				MessageBox.Show("Please select a movie name", "List Movie", MessageBoxButtons.OK);
			}
        }
    }
}
