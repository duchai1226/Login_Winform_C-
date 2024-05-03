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
        public void CheckSQLState()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }
        public string EncryptPassword(string passwd)
        {
            string password;
            byte[] hashByte;
            byte[] passwd_byte = Encoding.UTF8.GetBytes(passwd);
            if (nghenghiep == "SINHVIEN")
            {
                MD5 md5 = MD5.Create();
                hashByte = md5.ComputeHash(passwd_byte);
            }
            else
            {
                SHA1 sha1 = SHA1.Create();
                hashByte = sha1.ComputeHash(passwd_byte);
            }
            password = "0x" + BitConverter.ToString(hashByte).Replace("-", "");
            return password;
        }
        private void dangnhap_Click(object sender, EventArgs e)
        {

            CheckSQLState();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            string tendangnhap = textTenDN.Text.Trim();
            string password = textPassword.Text.Trim();
            
            string en_password=EncryptPassword(password);
            sqlCom.Connection = sqlCon;
            sqlCom.CommandText = "SELECT * FROM " + nghenghiep + " WHERE TENDN='" + tendangnhap + "' AND MATKHAU=" + en_password + "";
            try
            {
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        var form2 = new Form2();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
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
            DialogResult close = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (close == DialogResult.Yes)
                Close();
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
