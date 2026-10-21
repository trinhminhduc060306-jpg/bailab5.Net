using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class cau9 : Form
    {
        private Dictionary<string, int> tinChi =
            new Dictionary<string, int>();

        public cau9()
        {
            InitializeComponent();

            tinChi.Add("Lap trinh C#", 3);
            tinChi.Add("Co so du lieu", 3);
            tinChi.Add("Mang may tinh", 3);
            tinChi.Add("He dieu hanh", 2);
            tinChi.Add("Phan tich thiet ke he thong", 3);

            foreach (string mon in tinChi.Keys)
            {
                clbMonHoc.Items.Add(mon);
            }

            lblTongTinChi.Text = "Tong so tin chi: 0";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach (string mon in clbMonHoc.CheckedItems)
            {
                tong += tinChi[mon];
            }

            lblTongTinChi.Text = "Tong so tin chi: " + tong;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }

            lblTongTinChi.Text = "Tong so tin chi: 0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
