using Microsoft.Data.SqlClient;

namespace Activity1
{
    public class DbConClass
    {
        public SqlConnection connection;
        public DbConClass()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connectionStrings = configuration.GetConnectionString("SecondConnection");
            connection = new SqlConnection(connectionStrings);
        }
    }
}
