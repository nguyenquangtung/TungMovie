using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TungMovie
{
	class MovieInfo
	{
		DB db = new DB();
        public DataTable getmovielist()
        {
            SqlCommand command = new SqlCommand("select movieid  'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' from [Movie]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public DataSet getMovieSchedule()
        {
            SqlCommand command = new SqlCommand("SELECT movieid  'ID',name 'Movie', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', start_time 'Start_date', end_time 'End_Date' " +
                                                 "FROM[Movie_ticket_management].[dbo].[Movie] inner join[Movie_ticket_management].[dbo].[Schedule] on[Movie].movieid = [Schedule].movie_id ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet addMovie(string MovieN, string rating, string genre, string description, string duration)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Movie_ticket_management].[dbo].[Movie] (name, rating, genre, short_description , duration )" +
                                                 "VALUES ('" + MovieN + "', '" + rating + "', '" + genre + "', ' " + description + "', '" + duration + "');", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet updateMovie(string MovieN, string rating, string genre, string description, string duration, string movieid)
        {
            SqlCommand command = new SqlCommand("UPDATE [Movie_ticket_management].[dbo].[Movie] " +
                                                "SET name = '" + MovieN + "', rating = '" + rating + "', genre = '" + genre + "', short_description = '" + description + "', duration = '" + duration + "' " +
                                                "WHERE movieid = '" + movieid + "'; ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet DeleteMovie(string movieid)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Movie_ticket_management].[dbo].[Movie] WHERE movieid = '" + movieid + "' ", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }

        public DataSet getticket()
        {
            SqlCommand command = new SqlCommand(" select movieid  'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' from[Movie]", db.GetConnection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            sda.Fill(dt);
            return dt;
        }
    }
}
