using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public class BigliettoSqlProvider : SqlProvider<Biglietto>, ISqlProviderUpdate<Biglietto>, ISqlProviderCreate<Biglietto>
    {
        public BigliettoSqlProvider(string connectionString) : base(connectionString)
        {

        }

        public void Create(Biglietto biglietto)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"INSERT INTO [dbo].[Biglietti]([IdBiglietto],[NPosto],[PrezzoBiglietto])          
                                             VALUES(@IdBiglietto,@NPosto,@PrezzoBiglietto", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@IdBiglietto", biglietto.IdBiglietto);
                cmd.Parameters.AddWithValue("@NPosto", biglietto.NPosto);
                cmd.Parameters.AddWithValue("@PrezzoBiglietto", biglietto.PrezzoBiglietto);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Biglietto biglietto)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(@"UPDATE [dbo].[Biglietti]SET [IdBiglietto] = @IdBiglietto,[NPosto] = @NPosto,[PrezzoBiglietto] = @PrezzoBiglietto
                                            WHERE IdBiglietto = @IdBiglietto", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@IdBiglietto", biglietto.IdBiglietto);
                cmd.Parameters.AddWithValue("@NPosto", biglietto.NPosto);
                cmd.Parameters.AddWithValue("@PrezzoBiglietto", biglietto.PrezzoBiglietto);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
