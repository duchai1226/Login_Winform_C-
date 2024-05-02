using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_CaNhan
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LAPTOP-UBQQQL22\PERDB_SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection sqlCon = null;
        string nghenghiep = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            string tendangnhap = textTenDN.Text.Trim();
            string password = textPassword.Text.Trim();
            if (nghenghiep == "SINHVIEN")
            {
                byte[] pass_byte = Encoding.UTF8.GetBytes(password);
                MD5 md5 = MD5.Create();
                byte[] hashByte = md5.ComputeHash(pass_byte);
                password = "0x" + BitConverter.ToString(hashByte).Replace("-", "");
            }
            else
            {
                byte[] pass_byte = Encoding.UTF8.GetBytes(password);
                SHA1 sha1 = SHA1.Create();
                byte[] hashByte = sha1.ComputeHash(pass_byte);
                password = "0x" + BitConverter.ToString(hashByte).Replace("-", "");
            }
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "SELECT * FROM " + nghenghiep + " WHERE TENDN='" + tendangnhap + "' AND MATKHAU=" + password + "";
            try
            {
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (nghenghiep == "NHANVIEN")
                    {
                        this.Hide();
                        var form2 = new Form2();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlCon.Close();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue == "Sinh Viên")
                nghenghiep = "SINHVIEN";
            else if (selectedValue == "Nhân Viên")
                nghenghiep = "NHANVIEN";
        }
    }
}
