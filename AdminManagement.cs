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

        private void customer_btn_Click(object sender, EventArgs e)
        {
            new FormMenuCustomer().Show();
        }

        private void manager_btn_Click(object sender, EventArgs e)
        {
            new EmployeeManagermentAccount().Show();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            new RoomManagement().Show();
        }

        private void movie_btn_Click(object sender, EventArgs e)
        {
            new Film_management().Show();
        }

        private void ticket_btn_Click(object sender, EventArgs e)
        {
            new TicketManagement().Show();
        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            new ScheduleManagement().Show();
        }

        private void statistics_btn_Click(object sender, EventArgs e)
        {
            new StatiticsForm().Show();
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
