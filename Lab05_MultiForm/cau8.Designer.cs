namespace Lab05_MultiForm


{
    partial class cau8 
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(100, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size =
                new System.Drawing.Size(150, 25);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "CHỌN KHOA";

            // lblKhoa
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location =
                new System.Drawing.Point(30, 75);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size =
                new System.Drawing.Size(35, 15);
            this.lblKhoa.TabIndex = 1;
            this.lblKhoa.Text = "Khoa:";

            // cboKhoa
            this.cboKhoa.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location =
                new System.Drawing.Point(85, 72);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size =
                new System.Drawing.Size(220, 23);
            this.cboKhoa.TabIndex = 2;

            // btnChon
            this.btnChon.Location =
                new System.Drawing.Point(85, 120);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size =
                new System.Drawing.Size(95, 32);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click +=
                new System.EventHandler(this.btnChon_Click);

            // btnHuy
            this.btnHuy.Location =
                new System.Drawing.Point(195, 120);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size =
                new System.Drawing.Size(95, 32);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click +=
                new System.EventHandler(this.btnHuy_Click);

            // frmChonKhoa
            this.AcceptButton = this.btnChon;
            this.CancelButton = this.btnHuy;
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChonKhoa";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn khoa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
