using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class SpettatoreSqlprovider : SqlProvider<Spettatore>, ISqlProviderUpdate<Spettatore>, ISqlProviderCreate<Spettatore>, ISqlProviderSelect<Spettatore>
    {
        public SpettatoreSqlprovider(string connectionString) : base(connectionString)
        {

        }

        public void Create(Spettatore spettatore)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"INSERT INTO [dbo].[Spettatori] ([IdSpettatore],[NomeSpettatore],[CognomeSpettatore],[DataNascita],[IdBiglietto])           
                                            VALUES(@IdSpettatore,@NomeSpettatore,@CognomeSpettatore,@DataNascita,@IdBiglietto", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@IdSpettatore", spettatore.IdSpettatore);
                cmd.Parameters.AddWithValue("@NomeSpettatore", spettatore.NomeSpettatore);
                cmd.Parameters.AddWithValue("@CognomeSpettatore", spettatore.CognomeSpettatore);
                cmd.Parameters.AddWithValue("@DataNascita", spettatore.DataNascita);
                cmd.Parameters.AddWithValue("@IdBiglietto", spettatore.IdBiglietto);

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Spettatore> GetAll()
        {
            var listaSpettatori = new List<Spettatore>();

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"SELECT [IdSpettatore] ,[NomeSpettatore],[CognomeSpettatore],[DataNascita] ,[IdBiglietto]    
                                                FROM [dbo].[Spettatori]", conn))
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listaSpettatori.Add(new Spettatore(reader["IdSpettatore"].ToString(), reader["NomeSpettatore"].ToString(), reader["CognomeSpettatore"].ToString(), Convert.ToDateTime(reader["DataNascita"]), reader["IdBiglietto"].ToString()));
                }
                return listaSpettatori;
            }
        }


        public void Update(Spettatore spettatore)
        {

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"UPDATE [dbo].[Spettatori]SET [IdSpettatore] = @IdSpettatore,[NomeSpettatore] = @NomeSpettatore,[CognomeSpettatore] = @CognomeSpettatore,[DataNascita] = @DataNascita,[IdBiglietto] = @IdBiglietto
                                            WHERE IdSpettatore = @IdSpettatore", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@IdSpettatore", spettatore.IdSpettatore);
                cmd.Parameters.AddWithValue("@NomeSpettatore", spettatore.NomeSpettatore);
                cmd.Parameters.AddWithValue("@CognomeSpettatore", spettatore.CognomeSpettatore);
                cmd.Parameters.AddWithValue("@DataNascita", spettatore.DataNascita);
                cmd.Parameters.AddWithValue("@IdBiglietto", spettatore.IdBiglietto);



                cmd.ExecuteNonQuery();
            }

        }
    }
}
