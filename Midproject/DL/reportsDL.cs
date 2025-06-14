using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class reportsDL
    {
        public static DataTable RoomAllocations()
        {
            string query = @"SELECT f.name AS FacultyName, r.room_name, f.email AS faculty_email, r.capacity AS room_capacity, r.room_type
                             FROM faculty_room_allocations fa JOIN faculty f ON f.faculty_id = fa.faculty_id 
                             JOIN rooms r ON r.room_id = fa.room_id";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable adminroles()
        {
            string query = @"SELECT f.name as FacultyName, f.faculty_id AS FacultyId , Concat(term, "" "" , year) AS semester, f.contact 
                             FROM faculty_admin_roles fa JOIN faculty f ON f.faculty_id= fa.faculty_id JOIN semesters s 
                             ON s.semester_id = fa.semester_id ";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
