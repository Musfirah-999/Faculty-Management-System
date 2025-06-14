using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Midproject.DL
{
    public class FacultyRoomAllocationDL
    {
        public static DataTable GetAllAllocations()
        {
            string query = "SELECT allocation_id, faculty_id, room_id, reserved_hours, semester_id FROM faculty_room_allocations";

            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static bool IsRoomAlreadyAssignedToAnyFaculty(int roomId, int semesterId)
        {
            string query = $"SELECT * FROM faculty_room_allocations WHERE room_id = {roomId} AND semester_id = {semesterId}";
            return DatabaseHelper.Instance.GetDataTable(query).Rows.Count > 0;
        }

        public static int AddRoomAllocation(int facultyId, int roomId, int reservedHours, int semesterId)
        {
            string query = $"INSERT INTO faculty_room_allocations (faculty_id, room_id, reserved_hours, semester_id) " +
                           $"VALUES ({facultyId}, {roomId}, {reservedHours}, {semesterId})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateRoomAllocation(int id, int facultyId, int roomId, int reservedHours, int semesterId)
        {
            string query = $"UPDATE faculty_room_allocations SET faculty_id={facultyId}, room_id={roomId}, reserved_hours={reservedHours}, semester_id={semesterId} " +
                           $"WHERE allocation_id={id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteRoomAllocation(int id)
        {
            string query = $"DELETE FROM faculty_room_allocations WHERE allocation_id={id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static DataTable GetFaculty()
        {
            return DatabaseHelper.Instance.GetDataTable("SELECT faculty_id, name FROM faculty");
        }

        public static DataTable GetRooms()
        {
            return DatabaseHelper.Instance.GetDataTable("SELECT room_id, room_name FROM rooms");
        }

        public static DataTable GetSemesters()
        {
            return DatabaseHelper.Instance.GetDataTable("SELECT semester_id, CONCAT(term, ' ', year) AS semester FROM semesters");
        }
    }
}
