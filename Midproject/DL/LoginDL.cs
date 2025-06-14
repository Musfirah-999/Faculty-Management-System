using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class LoginDL
    {
        public static DataTable CheckLogin(string username, string hashedPassword, string roleName)
        {
            string query = $"SELECT u.user_id, u.role_id, l.value AS role_name " +
                           $"FROM users u JOIN lookup l ON u.role_id = l.lookup_id " +
                           $"WHERE u.username = '{username}' AND u.password_hash = '{hashedPassword}' AND l.value = '{roleName}'";

            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
