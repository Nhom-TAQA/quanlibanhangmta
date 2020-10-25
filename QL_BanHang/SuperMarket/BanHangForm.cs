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
            LoadSP();
            LoadTenSP();
            Bang();
            textBox8.Text = " Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
            TienThua();

        }

        void TienThua()
        {
            int s;
            if (textBox10.Text == "")
            {
                textBox9.Text = "";
            }
            else
            {
                if (textBox7.Text == "")
                {
                    textBox9.Text = "";
                }
                else
                {
                    s = int.Parse(textBox10.Text) - int.Parse(textBox7.Text);
                    textBox9.Text = s.ToString();
                }
            }
        }
        BindingSource SanPham = new BindingSource();
        void LoadSP()
        {
            string query = "select Ma as[Mã SP],Ten,DonVi as[Đơn vị],Gia as[Giá],SoLuong as[SL trong kho] from SanPham";
            SanPham.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadTenSP()
        {
            dataGridView1.DataSource = SanPham;
            textBox1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "Ten", true, DataSourceUpdateMode.Never));
        }
        DataTable dt = new DataTable();


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
