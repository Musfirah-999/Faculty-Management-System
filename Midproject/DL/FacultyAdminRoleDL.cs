using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class FacultyAdminRoleDL
    {
            public static DataTable GetAllRoles()
            {
                string query = "SELECT * FROM faculty_admin_roles";
                return DatabaseHelper.Instance.GetDataTable(query);
            }

            public static DataTable GetFaculty()
            {
                string query = "SELECT faculty_id, name FROM faculty";
                return DatabaseHelper.Instance.GetDataTable(query);
            }

            public static DataTable GetSemesters()
            {
                string query = "SELECT semester_id, Concat(term, ' ' ,Year) AS semester FROM semesters";
                return DatabaseHelper.Instance.GetDataTable(query);
            }

            public static bool AddAdminRole(int facultyId, string roleName, int semesterId)
            {
                string query = $"INSERT INTO faculty_admin_roles (faculty_id, role_name, semester_id) VALUES ({facultyId}, '{roleName}', {semesterId})";
                return DatabaseHelper.Instance.Insert(query);
            }

            public static int UpdateAdminRole(int id, int facultyId, string roleName, int semesterId)
            {
                string query = $"UPDATE faculty_admin_roles SET faculty_id = {facultyId}, role_name = '{roleName}', semester_id = {semesterId} WHERE id = {id}";
                return DatabaseHelper.Instance.Update(query);
            }

            public static bool DeleteAdminRole(int id)
            {
                string query = $"DELETE FROM faculty_admin_roles WHERE admin_role_id = {id}";
                return DatabaseHelper.Instance.Delete(query);
            }
        }
 }

