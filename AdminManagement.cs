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
    public partial class AdminManagement : Form
    {

        public AdminManagement()
        {
            InitializeComponent();
        }

		private void btnCustomerManagerment_Click(object sender, EventArgs e)
		{
            new UserManagement().Show();
		}

		private void btnManager_Click(object sender, EventArgs e)
		{

		}

		private void btnScheduleManagerment_Click(object sender, EventArgs e)
		{
			new ScheduleManagement().Show();
		}

		private void btnRoomManagerment_Click(object sender, EventArgs e)
		{
			new RoomManagement().Show();
		}

		private void btnCharacter_Click(object sender, EventArgs e)
		{
			new ListCharater().Show();
		}

		private void btnTicketManagerment_Click(object sender, EventArgs e)
		{
			new TicketManagement().Show();
		}

		private void btnMovieManagerment_Click(object sender, EventArgs e)
		{
			new Film_management().Show();
		}

		private void btnSeatManagerment_Click(object sender, EventArgs e)
		{
			new SeatManagement().Show();
		}

		private void btnStatitics_Click(object sender, EventArgs e)
		{
			new StatiticsForm().Show();
		}

		private void btnFilming_Click(object sender, EventArgs e)
		{
			new ListMV().Show();
		}
	}
}
