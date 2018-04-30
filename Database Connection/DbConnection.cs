
using System;

namespace Database_Connection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("The connection string cannot be null or empty !!");

            ConnectionString = connectionString; 
        }

        public abstract void Open();

        public abstract void Close();
    }
}
