using AMAZON.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DAO
{

    public class BillInfoDAO
    {
        
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo1(int mahoadon)
        {
            List<BillInfo> listBillInfo1 = new List<BillInfo>();
            // Sửa truy vấn để lấy thêm giá (DonGia) của mỗi món
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT c.MaHoaDon, c.TenMon, c.SoLuong, m.GiaTien " +
                                                                "FROM dbo.THANH_TOAN_HD_CHI_TIET c " +
                                                                "INNER JOIN dbo.MON m ON c.TenMon = m.TenMon " +
                                                                "WHERE c.MaHoaDon = " + mahoadon);

            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                // Tính toán thành tiền và gán vào đối tượng BillInfo1
                info.Thanhtien = Convert.ToInt32(item["SoLuong"]) * Convert.ToInt32(item["GiaTien"]);
                listBillInfo1.Add(info);
            }

            return listBillInfo1;

        }
        public List<BillInfo> GetListBilInfo (int mahoadoninfo)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select *from dbo.THANH_TOAN_HD_CHI_TIET where MaHoaDon= " + mahoadoninfo);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        /*
        internal List<BillInfo> GetListBilInfo(int v)
        {
            throw new NotImplementedException();
        }
        */
        /*
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(string mahoadon)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select MaHoaDon, TenMon, SoLuong from dbo.THANH_TOAN_HD_CHI_TIET where MaHoaDon= " + mahoadon);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }*/
    }
}
