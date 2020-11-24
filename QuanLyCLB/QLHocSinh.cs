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

namespace QuanLyCLB
{
    public partial class QLHocSinh : Form
    {
        String ConnectionString = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
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

            string query = "select MaLop,dsThanhVienLop.MaSV,HoTen,Sdt,Email from dsThanhVienLop join dsThanhVien on dsThanhVien.MaSV=dsThanhVienLop.MaSV";         using (connection = new SqlConnection(ConnectionString))
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
            using (connection = new SqlConnection(ConnectionString))
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
            connection = new SqlConnection(ConnectionString);
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
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
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
                        if(txtMaSV.Text.CompareTo(row[0].ToString())==0)
                        {
                            f = 1;
                            query = "insert into dsThanhVienLop values ('" + cbML.SelectedItem.ToString() + "','" + txtMaSV.Text + "',N'" + txtChucVu.Text + "')";
                            adapter = new SqlDataAdapter(query, connection);
                            adapter.Fill(data);
                            connection.Close();
                            dGVDSHocSinh.DataSource = GetDSHS().Tables[0];
                        }
                }
                if(f==0)
                {
                    MessageBox.Show("Sinh viên không tồn tại");
                }

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
            if (txtMaSV.Text.CompareTo("") == 0 || txtChucVu.Text.CompareTo("") == 0 || cbML.SelectedItem == null)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                int f = 0;
                foreach (DataRow row in GetDSMaSV().Tables[0].Rows)
                {
                    //foreach (DataColumn col in GetDSMaSV().Tables[0].Columns)
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
                connection = new SqlConnection(ConnectionString);
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
    }
}
