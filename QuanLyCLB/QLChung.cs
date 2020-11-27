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

    public partial class QLChung : Form
    {
        String ConnectionString = @"Data Source=DESKTOP-C3URM5B;Initial Catalog=DSTV;Integrated Security=True";
        SqlConnection connection;
        string query = "";
        SqlCommand cmd; 
        SqlDataAdapter adapter;
        DataSet data;
        public QLChung()
        {
            InitializeComponent();
        }

        private void QLChung_Load(object sender, EventArgs e)
        {
            cbChucVu.Items.Add("Chủ tịch");
            cbChucVu.Items.Add("Thành viên");
            dGVDSChung.DataSource = GetDSChung().Tables[0];
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
                query = "select * from dsThanhVien where";
                int flag = 0;
                //MessageBox.Show(query);
                if (txtMaSV.Text.CompareTo("") != 0)
                {
                    //MessageBox.Show("a");
                    string masv = " MaSV like '" + txtMaSV.Text + "'";
                    query = String.Concat(query, masv);
                    //MessageBox.Show(query);
                    flag = 1;
                }
                if (txtHoTen.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " HoTen like N'" + txtHoTen.Text + "'";
                    flag = 1;
                }
                if (txtLop.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " Lop like '" + txtLop.Text + "'";
                    flag = 1;
                }
                if (txtSdt.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " Sdt like '" + txtSdt.Text + "'";
                    flag = 1;
                }
                if (txtEmail.Text.CompareTo("") != 0)
                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " Email like '" + txtEmail.Text + "'";
                    flag = 1;
                }
                if (cbChucVu.SelectedItem != null)

                {
                    if (flag == 1)
                    { query += "and"; }
                    query += " ChucVu like N'" + cbChucVu.SelectedItem.ToString() + "'";
                }
                if (flag == 1)
                {
                    adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data, "TimKiem");
                    connection.Close();
                    dGVDSChung.DataSource = data.Tables["TimKiem"];
                }
                else
                    dGVDSChung.DataSource = GetDSChung().Tables[0];
            }
        }
        DataSet GetDSChung()
        {
            data = new DataSet();

            string query = "select MaSV as N'Mã SV', HoTen as N'Họ tên', Lop as N'Lớp',Sdt as N'SĐT',Email,ChucVu as N'Chức vụ' from dsThanhVien";
            using (connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        } 

        private void btThem_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            if(txtEmail.Text.CompareTo("")==0 || txtHoTen.Text.CompareTo("") == 0 || txtSdt.Text.CompareTo("") == 0 || txtLop.Text.CompareTo("") == 0 || txtMaSV.Text.CompareTo("") == 0 || cbChucVu.SelectedItem==null)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            { 
                query = "insert into dsThanhVien values ('" + txtMaSV.Text + "',N'" + txtHoTen.Text + "','" + txtLop.Text + "','" + txtSdt.Text + "','" + txtEmail.Text + "',N'" + cbChucVu.SelectedItem.ToString() + "')";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSChung.DataSource = GetDSChung().Tables[0];
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
            query = "delete from dsThanhVien where MaSV like '"+txtMaSV.Text+"'";
            adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(data);
            connection.Close();
            dGVDSChung.DataSource = GetDSChung().Tables[0];
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            connection = new SqlConnection(ConnectionString);
            if (connection.State != ConnectionState.Open)
            {

                connection.Open();
            }
            if (txtEmail.Text.CompareTo("") == 0 || txtHoTen.Text.CompareTo("") == 0 || txtSdt.Text.CompareTo("") == 0 || txtLop.Text.CompareTo("") == 0 || txtMaSV.Text.CompareTo("") == 0 || cbChucVu.SelectedItem == null)
            {
                MessageBox.Show("Thông tin chưa đầy đủ");
            }
            else
            {
                query = "update dsThanhVien set HoTen=N'" + txtHoTen.Text + "',Lop='" + txtLop.Text + "',Sdt='" + txtSdt.Text + "',Email='" + txtEmail.Text + "',ChucVu=N'" + cbChucVu.SelectedItem.ToString() + "' where MaSV like '" + txtMaSV.Text + "'";
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
                dGVDSChung.DataSource = GetDSChung().Tables[0];
            }
        }

        private void dGVDSChung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGVDSChung.CurrentRow.Index;
            txtMaSV.Text = dGVDSChung.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = dGVDSChung.Rows[i].Cells[1].Value.ToString();
            txtLop.Text = dGVDSChung.Rows[i].Cells[2].Value.ToString();
            txtSdt.Text = dGVDSChung.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dGVDSChung.Rows[i].Cells[4].Value.ToString();
            cbChucVu.Text=dGVDSChung.Rows[i].Cells[5].Value.ToString();

        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
