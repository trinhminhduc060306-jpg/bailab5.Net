

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05_MultiForm
{
    public partial class cau8 : Form
    {
        public string KhoaDuocChon { get; private set; }

        public cau8()
        {
            InitializeComponent();
        }

        // Phuong thuc nhan danh sach khoa
        public void NapDanhSachKhoa(List<string> danhSachKhoa)
        {
            cboKhoa.DataSource = null;
            cboKhoa.Items.Clear();

            cboKhoa.Items.AddRange(danhSachKhoa.ToArray());

            if (cboKhoa.Items.Count > 0)
            {
                cboKhoa.SelectedIndex = 0;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedItem == null)
            {
                MessageBox.Show("Vui long chon khoa!");
                return;
            }

            KhoaDuocChon = cboKhoa.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
