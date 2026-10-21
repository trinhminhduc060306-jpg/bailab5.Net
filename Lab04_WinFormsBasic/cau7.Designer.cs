
namespace Lab04_WinFormsBasic
{
    partial class cau7
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkGhiNho;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkGhiNho = new System.Windows.Forms.CheckBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(105, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size =
                new System.Drawing.Size(153, 26);
            this.lblTieuDe.Text = "DANG NHAP";

            // lblTenDangNhap
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location =
                new System.Drawing.Point(35, 90);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size =
                new System.Drawing.Size(86, 13);
            this.lblTenDangNhap.Text = "Ten dang nhap:";

            // txtTenDangNhap
            this.txtTenDangNhap.Location =
                new System.Drawing.Point(140, 87);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size =
                new System.Drawing.Size(180, 20);

            // lblMatKhau
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location =
                new System.Drawing.Point(35, 130);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size =
                new System.Drawing.Size(55, 13);
            this.lblMatKhau.Text = "Mat khau:";

            // txtMatKhau
            this.txtMatKhau.Location =
                new System.Drawing.Point(140, 127);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size =
                new System.Drawing.Size(180, 20);
            this.txtMatKhau.UseSystemPasswordChar = true;

            // chkGhiNho
            this.chkGhiNho.AutoSize = true;
            this.chkGhiNho.Location =
                new System.Drawing.Point(38, 170);
            this.chkGhiNho.Name = "chkGhiNho";
            this.chkGhiNho.Size =
                new System.Drawing.Size(116, 17);
            this.chkGhiNho.Text = "Ghi nho dang nhap";

            // chkHienMatKhau
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Location =
                new System.Drawing.Point(175, 170);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size =
                new System.Drawing.Size(97, 17);
            this.chkHienMatKhau.Text = "Hien mat khau";
            this.chkHienMatKhau.CheckedChanged +=
                new System.EventHandler(
                    this.chkHienMatKhau_CheckedChanged);

            // btnDangNhap
            this.btnDangNhap.Location =
                new System.Drawing.Point(70, 215);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size =
                new System.Drawing.Size(110, 32);
            this.btnDangNhap.Text = "Dang nhap";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click +=
                new System.EventHandler(
                    this.btnDangNhap_Click);

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(205, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(90, 32);
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click +=
                new System.EventHandler(
                    this.btnThoat_Click);

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(370, 280);

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.chkGhiNho);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Form dang nhap";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
