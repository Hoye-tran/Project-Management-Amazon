using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAZON.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) Instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(string maban1)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "select c.TenMon,a.SoLuong,c.GiaTien ,c.GiaTien*a.SoLuong as N'Thành Tiền' from dbo.THANH_TOAN_HD_CHI_TIET as a, dbo.THANH_TOAN_HD as b, dbo.MON as c where a.MaHoaDon = b.MaHoaDon and a.TenMon = c.TenMon and b.MaBan =" + maban1;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new AMAZON.DTO.Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
