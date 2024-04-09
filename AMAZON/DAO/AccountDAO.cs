using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AMAZON.DAO;
using System.Data;

namespace AMAZON.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO()
        { }

        public bool Login(string userName, string passWord)
        {
            string query = "select * from dbo.NHANVIEN where TenNV = N'" + userName + "' And MatKhau= '" + passWord +"' ";
            //string query = "select * from dbo.NHANVIEN where TenNV = N'Admin' and MatKhau= '0123456789'";
            DataTable result = (DataTable)DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
