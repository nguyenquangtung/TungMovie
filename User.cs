using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TungMovie
{
	class User
	{
        DB db = new DB();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public bool login(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT username, password FROM [User] WHERE username = @username and password = @password", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
        public bool auth_register(string username, string password, string fullname,string address, DateTime birthday, string phone, string email )
        {
                SqlCommand cmd = new SqlCommand("insert into [User]  (username, password, fullname, address , birthday, phone, email) values (@username, @password, @fullname, @address , @birthday, @phone,  @email)", db.GetConnection);
                cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                cmd.Parameters.Add("@fullname", SqlDbType.NVarChar).Value = fullname;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                cmd.Parameters.Add("@birthday", SqlDbType.NVarChar).Value = birthday;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@roleCode", SqlDbType.NVarChar).Value = "USER";
                cmd.Parameters.Add("@createdBy", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }

        }

        public string getrole(string username)
        {
            string rolename = "";
            SqlCommand command = new SqlCommand("SELECT role_code FROM [User] WHERE username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            db.openConnection();
            SqlDataReader sda = command.ExecuteReader();
            while (sda.Read())
            {
                rolename = sda.GetString(0);
            }
            return rolename;
        }

        public bool updateUserInfo(string username, string password, string fullname, string address, int phone, DateTime birthday, string email)
        {
            SqlCommand command = new SqlCommand("update [User] set password = @password, fullname = @fullname, address = @address" +
                " , phone = @phone, birthday = @birthday, email = @email where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fullname", SqlDbType.VarChar).Value = fullname;
            command.Parameters.Add("@address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
            command.Parameters.Add("@birthday", SqlDbType.DateTime).Value = birthday;
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            db.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getUserInfoByName(string username)
        {
            SqlCommand command = new SqlCommand("select password, fullname, address, phone, birthday, email from [User] where username = @username", db.GetConnection);
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getTotalUser()
        {
            SqlCommand command = new SqlCommand("select count(username) from [User]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public DataTable getAllUserExceptID()
        {
            SqlCommand command = new SqlCommand("select username, password, fullname, address, phone, birthday, email, role_code from [User]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
