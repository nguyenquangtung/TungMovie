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
    }
}
