using System;
using System.Collections;
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
    public partial class QLThanhVienNhom : Form
    {
        String Con = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
        SqlConnection connection;
        string query = "";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet data;
        DataTable dataTable;
        ArrayList maNhom = new ArrayList();
        public QLThanhVienNhom()
        {
            InitializeComponent();
        }

        private void QLThanhVienNhom_Load(object sender, EventArgs e)
        {
            dGVDSThanhVien.DataSource = GetDSThanhVien().Tables[0];
            GetMaNhom();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                    cbMNhom.Items.Add(row[col]);
            }

        }
        DataSet GetDSThanhVien()
        {
            data = new DataSet();

            query = "select dsNhomNghienCuu.MaNhom as N'Mã nhóm',dsNhomNghienCuu.TenNhom as N'Tên nhóm',dsThanhVienNhom.MaSV as N'Mã SV',HoTen as N'Họ tên',dsThanhVienNhom.ChucVu as N'Chức vụ' from dsThanhVienNhom join dsThanhVien on dsThanhVien.MaSV = dsThanhVienNhom.MaSV join dsNhomNghienCuu on dsNhomNghienCuu.MaNhom = dsThanhVienNhom.MaNhom";
            using (connection = new SqlConnection(Con))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        DataSet GetDSMaSV()
        {
            data = new DataSet();

            string query = "select MaSV from dsThanhVien";
            using (connection = new SqlConnection(Con))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        void GetMaNhom()
        {

            data = new DataSet();
            connection = new SqlConnection(Con);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "select MaNhom from dsNhomNghienCuu";
            adapter = new SqlDataAdapter(query, connection);

            adapter.Fill(data, "MaNhom");
            dataTable = data.Tables["MaNhom"];

            connection.Close();
        }

        private void cbMNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMNhom.SelectedItem != null)
            {
                data = new DataSet();
                connection = new SqlConnection(Con);
                if (connection.State != ConnectionState.Open)
                {

                    connection.Open();
                }
                query = "select TenNhom from dsNhomNghienCuu where MaNhom like '" + cbMNhom.SelectedItem.ToString() + "'";
                adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data, "TenNhom");
                DataTable dt = data.Tables["TenNhom"];

                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        txtTenN.Text = row[col].ToString();
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string constring = Con;
            using (SqlConnection con = new SqlConnection(constring))
            {
                if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbMNhom.SelectedItem == null)
                {
                    MessageBox.Show("Thông tin chưa đầy đủ");
                }
                else
                {
                    int f = 0;
                    foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                    {
                        if (txtMaSV.Text.CompareTo(row[0].ToString()) == 0)
                        {
                            f = 1;
                            query = "insert into dsThanhVienNhom values ('" + cbMNhom.SelectedItem.ToString() + "','" + txtMaSV.Text + "',N'" + txtChucVu.Text + "')";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.CommandType = CommandType.Text;
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataSet ds = new DataSet();
                                    sda.Fill(ds);
                                    connection.Close();
                                    dGVDSThanhVien.DataSource = GetDSThanhVien().Tables[0];
                                }
                            }
                        }
                    }
                    if (f == 0)
                    {
                        MessageBox.Show("Sinh viên không tồn tại");
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string constring = Con;
            using (SqlConnection con = new SqlConnection(constring))
            {
                if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbMNhom.SelectedItem == null)
                {
                    MessageBox.Show("Thông tin chưa đầy đủ");
                }
                else
                {
                    int f = 0;
                    foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                    {
                        if (txtMaSV.Text.CompareTo(row[0].ToString()) == 0)
                        {
                            f = 1;
                            query = "update dsThanhVienNhom set MaNhom='" + cbMNhom.SelectedItem.ToString() + "',MaSV='" + txtMaSV.Text + "',ChucVu=N'" + txtChucVu.Text + "' where MaSV like '" + txtMaSV.Text + "'";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.CommandType = CommandType.Text;
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataSet ds = new DataSet();
                                    sda.Fill(ds);
                                    connection.Close();
                                    dGVDSThanhVien.DataSource = GetDSThanhVien().Tables[0];
                                }
                            }
                        }
                    }
                    if (f == 0)
                    {
                        MessageBox.Show("Sinh viên không tồn tại");
                    }
        }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string constring = Con;
            using (SqlConnection con = new SqlConnection(constring))
            {
                int f = 0;
                foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                {
                    if (txtMaSV.Text.CompareTo(row[0].ToString()) == 0)
                    {
                        f = 1;
                        query = "delete from dsThanhVienNhom where MaSV like '" + txtMaSV.Text + "'";
                        adapter = new SqlDataAdapter(query, con);
                        adapter.Fill(data);
                        connection.Close();
                        dGVDSThanhVien.DataSource = GetDSThanhVien().Tables[0];
                    }
                }
                if (f == 0)
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }
            }
        }

        private void btHienThi_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(Con);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }

            {
                query = "select * from dsThanhVienNhom where";
                int flag = 0;
                if (cbMNhom.SelectedItem != null)
                {
                   
                    query += " MaNhom like '" + cbMNhom.SelectedItem.ToString() + "'";
                    flag = 1;
                }
                if (txtMaSV.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    string masv = " MaSV like '" + txtMaSV.Text + "'";
                    query = String.Concat(query, masv);
                    
                    flag = 1;
                }
             
               
                if (txtChucVu.Text.CompareTo("")!=0)

                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " ChucVu like N'" + txtChucVu.Text + "'";
                }
                if (flag == 1)
                {
                    adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data, "TimKiem");
                    connection.Close();
                    dGVDSThanhVien.DataSource = data.Tables["TimKiem"];
                }
                else
                    dGVDSThanhVien.DataSource = GetDSThanhVien().Tables[0];
            }
        
    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dGVDSThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVDSThanhVien.CurrentRow.Index;
            cbMNhom.Text = dGVDSThanhVien.Rows[i].Cells[0].Value.ToString();
            txtMaSV.Text = dGVDSThanhVien.Rows[i].Cells[2].Value.ToString();
            txtChucVu.Text = dGVDSThanhVien.Rows[i].Cells[4].Value.ToString();
        }
    }
}
