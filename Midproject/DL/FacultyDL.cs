using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class FacultyDL
    {
        public static int GetFacultyIdByUserId(int userId)
        {
            string query = $"SELECT faculty_id FROM faculty WHERE user_id = {userId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0]["faculty_id"]);
            return -1;
        }
    }
}
