namespace AdoNet.Data
{
    public class DataBaseConnection
    {
        private readonly string connectionString;

        public DataBaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}