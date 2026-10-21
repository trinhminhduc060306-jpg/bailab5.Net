using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhBMI
{
    public partial class cau8 : Form
    {
        public cau8()
        {
            InitializeComponent();
            lblBMI.Text = "Chi so BMI: ";
            lblPhanLoai.Text = "Phan loai: ";
        }

        private void btnTinhBMI_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtChieuCao.Text, out double cao) ||
                !double.TryParse(txtCanNang.Text, out double nang))
            {
                MessageBox.Show("Vui long nhap so hop le!");
                return;
            }

            if (cao <= 0 || nang <= 0)
            {
                MessageBox.Show("Chieu cao va can nang phai lon hon 0!");
                return;
            }

            double bmi = nang / (cao * cao);
            lblBMI.Text = "Chi so BMI: " + bmi.ToString("F2");

            if (bmi < 18.5)
                lblPhanLoai.Text = "Phan loai: Thieu can";
            else if (bmi < 25)
                lblPhanLoai.Text = "Phan loai: Binh thuong";
            else if (bmi < 30)
                lblPhanLoai.Text = "Phan loai: Thua can";
            else
                lblPhanLoai.Text = "Phan loai: Beo phi";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtChieuCao.Clear();
            txtCanNang.Clear();
            lblBMI.Text = "Chi so BMI: ";
            lblPhanLoai.Text = "Phan loai: ";
            txtChieuCao.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
