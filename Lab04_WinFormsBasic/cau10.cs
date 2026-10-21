
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhieuNhapSanPham
{
    public partial class cau10 : Form
    {
        public cau10()
        {
            InitializeComponent();

            cboLoaiSP.Items.Add("Dien tu");
            cboLoaiSP.Items.Add("Do gia dung");
            cboLoaiSP.Items.Add("Van phong pham");
            cboLoaiSP.Items.Add("Thuc pham");

            cboLoaiSP.SelectedIndex = -1;
            dtpNgayNhap.Value = DateTime.Today;
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chon anh san pham";
                ofd.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image img = Image.FromFile(ofd.FileName))
                        {
                            Image anhMoi = new Bitmap(img);

                            if (picAnh.Image != null)
                                picAnh.Image.Dispose();

                            picAnh.Image = anhMoi;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Khong the mo anh nay!");
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                cboLoaiSP.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) ||
                soLuong <= 0)
            {
                MessageBox.Show("So luong phai la so nguyen duong!");
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) ||
                donGia < 0)
            {
                MessageBox.Show("Don gia khong hop le!");
                return;
            }

            decimal thanhTien = soLuong * donGia;

            MessageBox.Show(
                "Thong tin phieu nhap:\n" +
                "Ma SP: " + txtMaSP.Text.Trim() + "\n" +
                "Ten SP: " + txtTenSP.Text.Trim() + "\n" +
                "Loai: " + cboLoaiSP.Text + "\n" +
                "So luong: " + soLuong + "\n" +
                "Don gia: " + donGia.ToString("N0") + "\n" +
                "Ngay nhap: " + dtpNgayNhap.Value.ToString("dd/MM/yyyy") + "\n" +
                "Thanh tien: " + thanhTien.ToString("N0"),
                "Thong bao",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            txtSoLuong.Clear();
            txtDonGia.Clear();
            dtpNgayNhap.Value = DateTime.Today;

            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }

            txtMaSP.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (picAnh.Image != null)
            {
                picAnh.Image.Dispose();
                picAnh.Image = null;
            }

            base.OnFormClosed(e);
        }
    }
}
