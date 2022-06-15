using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    public partial class UserItem : UserControl
    {
        public UserItem()
        {
            InitializeComponent();
        }
 

        private void UserItem_Load(object sender, EventArgs e)
        {

        }

        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phonenumber { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string role { get; set; }

        public string Fullname
        {
            get { return fullname; }
            set
            {
                fullname = value;
                lbfullname.Text = value;
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                lbusername.Text = value;
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                lbpassword.Text = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                lbaddress.Text = value;
            }
        }

        public string Phonenumber
        {
            get { return phonenumber; }
            set
            {
                phonenumber = value;
                lbphone.Text = value;
            }
        }

        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                lbbirthday.Text = value.ToString();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                lbemail.Text = value;
            }
        }

        public string Role
        {
            get { return role; }
            set
            {
                role = value;
                lbrole.Text = value;
            }
        }

        //
        private int radius = 20;
        [DefaultValue(25)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            using (var path = GetRoundRectagle(bounds, this.Radius))
                this.Region = new Region(path);

            //this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
            //    bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
    }
}
