using AMAZON.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAZON
{
    public partial class FormQLMua : Form
    {
        DataTable tblCTHDB, tblNCC, tblNMH, tblHH;
        public FormQLMua()
        {
            InitializeComponent();
            dgvHD.CellClick += dgvHD_CellClick;

        }


        private void LoadDataGridView()
        {
            // Bảng Hàng hóa
            if (tabHH.SelectedTab == tabHDMCT)
            {
                string sqlDetails = "SELECT a.MaDatHang, b.MaHH, a.SoLuongHH, a.ThanhTienHH FROM MUA_CHI_TIET AS a, HANGHOA AS b WHERE a.MaDatHang = N'" + textMDH.Text + "' AND a.MaHH = b.MaHH";
                SqlParameter[] parametersDetails =
                    {
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text }
                    };
                tblCTHDB = FunctionS.GetDataToTable(sqlDetails, parametersDetails);
                dgvHD.DataSource = tblCTHDB;
                dgvHD.Columns[0].HeaderText = "Mã đặt hàng";
                dgvHD.Columns[1].HeaderText = "Mã hàng hóa";
                dgvHD.Columns[2].HeaderText = "Số lượng";
                dgvHD.Columns[3].HeaderText = "Thành tiền";
                dgvHD.Columns[0].Width = 120;
                dgvHD.Columns[1].Width = 130;
                dgvHD.Columns[2].Width = 80;
                dgvHD.Columns[3].Width = 100;

                dgvHD.AllowUserToAddRows = false;
                dgvHD.EditMode = DataGridViewEditMode.EditProgrammatically;

                string sqlOrders = "SELECT * FROM MUA";
                SqlParameter[] parameters = new SqlParameter[0]; // Khởi tạo mảng rỗng vì truy vấn không yêu cầu tham số
                tblCTHDB = FunctionS.GetDataToTable(sqlOrders, parameters);
                dgvHDMCT.DataSource = tblCTHDB;
                dgvHDMCT.Columns[0].HeaderText = "Mã đặt hàng";
                dgvHDMCT.Columns[1].HeaderText = "Mã nhà cung cấp";
                dgvHDMCT.Columns[2].HeaderText = "Mã nhân viên";
                dgvHDMCT.Columns[3].HeaderText = "Ngày mua hàng";
                dgvHDMCT.Columns[4].HeaderText = "Tổng tiền";

                dgvHDMCT.Columns[0].Width = 160;
                dgvHDMCT.Columns[1].Width = 160;
                dgvHDMCT.Columns[2].Width = 160;
                dgvHDMCT.Columns[3].Width = 160;
                dgvHDMCT.Columns[4].Width = 180;

                dgvHDMCT.AllowUserToAddRows = false;
                dgvHDMCT.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            if (tabHH.SelectedTab == tabPageNCC)
            {
                string sql = "SELECT MaNCC, TenNCC, DiaChi, SDT FROM NHACUNGCAP";
                SqlParameter[] parameters = new SqlParameter[0]; // Khởi tạo mảng rỗng vì truy vấn không yêu cầu tham số
                tblNCC = FunctionS.GetDataToTable(sql, parameters);

                // Cài đặt các thuộc tính cho DataGridView
                dataGridViewNCC.DataSource = tblNCC; //Nguồn dữ liệu            
                dataGridViewNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
                dataGridViewNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
                dataGridViewNCC.Columns[2].HeaderText = "Địa chỉ";
                dataGridViewNCC.Columns[3].HeaderText = "Số điện thoại";
                dataGridViewNCC.Columns[0].Width = 100;
                dataGridViewNCC.Columns[1].Width = 180;
                dataGridViewNCC.Columns[2].Width = 450;
                dataGridViewNCC.Columns[3].Width = 100;

                dataGridViewNCC.AllowUserToAddRows = false;
                dataGridViewNCC.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            if (tabHH.SelectedTab == tabPageNMH)
            {
                string sql = "SELECT MaNV, TenNV FROM NHANVIEN";
                SqlParameter[] parameters = new SqlParameter[0]; // Khởi tạo mảng rỗng vì truy vấn không yêu cầu tham số
                tblNMH = FunctionS.GetDataToTable(sql, parameters);
                dataGridViewNMH.DataSource = tblNMH;
                dataGridViewNMH.Columns["MaNV"].HeaderText = "Mã người mua";
                dataGridViewNMH.Columns["TenNV"].HeaderText = "Tên người mua";

                dataGridViewNMH.Columns["MaNV"].Width = 300;
                dataGridViewNMH.Columns["TenNV"].Width = 550;

                dataGridViewNMH.AllowUserToAddRows = false;
                dataGridViewNMH.EditMode = DataGridViewEditMode.EditProgrammatically;//Không cho sửa dữ liệu trực tiếp
            }
            if (tabHH.SelectedTab == tabPageHH)
            {
                string sql;
                sql = "SELECT MaHH, TenHH,DonViTinhHH,DonGiaHH FROM HANGHOA";
                //Function.Connect();
                SqlParameter[] parameters = new SqlParameter[0]; // Khởi tạo mảng rỗng vì truy vấn không yêu cầu tham số
                tblHH = FunctionS.GetDataToTable(sql, parameters);
                dataGridViewHanghoa.DataSource = tblHH; //Nguồn dữ liệu            
                dataGridViewHanghoa.Columns[0].HeaderText = "Mã hàng hóa";
                dataGridViewHanghoa.Columns[1].HeaderText = "Tên hàng hóa";
                dataGridViewHanghoa.Columns[2].HeaderText = "Đơn vị tính";
                dataGridViewHanghoa.Columns[3].HeaderText = "Đơn giá";
                dataGridViewHanghoa.Columns[0].Width = 150;
                dataGridViewHanghoa.Columns[1].Width = 400;
                dataGridViewHanghoa.Columns[2].Width = 120;
                dataGridViewHanghoa.Columns[3].Width = 150;
                dataGridViewHanghoa.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
                dataGridViewHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
            }

        }
        // Bảng hàng hóa
        private void dataGridViewHanghoa_Click(object sender, EventArgs e)
        {
            if (buttonThemHH.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaHH.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBoxMaHH.Text = dataGridViewHanghoa.CurrentRow.Cells["MaHH"].Value.ToString();
            textBoxTenHH.Text = dataGridViewHanghoa.CurrentRow.Cells["TenHH"].Value.ToString();
            textBoxDVTHH.Text = dataGridViewHanghoa.CurrentRow.Cells["DonViTinhHH"].Value.ToString();
            numerDonGia.Text = dataGridViewHanghoa.CurrentRow.Cells["DonGiaHH"].Value.ToString();

            buttonSuaHH.Enabled = true;
            buttonXoaHH.Enabled = true;
        }
        //Thêm hàng hóa
        private void buttonThemHH_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (textBoxMaHH.Text.Trim().Length == 0 || textBoxTenHH.Text.Trim().Length == 0 || textBoxDVTHH.Text.Trim().Length == 0 || numerDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "Select MaHH From HANGHOA where MaHH=@MaHH";
            SqlParameter[] checkKeyParameters =
                {
                new SqlParameter("@MaHH", textBoxMaHH.Text.Trim())
                };

            if (FunctionS.CheckKey(sql, checkKeyParameters))
            {
                MessageBox.Show("Mã hàng hóa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaHH.Focus();
                return;
            }

            sql = "INSERT INTO HANGHOA VALUES(@MaHH, @TenHH, @DVTHH, @DonGia)";
            SqlParameter[] insertParameters =
                {
                    new SqlParameter("@MaHH", textBoxMaHH.Text.Trim()),
                    new SqlParameter("@TenHH", textBoxTenHH.Text.Trim()),
                    new SqlParameter("@DVTHH", textBoxDVTHH.Text.Trim()),
                    new SqlParameter("@DonGia", numerDonGia.Text.Trim())
                };

            FunctionS.RunSQL(sql, insertParameters); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
        }
        //Sửa hàng hóa
        private void buttonSuaHH_Click(object sender, EventArgs e)
        {

            string sql; //Lưu câu lệnh sql
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxMaHH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxTenHH.Text.Trim().Length == 0 || textBoxDVTHH.Text.Trim().Length == 0 || numerDonGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE HANGHOA SET TenHH=@TenHH, DonViTinhHH=@DVTHH, DonGiaHH=@DonGia WHERE MaHH=@MaHH";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@TenHH", textBoxTenHH.Text.Trim()),
                    new SqlParameter("@DVTHH", textBoxDVTHH.Text.Trim()),
                    new SqlParameter("@DonGia", numerDonGia.Text.Trim()),
                    new SqlParameter("@MaHH", textBoxMaHH.Text.Trim())
                };

            FunctionS.RunSQL(sql, parameters);
            LoadDataGridView();
            ResetValue();
        }
        //Xóa hàng hóa
        private void buttonXoaHH_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBoxMaHH.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM HANGHOA WHERE MaHH=@MaHH";
                SqlParameter[] deleteParameters =
                    {
                        new SqlParameter("@MaHH", textBoxMaHH.Text)
                    };
                FunctionS.RunSQL(sql, deleteParameters);
                LoadDataGridView();
                ResetValue();
            }
        }
        private void ResetValue()
        {
            textBoxMaHH.Text = "";
            textBoxTenHH.Text = "";
            textBoxDVTHH.Text = "";
            numerDonGia.Text = "0";
        }
        // Bảng nhà cung cấp
        private void dataGridViewNCC_Click(object sender, EventArgs e)
        {
            if (btnThemNCC.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaNCC.Focus();
                return;
            }

            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            textBoxMaNCC.Text = dataGridViewNCC.CurrentRow.Cells["MaNCC"].Value.ToString();
            textBoxTenNCC.Text = dataGridViewNCC.CurrentRow.Cells["TenNCC"].Value.ToString();
            textBoxDiaChiNCC.Text = dataGridViewNCC.CurrentRow.Cells["DiaChi"].Value.ToString();
            textBoxSDT.Text = dataGridViewNCC.CurrentRow.Cells["SDT"].Value.ToString();

            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;

        }
        //Thêm nhà cung cấp
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra và thông báo lỗi nếu có
            string sql;
            if ((textBoxMaNCC.Text.Trim().Length == 0 || (textBoxTenNCC.Text.Trim()).Length == 0 || (textBoxDiaChiNCC.Text.Trim()).Length == 0 || (textBoxSDT.Text.Trim()).Length == 0))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Select MaNCC From NHACUNGCAP where MaNCC=@MaNCC";
            SqlParameter[] checkKeyParameters =
                {
                    new SqlParameter("@MaNCC", textBoxMaNCC.Text.Trim())
                };

            if (FunctionS.CheckKey(sql, checkKeyParameters))
            {
                MessageBox.Show("Mã nhà cung cấp này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaNCC.Focus();
                return;
            }
            sql = "INSERT INTO NHACUNGCAP VALUES(@MaNCC, @TenNCC, @DiaChi, @SDT)";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@MaNCC", textBoxMaNCC.Text.Trim()),
                    new SqlParameter("@TenNCC", textBoxTenNCC.Text.Trim()),
                    new SqlParameter("@DiaChi", textBoxDiaChiNCC.Text.Trim()),
                    new SqlParameter("@SDT", textBoxSDT.Text.Trim())
                };



            FunctionS.RunSQL(sql, parameters); // Thực hiện câu lệnh SQL
            LoadDataGridView(); // Nạp lại DataGridView
                                //ResetValue(); // Không rõ ResetValue() được định nghĩa ở đâu, nếu đã có thể sử dụng nó để làm sạch TextBoxes.
            ResetValueNCC();
        }
        //Sửa Nhà cung cấp
        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra và thông báo lỗi nếu có
            if (string.IsNullOrEmpty(textBoxMaNCC.Text.Trim()) || string.IsNullOrEmpty(textBoxTenNCC.Text.Trim()) || string.IsNullOrEmpty(textBoxDiaChiNCC.Text.Trim()) || string.IsNullOrEmpty(textBoxSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "UPDATE NHACUNGCAP SET TenNCC=@TenNCC, DiaChi=@DiaChi, SDT=@SDT WHERE MaNCC=@MaNCC";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@TenNCC", textBoxTenNCC.Text.Trim()),
                    new SqlParameter("@DiaChi", textBoxDiaChiNCC.Text.Trim()),
                    new SqlParameter("@SDT", textBoxSDT.Text.Trim()),
                    new SqlParameter("@MaNCC", textBoxMaNCC.Text.Trim())
                };

            FunctionS.RunSQL(sql, parameters); // Thực hiện câu lệnh SQL
            LoadDataGridView(); // Nạp lại DataGridView
            ResetValueNCC();
        }
        //Xóa Nhà cung cấp
        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            // Kiểm tra và thông báo lỗi nếu có
            if (string.IsNullOrEmpty(textBoxMaNCC.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "DELETE FROM NHACUNGCAP WHERE MaNCC=@MaNCC";
            SqlParameter parameter = new SqlParameter("@MaNCC", textBoxMaNCC.Text.Trim());

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FunctionS.RunSQL(sql, new SqlParameter[] { parameter });
                LoadDataGridView();
                ResetValueNCC(); // Nếu đã có hàm ResetValue được định nghĩa ở đâu, bạn có thể sử dụng nó để làm sạch TextBoxes.
            }

        }

        private void ResetValueNCC()
        {
            textBoxMaNCC.Text = "";
            textBoxTenNCC.Text = "";
            textBoxDiaChiNCC.Text = "";
            textBoxSDT.Text = "";
        }

        // Bảng người mua hàng
        private void dataGridViewNMH_Click(object sender, EventArgs e)
        {
            if (btnThemNV.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaNMH.Focus();
                return;
            }

            if (tblNMH == null || tblNMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridViewNMH.CurrentRow != null)
            {
                textBoxMaNMH.Text = dataGridViewNMH.CurrentRow.Cells["MaNV"].Value?.ToString();
                textBoxTenNMH.Text = dataGridViewNMH.CurrentRow.Cells["TenNV"].Value?.ToString();
            }

            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = true;
        }
        //Thêm Người mua hàng
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ResetValue(); // Xoá trắng các textbox
            textBoxMaNMH.Enabled = true; // Cho phép nhập mới
            textBoxMaNMH.Focus();
            string sql; // Lưu lệnh sql

            if (textBoxTenNMH.Text.Trim().Length == 0) // Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên người mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxTenNMH.Focus();
                return;
            }

            sql = "Select MaNV From NHANVIEN where MaNV=@MaNV";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", textBoxMaNMH.Text.Trim()) };
            if (FunctionS.CheckKey(sql, parameters))
            {
                MessageBox.Show("Mã người mua này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMaNMH.Focus();
                return;
            }

            sql = "INSERT INTO NHANVIEN(MaNV, TenNV) VALUES(@MaNV, @TenNV)";
            SqlParameter[] insertParams =
                {
                    new SqlParameter("@MaNV", textBoxMaNMH.Text.Trim()),
                    new SqlParameter("@TenNV", textBoxTenNMH.Text.Trim())
                };
            FunctionS.RunSQL(sql, insertParams); // Thực hiện câu lệnh sql
            LoadDataGridView(); // Nạp lại DataGridView
            ResetValueNV();
        }
        //Sửa Người mua hàng
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (tblNMH.Rows.Count == 0 || string.IsNullOrEmpty(textBoxMaNMH.Text))
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "UPDATE NHANVIEN SET TenNV=@TenNV WHERE MaNV=@MaNV";
            SqlParameter[] updateParams =
                {
                    new SqlParameter("@TenNV", textBoxTenNMH.Text.Trim()),
                    new SqlParameter("@MaNV", textBoxMaNMH.Text.Trim())
                };
            FunctionS.RunSQL(sql, updateParams);
            LoadDataGridView();
            ResetValueNV();
        }
        //Xóa Người mua hàng
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNMH.Rows.Count == 0 || string.IsNullOrEmpty(textBoxMaNMH.Text))
            {
                MessageBox.Show("Vui lòng chọn một bản ghi để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE NHANVIEN WHERE MaNV=@MaNV";
                SqlParameter[] deleteParams =
                    {
                        new SqlParameter("@MaNV", textBoxMaNMH.Text.Trim())
                    };
                FunctionS.RunSQL(sql, deleteParams);
                LoadDataGridView();
                ResetValueNV();
            }

        }
        private void ResetValueNV()
        {
            textBoxMaNMH.Text = "";
            textBoxTenNMH.Text = "";

        }

        //Thêm hóa đơn
        private void btnThemHDMua_Click(object sender, EventArgs e)
        {
            textMDH.Enabled = true; // Cho phép nhập mới
            textMDH.Focus();
            LoadDataGridView();

            string sql = "SELECT MaDatHang FROM MUA WHERE MaDatHang=@MaDatHang";
            SqlParameter[] parameters = { new SqlParameter("@MaDatHang", SqlDbType.NVarChar) };
            parameters[0].Value = textMDH.Text;

            if (!FunctionS.CheckKey(sql, parameters))
            {
                // Thêm thông tin mới vào bảng MUA
                sql = "INSERT INTO MUA(MaDatHang, MaNCC, MaNV, NgayMuaHang, TongTienHH) VALUES (@MaDatHang, @MaNCC, @MaNV, @NgayMuaHang, @TongTienHH)";
                SqlParameter[] insertParameters =
                    {
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar),
                        new SqlParameter("@MaNCC", SqlDbType.NVarChar),
                        new SqlParameter("@MaNV", SqlDbType.NVarChar),
                        new SqlParameter("@NgayMuaHang", SqlDbType.DateTime),
                        new SqlParameter("@TongTienHH", SqlDbType.NVarChar)
                    };

                insertParameters[0].Value = textMDH.Text.Trim();
                insertParameters[1].Value = comboNCC.SelectedValue;
                insertParameters[2].Value = comboNV.SelectedValue;
                insertParameters[3].Value = dateNgaymua.Value;
                insertParameters[4].Value = texttongtien.Text;

                FunctionS.RunSQL(sql, insertParameters);
                LoadDataGridView();
            }

            // Kiểm tra và thêm thông tin các mặt hàng
            if (comboHH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboHH.Focus();
                return;
            }
            if ((textSLCT.Text.Trim().Length == 0) || (textSLCT.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSLCT.Text = "";
                textSLCT.Focus();
                return;
            }

            sql = "SELECT MaHH FROM MUA_CHI_TIET WHERE MaHH=@MaHH AND MaDatHang = @MaDatHang";
            SqlParameter[] checkKeyParams =
                {
                    new SqlParameter("@MaHH", SqlDbType.NVarChar),
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            checkKeyParams[0].Value = comboHH.SelectedValue;
            checkKeyParams[1].Value = textMDH.Text.Trim();

            if (FunctionS.CheckKey(sql, checkKeyParams))
            {
                // Nếu mã hàng hóa đã tồn tại trong đơn hàng, cập nhật số lượng và thành tiền

                // Lấy giá trị số lượng và thành tiền hiện tại từ bảng
                string currentQuantitySQL = "SELECT SoLuongHH, ThanhTienHH FROM MUA_CHI_TIET WHERE MaHH=@MaHH AND MaDatHang = @MaDatHang";
                SqlParameter[] currentValuesParams =
                    {
                        new SqlParameter("@MaHH", SqlDbType.NVarChar),
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                    };
                currentValuesParams[0].Value = comboHH.SelectedValue;
                currentValuesParams[1].Value = textMDH.Text.Trim();

                DataTable currentValues = FunctionS.GetDataToTable(currentQuantitySQL, currentValuesParams);

                double currentQuantity = Convert.ToDouble(currentValues.Rows[0]["SoLuongHH"]);
                double currentTotal = Convert.ToDouble(currentValues.Rows[0]["ThanhTienHH"]);

                // Tính giá trị mới của số lượng và thành tiền
                double newQuantity = currentQuantity + Convert.ToDouble(textSLCT.Text);
                double newTotal = currentTotal + Convert.ToDouble(textthanhtien.Text);

                string sqlUpdate = "UPDATE MUA_CHI_TIET SET SoLuongHH = @NewQuantity, ThanhTienHH = @NewTotal WHERE MaDatHang = @MaDatHang AND MaHH = @MaHH";
                SqlParameter[] updateParams =
                    {
                        new SqlParameter("@NewQuantity", SqlDbType.Float),
                        new SqlParameter("@NewTotal", SqlDbType.Float),
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar),
                        new SqlParameter("@MaHH", SqlDbType.NVarChar)
                    };
                updateParams[0].Value = newQuantity;
                updateParams[1].Value = newTotal;
                updateParams[2].Value = textMDH.Text.Trim();
                updateParams[3].Value = comboHH.SelectedValue;

                FunctionS.RunSQL(sqlUpdate, updateParams);
            }
            else
            {
                // Nếu chưa tồn tại, thực hiện thêm mới vào bảng
                string sqlInsert = "INSERT INTO MUA_CHI_TIET(MaDatHang, MaHH, SoLuongHH, ThanhTienHH) VALUES (@MaDatHang, @MaHH, @SoLuongHH, @ThanhTienHH)";
                SqlParameter[] insertParams =
                    {
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar),
                        new SqlParameter("@MaHH", SqlDbType.NVarChar),
                        new SqlParameter("@SoLuongHH", SqlDbType.Float),
                        new SqlParameter("@ThanhTienHH", SqlDbType.Float)
                    };
                insertParams[0].Value = textMDH.Text.Trim();
                insertParams[1].Value = comboHH.SelectedValue;
                insertParams[2].Value = Convert.ToDouble(textSLCT.Text);
                insertParams[3].Value = Convert.ToDouble(textthanhtien.Text);

                FunctionS.RunSQL(sqlInsert, insertParams);
            }

            // Code để kiểm tra và lấy giá trị tổng tiền mới từ bảng MUA_CHI_TIET
            string sumTotalSQL = "SELECT SUM(ThanhTienHH) FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang";
            SqlParameter[] sumTotalParams =
                {
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            sumTotalParams[0].Value = textMDH.Text.Trim();

            double tong = Convert.ToDouble(FunctionS.GetFieldValues(sumTotalSQL, sumTotalParams));

            // Cập nhật giá trị tổng tiền mới vào bảng MUA
            string updateTotalSQL = "UPDATE MUA SET TongTienHH = @TongTienHH WHERE MaDatHang = @MaDatHang";
            SqlParameter[] updateTotalParams =
                {
                    new SqlParameter("@TongTienHH", SqlDbType.Float),
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            updateTotalParams[0].Value = tong;
            updateTotalParams[1].Value = textMDH.Text.Trim();

            texttongtien.Text = tong.ToString();
            FunctionS.RunSQL(updateTotalSQL, updateTotalParams);
            LoadDataGridView();
            ResetValueHD();
 

            }

        //Sửa hóa đơn
        private void btnSuaHDMua_Click(object sender, EventArgs e)
        {
            if (textMDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra và thực hiện việc sửa thông tin các mặt hàng trong đơn hàng
            if (comboHH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã đặt hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboHH.Focus();
                return;
            }
            if ((textSLCT.Text.Trim().Length == 0) || (textSLCT.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSLCT.Text = "";
                textSLCT.Focus();
                return;
            }

            // Kiểm tra mã hàng hóa có tồn tại trong đơn hàng không
            string sqlCheck = "SELECT MaHH FROM MUA_CHI_TIET WHERE MaHH = @MaHH AND MaDatHang = @MaDatHang";
            SqlParameter[] checkKeyParams =
                {
                    new SqlParameter("@MaHH", SqlDbType.NVarChar),
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            checkKeyParams[0].Value = comboHH.SelectedValue;
            checkKeyParams[1].Value = textMDH.Text.Trim();

            bool isExist = FunctionS.CheckKey(sqlCheck, checkKeyParams);

            if (isExist)
            {
                // Nếu mã hàng hóa đã tồn tại trong đơn hàng, thực hiện sửa số lượng và thành tiền

                // Lấy giá trị số lượng và thành tiền hiện tại từ bảng
                string getCurrentValuesSQL = "SELECT SoLuongHH, ThanhTienHH FROM MUA_CHI_TIET WHERE MaHH = @MaHH AND MaDatHang = @MaDatHang";
                SqlParameter[] currentValuesParams =
                    {
                        new SqlParameter("@MaHH", SqlDbType.NVarChar),
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                    };
                currentValuesParams[0].Value = comboHH.SelectedValue;
                currentValuesParams[1].Value = textMDH.Text.Trim();

                DataTable currentValues = FunctionS.GetDataToTable(getCurrentValuesSQL, currentValuesParams);

                double currentQuantity = Convert.ToDouble(currentValues.Rows[0]["SoLuongHH"]);
                double currentTotal = Convert.ToDouble(currentValues.Rows[0]["ThanhTienHH"]);

                // Tính giá trị mới của số lượng và thành tiền
                double newQuantity = Convert.ToDouble(textSLCT.Text);
                double pricePerUnit = Convert.ToDouble(textDonGia.Text); // Giá của một đơn vị hàng hóa - Giả sử đã có thông tin về giá

                // Tính giá trị mới của thành tiền
                double newTotal = newQuantity * pricePerUnit;

                string sqlUpdate = "UPDATE MUA_CHI_TIET SET SoLuongHH = @NewQuantity, ThanhTienHH = @NewTotal WHERE MaDatHang = @MaDatHang AND MaHH = @MaHH";
                SqlParameter[] updateParams =
                    {
                        new SqlParameter("@NewQuantity", SqlDbType.Float),
                        new SqlParameter("@NewTotal", SqlDbType.Float),
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar),
                        new SqlParameter("@MaHH", SqlDbType.NVarChar)
                    };
                updateParams[0].Value = newQuantity;
                updateParams[1].Value = newTotal;
                updateParams[2].Value = textMDH.Text.Trim();
                updateParams[3].Value = comboHH.SelectedValue;

                FunctionS.RunSQL(sqlUpdate, updateParams);
            }
            else
            {
                MessageBox.Show("Mã hàng hóa không tồn tại trong đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Code để kiểm tra và lấy giá trị tổng tiền mới từ bảng MUA_CHI_TIET
            string sumTotalSQL = "SELECT SUM(ThanhTienHH) FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang";
            SqlParameter[] sumTotalParams =
                {
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            sumTotalParams[0].Value = textMDH.Text.Trim();

            double tongt = Convert.ToDouble(FunctionS.GetFieldValues(sumTotalSQL, sumTotalParams));

            // Cập nhật giá trị tổng tiền mới vào bảng MUA
            string updateTotalSQL = "UPDATE MUA SET TongTienHH = @TongTienHH WHERE MaDatHang = @MaDatHang";
            SqlParameter[] updateTotalParams =
                {
                    new SqlParameter("@TongTienHH", SqlDbType.Float),
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                };
            updateTotalParams[0].Value = tongt;
            updateTotalParams[1].Value = textMDH.Text.Trim();

            texttongtien.Text = tongt.ToString();
            FunctionS.RunSQL(updateTotalSQL, updateTotalParams);
            LoadDataGridView();
            ResetValueHD();

        }
        //Xóa hóa đơn
        private void btnXoaHDMua_Click(object sender, EventArgs e)
        {
            if (textMDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa các chi tiết của đơn hàng từ bảng MUA_CHI_TIET
                string deleteDetailsSQL = "DELETE FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang";
                SqlParameter[] deleteDetailsParams =
                    {
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                    };
                deleteDetailsParams[0].Value = textMDH.Text.Trim();

                FunctionS.RunSQL(deleteDetailsSQL, deleteDetailsParams);

                // Xóa đơn hàng từ bảng MUA
                string deleteOrderSQL = "DELETE FROM MUA WHERE MaDatHang = @MaDatHang";
                SqlParameter[] deleteOrderParams =
                    {
                        new SqlParameter("@MaDatHang", SqlDbType.NVarChar)
                    };
                deleteOrderParams[0].Value = textMDH.Text.Trim();

                FunctionS.RunSQL(deleteOrderSQL, deleteOrderParams);

                MessageBox.Show("Đã xóa đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi xóa, làm mới hoặc làm sạch các trường thông tin
                textMDH.Text = "";
                // ... (Các trường thông tin khác)
                texttongtien.Text = "";
                // ... (Làm sạch các trường thông tin khác)
                LoadDataGridView(); // Tải lại danh sách đơn hàng sau khi xóa
                ResetValueHD();
            }

        }
        private void ResetValueHD()
        {
            textMDH.Text = "";
            comboHH.Text = "";
            textDonGia.Text = "0";
            textSLCT.Text = "0";
            textthanhtien.Text = "0";
            texttongtien.Text = "0";

        }
        // cell click
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHD.Rows[e.RowIndex];

                // Lấy thông tin từ các cột trong hàng được chọn
                string maDatHang = row.Cells["MaDatHang"].Value.ToString();
                string maHH = row.Cells["MaHH"].Value.ToString();
                string soLuong = row.Cells["SoLuongHH"].Value.ToString();
                string thanhTien = row.Cells["ThanhTienHH"].Value.ToString();

                // Hiển thị thông tin lên các điều khiển trên form
                textMDH.Text = maDatHang;
                comboHH.SelectedValue = maHH;
                textSLCT.Text = soLuong;
                textthanhtien.Text = thanhTien;

                // Load thông tin chi tiết của hóa đơn (nếu cần)
                LoadInfoHoaDon();
            }

        }
        //

        private void dgvHD_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textMDH.Text))
            {
                MessageBox.Show("Vui lòng chọn mã đặt hàng cần xóa chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(comboHH.Text))
            {
                MessageBox.Show("Vui lòng chọn mã hàng hóa cần xóa chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết đơn hàng này?", "Xác nhận xóa chi tiết", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHH = comboHH.SelectedValue.ToString();

                // Đếm số lượng bản ghi trong bảng MUA_CHI_TIET
                string countQuery = "SELECT COUNT(*) FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang";
                SqlParameter[] countParams =
                {
                new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() }
            };
                int rowCount = Convert.ToInt32(FunctionS.GetFieldValues(countQuery, countParams));

                // Xóa hóa đơn chi tiết từ bảng MUA_CHI_TIET
                string deleteDetailSQL = "DELETE FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang AND MaHH = @MaHH";
                SqlParameter[] deleteDetailParams =
                {
                new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() },
                new SqlParameter("@MaHH", SqlDbType.NVarChar) { Value = maHH }
            };
                FunctionS.RunSQL(deleteDetailSQL, deleteDetailParams);

                MessageBox.Show("Đã xóa chi tiết đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kiểm tra nếu chỉ còn một bản ghi, xóa hóa đơn chi tiết
                if (rowCount == 1)
                {
                    string deleteInvoiceSQL = "DELETE FROM MUA WHERE MaDatHang = @MaDatHang";
                    FunctionS.RunSQL(deleteInvoiceSQL, countParams);
                }
                else
                {
                    // Tính lại tổng tiền sau khi xóa chi tiết
                    string sumQuery = "SELECT SUM(ThanhTienHH) FROM MUA_CHI_TIET WHERE MaDatHang = @MaDatHang";
                    SqlParameter[] sumParams =
                    {
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() }
                };
                    double tong = Convert.ToDouble(FunctionS.GetFieldValues(sumQuery, sumParams));

                    // Cập nhật tổng tiền mới vào bảng MUA
                    string updateTotalSQL = "UPDATE MUA SET TongTienHH = @TongTien WHERE MaDatHang = @MaDatHang";
                    SqlParameter[] updateTotalParams =
                    {
                    new SqlParameter("@TongTien", SqlDbType.Float) { Value = tong },
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() }
                };
                    texttongtien.Text = tong.ToString();
                    FunctionS.RunSQL(updateTotalSQL, updateTotalParams);
                }

                LoadDataGridView();
                ResetValueHD();
            }
        }


        private void LoadInfoHoaDon()
        {
            SqlParameter[] parameters =
                            {
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() }
                };

            string str = "SELECT NgayMuaHang, MaNCC, MaNV, TongTienHH FROM MUA WHERE MaDatHang = @MaDatHang";

            DataTable resultTable = FunctionS.GetDataToTable(str, parameters);

            if (resultTable.Rows.Count > 0)
            {
                dateNgaymua.Value = Convert.ToDateTime(resultTable.Rows[0]["NgayMuaHang"]);

                // Thay đổi cách lấy giá trị combo box
                string maNCC = resultTable.Rows[0]["MaNCC"].ToString();
                string maNV = resultTable.Rows[0]["MaNV"].ToString();

                // Kiểm tra xem giá trị maNCC và maNV có tồn tại trong ComboBox không
                if (comboNCC.Items.Cast<DataRowView>().Any(item => item.Row["MaNCC"].ToString() == maNCC))
                {
                    comboNCC.SelectedValue = maNCC;
                }

                if (comboNV.Items.Cast<DataRowView>().Any(item => item.Row["MaNV"].ToString() == maNV))
                {
                    comboNV.SelectedValue = maNV;
                }

                texttongtien.Text = resultTable.Rows[0]["TongTienHH"].ToString();
            }

            // Tạo một bộ tham số mới để tránh lỗi xảy ra khi sử dụng tham số cũ
            SqlParameter[] parametersForDetails =
                {
                    new SqlParameter("@MaDatHang", SqlDbType.NVarChar) { Value = textMDH.Text.Trim() }
                };

            string sql = "SELECT a.MaDatHang, b.MaHH, a.SoLuongHH, a.ThanhTienHH FROM MUA_CHI_TIET AS a INNER JOIN HANGHOA AS b ON a.MaHH = b.MaHH WHERE a.MaDatHang = @MaDatHang";
            tblCTHDB = FunctionS.GetDataToTable(sql, parametersForDetails);
            dgvHD.DataSource = tblCTHDB;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void tabHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabHH.SelectedTab == tabHDMCT)
            {
                textDonGia.ReadOnly = true;
                textthanhtien.ReadOnly = true;
                texttongtien.ReadOnly = true;

                texttongtien.Text = "0";
                FunctionS.FillCombo("SELECT MaNCC, TenNCC FROM NHACUNGCAP", comboNCC, "MaNCC", "MaNCC");
                comboNCC.SelectedIndex = -1;
                FunctionS.FillCombo("SELECT MaNV, TenNV FROM NHANVIEN", comboNV, "MaNV", "TenNV");
                comboNV.SelectedIndex = -1;
                FunctionS.FillCombo("SELECT MaHH, TenHH FROM HANGHOA", comboHH, "MaHH", "TenHH");
                comboHH.SelectedIndex = -1;
                //FunctionS.FillCombo("SELECT MaHH, TenHH FROM HANGHOA", comboTenHH, "TenHH", "TenHH");
                //comboTenHH.SelectedIndex = -1;
                if (textMDH.Text != "")
                {
                    LoadInfoHoaDon();
                    btnXoaHDMua.Enabled = true;

                }
                LoadDataGridView();

            }
            if (tabHH.SelectedTab == tabPageNCC)
            {
                LoadDataGridView();
            }
            if (tabHH.SelectedTab == tabPageNMH)
            {
                LoadDataGridView();
            }
            if (tabHH.SelectedTab == tabPageHH)
            {
                txtMaHangHoa.Enabled = false;
                LoadDataGridView();
            }
        }


        private void comboHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboHH.SelectedItem != null)
            {
                string str = "SELECT DonGiaHH FROM HANGHOA WHERE MaHH = @MaHH";

                if (comboHH.SelectedValue != null)
                {
                    SqlParameter[] parameters =
                        {
                            new SqlParameter("@MaHH", SqlDbType.NVarChar)
                        };
                    parameters[0].Value = comboHH.SelectedValue.ToString();

                    textDonGia.Text = FunctionS.GetFieldValues(str, parameters);
                }
                else
                {
                    textDonGia.Text = ""; // Thiết lập giá trị mặc định nếu không có giá trị được chọn
                }
            }
            else
            {
                textDonGia.Text = ""; // Thiết lập giá trị mặc định nếu không có phần tử nào được chọn
            }
        }


        private void textSLCT_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double sl, dg;
            if (textSLCT.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(textSLCT.Text);

            if (textDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(textDonGia.Text);

            double tt = sl * dg;
            textthanhtien.Text = tt.ToString();

            string[] thanhTienArray = textthanhtien.Text.Split(); // Tách chuỗi thành các phần tử
            double tongtien = 0;

            foreach (string value in thanhTienArray)
            {
                double ttien;
                if (double.TryParse(value, out ttien))
                {
                    tongtien += ttien;
                }
            }

            texttongtien.Text = tongtien.ToString(); // Gán giá trị tổng tiền vào texttongtien.Text
        }

        private void comboTimMDH_DropDown(object sender, EventArgs e)
        {
            FunctionS.FillCombo("SELECT MaDatHang FROM MUA", comboTimMDH, "MaDatHang", "MaDatHang");
            comboTimMDH.SelectedIndex = -1;
        }

        private void buttonTimKiemMDH_Click(object sender, EventArgs e)
        {
            if (comboTimMDH.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboTimMDH.Focus();
                return;
            }
            textMDH.Text = comboTimMDH.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoaHDMua.Enabled = true;
            btnThemHDMua.Enabled = true;
            comboTimMDH.SelectedIndex = -1;
        }

    }
}
