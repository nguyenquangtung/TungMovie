﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TungMovie
{
    internal class ListMovie
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
        public DataTable GetMovieById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE movieid LIKE '%" + id + "%' ", db.GetConnection);
            cmd.Parameters.AddWithValue("@movieid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable GetMovieByName(string name)
        {
            SqlCommand cmd = new SqlCommand("SELECT movieid 'ID',name 'Movie',thumbnail 'Image', rating 'Rating', genre 'Genre', short_description 'Desciption', duration 'Duration', trailer 'Trailer' FROM Movie WHERE name LIKE '%" + name + "%' ", db.GetConnection);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}