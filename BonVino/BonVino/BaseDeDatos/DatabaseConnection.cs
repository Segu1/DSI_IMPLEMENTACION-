using System;
using System.Data.SQLite;

public class DatabaseConnection
{
    private SQLiteConnection connection;

    public DatabaseConnection(string databasePath)
    {
        connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
    }

    public void OpenConnection()
    {
        if (connection.State != System.Data.ConnectionState.Open)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State != System.Data.ConnectionState.Closed)
        {
            connection.Close();
        }
    }

    public SQLiteConnection GetConnection()
    {
        return connection;
    }
}