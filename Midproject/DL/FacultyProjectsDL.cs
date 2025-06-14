using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class FacultyProjectsDL
    {
        public static DataTable GetAllFacultyProjects()
        {
            string query = "SELECT * FROM faculty_projects";
            return DatabaseHelper.Instance.GetDataTable(query);
        }


        public static DataTable GetAllFaculty()
        {
            string query = "SELECT faculty_id, name FROM faculty";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetAllSemesters()
        {
            string query = "SELECT semester_id, CONCAT(term, ' ', year) AS semester_name FROM semesters";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetAvailableProjects()
        {
            string query = "SELECT project_id, title FROM projects WHERE project_id NOT IN (SELECT project_id FROM faculty_projects)";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int AddFacultyProject(int facultyId, int semesterId, int projectId, int supervisionHours)
        {
            string query = $"INSERT INTO faculty_projects (faculty_id, semester_id, project_id, supervision_hours) " +
                           $"VALUES ({facultyId}, {semesterId}, {projectId}, {supervisionHours})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteFacultyProject(int id)
        {
            string query = $"DELETE FROM faculty_projects WHERE faculty_project_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static bool CheckProjectAssigned(int projectId)
        {
            string query = $"SELECT * FROM faculty_projects WHERE project_id = {projectId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }
    }
}
