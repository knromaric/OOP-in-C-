using System;

namespace Database_Connection
{
    public class OracleConnection: DbConnection
    {
        public OracleConnection(string connectionStr)
            : base(connectionStr)
        {

        }
        public override void Open()
        {
            Console.WriteLine("Opening Oracle connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle connection...");
        }
    }
}
