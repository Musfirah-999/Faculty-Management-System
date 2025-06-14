using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class SignupDL
    {
        public static DataTable GetUserRoles()
        {
            string query = "SELECT value FROM lookup WHERE category = 'UserRoles'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static string GetRoleId(string roleName)
        {
            string query = $"SELECT lookup_id FROM lookup WHERE category = 'UserRoles' AND value = '{roleName}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? dt.Rows[0]["lookup_id"].ToString() : null;
        }

        public static bool InsertUser(string username, string email, string passwordHash, string roleId)
        {
            string query = $"INSERT INTO users (username, email, password_hash, role_id) " +
                           $"VALUES ('{username}', '{email}', '{passwordHash}', '{roleId}')";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }
    }
}

