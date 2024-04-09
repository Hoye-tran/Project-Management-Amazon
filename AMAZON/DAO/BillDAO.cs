using AMAZON.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }
        //Thành công: bill id
        //Thất bại: null
        
        public string GetUncheckBillIDByTableID(int mahoadon)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" select * from dbo.THANH_TOAN_HD where MaHoaDon=" + mahoadon + "and MaBan = 'B.05'");
            
            if (data.Rows.Count>0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Maban.ToString();
            }
            return null;
        }
        public int GetBillSoBanByTableSoBan(int soban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from dbo.THANH_TOAN_HD where SoBan = '" + soban + "'");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Soban;
            }
            return -1;
        }
        public void Checkout(int soban)
        {
            string query = "update BAN set TinhTrang='Đang phục vụ' where SoBan=" + soban;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        /*
        public int GetBillSoBanByTableSoBan1(int soban)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select *from dbo.THANH_TOAN_HD where SoBan=" + soban);
            if (data.Rows.Count > 0)
            {
                Bill bill1 = new Bill(data.Rows[0]);
                return bill1.SoBan;
            }
            return -1;
        }*/
    }
}
