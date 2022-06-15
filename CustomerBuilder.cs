using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungMovie
{
    public class CustomerSettings
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }

    public interface ICustomerBuilder
    {
        void AddFullname(string fullname);
        void AddUsername(string username);
        void AddPassword(string password);
        void AddAddress(string address);
        void AddPhonenumber(string phonenumber);
        void AddBirthday(string birthday);
        void AddEmail(string email);
        void AddRole(string role);
        CustomerSettings Build();
    }

    public class CustomerBuilder : ICustomerBuilder
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

        public void AddPhonenumber(string phonenumber)
        {
            customersettings.Phonenumber = phonenumber;
        }

        public void AddBirthday(string birthday)
        {
            customersettings.Birthday = birthday;
        }

        public void AddEmail(string email)
        {
            customersettings.Email = email;
        }

        public void AddRole(string role)
        {
            customersettings.Role = role;
        }

        public CustomerSettings Build()
        {
            return customersettings;
        }
    }
}