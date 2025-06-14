using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class FacultyRequestDL
    {
        public static DataTable GetConsumableItems()
        {
            string query = "SELECT consumable_id, item_name FROM consumables";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int GetPendingStatusId()
        {
            string query = "SELECT lookup_id FROM lookup WHERE category = 'RequestStatus' AND value = 'Pending'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["lookup_id"]);
            }
            return -1; 
        }
        public static int GetFacultyIdByName(string name)
        {
            string query = $"SELECT faculty_id FROM faculty WHERE name = '{name}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["faculty_id"]);
            }
            return -1;
        }

        public static DataTable GetRequestsByFacultyId(int facultyId)
        {
            string query = $"SELECT * FROM faculty_requests WHERE faculty_id = {facultyId}";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int InsertRequest(int facultyId, int itemId, int quantity)
        {
            int pendingStatusId = GetPendingStatusId();
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            string query = $"INSERT INTO faculty_requests (faculty_id, item_id, quantity, status_id, request_date) " +
                           $"VALUES ({facultyId}, {itemId}, {quantity}, {pendingStatusId}, '{currentDate}')";
            return DatabaseHelper.Instance.Update(query);
        }


    }
}
