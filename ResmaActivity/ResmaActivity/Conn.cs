using Microsoft.Data.SqlClient;

namespace ResmaActivity
{
    public class Conn
    {
        
        
            public SqlConnection connection;
            public Conn()
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionStrings = configuration.GetConnectionString("DefaultConnection2");
                connection = new SqlConnection(connectionStrings);
            }
        
    }
}
