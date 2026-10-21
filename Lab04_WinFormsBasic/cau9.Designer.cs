
namespace DangKyHocPhan
{
    partial class cau9 
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.Label lblTongTinChi;
        private System.Windows.Forms.Button btnTinh;
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.lblTongTinChi = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(75, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "DANG KY HOC PHAN";

            // lblDanhSach
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location =
                new System.Drawing.Point(30, 70);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Text = "Chon cac mon hoc:";

            // clbMonHoc
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Location =
                new System.Drawing.Point(30, 95);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size =
                new System.Drawing.Size(310, 124);
            this.clbMonHoc.CheckOnClick = true;

            // lblTongTinChi
            this.lblTongTinChi.AutoSize = true;
            this.lblTongTinChi.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Bold);
            this.lblTongTinChi.Location =
                new System.Drawing.Point(30, 235);
            this.lblTongTinChi.Name = "lblTongTinChi";
            this.lblTongTinChi.Text = "Tong so tin chi: 0";

            // btnTinh
            this.btnTinh.Location =
                new System.Drawing.Point(25, 280);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size =
                new System.Drawing.Size(100, 30);
            this.btnTinh.Text = "Tinh tin chi";
            this.btnTinh.Click +=
                new System.EventHandler(this.btnTinh_Click);

            // btnLamMoi
            this.btnLamMoi.Location =
                new System.Drawing.Point(135, 280);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size =
                new System.Drawing.Size(90, 30);
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.Click +=
                new System.EventHandler(this.btnLamMoi_Click);

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(235, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(80, 30);
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click +=
                new System.EventHandler(this.btnThoat_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(370, 335);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblTongTinChi);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);

            this.Name = "Form1";
            this.Text = "Dang ky hoc phan";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
