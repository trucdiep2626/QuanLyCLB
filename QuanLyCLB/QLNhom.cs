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

namespace QuanLyCLB
{
    public partial class QLNhom : Form
    {
        String ConnectionString = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
        SqlConnection connection;
        string query = "";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet data;
        public QLNhom()
        {
            InitializeComponent();
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }

            {
                query = "select * from dsNhomNghienCuu where";
                int flag = 0;
                if (txtMaNhom.Text.CompareTo("") != 0)
                {

                    string manhom = " MaNhom like '" + txtMaNhom.Text + "'";
                    query = String.Concat(query, manhom);
                    flag = 1;
                }
                if (txtTenNhom.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " TenNhom like N'" + txtTenNhom.Text + "'";
                    flag = 1;
                }
                if (txtSLTV.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " SoLuongtv =" + txtSLTV.Text;
                    flag = 1;
                }

                if (txtTruongNhom.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " TruongNhom like '" + txtTruongNhom.Text + "'";
                    flag = 1;
                }
                if (flag == 1)
                {
                    adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data, "TimKiem");
                    connection.Close();
                    dGVDSNhom.DataSource = data.Tables["TimKiem"];
                }
                else
                {
                    dGVDSNhom.DataSource = GetDSNhom().Tables[0];
                }
            }
        }

       

        private void btThem_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            if (txtTruongNhom.Text.CompareTo("") == 0 || txtTenNhom.Text.CompareTo("") == 0 || txtSLTV.Text.CompareTo("") == 0 || txtMaNhom.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                query = "insert into dsNhomNghienCuu values ('" + txtMaNhom.Text + "',N'" + txtTenNhom.Text + "','" + txtSLTV.Text + "','" + txtTruongNhom.Text + "')";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSNhom.DataSource = GetDSNhom().Tables[0];
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            if (txtTruongNhom.Text.CompareTo("") == 0 || txtTenNhom.Text.CompareTo("") == 0 || txtSLTV.Text.CompareTo("") == 0 || txtMaNhom.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                query = "update dsNhomNghienCuu set TenNhom='" + txtTenNhom.Text + "',SoLuongtv='" + txtSLTV.Text + "',TruongNhom='" + txtTruongNhom.Text + "' where MaNhom like '" + txtMaNhom.Text + "'";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSNhom.DataSource = GetDSNhom().Tables[0];
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "delete from dsNhomNghienCuu where MaNhom like '" + txtMaNhom.Text + "'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            connection.Close();
            dGVDSNhom.DataSource = GetDSNhom().Tables[0];
        }

        private void QLNhom_Load(object sender, EventArgs e)
        {
            dGVDSNhom.DataSource = GetDSNhom().Tables[0];
        }
        DataSet GetDSNhom()
        {
            data = new DataSet();

            string query = "select MaNhom as N'Mã Nhóm',TenNhom as N'Tên Nhóm',SoLuongtv as N'Số lượng thành viên',dsThanhVien.HoTen as N'Trưởng nhóm' from dsNhomNghienCuu join dsThanhVien on dsThanhVien.MaSV = dsNhomNghienCuu.TruongNhom";
            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void dGVDSNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVDSNhom.CurrentRow.Index;
            txtMaNhom.Text = dGVDSNhom.Rows[i].Cells[0].Value.ToString();
            txtTenNhom.Text= dGVDSNhom.Rows[i].Cells[1].Value.ToString();
            txtSLTV.Text=dGVDSNhom.Rows[i].Cells[2].Value.ToString();
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "select MaSV from dsThanhVien where HoTen like N'" + dGVDSNhom.Rows[i].Cells[3].Value.ToString() + "'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data,"Masv");
            connection.Close();
            foreach (DataRow item in data.Tables["Masv"].Rows)
            {
                txtTruongNhom.Text = item[0].ToString();
            }
            
        }
    }
}
