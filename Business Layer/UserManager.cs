using Guna.UI2.WinForms;
using RMS_Project.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project.Business_Layer
{
    class UserManager
    {
        public static void AddUser(User user)
        {
            string query = "INSERT INTO tbUser (FullName, UserName, Password, Role, Status, PhotoImage) " +
                "VALUES (@Fullname, @Username, @Password, @Role, @Status, @Image);";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Fullname", user.Fullname);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@Status", user.Status);
                    command.Parameters.AddWithValue("@Image", user.Image);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<User> ReadUser()
        {
            List<User> users = new List<User>();
            using (SqlConnection connection = DBConnection.GetConnection())
            using (SqlCommand command = new SqlCommand("SELECT * FROM tbUser", connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Fullname = reader["FullName"].ToString(),
                        Username = reader["UserName"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        Status = (bool)reader["Status"],
                        Image = (byte[])reader["PhotoImage"]
                    };
                    users.Add(user);
                }
            }
            return users;
        }

        public static void UpdateUser(User user)
        {
            string query = "UPDATE tbUser SET FullName = @Fullname, UserName = @Username, Password = @Password, Role = @Role, Status = @Status, PhotoImage = @Image WHERE UserID = @UserID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@Fullname", user.Fullname);
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);
                    command.Parameters.AddWithValue("@Status", user.Status);
                    command.Parameters.AddWithValue("@Image", user.Image);

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteUser(int userId)
        {
            string query = "DELETE FROM tbUser WHERE UserID = @UserID;";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM tbUser WHERE UserName = @Username;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}