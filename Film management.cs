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
    public partial class Film_management : Form
    {
        public Film_management()
        {
            InitializeComponent();
        }
        DataTable dtMovie = null;
        MovieInfo Mi = new MovieInfo();

        public void LoadDataGrid()
        {
            dtMovie = new DataTable();
            dtMovie.Clear();

            DataSet ds = Mi.getMovieSchedule();
            dtMovie = ds.Tables[0];
            gridFilmManagement.DataSource = dtMovie;
            gridFilmManagement.AutoResizeColumns();

        }

        private void Film_management_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void gridFilmManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gridFilmManagement.CurrentCell.RowIndex;

            boxFilmId.Text = gridFilmManagement.Rows[i].Cells["ID"].Value.ToString();
            textFilmName.Text = gridFilmManagement.Rows[i].Cells["Movie"].Value.ToString(); 
            textRating.Text = gridFilmManagement.Rows[i].Cells["Rating"].Value.ToString();
            txtGenre.Text = gridFilmManagement.Rows[i].Cells["Genre"].Value.ToString();
            txtDescription.Text = gridFilmManagement.Rows[i].Cells["Desciption"].Value.ToString();
            txtDuration.Text = gridFilmManagement.Rows[i].Cells["Duration"].Value.ToString();
            dateStartTime.Value = DateTime.ParseExact(gridFilmManagement.Rows[i].Cells["Start_date"].Value.ToString(), "M/dd/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);      
            dateEndTime.Value = DateTime.ParseExact(gridFilmManagement.Rows[i].Cells["End_Date"].Value.ToString(), "M/dd/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            Movie.addMovie(textFilmName.Text, textRating.Text, txtGenre.Text, txtDescription.Text, txtDuration.Text);
            LoadDataGrid();
            MessageBox.Show("add success");
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            Movie.updateMovie(textFilmName.Text, textRating.Text, txtGenre.Text, txtDescription.Text, txtDuration.Text, boxFilmId.Text);
            LoadDataGrid();
            MessageBox.Show("add success");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MovieInfo Movie = new MovieInfo();
            Movie.DeleteMovie(boxFilmId.Text);
            LoadDataGrid();
            MessageBox.Show("delete success ");

        }

        private void btn_Schedule_Click(object sender, EventArgs e)
        {
            new ScheduleManagement().Show();
            this.Close();
        }
    }
}
