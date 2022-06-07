using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshf.AddPage
{
    public partial class AddArchiveCategory : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBAREntities db;
        TBArchiveCategory tbadd;
        // Other var
        public int id;
        public Pages.ArchiveCatPage page;
        bool state;
        public AddArchiveCategory()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "")
            {
                MessageBox.Show("خطأ ادخال", "اكمل الحقول لطفا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Set Data
                // Check if Add or Edit
                if (id == 0)
                    // Add
                {
                    tbadd = new TBArchiveCategory
                    {
                        ArchiveTitle=edt_name.Text,
                        ArchiveDes=edt_details.Text,
                        UserName=Properties.Settings.Default.FullName,
                        UserDep=Properties.Settings.Default.UserDep,
                        IDUser= Properties.Settings.Default.UserID
                    };
                }
                // Edit
                else
                {
                    tbadd = new TBArchiveCategory
                    {
                        ID=id,
                        ArchiveTitle = edt_name.Text,
                        ArchiveDes = edt_details.Text,
                        UserName = Properties.Settings.Default.FullName,
                        UserDep = Properties.Settings.Default.UserDep,
                        IDUser = Properties.Settings.Default.UserID

                    };
                }

                // loading
                loading.Visible=true;
                // Add or Edit
                var result =await Task.Run(()=> AddOrEdit(tbadd));
                if (result == true)
                {
                    // Reload Data
                    page.LoadData();
                    toastNotificationsManager1.ShowNotification("96616aac-b9fe-45d7-8bb1-5cd04f388f4c");
                    Close();
                }
                else
                {
                    MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر لطفا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loading.Visible = false;


            }
        }

        // Add or Edit
        private bool AddOrEdit(TBArchiveCategory Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBArchiveCategory>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;

            }
            catch { state = false; }
            return state;
        }
    }
}