using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class cau6 : Form
    {
        private int soLanSai = 0;
        private int thoiGianKhoa = 30;

        private Timer timerKhoa = new Timer();
        public cau6()
        {
            InitializeComponent();
            timerKhoa.Interval = 1000;
            timerKhoa.Tick += timerKhoa_Tick;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap == "admin" && matKhau == "123456")
            {
                MessageBox.Show(
                    "Đăng nhập thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                soLanSai = 0;
            }
            else
            {
                soLanSai++;

                int soLanConLai = 3 - soLanSai;

                if (soLanSai >= 3)
                {
                    btnDangNhap.Enabled = false;
                    thoiGianKhoa = 30;

                    timerKhoa.Start();

                    MessageBox.Show(
                        "Bạn đã nhập sai 3 lần. Nút đăng nhập bị khóa trong 30 giây!",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Sai tên đăng nhập hoặc mật khẩu!\n" +
                        "Bạn còn " + soLanConLai + " lần thử.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void timerKhoa_Tick(object sender, EventArgs e)
        {
            thoiGianKhoa--;

            btnDangNhap.Text = "Đợi " + thoiGianKhoa + " giây";

            if (thoiGianKhoa <= 0)
            {
                timerKhoa.Stop();

                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "Đăng nhập";

                soLanSai = 0;
                thoiGianKhoa = 30;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            timerKhoa.Stop();
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            timerKhoa.Stop();
            timerKhoa.Dispose();

            base.OnFormClosed(e);
        }


        private void cau6_Load(object sender, EventArgs e)
        {

        }
    }
}
