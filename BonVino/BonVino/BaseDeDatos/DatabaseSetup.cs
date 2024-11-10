using System.Data.SQLite;

public class DatabaseSetup
{
    private DatabaseConnection dbConnection;

    public DatabaseSetup(DatabaseConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public void CreateTables()
    {
        dbConnection.OpenConnection();

        string sql = @"CREATE TABLE IF NOT EXISTS Productos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Precio REAL NOT NULL,
                        Categoria TEXT NOT NULL
                      );";

        using (SQLiteCommand command = new SQLiteCommand(sql, dbConnection.GetConnection()))
        {
            command.ExecuteNonQuery();
        }

        dbConnection.CloseConnection();
    }
}