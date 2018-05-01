using System;


namespace Database_Connection
{
    class DbConnectionApp
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SQL connection string");
            var oracleConnection = new OracleConnection("Oracle connection string");

            var command = new DbCommand(sqlConnection, "SELECT ALL DATA - SQL");
            command.Execute();

            Console.WriteLine();
            Console.WriteLine();

            command = new DbCommand(oracleConnection, "SELECT ALL ENTITIES - ORACLE");
            command.Execute();
            Console.WriteLine();
        }
    }
}
