using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class ProjectDL
    {
        public static DataTable GetAllProjects()
        {
            string query = "SELECT * FROM projects";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int AddProject(int project_id, string project_name, string description)
        {
            string query = $"INSERT INTO projects (project_id, title, description) VALUES ({project_id}, '{project_name}', '{description}')";
            return DatabaseHelper.Instance.Update(query);
        }

        public static int UpdateProject(int project_id, string project_name, string description)
        {
            string query = $"UPDATE projects SET title = '{project_name}' , description = '{description}'  WHERE project_id = {project_id}";
            return DatabaseHelper.Instance.Update(query);
        }
        public static int DeleteProject(int project_id)
        {

            string checkQuery = $"SELECT COUNT(*) FROM faculty_projects WHERE project_id = {project_id}";
            DataTable result = DatabaseHelper.Instance.GetDataTable(checkQuery);
            if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
                return -1;

            string deleteQuery = $"DELETE FROM projects WHERE project_id = {project_id}";
            return DatabaseHelper.Instance.Update(deleteQuery);
        }

    }
}

