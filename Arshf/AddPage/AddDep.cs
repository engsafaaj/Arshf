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
    public partial class AddDep : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBAREntities db;
        TBDep tbadd;
        // Other var
        public int id;
        public Pages.DepPage page;
        bool state;
        public int start;
        public AddDep()
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
                    tbadd = new TBDep
                    {
                        DepName=edt_name.Text,
                        DepDetails=edt_details.Text,

                    };
                }
                // Edit
                else
                {
                    tbadd = new TBDep
                    {
                        ID=id,
                        DepName = edt_name.Text,
                        DepDetails = edt_details.Text,

                    };
                }

                // loading
                loading.Visible=true;
                // Add or Edit
                var result =await Task.Run(()=> AddOrEdit(tbadd));
                if (result == true)
                {
                  
                    toastNotificationsManager1.ShowNotification("96616aac-b9fe-45d7-8bb1-5cd04f388f4c");
                    if (start == 1)
                    {
                        // Add Dep and User
                        AddPage.AddUser UserPage = new AddPage.AddUser();
                        UserPage.Start = 1;
                        MessageBox.Show("  الصفحة القادمة تتيح لك اضافة مستخدم ");
                        start = 0;
                        UserPage.Show();
                    }
                    else
                    {
                        // Reload Data
                        page.LoadData();
                    }
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
        private bool AddOrEdit(TBDep Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBDep>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;

            }
            catch { state = false; }
            return state;
        }

        private void AddDep_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (start == 1)
            {
                Application.Exit();
            }
        }
    }
}