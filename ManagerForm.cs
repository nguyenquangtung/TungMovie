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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
            new ManagerCustomerAccount().Show();
        }

		private void button8_Click(object sender, EventArgs e)
		{
            //thiếu form add character
		}

		private void button10_Click(object sender, EventArgs e)
		{
            new TicketManagement().Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
            new ListMV().Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
            new SeatManagement().Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
            new Chat().Show();
		}
	}
}
