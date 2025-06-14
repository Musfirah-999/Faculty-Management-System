using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
     public class SemesterDl
     {
        public static DataTable GetAllSemesters()
        {
            string query = "SELECT * FROM semesters";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static int AddSemester(string term, int year)
        {
            string query = $"INSERT INTO semesters (term, year) VALUES ('{term}', {year})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateSemester(int semesterId, string term, int year)
        {
            string query = $"UPDATE semesters SET term = '{term}', year = {year} WHERE semester_id = {semesterId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int DeleteSemester(int semesterId)
        {

            string checkQuery = $"SELECT COUNT(*) FROM faculty_projects WHERE semester_id = {semesterId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(checkQuery);

            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return -1;
            }

            string deleteQuery = $"DELETE FROM semesters WHERE semester_id = {semesterId}";
            return DatabaseHelper.Instance.Update(deleteQuery);
        
        }
     }
}
