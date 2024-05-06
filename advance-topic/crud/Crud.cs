using System;
using MySql.Data.MySqlClient;


public class StudentCrud
{
    private MySqlConnection conn;
    public StudentCrud(MySqlConnection connection)
    {
        conn = connection;
    }



    public void InsertData()
    {
        Console.WriteLine("Enter the name you want to insert: ");
        string? name = Console.ReadLine();
        System.Console.WriteLine("Enter age");
        int age = Convert.ToInt32(Console.ReadLine());

        try
        {
            string query = "INSERT INTO Student(Name,age) VALUES(@name, @age)";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@name", age);
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

        try
        {
            string query = "SELECT * FROM STUDENT";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            System.Console.WriteLine(reader.Read());
            while (reader.Read())
            {
                System.Console.Write(reader["Id"]);
                System.Console.WriteLine(reader["Name"]);

            }
            reader.Close();



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

        string query = "UPDATE Student SET Name =@newName WHERE Id =@id";

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@newName", newName);

            cmd.ExecuteNonQuery();

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

        string query = "DELETE FROM Student WHERE id=@id";

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}



public class MainClass
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


            // studentCrud.CreateTable();
            // studentCrud.InsertData();
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


class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
