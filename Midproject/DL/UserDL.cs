using System.Data;

namespace Midproject.DL
{
    public class UserDL
    {
        public static bool AddUser(string name, string email, string hashedPassword)
        {
            string query = $"INSERT INTO users (username, email, password_hash, role_id) VALUES ('{name}', '{email}', '{hashedPassword}', {2})";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }

        public static bool IsUsernameExists(string username)
        {
            string query = $"SELECT * FROM users WHERE username = '{username}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }

        public static bool IsEmailExists(string email)
        {
            string query = $"SELECT * FROM users WHERE email = '{email}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }
    }
}
