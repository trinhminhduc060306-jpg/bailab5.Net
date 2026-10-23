namespace Lab05_MultiForm


{
    partial class cau7
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuy;

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
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTuKhoa
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location =
                new System.Drawing.Point(25, 35);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size =
                new System.Drawing.Size(95, 15);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Từ khóa tìm kiếm:";

            // txtTuKhoa
            this.txtTuKhoa.Location =
                new System.Drawing.Point(135, 32);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size =
                new System.Drawing.Size(220, 23);
            this.txtTuKhoa.TabIndex = 1;

            // btnTimKiem
            this.btnTimKiem.Location =
                new System.Drawing.Point(135, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size =
                new System.Drawing.Size(105, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click +=
                new System.EventHandler(this.btnTimKiem_Click);

            // btnHuy
            this.btnHuy.Location =
                new System.Drawing.Point(250, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size =
                new System.Drawing.Size(105, 32);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click +=
                new System.EventHandler(this.btnHuy_Click);

            // cau7
            this.AcceptButton = this.btnTimKiem;
            this.CancelButton = this.btnHuy;
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 145);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hộp thoại tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
