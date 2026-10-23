
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Mo cau 6
        private void btnCau6_Click(object sender, EventArgs e)
        {
            using (cau6 frm = new cau6())
            {
                frm.ShowDialog();
            }
        }

        // Mo cau 7
        private void btnCau7_Click(object sender, EventArgs e)
        {
            using (cau7 frm = new cau7())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Tu khoa tim kiem: " + frm.TuKhoa
                    );
                }
            }
        }

        // Mo cau 8
        private void btnCau8_Click(object sender, EventArgs e)
        {
            List<string> danhSachKhoa = new List<string>
            {
                "Cong nghe thong tin",
                "Quan tri kinh doanh",
                "Ke toan",
                "Dien - Dien tu",
                "Ngon ngu Anh"
            };

            using (cau8 frm = new cau8())
            {
                frm.NapDanhSachKhoa(danhSachKhoa);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Khoa duoc chon: " + frm.KhoaDuocChon
                    );
                }
            }
        }
    }
}
