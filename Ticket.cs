using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
    class Ticket
    {
        DB db = new DB();

        public DataTable getTicketList()
        {
            SqlCommand cmd = new SqlCommand("Select * from Ticket", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getUsernameList()
        {
            SqlCommand cmd = new SqlCommand("select username from [User]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getSeatList()
        {
            SqlCommand cmd = new SqlCommand("select seatid from Seat", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataTable getScheduleList()
        {
            SqlCommand cmd = new SqlCommand("Select scheduleid from Schedule", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public DataTable getTicketById(int tid)
        {
            SqlCommand cmd = new SqlCommand("Select price, booking_date, schedule_id, username, seat_id, statistics_id from Ticket where ticketid = @tid", db.GetConnection);
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = tid;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }


        public bool addTicket(int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Ticket (price) VALUES (@price)", db.GetConnection);
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;

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

        public bool updateTicket(int ticketid, int price, DateTime booking_date, int schedule_id, string username, int seat_id, int statistics_id)
        {
            SqlCommand command = new SqlCommand("UPDATE Ticket SET price = @price, booking_date = @booking_date, schedule_id = @schedule_id " +
                ", username = @username, seat_id = @seat_id, statistics_id = @statistics_id WHERE ticketid = @ticketid", db.GetConnection);
            command.Parameters.Add("@ticketid", SqlDbType.Int).Value = ticketid;
            command.Parameters.Add("@price", SqlDbType.VarChar).Value = price;
            command.Parameters.Add("@booking_date", SqlDbType.Date).Value = booking_date;
            command.Parameters.Add("@schedule_id", SqlDbType.Int).Value = schedule_id;
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@seat_id", SqlDbType.Int).Value = seat_id;
            command.Parameters.Add("@statistics_id", SqlDbType.Int).Value = statistics_id;

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

        public bool resetIncrement()
        {
            SqlCommand command = new SqlCommand("DECLARE @number INT; select @number = max(ticketid) from Ticket; DBCC CHECKIDENT ('Ticket', RESEED, @number)", db.GetConnection);
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
    }
}
