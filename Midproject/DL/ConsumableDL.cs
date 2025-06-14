using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class ConsumableDL
    {
        public static DataTable GetAllConsumables()
        {
            string query = "Select * from consumables";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int AddConsumable(string name)
        {
            string query = $"INSERT INTO consumables (item_name) VALUES ('{name}')";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateConsumable(int id, string name)
        {
      
            string query = $"UPDATE consumables SET item_name = '{name}' WHERE consumable_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        
        }
        public static int DeleteConsumable(int consumableid)
        {
 
            //string checkQuery = $"SELECT COUNT(*) FROM faculty_requests WHERE consumable_id = {consumableid}";
            //DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);

            //if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            //    return -1;

            string deleteQuery = $"DELETE FROM consumables WHERE consumable_id = {consumableid}";
            return DatabaseHelper.Instance.Update(deleteQuery);
        }

    }

}

