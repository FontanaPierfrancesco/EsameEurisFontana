using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.ProgettoCinema
{
    public abstract class SqlProvider<T>
    {

        protected readonly string connectionString;

        protected SqlProvider(string connectionString)
        {
            this.connectionString = connectionString;
        }
        
        
       
    }
}
