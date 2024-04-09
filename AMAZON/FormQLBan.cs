using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AMAZON.DAO;

namespace AMAZON
{
    public partial class FormQLBan : Form
    {


        public FormQLBan()
        {
            InitializeComponent();
            LoadFoodList();
            //LoadAccountList();
            LoadTableList();
        }
     
        void LoadFoodList()
        {
             string query = "select * from dbo.MON";
             dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {
             string query = "select MaNV, TenNV from dbo.NHANVIEN";
             //dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void LoadTableList()
        {
            string query = "select * from dbo.BAN";
            dtgvTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string tenmon = txbFoodName.Text;
            int giatien = (int)nmFoodPrice.Value;

            if (FoodDAO.Instance.InsertMON(tenmon, giatien))
            {
                MessageBox.Show("Thêm món thành công");
                LoadFoodList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm món");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string tenmon = txbFoodName.Text;
            int giatien = (int)nmFoodPrice.Value;

            if (FoodDAO.Instance.DeleteMON(tenmon, giatien))
            {
                MessageBox.Show("Xóa hóa đơn thành công");
                LoadFoodList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string tenmon = txbFoodName.Text;
            int giatien = (int)nmFoodPrice.Value;

            if (FoodDAO.Instance.UpdateMON(tenmon, giatien))
            {
                MessageBox.Show("Sửa món thành công");
                LoadFoodList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa món");
            }
        }
        //Table
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string maban = txbTableName.Text;
            int soban = (int)numericBan.Value;
            string tinhtrang = txbTableStatus.Text;
            if (TableDAO.Instance.InsertBAN(maban, soban,tinhtrang))
            {
                MessageBox.Show("Thêm bàn thành công");
                LoadTableList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm bàn");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string maban = txbTableName.Text;
            int soban = (int)numericBan.Value;
            string tinhtrang = txbTableStatus.Text;
            if (TableDAO.Instance.UpdateBAN(maban, soban,tinhtrang))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadTableList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string maban = txbTableName.Text;
            int soban = (int)numericBan.Value;
            string tinhtrang= txbTableStatus.Text;
            if (TableDAO.Instance.DeleteBAN(maban, soban,tinhtrang))
            {
                MessageBox.Show("Xóa bàn thành công");
                LoadTableList();

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa bàn");
            }
        }
    }
}
