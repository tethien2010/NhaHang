using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace NhaHang
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text.Trim()))
            {
                XtraMessageBox.Show("Chưa điền tên đăng nhập!","Thông báo",MessageBoxButtons.OK);
                txt_Username.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Pass.Text.Trim()))
            {
                XtraMessageBox.Show("Chưa điền mật khẩu!", "Thông báo", MessageBoxButtons.OK);
                txt_Pass.Focus();
                return;
            }



        }
    }
}