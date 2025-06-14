using System.Data;
using Midproject.DL;

namespace Midproject.DL
{
    public class FacultyCourseDL
    {
        public static int AddFacultyCourse(int facultyId, int courseId, int semesterId)
        {
            string checkQuery = $"SELECT * FROM faculty_courses WHERE course_id = {courseId} AND semester_id = {semesterId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);
            if (dt.Rows.Count > 0)
                return -1; 

            string query = $"INSERT INTO faculty_courses (faculty_id, course_id, semester_id) VALUES ({facultyId}, {courseId}, {semesterId})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateFacultyCourse(int id, int facultyId, int courseId, int semesterId)
        {
            string checkQuery = $"SELECT * FROM faculty_courses WHERE course_id = {courseId} AND semester_id = {semesterId} AND faculty_course_id != {id}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);
            if (dt.Rows.Count > 0)
                return -1;

            string query = $"UPDATE faculty_courses SET faculty_id = {facultyId}, course_id = {courseId}, semester_id = {semesterId} WHERE faculty_course_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteFacultyCourse(int id)
        {
            string query = $"DELETE FROM faculty_courses WHERE faculty_course_id = {id}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static DataTable GetAllFacultyCourses()
        {
            string query = "SELECT fc.faculty_course_id, f.name AS faculty_name, c.course_name AS course_name, s.term " +
                           "FROM faculty_courses fc " +
                           "JOIN faculty f ON fc.faculty_id = f.faculty_id " +
                           "JOIN courses c ON fc.course_id = c.course_id " +
                           "JOIN semesters s ON fc.semester_id = s.semester_id";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetFaculty()
        {
            string query = "SELECT faculty_id FROM faculty";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetCourses()
        {
            string query = "SELECT course_id FROM courses";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

  
        public static DataTable GetSemesters()
        {
            string query = "SELECT semester_id FROM semesters";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
