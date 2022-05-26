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
	public partial class ListMovie2 : Form
	{
		public ListMovie2()
		{
			InitializeComponent();
		}

		private void ListMovie_Load(object sender, EventArgs e)
		{
			populateItems();
		}
		private void populateItems()
		{
			PanelListMovie[] listMovies = new PanelListMovie[20];
			for(int i = 0; i< listMovies.Length;i++)
			{
				listMovies[i] = new PanelListMovie();
				listMovies[i].Title = "sdf";
			/*	if (flowLayoutPanel1.Controls.Count > 0)
				{
					flowLayoutPanel1.Controls.Clear();
				}
				else
				{
					flowLayoutPanel1.Controls.Add(listMovies[i]);
				}*/
			}
		}

		private void panelListMovie1_Load(object sender, EventArgs e)
		{

		}
	}
}
