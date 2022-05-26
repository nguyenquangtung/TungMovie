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


		private void button4_Click(object sender, EventArgs e)
		{
            new ManagerCustomerAccount().Show();
            this.Hide();
        }

		private void button1_Click(object sender, EventArgs e)
		{
            new EmployeeManagermentAccount().Show();
            this.Hide();
        }
	}
}
