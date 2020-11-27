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
    public partial class QLLop : Form
    {
        String ConnectionString = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
        SqlConnection connection;
        string query = "";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet data;
        public QLLop()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            if ( txtGV.Text.CompareTo("") == 0 ||txtMaLop.Text.CompareTo("") == 0 ||txtSlhs.Text.CompareTo("") == 0 ||txtTenLop.Text.CompareTo("") == 0 )
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                query = "insert into dsLop values ('" + txtMaLop.Text + "',N'" + txtTenLop.Text + "','" + txtSlhs.Text + "','" + txtGV.Text + "')";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSLop.DataSource = GetDSLop().Tables[0];
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
            if (txtGV.Text.CompareTo("") == 0 || txtMaLop.Text.CompareTo("") == 0 || txtSlhs.Text.CompareTo("") == 0 || txtTenLop.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                query = "update dsLop set TenLop='" + txtTenLop.Text + "',SoLuonghs='" + txtSlhs.Text + "',Gv='" +txtGV.Text+ "' where MaLop like '" + txtMaLop.Text + "'";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSLop.DataSource = GetDSLop().Tables[0];
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
            query = "delete from dsLop where MaLop like '" + txtMaLop.Text + "'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            connection.Close();
            dGVDSLop.DataSource = GetDSLop().Tables[0];
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
                query = "select * from dsLop where";
                int flag = 0;
                if (txtMaLop.Text.CompareTo("") != 0)
                {

                    string malop = " MaLop like '" + txtMaLop.Text + "'";
                    query = String.Concat(query, malop);
                    flag = 1;
                }
                if (txtTenLop.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " TenLop like N'" + txtTenLop.Text + "'";
                    flag = 1;
                }
                if (txtSlhs.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " SoLuonghs =" + txtSlhs.Text  ;
                    flag = 1;
                }
          
                if (txtGV.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " Gv like '" + txtGV.Text + "'";
                    flag = 1;
                }
                if (flag == 1)
                {
                    adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data, "TimKiem");
                    connection.Close();
                    dGVDSLop.DataSource = data.Tables["TimKiem"];
                }
                else
                {
                    dGVDSLop.DataSource = GetDSLop().Tables[0];
                }
            }
        }

        private void QLLop_Load(object sender, EventArgs e)
        {
            dGVDSLop.DataSource = GetDSLop().Tables[0];
        }
        DataSet GetDSLop()
        {
            data = new DataSet();

            string query = "select MaLop as N'Mã Lớp',TenLop as N'Tên Lớp',SoLuonghs as N'Số lượng học sinh',dsThanhVien.HoTen as N'Giảng viên' from dsLop join dsThanhVien on dsThanhVien.MaSV = dsLop.Gv";
            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void dGVDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVDSLop.CurrentRow.Index;
            txtMaLop.Text = dGVDSLop.Rows[i].Cells[0].Value.ToString();
            txtTenLop.Text = dGVDSLop.Rows[i].Cells[1].Value.ToString();
            txtSlhs.Text = dGVDSLop.Rows[i].Cells[2].Value.ToString();
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "select MaSV from dsThanhVien where HoTen like N'" + dGVDSLop.Rows[i].Cells[3].Value.ToString() + "'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data, "Masv");
            connection.Close();
            foreach (DataRow item in data.Tables["Masv"].Rows)
            {
                txtGV.Text = item[0].ToString();
            }
        }
    }
}
