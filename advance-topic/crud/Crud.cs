using System;
using MySql.Data.MySqlClient;

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class StudentCrud
{
    private readonly MySqlConnection _connection;
    public StudentCrud(MySqlConnection connection)
    {
        _connection = connection;
    }

    public void CreateTable()
    {
        try
        {
            string createTableQuery = "CREATE TABLE IF NOT EXISTS Student (Id INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(50))";

            MySqlCommand cmd = new MySqlCommand(createTableQuery, _connection);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Student table created ✅");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void InsertData()
    {
        Console.WriteLine("Enter the name you want to insert: ");
        string? name = Console.ReadLine();

        try
        {
            string insertDataQuery = "INSERT INTO Student(Name) VALUES(@name)";

            MySqlCommand cmd = new MySqlCommand(insertDataQuery, _connection);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();

            Console.WriteLine("🟢 Data insertion successful.");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("🔴 Error: " + ex.Message);
        }

    }

    public void ReadData()
    {
        List<Student> students = new List<Student>();

        try
        {
            string readDataQuery = "SELECT * FROM STUDENT";

            MySqlCommand cmd = new MySqlCommand(readDataQuery, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string? name = reader["Name"].ToString();

                students?.Add(new Student { Id = id, Name = name });
            }
            reader.Close();

            if (students?.Count > 0)
            {
                Console.WriteLine("List of students:");
                foreach (Student student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
                }
            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(" Error reading data: " + ex.Message);
        }
    }

    public void UpdateData()
    {
        Console.WriteLine("Enter the ID of student to update : ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter new name:");
        string? newName = Console.ReadLine();

        string updateDataQuery = "UPDATE Student SET Name =@newName WHERE Id =@id";

        try
        {
            MySqlCommand cmd = new MySqlCommand(updateDataQuery, _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@newName", newName);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine($"Student with ID {id} updated successfully.");
            }
            else
            {
                Console.WriteLine($"No student found with ID {id} to update.");
            }
        }
        catch (MySqlException ex)
        {
            Console.Write("Error updating data:" + ex.Message);
        }
    }

    public void DeleteData()
    {
        Console.WriteLine("Enter the ID of student you want to delete:");
        int id = Convert.ToInt32(Console.ReadLine());

        string deleteDataQuery = "DELETE FROM Student WHERE id=@id";

        try
        {
            MySqlCommand cmd = new MySqlCommand(deleteDataQuery, _connection);
            cmd.Parameters.AddWithValue("@id", id);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine($"Student with ID {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"No student found with ID {id} to delete.");
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}


public class CrudApp
{
    public static void Main()
    {
        string connectionString = "Server=localhost;Username=root;Password=;Database=dotnet";

        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();
            Console.WriteLine("Connected successfully...");

            // perform database operations
            StudentCrud studentCrud = new StudentCrud(connection);
            studentCrud.CreateTable();
            studentCrud.InsertData();
            studentCrud.ReadData();
            // studentCrud.UpdateData();
            // studentCrud.DeleteData();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
