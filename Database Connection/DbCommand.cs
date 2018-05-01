using System;


namespace Database_Connection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction; 

        public DbCommand(DbConnection dbConnect, string instruction)
        {
            if (String.IsNullOrEmpty(instruction))
                throw new InvalidOperationException("The instruction cannot be Empty or Null");

            _instruction = instruction;

            _dbConnection = dbConnect ?? throw new InvalidOperationException("db connection cannot be NULL!!!");
            
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Running the instruction : " + _instruction);
            _dbConnection.Close();
        }
    }
}
