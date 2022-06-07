
namespace Arshf
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement15 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement16 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement17 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement18 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.btn_home = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_dep = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_users = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_archive = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_settings = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_help = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.pn_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1078, 116);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btn_home);
            this.tileBarGroup2.Items.Add(this.btn_dep);
            this.tileBarGroup2.Items.Add(this.btn_users);
            this.tileBarGroup2.Items.Add(this.btn_archive);
            this.tileBarGroup2.Items.Add(this.btn_settings);
            this.tileBarGroup2.Items.Add(this.btn_help);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // btn_home
            // 
            this.btn_home.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_home.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_home.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_home.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_home.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement13.Text = "الرئيسة";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_home.Elements.Add(tileItemElement13);
            this.btn_home.Id = 0;
            this.btn_home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_home.Name = "btn_home";
            this.btn_home.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_home_ItemClick);
            // 
            // btn_dep
            // 
            this.btn_dep.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_dep.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dep.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_dep.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_dep.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement14.Text = "الاقسام";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_dep.Elements.Add(tileItemElement14);
            this.btn_dep.Id = 1;
            this.btn_dep.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_dep_ItemClick);
            // 
            // btn_users
            // 
            this.btn_users.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_users.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_users.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_users.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_users.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement15.Text = "مستخدمين";
            tileItemElement15.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_users.Elements.Add(tileItemElement15);
            this.btn_users.Id = 2;
            this.btn_users.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_users.Name = "btn_users";
            this.btn_users.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_users_ItemClick);
            // 
            // btn_archive
            // 
            this.btn_archive.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_archive.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_archive.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_archive.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_archive.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement16.Text = "ارشيف";
            tileItemElement16.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_archive.Elements.Add(tileItemElement16);
            this.btn_archive.Id = 3;
            this.btn_archive.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_archive_ItemClick);
            // 
            // btn_settings
            // 
            this.btn_settings.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_settings.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_settings.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_settings.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_settings.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement17.Text = "الاعدادات";
            tileItemElement17.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_settings.Elements.Add(tileItemElement17);
            this.btn_settings.Id = 4;
            this.btn_settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_settings_ItemClick);
            // 
            // btn_help
            // 
            this.btn_help.AppearanceItem.Normal.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_help.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_help.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_help.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_help.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement18.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement18.Text = "تسجل الخروج";
            tileItemElement18.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_help.Elements.Add(tileItemElement18);
            this.btn_help.Id = 5;
            this.btn_help.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_help.Name = "btn_help";
            this.btn_help.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_help_ItemClick);
            // 
            // pn_container
            // 
            this.pn_container.BackColor = System.Drawing.Color.White;
            this.pn_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_container.Location = new System.Drawing.Point(0, 116);
            this.pn_container.Name = "pn_container";
            this.pn_container.Size = new System.Drawing.Size(1078, 564);
            this.pn_container.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 680);
            this.Controls.Add(this.pn_container);
            this.Controls.Add(this.tileBar1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ارشف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_home;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_archive;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_settings;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_help;
        private System.Windows.Forms.Panel pn_container;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_dep;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_users;
    }
}

