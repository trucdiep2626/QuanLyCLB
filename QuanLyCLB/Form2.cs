using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCLB
{
    public partial class QLCLB : Form
    {
        public QLCLB()
        {
            InitializeComponent();
        }

        private void QLCLB_Load(object sender, EventArgs e)
        {
            w = lbWelcome.Text;
            len = w.Length;
            lbWelcome.Text = "";
            timer1.Start();
        }
        int count = 0;
        int len = 0;
        string w ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count <= len)
            {
                lbWelcome.Text = w.Substring(0, count);
            }
        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLChung qlc = new QLChung();
            qlc.ShowDialog();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLop qll = new QLLop();
            qll.ShowDialog();

        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHocSinh qlhs = new QLHocSinh();
            qlhs.ShowDialog();
        }

        private void quảnLýNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhom qln = new QLNhom();
            qln.ShowDialog();
        }

        private void quảnLýThànhViênNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLThanhVienNhom qltv = new QLThanhVienNhom();
            qltv.ShowDialog();
        }
    }
}
