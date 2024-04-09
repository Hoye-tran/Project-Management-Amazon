using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DTO
{
    public class Menu
    {
        public Menu(string tenmon, int sl, decimal giatien, decimal thanhtien)
        {
            this.Tenmon = tenmon;
            this.SL = sl;
            this.Giatien = giatien;
            this.Thanhtien = thanhtien;
        }
        public Menu(DataRow row)
        {
            this.Tenmon = row["tenmon"].ToString();
            this.SL = Convert.ToInt32(row["sl"]);
            this.Giatien = Convert.ToDecimal(row["giatien"]);
            this.Thanhtien = Convert.ToDecimal(row["thanhtien"]);
        }

        private string tenmon;
        public string Tenmon
        {
            get { return tenmon; }
            private set { tenmon = value; }
        }
        private int sl;
        public int  SL
        {
            get { return sl; }
            private set { sl = value; }
        }
        private decimal thanhtien;
        public decimal Thanhtien
        {
            get { return thanhtien; }
            private set { thanhtien = value; }
        }
        private decimal giatien;
        public decimal Giatien
        {
            get { return giatien; }
            private set { giatien = value; }
        }

        public static implicit operator System.Windows.Forms.Menu(Menu v)
        {
            throw new NotImplementedException();
        }
    }
}
