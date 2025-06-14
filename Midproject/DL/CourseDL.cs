using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class CourseDL
    {
        public static DataTable GetAllCourses()
        {
            string query = "SELECT * FROM courses";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int AddCourse(string courseName, string courseType, int creditHours, int contactHours)
        {
            string query = $"INSERT INTO courses (course_name, course_type, credit_hours, contact_hours) VALUES ('{courseName}', '{courseType}', {creditHours}, {contactHours})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateCourse(int courseId, string courseName, string courseType, int creditHours, int contactHours)
        {
            string query = $"UPDATE courses SET course_name = '{courseName}', course_type = '{courseType}', credit_hours = {creditHours}, contact_hours = {contactHours} WHERE course_id = {courseId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteCourse(int courseId)
        {
            string checkQuery = $"SELECT COUNT(*) FROM faculty_courses WHERE course_id = {courseId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);

            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return -1;
            }

            string deleteQuery = $"DELETE FROM courses WHERE course_id = {courseId}";
            return DatabaseHelper.Instance.Update(deleteQuery);
        }

    }
}

