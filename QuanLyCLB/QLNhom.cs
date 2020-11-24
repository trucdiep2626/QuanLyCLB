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

        }
    }
}
