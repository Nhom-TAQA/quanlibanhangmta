using SuperMarket.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class BanHangForm : Form
    {
        public BanHangForm()
        {
            InitializeComponent();
            

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        public void LoadSearch(string TenSP)
        {
            string query = "SELECT * FROM dbo.SanPham WHERE Ten LIKE N'%" + TenSP + "%'";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
