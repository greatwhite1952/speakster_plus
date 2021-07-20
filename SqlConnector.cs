using System;

namespace Speech.DataAccess
{
	public SqlConnector()
    {
        using var connection = new MySqlConnection(connectionString); // C# 8!
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = "SELECT id, name FROM fooBar WHERE deleted = 0"; // whatever

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            result.Add(new MyObject
            {
                Id = reader.GetUInt64("id"), // the parameter is the name of the column
                Name = reader.GetString("name"),
            });

        }

        return result;
    }
}
