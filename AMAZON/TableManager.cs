using AMAZON.DAO;
using AMAZON.DTO;
using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = AMAZON.DTO.Menu;

namespace AMAZON
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadFoodList();
        }

        #region Method
        void LoadFoodList()
        {
            List<Food> listFood = FoodDAO.Instance.GetListFood();
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "TenMon";
        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.MaBan + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.LawnGreen;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int mahoadoninfo)
        {
            lsbBill.Items.Clear();
            List<BillInfo> listBillInfo = BillInfoDAO.Instance.GetListBilInfo(mahoadoninfo);
            decimal tongtien = 0;
            foreach (BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Mahoadoninfo.ToString());
                lsvItem.SubItems.Add(item.Tenmon.ToString());
                lsvItem.SubItems.Add(item.Soluong.ToString());
                lsvItem.SubItems.Add(item.Thanhtien.ToString());
                tongtien += item.Thanhtien;
                lsbBill.Items.Add(lsvItem);

            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtTongTien.Text = tongtien.ToString("c", culture);
        }


        //void ShowBill(int soban)
        //{
        //lsvBill.Items.Clear();
        //List<BillInfo> listbillInfo1 = BillInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetBillSoBanByTableSoBan1(soban));
        //foreach (BillInfo item1 in listBillInfo)
        //{

        //    ListViewItem lsvItem1 = new ListViewItem(item1.MaHoaDon.ToString());
        //    lsvItem1.SubItems.Add(item1.TenMon.ToString());
        //    //lsvItem1.SubItems.Add(item1.SoLuong.ToString());
        //    //lsvItem1.SubItems.Add(item1.ThanhTien.ToString());
        //    lsvBill.Items.Add(lsvItem1);
        //}
        //}
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int maban = ((sender as Button).Tag as Table).Soban;
            //string mahoadon = ((sender as Button).Tag as Table).Name;
            ShowBill(maban);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Admin f = new Admin();
            //f.ShowDialog();
        }


        private void nmuQuanlymua_Click(object sender, EventArgs e)
        {
            FormQLMua qlyMua = new FormQLMua();
            qlyMua.ShowDialog();
        }
        private void mnuQuanLyBan_Click(object sender, EventArgs e)
        {
            FormQLBan qlyBan = new FormQLBan();
            qlyBan.ShowDialog();
        }


        #endregion

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsbBill.Tag as Table;
            int Soban = BillDAO.Instance.GetBillSoBanByTableSoBan(table.Soban);
            if (Soban != -1)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + table.Soban, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.Checkout(Soban);
                    ShowBill(table.Soban);
                }

            }
        }
    }
}