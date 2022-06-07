using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshf.PL
{
    public partial class Start : SplashScreen
    {
        DBAREntities db;
        TBUSER tbadd;
        int state;
        public Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "جميع الحقوق محفوظة © 2022-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void CheckState()
        {
            try
            {
                db = new DBAREntities();
                var userid = db.TBUSERS.Select(x=>x.ID).FirstOrDefault();
                // Login in
                if (userid > 0)
                {
                    state = 1;
                }
                else
                {
                    state = 2;
                }

            }
            catch
            {
                state = 3;
            }
        }

        private async void Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CheckState());
            if (state == 1)
            {
                AddPage.LoginFrom loginFrom = new AddPage.LoginFrom();
                loginFrom.Show();
                Hide();
            }
            if (state == 2)
            {
                // Add Dep and User
                AddPage.AddDep DepPage = new AddPage.AddDep();
                DepPage.start = 1;
                MessageBox.Show("مرحبا بك , الصفحة القادمة تتيح لك اضافة قسم ");
                DepPage.Show();
                Hide();
            }
            if (state == 3)
            {
                // Set Server Con form Settings
              var rs=  MessageBox.Show( "اختر نعم لاعادة الاتصال, لا لضبط الاتصال, الغاء الامر لغلق البرنامج", "خطأ اتصال", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Application.Restart();
                }else if (rs == DialogResult.No)
                {
                    PL.SettingForm setting = new SettingForm();
                    setting.Start = 1;
                    setting.Show();
                    Hide();

                }
                else if(rs==DialogResult.Cancel)
                {
                    Application.Exit();
                }

            }
        }
    }
}