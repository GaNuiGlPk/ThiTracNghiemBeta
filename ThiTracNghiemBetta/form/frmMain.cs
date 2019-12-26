﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThiTracNghiemBetta.form.examregistation;
using ThiTracNghiemBetta.form.register;
using ThiTracNghiemBetta.form.student;

namespace ThiTracNghiemBetta.form
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public static bool flag = true;
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusHOTEN.Text = "Họ và Tên: " + Program.mHoTen;
            toolStripStatusMAGV.Text = "Mã GV: " + Program.mUserId;
            toolStripStatusNHOM.Text = "Nhóm: " + Program.mNhom;
            if (Program.mNhom == "GIANGVIEN")
            {
                btKHOA.Enabled = btGiaoVien.Enabled = btLOP.Enabled = btMonHoc.Enabled = btlogin.Enabled = false;
                btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
            }
        }
        private void btMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMH f = new frmMH();
             f.MdiParent = this;
             f.Show();
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;

        }

        private void btLOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
            frmInputStudent f = new frmInputStudent();
            f.MdiParent = this;
            f.Show();
        }

        private void btDSDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListExamRegistration f = new frmListExamRegistration();
            f.MdiParent = this;
            f.Show();
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
        }

        private void btBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmBD f = new frmBD();
            f.MdiParent = this;
            f.Show();
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
        }

        private void btlogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;

            Form frm = this.CheckExists(typeof(frmRegisterUsers));
             if (frm != null)
             {
                 frm.Activate();
             }

             else
             {
                 //btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
                 //btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
                 frmRegisterUsers f = new frmRegisterUsers();
                 f.MdiParent = this;
                 f.Show();
             }
        }
        private void btKHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKHOA f = new frmKHOA();
            f.MdiParent = this;
            f.Show();
            btlogin.Enabled = btBD.Enabled = btDSDK.Enabled = btKHOA.Enabled = btLOP.Enabled = btCancel.Enabled = btMonHoc.Enabled = false;
            btnXEMBAITHI.Enabled = btnXEMBANGDIEM.Enabled = btnXEMDSDANGKY.Enabled = false;
        }
        private void btCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Program.formDangNhap.Show();
                this.Close();
            }
        }

        private void btnXEMBAITHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* Form frm = this.CheckExists(typeof(frmXemBaiThi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmXemBaiThi f = new frmXemBaiThi();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void btnXEMBANGDIEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           /* Form frm = this.CheckExists(typeof(frmXemBangDiem));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmXemBangDiem f = new frmXemBangDiem();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void btnXEMDSDANGKY_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Form frm = this.CheckExists(typeof(frmXemDSDangKy));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmXemDSDangKy f = new frmXemDSDangKy();
                f.MdiParent = this;
                f.Show();
            }*/
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
