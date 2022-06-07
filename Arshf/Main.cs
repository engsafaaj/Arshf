using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arshf
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }


        // Load Home Page
        private void btn_home_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            Pages.HomePage page = new Pages.HomePage();
            LoadPage(page);
        }

        // Load Page Method
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try
            {
                var oldpage = pn_container.Controls.OfType<XtraUserControl>().FirstOrDefault();
                if (oldpage != null)
                {
                    pn_container.Controls.Remove(oldpage);
                    oldpage.Dispose();
                }


                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch { }
        }

        private void btn_dep_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.DepPage page = new Pages.DepPage();
            LoadPage(page);
        }

        private void btn_users_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.UsersPage page = new Pages.UsersPage();
            LoadPage(page);
        }

        private void btn_archive_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Pages.ArchiveCatPage page = new Pages.ArchiveCatPage();
            LoadPage(page);
        }

        private void btn_settings_ItemClick(object sender, TileItemEventArgs e)
        {
            PL.SettingForm setting = new PL.SettingForm();
            setting.Show();
        }

        private void btn_help_ItemClick(object sender, TileItemEventArgs e)
        {
            AddPage.LoginFrom loginFrom = new AddPage.LoginFrom();
            loginFrom.Show();
            Hide();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
