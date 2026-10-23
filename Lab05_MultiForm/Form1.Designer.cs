
namespace Lab05_MultiForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnCau6;
        private System.Windows.Forms.Button btnCau7;
        private System.Windows.Forms.Button btnCau8;

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
            this.btnCau6 = new System.Windows.Forms.Button();
            this.btnCau7 = new System.Windows.Forms.Button();
            this.btnCau8 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Tieu de
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 16F,
                System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location =
                new System.Drawing.Point(75, 25);
            this.lblTieuDe.Text = "BAI TAP MULTIFORM";

            // Nut cau 6
            this.btnCau6.Location =
                new System.Drawing.Point(70, 85);
            this.btnCau6.Size =
                new System.Drawing.Size(240, 40);
            this.btnCau6.Name = "btnCau6";
            this.btnCau6.Text = "Cau 6 - Dang nhap";
            this.btnCau6.UseVisualStyleBackColor = true;
            this.btnCau6.Click +=
                new System.EventHandler(this.btnCau6_Click);

            // Nut cau 7
            this.btnCau7.Location =
                new System.Drawing.Point(70, 140);
            this.btnCau7.Size =
                new System.Drawing.Size(240, 40);
            this.btnCau7.Name = "btnCau7";
            this.btnCau7.Text = "Cau 7 - Tim kiem";
            this.btnCau7.UseVisualStyleBackColor = true;
            this.btnCau7.Click +=
                new System.EventHandler(this.btnCau7_Click);

            // Nut cau 8
            this.btnCau8.Location =
                new System.Drawing.Point(70, 195);
            this.btnCau8.Size =
                new System.Drawing.Size(240, 40);
            this.btnCau8.Name = "btnCau8";
            this.btnCau8.Text = "Cau 8 - Chon khoa";
            this.btnCau8.UseVisualStyleBackColor = true;
            this.btnCau8.Click +=
                new System.EventHandler(this.btnCau8_Click);

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize =
                new System.Drawing.Size(380, 280);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnCau6);
            this.Controls.Add(this.btnCau7);
            this.Controls.Add(this.btnCau8);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Menu bai tap";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
