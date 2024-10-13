using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace Milestone5
{
    internal class DBConnectionTest
    {  

           // Define a User class to hold the data
            public class User
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Email { get; set; }
            }

            static void Main(string[] args)
            {
                // Connection string for the database
                string connectionString = "Server=WIPDNFSD;Database=SampleDB;Integrated Security=True;";

                // List to hold user data
                List<User> users = new List<User>();

                try
                {
                // Establish the database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Open the connection
                        connection.Open();

                        // SQL query to retrieve data
                        string query = "SELECT * FROM Users";

                        // Execute the query
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // Read the data
                                while (reader.Read())
                                {
                                    User user = new User
                                    {
                                        Id = reader.GetInt32(0), 
                                        Name = reader.GetString(1), 
                                        Email = reader.GetString(2) 
                                    };
                                    users.Add(user);
                                }
                            }
                        }
                    }

                    // Display the results
                    foreach (var user in users)
                    {
                        Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Email: {user.Email}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }

