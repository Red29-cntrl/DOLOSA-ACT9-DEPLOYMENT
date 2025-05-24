using MySql.Data.MySqlClient;
using System;
using System.Configuration;

public static class DatabaseHelper
{
    // Method to get the MySQL database connection
    public static MySqlConnection GetConnection()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
}
