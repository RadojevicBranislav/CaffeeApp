using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaffeeData;
using CaffeeData.Models;
namespace CaffeBusiness
{
    public class TableBusiness
    {
        //instance of TableRepository that allows us to access methods of data layer
        private readonly TableRepository tableRepository = new TableRepository();

        //method that calls GetAllTable from tableRepository class and returns list of all tables
        public List<Table> getAllTables()
        {
            List<Table> tables = tableRepository.GetAllTables();
            return tables;

        }
        //method that pasess table object to InsertTable method on dataLayer
        public bool insertTable(Table t)
        {
            return tableRepository .InsertTable(t) != 0;
        }
        //method that is used to pass number of a table and his new cordinates 
        public bool updateTable(int table_num, int pos_w, int pos_h)
        {
            return tableRepository.UpdatePosition(table_num, pos_w, pos_h) != 0;
        }
        //method that changes if table is occupied
        public bool changeOccupancy(int table_num, bool occupied)
        {
            return tableRepository.ChangeOccupancy(table_num, occupied) != 0;
        }
        //method that returns true if record is deleted
        public bool deleteTable(int tableNum)
        {
            return tableRepository.DeleteTable(tableNum) != 0;  
        }
        //public int returnLatestId()
        //{
        //    return tableRepository.GetLatestId();
        //}
        
    }
}
