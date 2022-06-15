using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungMovie
{
    class CustomerSettings
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int Phonenumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
    }

    interface ICustomerBuilder
    {
        void AddFullname(string fullname);
        void AddUsername(string username);
        void AddPassword(string password);
        void AddAddress(string address);
        void AddPhonenumber(int phonenumber);
        void AddBirthday(DateTime birthday);
        void AddEmail(string email);
        CustomerSettings Build();
    }

    class CustomerBuilder : ICustomerBuilder
    {
        private CustomerSettings customersettings = new CustomerSettings();

        public CustomerBuilder()
        {

        }

        public void AddFullname(string fullname)
        {
            customersettings.Fullname = fullname;
        }

        public void AddUsername(string username)
        {
            customersettings.Username = username;
        }

        public void AddPassword(string password)
        {
            customersettings.Password = password;
        }

        public void AddAddress(string address)
        {
            customersettings.Address = address;
        }

        public void AddPhonenumber(int phonenumber)
        {
            customersettings.Phonenumber = phonenumber;
        }

        public void AddBirthday(DateTime birthday)
        {
            customersettings.Birthday = birthday;
        }

        public void AddEmail(string email)
        {
            customersettings.Email = email;
        }

        public CustomerSettings Build()
        {
            return customersettings;
        }
    }
}