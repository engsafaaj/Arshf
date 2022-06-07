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
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        // DataBase and Tables
        DBAREntities db;
        private List<string> DepNameList;
        TBUSER tbadd;
        // Other var
        public int id;
        public int depid;
        public Pages.UsersPage page;
        bool state;
        public int Start;
        public AddUser()
        {
            InitializeComponent();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_name.Text == "" || edt_username.Text == "" || edt_password.Text == "" || edt_dep.SelectedItem==null || edt_role.SelectedItem == null || depid==null)
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
                    tbadd = new TBUSER
                    {
                        IDDep=depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_dep.Text,
                    };
                }
                // Edit
                else
                {
                    tbadd = new TBUSER
                    {
                        ID=id,
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_dep.Text,

                    };
                }

                // loading
                loading.Visible=true;
                // Add or Edit
                var result =await Task.Run(()=> AddOrEdit(tbadd));
                if (result == true)
                {
                   
                    toastNotificationsManager1.ShowNotification("96616aac-b9fe-45d7-8bb1-5cd04f388f4c");
                    if (Start == 1)
                    {
                        Start = 0;
                        Application.Restart();
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
        private bool AddOrEdit(TBUSER Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBUSER>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;

            }
            catch { state = false; }
            return state;
        }

        private bool LoadDepName()
        {
            try
            {
                db = new DBAREntities();
                DepNameList = db.TBDeps.Select(x => x.DepName).ToList();
                state = true;

            }
            catch
            {
                state = false;
            }
            return state;
        }

        private async void AddUser_Load(object sender, EventArgs e)
        {
            loading.Visible = true;
            var rs= await Task.Run(() => LoadDepName());
            if (rs == true)
            {
                edt_dep.DataSource = DepNameList;
            }
            else
            {
                MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر لطفا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            loading.Visible = false;

        }

        private async void edt_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading.Visible = true;
            var depName = edt_dep.Text;
            var rs = await Task.Run(() => LoadDepId(depName));
            if (rs == false)
            {
                MessageBox.Show("خطأ في الاتصال", "تأكد من الاتصال في السيرفر لطفا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            loading.Visible = false;
        }

        private bool LoadDepId(string DepName)
        {
            try
            {
                db = new DBAREntities();
                depid = db.TBDeps.Where(X => X.DepName == DepName).Select(x => x.ID).FirstOrDefault();
                state = true;

            }
            catch
            {
                state = false;
            }
            return state;
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Start == 1)
            {
                Application.Exit();
            }
        }
    }
}