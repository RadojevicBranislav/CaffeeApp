using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class BillRepository
    {
        //creating ConstantParameters class, to get a connection string from it
        private ConstantParameters constant = new ConstantParameters();
        
        //returning all bills from database
        public List<Bill> GetAllBills()
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = "SELECT * FROM Bills";

                List<Bill> bills = new List<Bill>();

                sqlConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    Bill b = new Bill();

                    b.Id = dataReader.GetInt32(0);

                    b.DateOfIssue = dataReader.GetDateTime(1);

                    b.TableId = dataReader.GetInt32(2);

                    bills.Add(b);
                }

                return bills;
            }
        }

        //Insering bill into database
        public int InsertBill(Bill b)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Bills VALUES('{0}', {1})", b.formattedDate, b.TableId);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
