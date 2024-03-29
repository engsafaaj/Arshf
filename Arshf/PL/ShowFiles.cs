﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Arshf.PL
{
    public partial class ShowFiles : DevExpress.XtraEditors.XtraForm
    {
        // Data Base and Tables
        TBArchiveFile tbadd;
        DBAREntities db;
        // other var
        public int ArchiveID;
        public int id;
        private bool state;
        string FileName, FileExt, path;
        byte[] FileFile;
        public ShowFiles()
        {
            InitializeComponent();
            LoadData();




        }

        public void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
            this.entityInstantFeedbackSource1.Refresh();
        }
        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Instantiate a new DataContext
            Arshf.DBAREntities dataContext = new Arshf.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBArchiveFiles.Where(x => x.ID == id)
                .Select(x => new
                {
                    x.ID,
                    x.FileExt1,
                    x.FileExt2,
                    x.FileExt3,
                    x.FileExt4,
                    x.FileExt5,
                    x.FileName1,
                    x.FileName2,
                    x.FileName3,
                    x.FileName4,
                    x.FileName5,

                });
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Dispose of the DataContext
            ((Arshf.DBAREntities)e.Tag).Dispose();
        }

        private void btn_showfolder_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Files");

        }

        private async void btn1_Click(object sender, EventArgs e)
        {
            var ExFile = gridView1.GetRowCellValue(0, "FileName1");
            if (ExFile == null)
            {
                MessageBox.Show("لا يوجد ملف ");

            }
            else
            {
                loading.Visible = true;
                var rs = await Task.Run(() => WriteFile1());
                if (rs == true)
                {
                    Process.Start(path);

                }
                else
                {
                    MessageBox.Show("لا يمكن كتابة الملف ");
                }
                loading.Visible = false;
            }
          
        }

        private bool WriteFile1()
        {
            try
            {
                db = new DBAREntities();
                FileName = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileName1).FirstOrDefault();
                FileExt = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileExt1).FirstOrDefault();
                FileFile = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileFile1).FirstOrDefault();
                path = @".\Files\" + FileName + FileExt;
                File.WriteAllBytes(path, FileFile);
                state = true;
            }
            catch { state = false; }
            return state;
        }
        private bool WriteFile2()
        {
            try
            {
                db = new DBAREntities();
                FileName = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileName2).FirstOrDefault();
                FileExt = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileExt2).FirstOrDefault();
                FileFile = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileFile2).FirstOrDefault();
                path = @".\Files\" + FileName + FileExt;
                File.WriteAllBytes(path, FileFile);
                state = true;
            }
            catch { state = false; }
            return state;
        }
        private bool WriteFile3()
        {
            try
            {
                db = new DBAREntities();
                FileName = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileName3).FirstOrDefault();
                FileExt = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileExt3).FirstOrDefault();
                FileFile = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileFile3).FirstOrDefault();
                path = @".\Files\" + FileName + FileExt;
                File.WriteAllBytes(path, FileFile);
                state = true;
            }
            catch { state = false; }
            return state;
        }

        private async void btn2_Click(object sender, EventArgs e)
        {
            var ExFile = gridView1.GetRowCellValue(0, "FileName2");
            if (ExFile == null)
            {
                MessageBox.Show("لا يوجد ملف ");

            }
            else
            {
                loading.Visible = true;
                var rs = await Task.Run(() => WriteFile2());
                if (rs == true)
                {
                    Process.Start(path);

                }
                else
                {
                    MessageBox.Show("لا يمكن كتابة الملف ");
                }
                loading.Visible = false;
            }
        }

        private async void btn3_Click(object sender, EventArgs e)
        {
            var ExFile = gridView1.GetRowCellValue(0, "FileName3");
            if (ExFile == null)
            {
                MessageBox.Show("لا يوجد ملف ");

            }
            else
            {
                loading.Visible = true;
                var rs = await Task.Run(() => WriteFile3());
                if (rs == true)
                {
                    Process.Start(path);

                }
                else
                {
                    MessageBox.Show("لا يمكن كتابة الملف ");
                }
                loading.Visible = false;
            }
        }

        private async void btn4_Click(object sender, EventArgs e)
        {
            var ExFile = gridView1.GetRowCellValue(0, "FileName4");
            if (ExFile == null)
            {
                MessageBox.Show("لا يوجد ملف ");

            }
            else
            {
                loading.Visible = true;
                var rs = await Task.Run(() => WriteFile4());
                if (rs == true)
                {
                    Process.Start(path);

                }
                else
                {
                    MessageBox.Show("لا يمكن كتابة الملف ");
                }
                loading.Visible = false;
            }
        }

        private async void btn5_Click(object sender, EventArgs e)
        {
            var ExFile = gridView1.GetRowCellValue(0, "FileName5");
            if (ExFile == null)
            {
                MessageBox.Show("لا يوجد ملف ");

            }
            else
            {
                loading.Visible = true;
                var rs = await Task.Run(() => WriteFile5());
                if (rs == true)
                {
                    Process.Start(path);

                }
                else
                {
                    MessageBox.Show("لا يمكن كتابة الملف ");
                }
                loading.Visible = false;
            }
        }

        private bool WriteFile4()
        {
            try
            {
                db = new DBAREntities();
                FileName = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileName4).FirstOrDefault();
                FileExt = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileExt4).FirstOrDefault();
                FileFile = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileFile4).FirstOrDefault();
                path = @".\Files\" + FileName + FileExt;
                File.WriteAllBytes(path, FileFile);
                state = true;
            }
            catch { state = false; }
            return state;
        }
        private bool WriteFile5()
        {
            try
            {
                db = new DBAREntities();
                FileName = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileName5).FirstOrDefault();
                FileExt = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileExt5).FirstOrDefault();
                FileFile = db.TBArchiveFiles.Where(X => X.ID == id).Select(x => x.FileFile5).FirstOrDefault();
                path = @".\Files" + FileName + FileExt;
                File.WriteAllBytes(path, FileFile);
                state = true;
            }
            catch { state = false; }
            return state;
        }
    }
}