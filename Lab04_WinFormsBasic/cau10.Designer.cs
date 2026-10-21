
namespace PhieuNhapSanPham
{
    partial class cau10 
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();

            // Tieu de
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(145, 20);
            this.lblTieuDe.Text = "PHIEU NHAP SAN PHAM";

            // Ma san pham
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location =
                new System.Drawing.Point(35, 85);
            this.lblMaSP.Text = "Ma san pham:";

            this.txtMaSP.Location =
                new System.Drawing.Point(145, 82);
            this.txtMaSP.Size =
                new System.Drawing.Size(200, 22);
            this.txtMaSP.Name = "txtMaSP";

            // Ten san pham
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location =
                new System.Drawing.Point(35, 125);
            this.lblTenSP.Text = "Ten san pham:";

            this.txtTenSP.Location =
                new System.Drawing.Point(145, 122);
            this.txtTenSP.Size =
                new System.Drawing.Size(200, 22);
            this.txtTenSP.Name = "txtTenSP";

            // Loai san pham
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location =
                new System.Drawing.Point(35, 165);
            this.lblLoaiSP.Text = "Loai san pham:";

            this.cboLoaiSP.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Location =
                new System.Drawing.Point(145, 162);
            this.cboLoaiSP.Size =
                new System.Drawing.Size(200, 24);
            this.cboLoaiSP.Name = "cboLoaiSP";

            // So luong
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location =
                new System.Drawing.Point(35, 205);
            this.lblSoLuong.Text = "So luong:";

            this.txtSoLuong.Location =
                new System.Drawing.Point(145, 202);
            this.txtSoLuong.Size =
                new System.Drawing.Size(200, 22);
            this.txtSoLuong.Name = "txtSoLuong";

            // Don gia
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location =
                new System.Drawing.Point(35, 245);
            this.lblDonGia.Text = "Don gia:";

            this.txtDonGia.Location =
                new System.Drawing.Point(145, 242);
            this.txtDonGia.Size =
                new System.Drawing.Size(200, 22);
            this.txtDonGia.Name = "txtDonGia";

            // Ngay nhap
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location =
                new System.Drawing.Point(35, 285);
            this.lblNgayNhap.Text = "Ngay nhap:";

            this.dtpNgayNhap.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location =
                new System.Drawing.Point(145, 282);
            this.dtpNgayNhap.Size =
                new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.Name = "dtpNgayNhap";

            // Anh san pham
            this.picAnh.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location =
                new System.Drawing.Point(405, 85);
            this.picAnh.Size =
                new System.Drawing.Size(180, 180);
            this.picAnh.Name = "picAnh";
            this.picAnh.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabStop = false;

            // Chon anh
            this.btnChonAnh.Location =
                new System.Drawing.Point(440, 280);
            this.btnChonAnh.Size =
                new System.Drawing.Size(110, 30);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Text = "Chon anh";
            this.btnChonAnh.Click +=
                new System.EventHandler(this.btnChonAnh_Click);

            // Luu phieu
            this.btnLuu.Location =
                new System.Drawing.Point(100, 350);
            this.btnLuu.Size =
                new System.Drawing.Size(110, 35);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Text = "Luu phieu";
            this.btnLuu.Click +=
                new System.EventHandler(this.btnLuu_Click);

            // Lam moi
            this.btnLamMoi.Location =
                new System.Drawing.Point(250, 350);
            this.btnLamMoi.Size =
                new System.Drawing.Size(100, 35);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            // Thoat
            this.btnThoat.Location =
                new System.Drawing.Point(390, 350);
            this.btnThoat.Size =
                new System.Drawing.Size(100, 35);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            // Form1
            this.ClientSize =
                new System.Drawing.Size(630, 420);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);

            this.Name = "Form1";
            this.Text = "Phieu nhap san pham";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
