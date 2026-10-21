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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool NhapHaiSo(out decimal a, out decimal b)
        {
            a = 0;
            b = 0;

            if (!decimal.TryParse(txtSo1.Text, out a) ||
                !decimal.TryParse(txtSo2.Text, out b))
            {
                MessageBox.Show(
                    "Vui long nhap hai so hop le!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (NhapHaiSo(out decimal a, out decimal b))
                txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (NhapHaiSo(out decimal a, out decimal b))
                txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (NhapHaiSo(out decimal a, out decimal b))
                txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!NhapHaiSo(out decimal a, out decimal b))
                return;

            if (b == 0)
            {
                MessageBox.Show("Khong the chia cho 0!");
                return;
            }

            txtKetQua.Text = (a / b).ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();

            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ban co chac muon thoat khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
