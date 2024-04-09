using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DTO
{
    public class Bill
    {
        public Bill(int mahoadon, int soban, string maban, DateTime? giovao, DateTime? giora, string makh, string manv)
        {
            this.Mahoadon = mahoadon;
            this.Soban = soban;
            this.Maban = maban;
            this.Giovao = giovao;
            this.Giora = giora;
            this.MaKH = makh;
            this.MaNV = manv;
        }
        public Bill(DataRow row)
        {
            this.Mahoadon = (int) row["mahoadon"];
            this.Soban = (int)row["soban"];
            this.Maban = row["soban"].ToString();
            var giovao = row["giovao"];
            if (giovao.ToString() != "")
                this.Giovao = (DateTime?)giovao;
            var giora = row["giora"];
            if (giora != null)
                this.Giora = (DateTime?)giora;
            this.MaKH = row["makh"].ToString();
            this.MaNV = row["manv"].ToString();
        }
        private DateTime? giovao;
        public DateTime? Giovao
        {
            get { return giovao; }
            set { giovao = value; }

        }
        private DateTime? giora;
        public DateTime? Giora
        {
            get { return giora; }
            set { giora = value; }

        }

        private int mahoadon;
        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        private int soban;
        public int Soban { get => soban; set => soban = value; }
        private string maban;
        public string Maban { get => maban; set => maban = value; }

        private string makh;
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }

        }
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }

        }

        /*
        public Bill(int mahoadon, int soban, DateTime? giovao, DateTime? giora, string makh, string manv)
        {
            this.MaHoaDon = mahoadon;
            this.SoBan = soban;
            this.GioVao = giovao;
            this.GioRa = giora;
            this.MaKH = makh;
            this.MaNV = manv;

        }
        public Bill(DataRow row)
        {

            this.MaHoaDon = (int)row["mahoadon"];
            this.SoBan = (int)row["soban"];
            var giovao = row["giovao"];
            if (giovao.ToString() != "")
                this.GioVao = (DateTime?)giovao;
            var giora = row["giora"];
            if (giora != null)
                this.GioRa = (DateTime?)giora;
            this.MaKH = row["makh"].ToString();
            this.MaNV = row["manv"].ToString();
        }
        private int mahoadon;
        public int MaHoaDon
        {
            get { return mahoadon; }
            set { mahoadon = value; }

        }
        private int soban;
        public int SoBan
        {
            get { return soban; }
            set { soban = value; }

        }
        private DateTime? giovao;
        public DateTime? GioVao
        {
            get { return giovao; }
            set { giovao = value; }

        }
        private DateTime? giora;
        public DateTime? GioRa
        {
            get { return giora; }
            set { giora = value; }

        }

        private string makh;
        public string MaKH
        {
            get { return makh; }
            set { makh = value; }

        }
        private string manv;
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }

        }
        */
    }
}
