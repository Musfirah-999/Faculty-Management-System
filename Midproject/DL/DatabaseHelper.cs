using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Midproject.DL
{

    public class DatabaseHelper
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "midprojectdb";
        private string databaseUser = "root";
        private string databasePassword = "Musfirahzainab123@";
        private DatabaseHelper() { }
        private static DatabaseHelper? _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }
        public MySqlConnection getConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public MySqlDataReader getData(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, getConnection()))
                {
                    return command.ExecuteReader();
                }
            }
        }
        public int Update(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection)) 
                {
                    return command.ExecuteNonQuery();
                }
            }
        }

        internal object Query(string query)
        {
            throw new NotImplementedException();
        }
        public DataTable GetDataTable(string query)
        {
            var dataTable = new DataTable();
            using (var connection = getConnection())
            {
                using (var adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
        public bool Insert(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}