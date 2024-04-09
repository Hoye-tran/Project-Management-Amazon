using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMAZON.Class
{
    public class FunctionS
    {
        private static readonly string connectionString = "Data Source=HOYE\\SQLEXPRESS;Initial Catalog=Quanlycaphe;Integrated Security=True";

        public static DataTable GetDataToTable(string sql, SqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        connection.Open();
                        using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                        {
                            dap.Fill(table); // Đổ kết quả từ câu lệnh SQL vào DataTable
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý ngoại lệ của SQL nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ khác nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return table;
        }

        public static void RunSQL(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();

                        // Tạo một mảng mới để tránh sử dụng lại các tham số trong SqlParameter[] parameters
                        SqlParameter[] newParameters = new SqlParameter[parameters.Length];
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            newParameters[i] = new SqlParameter(parameters[i].ParameterName, parameters[i].SqlDbType);
                            newParameters[i].Value = parameters[i].Value;
                        }

                        cmd.Parameters.AddRange(newParameters); // Thêm các tham số mới vào command

                        cmd.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý ngoại lệ của SQL nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ khác nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public static bool CheckKey(string sql, SqlParameter[] parameters)
        {
            bool exists = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dap = new SqlDataAdapter(sql, connection))
                {
                    dap.SelectCommand.Parameters.AddRange(parameters);

                    DataTable table = new DataTable();
                    dap.Fill(table);

                    exists = (table.Rows.Count > 0);
                }
            }

            return exists;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cbo.DataSource = dataTable;
                    cbo.DisplayMember = ten;
                    cbo.ValueMember = ma;
                }
                catch (SqlException ex)
                {
                    // Xử lý ngoại lệ của SQL nếu cần thiết
                    MessageBox.Show("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ khác nếu cần thiết
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static string GetFieldValues(string sql, SqlParameter[] parameters)
        {
            string value = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddRange(parameters);

                    try
                    {
                        connection.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            value = result.ToString();
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý ngoại lệ của SQL nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ khác nếu cần thiết
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return value;
        }
    }
    /*
    public class FunctionS
    {
        public static SqlConnection Con;  //Khai báo đối tượng kết nối        


        public static void Connect()
        {
            Con = new SqlConnection();   //Khởi tạo đối tượng
                                         //Con.ConnectionString = Properties.Settings.Default.QlyHangHoaConnectionString;
            Con.ConnectionString = "Data Source=DESKTOP-DD3HHKC\\SQLNALE;Initial Catalog=Quanlycaphe;Integrated Security=True";
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
            else
                MessageBox.Show("Kết nối không thành công!");
        }



        // TẠO PHƯƠNG THỨC DISCONNECT
        //public static void Disconnect()
        //{
        //    if (Con.State == ConnectionState.Open)
        //    {
        //        Con.Close();
        //        Con.Dispose();
        //        Con = null;
        //    }

        //}
        //Phương thức thực thi câu lệnh select lấy dữ liệu
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
                                                               //Khai báo đối tượng table thuộc lớp DataTable
                                                               //Tạo đối tượng thuộc lớp SqlCommand
            FunctionS.Connect();
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = FunctionS.Con; //Kết nối cơ sở dữ liệu
            dap.SelectCommand.CommandText = sql; //Lệnh SQL
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }
        //Phương thức thực thi câu lệnh insert, update,delete
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Con; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            using (SqlConnection connection = new SqlConnection(Con.ConnectionString))
            {
                // Khởi tạo SqlCommand và gán giá trị cho Connection
                SqlCommand command = new SqlCommand(sql, connection);

                // Mở kết nối trước khi sử dụng
                connection.Open();

                // Khởi tạo SqlDataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Khởi tạo DataTable
                DataTable dataTable = new DataTable();

                // Sử dụng phương thức Fill để điền dữ liệu vào DataTable
                adapter.Fill(dataTable);

                // Gán DataTable làm nguồn dữ liệu cho ComboBox
                cbo.DataSource = dataTable;

                // Thiết lập cột hiển thị và giá trị tương ứng
                cbo.DisplayMember = ten;
                cbo.ValueMember = ma;

                // Đóng kết nối sau khi sử dụng
                connection.Close();
            }
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }*/
}
