using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshf.Pages
{
    public partial class HomePage : DevExpress.XtraEditors.XtraUserControl
    {


        private DataSet dataset;
        DBAREntities db;
        private int Depcount;
        private int Usercount;
        private int Archiescount;
        private double DataCount1;
        private double DataCount2;
        private double DataCount3;
        private double DataCount4;
        private double DataCount5;
        private double TotalSize;
        private int id;

        public HomePage()
        {
            InitializeComponent();
            db = new DBAREntities();
        }


        private void LoadDep()
        {
            try
            {
                 Depcount = db.TBDeps.Select(x => x.ID).ToList().Count;
            }
            catch { }
        }
        private void LoadUsers()
        {
            try
            {
                Usercount = db.TBUSERS.Select(x => x.ID).ToList().Count;
            }
            catch { }
        }
        private void LoadArchies()
        {
            try
            {
                Archiescount = db.TBArchiveCategories.Select(x => x.ID).ToList().Count;
            }
            catch { }
        }
        private void LoadData()
        {
            try
            {
                DataCount1 =(double) db.TBArchiveFiles.Select(x => x.FileSize1).ToArray().Sum();
                DataCount2 = (double)db.TBArchiveFiles.Select(x => x.FileSize2).ToArray().Sum();
                DataCount3 = (double)db.TBArchiveFiles.Select(x => x.FileSize3).ToArray().Sum();
                DataCount4 = (double)db.TBArchiveFiles.Select(x => x.FileSize4).ToArray().Sum();
                DataCount5 = (double)db.TBArchiveFiles.Select(x => x.FileSize5).ToArray().Sum();
                TotalSize = (DataCount1 + DataCount2 + DataCount3 + DataCount4 + DataCount5)*0.000001;
            }
            catch { }
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            // Load Dep
            await Task.Run(() => LoadDep());
            await Task.Run(() => LoadArchies());
            await Task.Run(() => LoadData());
            await Task.Run(() => LoadUsers());
            txt_depcount.Text = Depcount.ToString();
            txt_usercount.Text = Usercount.ToString();
            txt_archviecount.Text = Archiescount.ToString();
            txt_datasize.Text = TotalSize.ToString("#0.0");

        }

        private  void btn_search_Click(object sender, EventArgs e)
        {
            PL.SearchResults search = new PL.SearchResults();
            search.SeachText = edt_search.Text;
            search.Show();

        }

        private void btn_addfile_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddPage.AddNewFileFromHome addNewFileFromHome = new AddPage.AddNewFileFromHome();
            addNewFileFromHome.Show();

        }
    }
}
