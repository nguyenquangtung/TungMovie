using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class ManagerCustomerAccount : Form
    {
		private AdminManagement adminManagement;

		public ManagerCustomerAccount()
        {
            InitializeComponent();
        }

		public ManagerCustomerAccount(AdminManagement adminManagement)
		{
			this.adminManagement = adminManagement;
		}
	}
}
