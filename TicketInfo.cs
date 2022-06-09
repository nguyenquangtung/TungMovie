using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
    class TicketInfo
    {
        DB db = new DB();
        public DataSet getTicketInfo()
        {
            SqlCommand command = new SqlCommand("SELECT ticketid, price, schedule_id, username, seat_id FROM[Movie_ticket_management].[dbo].[Ticket]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }
    }
}
