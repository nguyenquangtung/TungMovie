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
	public partial class PanelListMovie : UserControl
	{
		public PanelListMovie()
		{
			InitializeComponent();
		}

		#region Properties
		private string _title;
		private string _genre;
		private string _rating;
		private string _duaration;
		private Image _icon;

		public string Title
		{
			get { return _title; }
			set { _title = value; lbTitle.Text = value; }
		}
		public string Genre
		{
			get { return _genre; }
			set { _genre = value; lbGenre.Text = value; }
		}
		public string Rating
		{
			get { return _rating; }
			set { _rating = value; LbDuaration.Text = value; }
		}
		public string Duaration
		{
			get { return _duaration; }
			set { _duaration = value;LbDuaration.Text = value; }
		}

		public Image Icon
		{
			get { return _icon; }
			set { _icon = value;pictureBox1.Image = value; }
		}

		#endregion
	}
}