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
    public partial class cau7 : Form
    {
        public string TuKhoa { get; private set; }
        
        public cau7()
        {
            InitializeComponent();
            this.Text = "Hộp thoại tìm kiếm";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTuKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa!");
                txtTuKhoa.Focus();
                return;
            }

            TuKhoa = txtTuKhoa.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnMoTimKiem_Click(object sender, EventArgs e)
        {
            using (cau7  frm = new cau7())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string tuKhoa = frm.TuKhoa;

                    MessageBox.Show(
                        "Từ khóa tìm kiếm: " + tuKhoa
                    );
                }
            }
        }


        private void cau7cs_Load(object sender, EventArgs e)
        {

        }
    }
}
