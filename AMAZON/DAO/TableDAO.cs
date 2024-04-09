using AMAZON.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO()
        {

        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.spGet_Table_List");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertBAN(string maban, int soban, string tinhtrang)
        {
            string query = string.Format("insert into BAN (MaBan,SoBan,TinhTrang) values (N'{0}','{1}',N'{2}')", maban, soban, tinhtrang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateBAN(string maban, int soban, string tinhtrang)
        {
            string query = string.Format("UPDATE BAN SET TinhTrang = N'{2}'  WHERE MaBan = N'{0}' and Soban= {1}",maban, soban, tinhtrang);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteBAN(string maban, int soban, string tinhtrang )
        {
            string query = "Delete from BAN where SoBan= @soban";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { soban });


            return result > 0;
        }
    }
}
