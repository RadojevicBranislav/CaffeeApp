using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class OrderItemRepository
    {
        private ConstantParameters constant = new ConstantParameters();



        public int InsertOrderItem(OrderItem orderItem)
        {
            using (SqlConnection sqlConnection = new SqlConnection(constant.connectionString))
            {
                SqlCommand command = new SqlCommand();

                command.Connection = sqlConnection;

                command.CommandText = string.Format("INSERT INTO Order_Items VALUES({0},{1},{2})",
                    orderItem.ItemQuantity, orderItem.ItemId, orderItem.BillId);

                sqlConnection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
