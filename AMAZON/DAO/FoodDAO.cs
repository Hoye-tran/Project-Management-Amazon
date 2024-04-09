using AMAZON.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }
        /*
        public List<Food> GetFoodBy(string tenmon)
        {
            List<Food> list = new List<Food>();
            string query = "select * from MON where TenMon= " + tenmon;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }*/
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select *from MON ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        //Thêm
        public bool InsertMON(string tenmon, int giatien)
        {
            string query = string.Format("insert into MON (TenMon,GiaTien) values (N'{0}','{1}')", tenmon, giatien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //public bool DeleteMON(string tenmon, int giatien)
        //{
        //    string query = string.Format("delete from MON where (N'{0}','{1}')", tenmon, giatien);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

        //sửa
        public bool UpdateMON(string tenmon, int giatien)
        {
            string query = string.Format("UPDATE MON SET GiaTien = '{1}' WHERE TenMon = N'{0}'", tenmon, giatien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //Xóa
        public bool DeleteMON(string tenmon, int giatien)
        {
            string query = "Delete from MON where TenMon= @tenmon";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenmon });


            return result > 0;
        }
    }
}
