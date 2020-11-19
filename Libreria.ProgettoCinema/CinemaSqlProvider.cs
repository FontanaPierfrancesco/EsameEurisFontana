using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class CinemaSqlProvider : SqlProvider<Cinema>, ISqlProviderUpdate<Cinema>
    {
        public CinemaSqlProvider(string connectionString) : base(connectionString)
        {

        }
       
        public void Update(Cinema cinema)
        {
           using(var conn = new SqlConnection(connectionString))
                using(var cmd = new SqlCommand(@"UPDATE [dbo].[Cinema],[IdFilm] = @IdFilm 
                                               WHERE IdCinema = @IdCinema", conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdCinema", cinema.IdCinema);
                cmd.Parameters.AddWithValue("@IdFilm", cinema.IdFilm);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
