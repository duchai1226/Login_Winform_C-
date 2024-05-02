using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04_CaNhan
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=LAPTOP-UBQQQL22\PERDB_SQL;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        BindingSource bs= null;
        string key = "2033221988";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLSVDataSet.NHANVIEN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtEmail.Text = "";
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            txtMa.Focus();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "LUONG")
            {
                
                var value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if(value != null && value.GetType() == typeof(byte[]))
                {
                    string stringValue = BitConverter.ToString((byte[])value);
                    stringValue = "0x" + stringValue.Replace("-", "");
                    string luong= new string('*', stringValue.Length);
                    e.Value = luong;
                }
            }
        }
        public byte[] AES256Encrypt(string plaintext, string key)
        {
            byte[] byteKey=Encoding.UTF8.GetBytes(key);
            List<byte> byteKeyList = new List<byte>(byteKey);
            while (byteKeyList.Count < 32)
                byteKeyList.Add(0);
            byteKey=byteKeyList.ToArray();
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = byteKey;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key,aesAlg.IV);
                byte[] encryptedBytes;
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                    }
                    encryptedBytes = msEncrypt.ToArray();
                }
                return encryptedBytes;
            }
        }
        public byte[] SHA_1(string plaintext)
        {
            byte[] pass_byte = Encoding.UTF8.GetBytes(plaintext);
            SHA1 sha1 = SHA1.Create();
            byte[] hashByte = sha1.ComputeHash(pass_byte);
            return hashByte;
        }
        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {

        }
        private void button_Ghi_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            List<string> listPar = new List<string>();
            string ma, hoten, email, luong, tendn, matkhau;
            listPar.Add(ma=txtMa.Text.Trim());
            listPar.Add(hoten = txtHoTen.Text.Trim());
            listPar.Add(email = txtEmail.Text.Trim());
            listPar.Add(luong = txtLuong.Text.Trim());
            listPar.Add(tendn = txtTenDN.Text.Trim());  
            listPar.Add(matkhau = txtMatKhau.Text.Trim());
            for (int i = 0; i < listPar.Count; i++)
            {
                if (listPar[i] == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            byte[] en_luong = AES256Encrypt(luong, key);
            byte[] en_matkhau = SHA_1(matkhau);
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCom.CommandText = "SP_INS_ENCRYPT_NHANVIEN";

            SqlParameter parMa=new SqlParameter("@MANV",SqlDbType.VarChar);
            SqlParameter parHoten=new SqlParameter("@HOTEN",SqlDbType.NVarChar);
            SqlParameter parEmail=new SqlParameter("@EMAIL",SqlDbType.VarChar);
            SqlParameter parLuong = new SqlParameter("@LUONG", SqlDbType.VarBinary);
            SqlParameter parTenDN = new SqlParameter("@TENDN", SqlDbType.NVarChar);
            SqlParameter parMatKhau = new SqlParameter("@MATKHAU", SqlDbType.VarBinary);

            parMa .Value= ma;
            parHoten .Value= hoten;
            parEmail .Value= email;
            parLuong .Value= en_luong;
            parTenDN .Value= tendn;
            parMatKhau .Value= en_matkhau;
            sqlCom.Parameters.Add(parMa);
            sqlCom.Parameters.Add(parHoten);
            sqlCom.Parameters.Add(parEmail);
            sqlCom.Parameters.Add(parLuong);
            sqlCom.Parameters.Add(parTenDN);
            sqlCom.Parameters.Add(parMatKhau);                    
            sqlCom.Connection = sqlCon;
            try
            {
                int rowAffected= sqlCom.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string sql = "SELECT * FROM NHANVIEN";
                    SqlCommand cmd = new SqlCommand(sql,sqlCon);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlCon.Close();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_Ghi.PerformClick();
            }
        }
    }
}
