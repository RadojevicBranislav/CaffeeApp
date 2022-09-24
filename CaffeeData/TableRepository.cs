using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class TableRepository
    {
        private ConstantParameters constant = new ConstantParameters();

        public List<Table> GetAllTables()
        {
            using(SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM Tables";

                List<Table> tables = new List<Table>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    Table t = new Table();

                    t.Id = dataReader.GetInt32(0);

                    t.Occupied = dataReader.GetBoolean(1);

                    t.position_w = dataReader.GetInt32(2);

                    t.position_h = dataReader.GetInt32(3);

                    tables.Add(t);
                }

                return tables;

            }
        }

        public int InsertTable(Table t)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Tables VALUES({0}, {1}, {2})",
                   ocupied_check(t.Occupied),t.position_w,t.position_h);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }

        public int UpdatePosition(int table_num, int pos_w, int pos_h)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("UPDATE Tables SET position_w = {0}, position_h = {1} WHERE table_number = {2}",
                    pos_w, pos_h, table_num);

                return command.ExecuteNonQuery();
            }
        }

        //prosledjuje se trenutna vrednost occupied u programu
        public int ChangeOccupancy(int table_num, bool occupied)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("UPDATE Tables SET occupied = {0} WHERE table_number = {1}",
                    ocupied_check(occupied), table_num);

                return command.ExecuteNonQuery();
            }
        }

        public int DeleteTable(int tableNum)
        {
            using(SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;
                
                command.CommandText = string.Format("DELETE FROM Tables WHERE table_number = {0}", 
                    tableNum);
                
                return command.ExecuteNonQuery();
            }
        } 
        public int ocupied_check(bool check)
        {
            if (check)
                return 1;
            else 
                return 0;
        }
        
    }
}
