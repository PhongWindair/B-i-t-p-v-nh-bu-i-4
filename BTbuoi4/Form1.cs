using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTbuoi4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Nhan_vien> nv;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MSNV", "MSNV");
            dataGridView1.Columns.Add("TenNV", "Tên NV");
            dataGridView1.Columns.Add("LuongCB", "Lương CB");

        }

        private void them_Click(object sender, EventArgs e)
        {
            Nhan_vien nv = new Nhan_vien();
            if (nv.ShowDialog() == DialogResult.OK)
            {
                
                dataGridView1.Rows.Add(nv.ms, nv.ten, nv.luong);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                string employeeID = selectedRow.Cells[0].Value.ToString();
                string employeeName = selectedRow.Cells[1].Value.ToString();
                string employeeSalary = selectedRow.Cells[2].Value.ToString();

              
                Nhan_vien nv = new Nhan_vien(employeeID, employeeName, employeeSalary);
                if (nv.ShowDialog() == DialogResult.OK)
                {
              
                    selectedRow.Cells[0].Value = nv.ms;
                    selectedRow.Cells[1].Value = nv.ten;
                    selectedRow.Cells[2].Value = nv.luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo");
            }
        }

        private void dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
