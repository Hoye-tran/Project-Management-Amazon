using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DTO
{
    public class Table
    {
        //public Table (string name, int soban, string status)
        //{
        //    this.Name = name;
        //    this.Soban = soban;
        //    this.Status = status;
        //}

        //public Table(DataRow row)
        //{
        //    this.Name =row["maban"].ToString();
        //    this.Soban = (int)row["soban"];
        //    this.Status = row["tinhtrang"].ToString();
        //}

        //private string status;
        //public string Status
        //{
        //    get { return status; }
        //    set { status = value; }
        //}
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //private int soban;

        //public int Soban
        //{
        //    get { return soban; }
        //    set { soban = value; }
        //}

        //public static implicit operator string(Table v)
        //{
        //    throw new NotImplementedException();
        //}
        public Table(string maban, int soban, string status)
        {
            this.MaBan = maban;
            this.Soban = soban;
            this.Status = status;
        }
        public Table(DataRow row)
        {
            this.MaBan = row["maban"].ToString();
            this.Soban = (int)row["soban"];
            this.Status = row["tinhtrang"].ToString();
        }

        private string maban;
        public string MaBan
        {
            get { return maban; }
            set { maban = value; }
        }
        private int soban;
        public int Soban
        {
            get { return soban; }
            set { soban = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}

