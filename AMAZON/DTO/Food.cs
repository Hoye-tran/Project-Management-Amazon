using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMAZON.DTO
{
    public class Food
    {
        public Food(string tenmon, int giatien)
        {
            this.TenMon = tenmon;
            this.GiaTien = giatien;
        }
        public Food(DataRow row)
        {
            this.TenMon = row["tenmon"].ToString();
            //this.TenMon = row["tenmon"].ToString();

            // Use int.TryParse to handle the conversion safely
            if (int.TryParse(row["giatien"].ToString(), out int giatien))
            {
                this.GiaTien = giatien;
            }
            else
            {
                // Handle the case where the conversion fails (e.g., log a warning, set a default value, etc.)
                // For now, setting a default value of 0, but adjust as needed.
                this.GiaTien = 0;
            }


        }
        private string tenmon;
        public string TenMon
        {
            get { return tenmon; }
            private set { tenmon = value; }
        }
        private int giatien;
        public int GiaTien
        {
            get { return giatien; }
            private set { giatien = value; }
        }
    }
}
