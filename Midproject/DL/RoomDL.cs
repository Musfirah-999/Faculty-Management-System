using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Midproject.DL
{
    public class RoomDL
    {
        public static DataTable GetAllRooms()
        {
            string query = "Select * from rooms";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int addRooms(int Roomid, string RoomName, string RoomType, int RoomCapacity )
        {
            string query = $"INSERT INTO rooms (room_id, room_name, room_type, capacity) VALUES ({Roomid}, '{RoomName}', '{RoomType}', {RoomCapacity})";
            return DatabaseHelper.Instance.Update(query);
        }
        public static int Updaterooms(int RoomId, string RoomName, string RoomType, int RoomCapacity)
        {
            string query = $"UPDATE rooms SET room_name = '{RoomName}', room_type = '{RoomType}', capacity = {RoomCapacity} WHERE room_id = {RoomId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteRoom(int roomId)
        {
              string checkQuery = $"SELECT COUNT(*) FROM faculty_room_allocations WHERE room_id = {roomId}";
                DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);

            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return -1;
            }
                string deleteQuery = $"DELETE FROM rooms WHERE room_id = {roomId}";
                return DatabaseHelper.Instance.Update(deleteQuery);
            

        }
    }
}
