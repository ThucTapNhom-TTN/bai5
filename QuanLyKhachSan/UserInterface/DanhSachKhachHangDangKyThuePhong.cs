using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Controller;

namespace QUANLYKHACHSAN.UserInterface
{
    public partial class DanhSachKhachHangDangKyThuePhong : Form
    {
        PhieuThuePhongControl ctrl = new PhieuThuePhongControl();
        PhongControl pctrl = new PhongControl();
        KhachHangControl khctrl = new KhachHangControl();

        public DanhSachKhachHangDangKyThuePhong()
        {
            InitializeComponent();
        }       

        private void DangKyThuePhong_Load(object sender, EventArgs e)
        {
            khctrl.HienthiDataGridviewComboBox(MaKhachHang);            
            ctrl.HienThiPhieuThue(dataGridViewX1, bindingNavigator1);          
        }

        PhieuDangKy dangky = null;
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dangky == null || dangky.IsDisposed)
            {
                dangky = new PhieuDangKy();
                dangky.Show();
            }
            else
                dangky.Activate();
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Phieu Dang Ky", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingNavigator1.BindingSource.RemoveCurrent();
                //ctrl.Save();
            }
        }

        private void DataGridview_DoubleClick(object sender, EventArgs e)
        {
            if (dangky == null || dangky.IsDisposed)
            {
                dangky = new PhieuDangKy(ctrl);
                dangky.Show();
            }
            else
                dangky.Activate();
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            
            ctrl.Save();
        }
      
        private void toolStripButtonTim_Click(object sender, EventArgs e)
        {
            QUANLYKHACHSAN.UserInterface.TimKhachHang tim = new QUANLYKHACHSAN.UserInterface.TimKhachHang();
            Point p = PointToScreen(toolStripButtonTim.Bounds.Location);
            p.X += toolStripButtonTim.Width;
            p.Y += toolStripButtonTim.Height;
            tim.Location = p;
            tim.ShowDialog();
            if (tim.DialogResult == DialogResult.OK)
            {
                ctrl.TimKhachHang(tim.cmbtimKH.SelectedValue.ToString());
            }
        }
    }
}