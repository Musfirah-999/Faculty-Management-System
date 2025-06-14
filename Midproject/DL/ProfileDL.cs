using Midproject.UI;
using System.Data;

namespace Midproject.DL
{
    class ProfileDL
    {
     
        public static DataTable GetAllFaculty()
        {
            string query = "SELECT faculty_id, name, email, designation_id, research_area, total_teaching_hours FROM faculty";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        
        public static int AddFaculty(string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            string query = $"INSERT INTO faculty (name, email, contact, designation_id, research_area, total_teaching_hours) " +
                           $"VALUES ('{name}', '{email}', '{contact}', {designationId}, '{researchArea}', {teachingHours})";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateFaculty(int facultyId, string name, string email, string contact, int designationId, string researchArea, int teachingHours)
        {
            string query = $"UPDATE faculty SET name='{name}', email='{email}', contact='{contact}', designation_id={designationId}, " +
                           $"research_area='{researchArea}', total_teaching_hours={teachingHours} WHERE faculty_id={facultyId}";
            return DatabaseHelper.Instance.Update(query);
        }

       
        public static int DeleteFaculty(int facultyId)
        {
    
            string checkQuery = $"SELECT COUNT(*) FROM faculty_courses WHERE faculty_id={facultyId}";
            var result = DatabaseHelper.Instance.GetDataTable(checkQuery);
            if (result.Rows.Count > 0 && result.Rows[0][0].ToString() != "0")
                return -1;

            string query = $"DELETE FROM faculty WHERE faculty_id={facultyId}";
            return DatabaseHelper.Instance.Update(query);
        }


        public static DataTable GetDesignations()
        {
            string query = "SELECT * FROM lookup WHERE category='designation'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}