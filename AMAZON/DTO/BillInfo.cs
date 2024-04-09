using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DTO
{
    public class BillInfo
    {
        
        public BillInfo(int mahoadoninfo, string tenmon, int soluong, decimal thanhtien)
        {
            this.Mahoadoninfo  = mahoadoninfo;
            this.Tenmon = tenmon;
            this.Soluong = soluong;
            this.Thanhtien = thanhtien;
        }
        public BillInfo(DataRow row)
        {
            this.Mahoadoninfo = (int)row["mahoadon"];
            this.Tenmon = row["tenmon"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Thanhtien =(decimal)Convert.ToDouble(row["thanhtien"].ToString());
        }

        private decimal thanhtien;

        public decimal Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private string tenmon;

        public string Tenmon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        private int mahoadoninfo;

        public int Mahoadoninfo
        {
            get { return mahoadoninfo; }
            set { mahoadoninfo = value; }
        }


        }
        /*
        public BillInfo(string mahoadon, string tenmon, int soluong, float thanhtien)
        {
            this.MaHoaDon = mahoadon;
            this.TenMon = tenmon;
            this.SoLuong = soluong;
            //this.ThanhTien = thanhtien;

        }
        public BillInfo(DataRow row)
        {
            this.MaHoaDon = row["mahoadon"].ToString();
            this.TenMon = row["tenmon"].ToString();
            this.SoLuong = (int)row["soluong"];
            //this.ThanhTien =(float)Convert.ToDouble(row["thanhtien"].ToString());
        }
        private string mahoadon;
        public string MaHoaDon
        {
            get { return mahoadon; }
            set { mahoadon = value; }

        }
        private string tenmon;
        public string TenMon
        {
            get { return tenmon; }
            set { tenmon = value; }

        }
        private int soluong;
        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }

        }
        private float thanhtien;
        public float ThanhTien
        {
            get { return thanhtien; }
            set { thanhtien = value; }

        }*/
    }

