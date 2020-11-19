using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class SalaCinematograficaSqlProvider : SqlProvider<SalaCinematografica>,ISqlProviderUpdate<SalaCinematografica>
    {
        public SalaCinematograficaSqlProvider(string connectionString) : base(connectionString)
        {

        }

        public void Update(SalaCinematografica salaCinematografica)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"UPDATE [dbo].[SaleCinematografice]SET,[IdSpettatore] = @IdSpettatore ,[IdFilm] = @IdFilm     
                                            WHERE IdSala = @IdSala", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@IdSala", salaCinematografica.IdSala);              
                cmd.Parameters.AddWithValue("@IdSpettatore", salaCinematografica.IdSpettatore);
                cmd.Parameters.AddWithValue("@IdFilm", salaCinematografica.IdFilm);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
