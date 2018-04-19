using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;

using DevExpress.XtraEditors;


namespace NhaHang
{
    public partial class Frm_Main : RibbonForm
    {
        public Frm_Main()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        /// <summary>
        /// Hàm mở màn hình
        /// </summary>
        /// <param name="form"></param>
        void MoManHinh(XtraForm form)
        {
            if (KiemTraFormDaMo(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }
        bool KiemTraFormDaMo(XtraForm form)
        {
            foreach (var item in MdiChildren)
            {
                if (item.Name == form.Name)
                {
                    item.Activate();
                    return true;
                }
            }
            return false;
        }

        private void bar_ThemBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ThemBan themban = new frm_ThemBan();
            themban.ShowDialog();
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (XtraForm aForm in this.MdiChildren)
            {
                aForm.Close();
            }
            Application.Exit();
        }

        private void bar_ChonBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_ChonBan chonban = new frm_ChonBan();
            MoManHinh(chonban);
            chonban.f_showform();
        }

    }
}