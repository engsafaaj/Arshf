
namespace Arshf.AddPage
{
    partial class AddFile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_title = new DevExpress.XtraEditors.TextEdit();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_details = new System.Windows.Forms.RichTextBox();
            this.edt_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_reciver = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_sender = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_number = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_selectfiles = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_title.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_reciver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_number.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 644);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 77);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.Location = new System.Drawing.Point(557, 8);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(150, 57);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "العنوان";
            // 
            // edt_title
            // 
            this.edt_title.Location = new System.Drawing.Point(15, 44);
            this.edt_title.Name = "edt_title";
            this.edt_title.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_title.Properties.Appearance.Options.UseFont = true;
            this.edt_title.Size = new System.Drawing.Size(418, 44);
            this.edt_title.TabIndex = 2;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "cfcb4971-26aa-43fa-9cb6-09c2ad124f56";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("96616aac-b9fe-45d7-8bb1-5cd04f388f4c", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت العملية بنجاح", "تمت العملية بنجاح", "تمت العملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // loading
            // 
            this.loading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.Caption = "الرجاء الانتظار";
            this.loading.Description = "العملية تجرى في الخلفية";
            this.loading.Location = new System.Drawing.Point(198, 264);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(246, 66);
            this.loading.TabIndex = 4;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_details);
            this.groupBox1.Controls.Add(this.loading);
            this.groupBox1.Controls.Add(this.edt_date);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edt_reciver);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edt_sender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_number);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 483);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعلومات الاساسية";
            // 
            // edt_details
            // 
            this.edt_details.Location = new System.Drawing.Point(15, 370);
            this.edt_details.Name = "edt_details";
            this.edt_details.Size = new System.Drawing.Size(418, 96);
            this.edt_details.TabIndex = 4;
            this.edt_details.Text = "";
            // 
            // edt_date
            // 
            this.edt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edt_date.Location = new System.Drawing.Point(15, 181);
            this.edt_date.Name = "edt_date";
            this.edt_date.Size = new System.Drawing.Size(418, 45);
            this.edt_date.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(553, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "التفاصيل";
            // 
            // edt_reciver
            // 
            this.edt_reciver.Location = new System.Drawing.Point(15, 308);
            this.edt_reciver.Name = "edt_reciver";
            this.edt_reciver.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_reciver.Properties.Appearance.Options.UseFont = true;
            this.edt_reciver.Size = new System.Drawing.Size(418, 44);
            this.edt_reciver.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "الجهة الوارد اليها";
            // 
            // edt_sender
            // 
            this.edt_sender.Location = new System.Drawing.Point(15, 245);
            this.edt_sender.Name = "edt_sender";
            this.edt_sender.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sender.Properties.Appearance.Options.UseFont = true;
            this.edt_sender.Size = new System.Drawing.Size(418, 44);
            this.edt_sender.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "الجهة الصادر منها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "التاريخ";
            // 
            // edt_number
            // 
            this.edt_number.Location = new System.Drawing.Point(15, 111);
            this.edt_number.Name = "edt_number";
            this.edt_number.Properties.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_number.Properties.Appearance.Options.UseFont = true;
            this.edt_number.Size = new System.Drawing.Size(418, 44);
            this.edt_number.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(582, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "العدد";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_selectfiles);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 134);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار ملفات ( 5 حد اقصى) وبحجم لا يتعدى 5 ميكا لكل ملف";
            // 
            // btn_selectfiles
            // 
            this.btn_selectfiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_selectfiles.Appearance.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectfiles.Appearance.Options.UseFont = true;
            this.btn_selectfiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_selectfiles.ImageOptions.Image")));
            this.btn_selectfiles.Location = new System.Drawing.Point(47, 56);
            this.btn_selectfiles.Name = "btn_selectfiles";
            this.btn_selectfiles.Size = new System.Drawing.Size(602, 57);
            this.btn_selectfiles.TabIndex = 5;
            this.btn_selectfiles.Text = "اختر ملفات";
            this.btn_selectfiles.Click += new System.EventHandler(this.btn_selectfiles_Click);
            // 
            // AddFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFile";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة ملف";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_title.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_reciver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_sender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_number.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edt_title;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.TextEdit edt_reciver;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit edt_sender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit edt_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.SimpleButton btn_selectfiles;
        public System.Windows.Forms.RichTextBox edt_details;
        public System.Windows.Forms.DateTimePicker edt_date;
    }
}