using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class SqlConnection: DbConnection
    {
        public SqlConnection(string connectionStr)
            : base(connectionStr)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Closing SQL connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection...");
        }
    }
}
