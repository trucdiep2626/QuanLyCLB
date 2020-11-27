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
using System.Collections;
using System.Configuration;

namespace QuanLyCLB
{
    public partial class QLHocSinh : Form
    {
        String Con = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
        SqlConnection connection;
        string query = "";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet data;
        DataTable dataTable;
        ArrayList maLop= new ArrayList();
        public QLHocSinh()
        {
            InitializeComponent();
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
                query = "select * from dsThanhVienLop where";
                int flag = 0;
                if (cbML.SelectedItem != null)
                {

                    query += " MaLop like '" + cbML.SelectedItem.ToString() + "'";
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


                if (txtChucVu.Text.CompareTo("") != 0)

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
                    dGVDSHocSinh.DataSource = data.Tables["TimKiem"];
                }
                else
                    dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
            }

        }


        private void QLHocSinh_Load(object sender, EventArgs e)
        {
            dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
            GetMaLop();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn col in dataTable.Columns)
                    cbML.Items.Add(row[col]);
            }
            
        }
        DataSet GetDSHS()
        {
            data = new DataSet();

            query = "select dsLop.MaLop as N'Mã Lớp',dsLop.TenLop as N'Tên lớp',dsThanhVienLop.MaSV as N'Mã SV',HoTen as N'Họ tên',dsThanhVienLop.ChucVu as N'Chức vụ' from dsThanhVien join dsThanhVienLop on dsThanhVien.MaSV = dsThanhVienLop.MaSV join dsLop on dsLop.MaLop = dsThanhVienLop.MaLop";         
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
        void GetMaLop()
        {
            
            data = new DataSet();
            connection = new SqlConnection(Con);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "select MaLop from dsLop";
            adapter = new SqlDataAdapter(query, connection);
            
            adapter.Fill(data,"MaLop");
            dataTable = data.Tables["MaLop"];

            connection.Close();
        }
          
        private void btThem_Click(object sender, EventArgs e)
        {
            //String Con = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
            /*data = new DataSet();
            connection = new SqlConnection();
            connection.ConnectionString=Con;
            MessageBox.Show(connection.ConnectionString);
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
                
            }
            if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbML.SelectedItem == null)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else {
                int f = 0;
                
                foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                {
                    
                    //foreach (DataColumn col in GetDSMaSV().Tables[0].Columns)
                    if (txtMaSV.Text.CompareTo(row[0].ToString())==0)
                        {
                            f = 1;
                            query = "insert into dsThanhVienLop values ('" + cbML.SelectedItem.ToString() + "','" + txtMaSV.Text + "',N'" + txtChucVu.Text + "')";
                            adapter = new SqlDataAdapter(query, connection);
                            adapter.Fill(data);
                            connection.Close();
                            dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
                        }
                }
                i`f(f==0)
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }

            }
            */
            string constring =Con;
            using (SqlConnection con = new SqlConnection(constring))
            {
                if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbML.SelectedItem == null)
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
                            query = "insert into dsThanhVienLop values ('" + cbML.SelectedItem.ToString() + "','" + txtMaSV.Text + "',N'" + txtChucVu.Text + "')";

                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.CommandType = CommandType.Text;
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataSet ds = new DataSet();
                                    sda.Fill(ds);
                                    connection.Close();
                                    dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
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
            /*data = new DataSet();
            connection = new SqlConnection(Con);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
                MessageBox.Show("aaa");
            }
            if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbML.SelectedItem == null)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                MessageBox.Show("aaa");
                int f = 0;
                foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                {
                    if (txtMaSV.Text.CompareTo(row[0].ToString()) == 0)
                    {
                        f = 1;
                        query = "update dsThanhVienLop set MaLop='" + cbML.SelectedItem.ToString() + "',MaSV='" + txtMaSV.Text + "',ChucVu=N'" + txtChucVu.Text + "' where MaSV like '" + txtMaSV.Text + "'";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
                    }
                }
                if (f == 0)
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }
            }*/
            string constring = Con;
            using (SqlConnection con = new SqlConnection(constring))
            {
                if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbML.SelectedItem == null)
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
                            query = "update dsThanhVienLop set MaLop='" + cbML.SelectedItem.ToString() + "',MaSV='" + txtMaSV.Text + "',ChucVu=N'" + txtChucVu.Text + "' where MaSV like '" + txtMaSV.Text + "'";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.CommandType = CommandType.Text;
                                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                                {
                                    DataSet ds = new DataSet();
                                    sda.Fill(ds);
                                    connection.Close();
                                    dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
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
            data = new DataSet();
            connection = new SqlConnection(Con);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            query = "delete from dsThanhVienLop where MaSV like '" + txtMaSV.Text + "'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            connection.Close();
            dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
        }

        private void cbML_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbML.SelectedItem != null)
            {
                data = new DataSet();
                connection = new SqlConnection(Con);
                if (connection.State != ConnectionState.Open)
                {

                    connection.Open();
                }
                query = "select TenLop from dsLop where MaLop like '" + cbML.SelectedItem.ToString() + "'";
                adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(data, "TenLop");
                DataTable dt = data.Tables["TenLop"];

                connection.Close();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                        txtTenL.Text=row[col].ToString();
                }
            }
        }

        private void dGVDSHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int i = dGVDSHocSinh.CurrentRow.Index;
           cbML.Text = dGVDSHocSinh.Rows[i].Cells[0].Value.ToString();
            txtMaSV.Text = dGVDSHocSinh.Rows[i].Cells[2].Value.ToString();
            txtChucVu.Text = dGVDSHocSinh.Rows[i].Cells[4].Value.ToString();
        }
    }
}
