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
    public partial class FlowPanelForm : Form
    {
        User us = new User();
        int size = 0;

        public FlowPanelForm()
        {
            InitializeComponent();
        }


        //public void GetCustomerData(string fullname, string pass, string username, string add, string email, DateTime date, string phone, string role)
        //{
        //    var customerbuilder = new CustomerBuilder();
        //    customerbuilder.AddFullname(fullname);
        //    customerbuilder.AddPassword(pass);
        //    customerbuilder.AddUsername(username);
        //    customerbuilder.AddAddress(add);
        //    customerbuilder.AddEmail(email);
        //    customerbuilder.AddBirthday(date);
        //    customerbuilder.AddPhonenumber(phone);
        //    customerbuilder.AddRole(role);

        //}

        private void FlowPanelForm_Load(object sender, EventArgs e)
        {
            size = Convert.ToInt32(us.getTotalUser().Rows[0][0].ToString());
            UserItem[] useritem = new UserItem[size];
            var customerbuilder = new CustomerBuilder();
            DataTable dt = us.getAllUserExceptID();
            for (int i = 0; i < size; i++)
            {
                //select username, password, fullname, address, phone, birthday, email, role_code
                customerbuilder.AddFullname(dt.Rows[i][2].ToString());
                customerbuilder.AddPassword(dt.Rows[i][1].ToString());
                customerbuilder.AddUsername(dt.Rows[i][0].ToString());
                customerbuilder.AddAddress(dt.Rows[i][3].ToString());
                customerbuilder.AddPhonenumber(dt.Rows[i][4].ToString());
                customerbuilder.AddBirthday(DateTime.Parse(dt.Rows[i][5].ToString()).ToShortDateString());
                customerbuilder.AddEmail(dt.Rows[i][6].ToString());
                customerbuilder.AddRole(dt.Rows[i][7].ToString());

                var customers = customerbuilder.Build();

                useritem[i] = new UserItem();
                useritem[i].Fullname = customers.Fullname;
                useritem[i].Password = customers.Password;
                useritem[i].Username = customers.Username;
                useritem[i].Address = customers.Address;
                useritem[i].Email = customers.Email;
                useritem[i].Birthday = customers.Birthday;
                useritem[i].Phonenumber = customers.Phonenumber;
                useritem[i].Role = customers.Role;

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.AutoScroll = true;
                    flowLayoutPanel1.Controls.Add(useritem[i]);
                }
            }
   
        }
    }
}
