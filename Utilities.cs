namespace DockerCalculator;

public class Utilities
{
    public static string GetConnectionString()
        {
            // var database = "DockerCalculator";
            // var server = Environment.GetEnvironmentVariable("DockerDbServer") ?? "mysql-server";
            // var port = Environment.GetEnvironmentVariable("DockerDbPort") ?? "3306";
            // var user = Environment.GetEnvironmentVariable("DockerDbUser") ?? "root";
            // var password = Environment.GetEnvironmentVariable("DockerDbPassword") ?? "1234";

            var database = "DockerCalculator";
            var server = "mysql-server";
            var port = "3307";
            var user = "root";
            var password = "1234";
           
            // Check if any of the required environment variables are missing
            if (string.IsNullOrEmpty(database) 
                || string.IsNullOrEmpty(server)
                || string.IsNullOrEmpty(port) 
                || string.IsNullOrEmpty(user) 
                || string.IsNullOrEmpty(password))
            {
                throw new InvalidOperationException("Missing database environment variables.");
            }


            // Construct and return the connection string
            return $"database={database}; server={server}; port={port}; user={user}; password={password};";
        }
}

