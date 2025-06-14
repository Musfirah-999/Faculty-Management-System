using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midproject.DL
{
    public class coursescheduleDL
    {
        public static DataTable GetAllSchedules()
        {
            string query = "SELECT * FROM faculty_course_schedule";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static bool IsScheduleConflict(int facultyCourseId, string day)
        {
            string query = $"SELECT * FROM faculty_course_schedule WHERE faculty_course_id = {facultyCourseId} AND day_of_week = '{day}'";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0;
        }

 
        public static int AddSchedule(int facultyCourseId, int roomId, string day, string startTime, string endTime)
        {
            string query = $"INSERT INTO faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) " +
                           $"VALUES ({facultyCourseId}, {roomId}, '{day}', '{startTime}', '{endTime}')";
            return DatabaseHelper.Instance.Update(query);
        }

   
        public static int UpdateSchedule(int scheduleId, int facultyCourseId, int roomId, string day, string startTime, string endTime)
        {
            string query = $"UPDATE faculty_course_schedule SET faculty_course_id = {facultyCourseId}, room_id = {roomId}, " +
                           $"day_of_week = '{day}', start_time = '{startTime}', end_time = '{endTime}' " +
                           $"WHERE schedule_id = {scheduleId}";
            return DatabaseHelper.Instance.Update(query);
        }

       
        public static int DeleteSchedule(int scheduleId)
        {
            string query = $"DELETE FROM faculty_course_schedule WHERE schedule_id = {scheduleId}";
            return DatabaseHelper.Instance.Update(query);
        }

        public static DataTable GetFacultyCourseIds()
        {
            string query = "SELECT faculty_course_id FROM faculty_courses";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

      
        public static DataTable GetRooms()
        {
            string query = "SELECT room_id, room_name FROM rooms";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }

}
