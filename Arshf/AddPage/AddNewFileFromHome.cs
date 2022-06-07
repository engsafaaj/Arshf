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

namespace Arshf.AddPage
{
    public partial class AddNewFileFromHome : DevExpress.XtraEditors.XtraForm
    {
        DBAREntities db;
        private List<string> ListCategory;
        TBArchiveCategory tbaddd;
        private int id;

        public string DepName { get; }
        public string UserRole { get; }

        public AddNewFileFromHome()
        {
            InitializeComponent();
            DepName = Properties.Settings.Default.UserDep;
            db = new DBAREntities();
        }

        private void GetCategoryName()
        {
            try
            {
                
                 ListCategory = db.TBArchiveCategories.Where(x=>x.UserDep==DepName).Select(x => x.ArchiveTitle).ToList();
            }
            catch { }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private async void AddNewFileFromHome_Load(object sender, EventArgs e)
        {
            // Load
            await Task.Run(() => GetCategoryName());
            comboBox1.DataSource = ListCategory;

        }

        private void SetCatData(string CatName)
        {
            try
            {
                tbaddd = db.TBArchiveCategories.Where(x => x.ArchiveTitle == CatName).FirstOrDefault();
            }
            catch { }
        }

        private async void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                var CatName = comboBox1.SelectedItem.ToString();
                await Task.Run(() => SetCatData(CatName));
                PL.ArchiveFileForm archive = new PL.ArchiveFileForm();
                id = tbaddd.ID;
                archive.lb_id.Text = id.ToString();
                archive.ArchiveID = id;
                archive.lb_archivename.Text = tbaddd.ArchiveTitle;
                archive.lb_archdep.Text = tbaddd.UserDep;
                archive.Show();


            }
            catch { }
        }
    }
}