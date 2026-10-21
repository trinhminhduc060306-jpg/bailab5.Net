
namespace TinhBMI
{
    partial class cau8
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChieuCao;
        private System.Windows.Forms.Label lblCanNang;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Button btnTinhBMI;
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
            this.lblChieuCao = new System.Windows.Forms.Label();
            this.lblCanNang = new System.Windows.Forms.Label();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.btnTinhBMI = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(105, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "TINH CHI SO BMI";

            // lblChieuCao
            this.lblChieuCao.AutoSize = true;
            this.lblChieuCao.Location =
                new System.Drawing.Point(30, 80);
            this.lblChieuCao.Name = "lblChieuCao";
            this.lblChieuCao.Text = "Chieu cao (m):";

            // txtChieuCao
            this.txtChieuCao.Location =
                new System.Drawing.Point(145, 77);
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size =
                new System.Drawing.Size(180, 20);

            // lblCanNang
            this.lblCanNang.AutoSize = true;
            this.lblCanNang.Location =
                new System.Drawing.Point(30, 120);
            this.lblCanNang.Name = "lblCanNang";
            this.lblCanNang.Text = "Can nang (kg):";

            // txtCanNang
            this.txtCanNang.Location =
                new System.Drawing.Point(145, 117);
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size =
                new System.Drawing.Size(180, 20);

            // btnTinhBMI
            this.btnTinhBMI.Location =
                new System.Drawing.Point(125, 160);
            this.btnTinhBMI.Name = "btnTinhBMI";
            this.btnTinhBMI.Size =
                new System.Drawing.Size(110, 30);
            this.btnTinhBMI.Text = "Tinh BMI";
            this.btnTinhBMI.Click +=
                new System.EventHandler(btnTinhBMI_Click);

            // lblBMI
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location =
                new System.Drawing.Point(30, 210);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Text = "Chi so BMI:";

            // lblPhanLoai
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.Location =
                new System.Drawing.Point(30, 240);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Text = "Phan loai:";

            // btnLamMoi
            this.btnLamMoi.Location =
                new System.Drawing.Point(55, 280);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size =
                new System.Drawing.Size(90, 30);
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.Click +=
                new System.EventHandler(btnLamMoi_Click);

            // btnThoat
            this.btnThoat.Location =
                new System.Drawing.Point(205, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size =
                new System.Drawing.Size(90, 30);
            this.btnThoat.Text = "Thoat";
            this.btnThoat.Click +=
                new System.EventHandler(btnThoat_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(370, 340);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblChieuCao);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.lblCanNang);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.btnTinhBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblPhanLoai);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThoat);

            this.Name = "Form1";
            this.Text = "Tinh chi so BMI";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
