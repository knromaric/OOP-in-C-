using System;


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
            Console.WriteLine("Opening SQL connection...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL connection...");
        }
    }
}
