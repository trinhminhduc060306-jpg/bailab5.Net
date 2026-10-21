using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_WinFormsBasic
{
    public partial class cau7 : Form
    {
        public cau7()
        {
            InitializeComponent();

            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void chkHienMatKhau_CheckedChanged(
            object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar =
                !chkHienMatKhau.Checked;
        }

        private void btnDangNhap_Click(
            object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap == "" || matKhau == "")
            {
                MessageBox.Show(
                    "Vui long nhap day du thong tin!");
                return;
            }

            if (tenDangNhap == "admin" &&
                matKhau == "123456")
            {
                MessageBox.Show(
                    "Dang nhap thanh cong!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Ten dang nhap hoac mat khau khong dung!");
            }
        }

        private void btnThoat_Click(
            object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
