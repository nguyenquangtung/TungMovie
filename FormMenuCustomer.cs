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
	public partial class FormMenuCustomer : Form
	{
		public FormMenuCustomer()
		{
			InitializeComponent();
		}

		private void labelRegister_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			// form show schedule
		}

		private void button8_Click(object sender, EventArgs e)
		{
			new ListCharater().Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			//show vé khách đã mua
		}

		private void button5_Click(object sender, EventArgs e)
		{
			new ListMV().Show(); // show list rồi chọn phim, chọn xong form schedule sẽ xuất hiện, chọn schedule sau đó thanh toán
		}

		private void button9_Click(object sender, EventArgs e)
		{
			new ListMV().Show(); // xem các danh sách phim đang chiếu
		}
	}
}
