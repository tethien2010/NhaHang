using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using System.Linq;
using DAO;

namespace NhaHang
{
    public partial class frm_ChonBan : XtraForm
    {
        public frm_ChonBan()
        {
            InitializeComponent();
        }
        DTO_ChiTietHD dto_ct = new DTO_ChiTietHD();
        DTO_MonAn dto_monan = new DTO_MonAn();
        BUS_Ban bus_ban = new BUS_Ban();
        BUS_MonAn bus_monan = new BUS_MonAn();
        void LoadBan(string type)
        {
            
            int id = 0;
            
            cbb_Ban.Properties.DataSource = bus_ban.GetBan(id);
            cbb_Ban.Properties.ValueMember = "ID";
            cbb_Ban.Properties.DisplayMember = "TenBan";
            
         
        }

        void Load_ChonMon()
        {
            int id = 0;
            DataSet ds = new DataSet();
            ds = bus_monan.ChonMonAn(id);
            foreach (DataRow item in bus_monan.ChonMonAn(id).Tables[0].Rows)
            {
                dto_monan.list_monan.Add(new DTO_MonAn(
                    false
                    , Convert.ToInt32(item["ID_MonAn"])
                    , item["TenMonAn"].ToString()
                    , 1
                    , Convert.ToDouble(item["DonGia"])
                    ));
            }
            gc_ChonMon.DataSource = dto_monan.list_monan;
            gc_ChonMon.RefreshDataSource();
        }

        public void f_showform()
        {
            LoadBan("0");
            
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            try
            {
                TienIch tienich = new TienIch();
                
                foreach (var item in dto_monan.list_monan.Where(p=>p.Chon))
                {
                    dto_ct.list_chitiet.Add(new DTO_ChiTietHD(
                        0 //Số chi tiết hóa đơn
                        , 0 //Số hóa đơn
                        , item.ID //ID món ăn
                        , item.DonGia
                        , item.NgayTao
                        , Convert.ToDateTime(item.NgayTao.ToString("HH:mm"))
                        , Convert.ToDateTime(item.NgayTao.ToString("HH:mm"))
                        , ""
                        , item.SoLuong
                        , Convert.ToDouble(item.DonGia)
                        ));
                }
                gc_list.DataSource = dto_ct.list_chitiet;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

        private void rep_CheckChon_CheckedChanged(object sender, EventArgs e)
        {
            bool l_bCheck = ((CheckEdit)sender).Checked;
            dto_monan.list_monan[gv_ChonMon.FocusedRowHandle].Chon = l_bCheck;
        }

        private void cbb_Ban_EditValueChanged(object sender, EventArgs e)
        {
            if (cbb_Ban.EditValue != null)
            {
                Load_ChonMon();
            }
        }

    }
}