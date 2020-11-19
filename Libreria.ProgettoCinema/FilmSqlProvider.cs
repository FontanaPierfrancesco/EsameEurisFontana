using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class FilmSqlProvider : SqlProvider<Film>, ISqlProviderUpdate<Film>, ISqlProviderCreate<Film>, ISqlProviderSelect<Film>
    {
        public FilmSqlProvider(string connectionString) : base(connectionString)
        {

        }

        public void Create(Film film)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"INSERT INTO [dbo].[Film]([IdFilm],[Titolo],[Autore],[Produttore],[Genere],[Durata]          
                                             VALUES(@IdFilm,@Titolo,@Autore,@Produttore,@Genere,@Durata)",conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdFilm", film.IdFilm);
                cmd.Parameters.AddWithValue("@Titolo", film.Titolo);
                cmd.Parameters.AddWithValue("@Autore", film.Autore);
                cmd.Parameters.AddWithValue("@Produttore", film.Produttore);
                cmd.Parameters.AddWithValue("@Genere", film.Genere);
                cmd.Parameters.AddWithValue("@Durata", film.Durata);

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Film> GetAll()
        {
            var listaFilm = new List<Film>();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"SELECT [IdFilm],[Titolo],[Autore],[Produttore],[Genere],[Durata]
                                             FROM [Film]", conn))
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaFilm.Add(new Film(reader["IdFilm"].ToString(), reader["Titolo"].ToString(), reader["Autore"].ToString(), reader["Produttore"].ToString(), reader["Genere"].ToString(), Convert.ToDateTime(reader["Durata"])));
                }
                return listaFilm;
            }
        }

        public void Update(Film film)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"UPDATE [dbo].[Film]SET [IdFilm] = @IdFilm,[Titolo] = @Titolo,[Autore] = @Autore,[Produttore] = @Produttore,[Genere] = @Genere,[Durata] = @Durata
                                            WHERE IdFilm = @IdFilm", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdFilm", film.IdFilm);
                cmd.Parameters.AddWithValue("@Titolo", film.Titolo);
                cmd.Parameters.AddWithValue("@Autore", film.Autore);
                cmd.Parameters.AddWithValue("@Produttore", film.Produttore);
                cmd.Parameters.AddWithValue("@Genere", film.Genere);
                cmd.Parameters.AddWithValue("@Durata", film.Durata);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
