using System.Data.SqlClient;
// Establish connection
string connectionString = "Server=HUNTUR\\SQLEXPRESS;Database=QLBH2;Integrated Security=SSPI;";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
// create query
// string sqlQuery = "SELECT * FROM NEW";
// SqlCommand command = new SqlCommand(sqlQuery, connection);
// // Execute query 
// SqlDataReader reader = command.ExecuteReader();
// while (reader.Read())
// {
//     Console.WriteLine(reader["COLUMN1"]);
//     Console.WriteLine(reader["COLUMN2"]);
// }
// reader.Close();
// non query
string updateQuery = "UPDATE NEW SET COLUMN1 = @newValue WHERE COLUMN1 = @id";
SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
updateCommand.Parameters.AddWithValue("@newValue", "NEW");
updateCommand.Parameters.AddWithValue("@id", "ROW11");
updateCommand.ExecuteNonQuery(); 

connection.Close();
