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
	public partial class ListCharater : Form
	{
		CharacterInfo ch = new CharacterInfo();
		public ListCharater()
		{
			InitializeComponent();
		}
		public void ListCh_grid_Load()
		{
			gridListChr.RowTemplate.Height = 45;
			gridListChr.DataSource = ch.getcharacterlist();
			gridListChr.Columns[0].Width = 70;
			gridListChr.Columns[1].Width = 80;
			gridListChr.Columns[2].Width = 60;
			gridListChr.Columns[3].Width = 60;
			gridListChr.AllowUserToResizeColumns = false;
		}
		private void ListCh_Load(object sender, EventArgs e)
		{
			ListCh_grid_Load();
		}


	}
}
