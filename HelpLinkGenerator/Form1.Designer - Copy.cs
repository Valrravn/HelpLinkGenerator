namespace HelpLinkGenerator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageMembers = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.ucAPIMember1 = new HelpLinkGenerator.ucAPIMember();
            this.pageClasses = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageNSpaces = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pageArticles = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.nbiMembers = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.nbiClasses = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.nbiNSpaces = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.nbiArticles = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.pageMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.officeNavigationBar1);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.navigationFrame1);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(760, 614);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.simpleButton1.Location = new System.Drawing.Point(690, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(58, 28);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.ToolTip = "Open Repository Folder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.pageMembers);
            this.navigationFrame1.Controls.Add(this.pageClasses);
            this.navigationFrame1.Controls.Add(this.pageNSpaces);
            this.navigationFrame1.Controls.Add(this.pageArticles);
            this.navigationFrame1.Location = new System.Drawing.Point(12, 44);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMembers,
            this.pageClasses,
            this.pageNSpaces,
            this.pageArticles});
            this.navigationFrame1.SelectedPage = this.pageMembers;
            this.navigationFrame1.Size = new System.Drawing.Size(736, 495);
            this.navigationFrame1.TabIndex = 5;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // pageMembers
            // 
            this.pageMembers.Caption = "pageMembers";
            this.pageMembers.Controls.Add(this.ucAPIMember1);
            this.pageMembers.Name = "pageMembers";
            this.pageMembers.Size = new System.Drawing.Size(736, 495);
            // 
            // ucAPIMember1
            // 
            this.ucAPIMember1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAPIMember1.Location = new System.Drawing.Point(0, 0);
            this.ucAPIMember1.Name = "ucAPIMember1";
            this.ucAPIMember1.Size = new System.Drawing.Size(736, 495);
            this.ucAPIMember1.TabIndex = 0;
            // 
            // pageClasses
            // 
            this.pageClasses.Caption = "pageClasses";
            this.pageClasses.Name = "pageClasses";
            this.pageClasses.Size = new System.Drawing.Size(736, 495);
            // 
            // pageNSpaces
            // 
            this.pageNSpaces.Caption = "pageNSpaces";
            this.pageNSpaces.Name = "pageNSpaces";
            this.pageNSpaces.Size = new System.Drawing.Size(736, 495);
            // 
            // pageArticles
            // 
            this.pageArticles.Caption = "pageArticles";
            this.pageArticles.Name = "pageArticles";
            this.pageArticles.Size = new System.Drawing.Size(736, 495);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(141, 14);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.comboBoxEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.comboBoxEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(545, 24);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(760, 614);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.comboBoxEdit1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControlItem1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem1.Size = new System.Drawing.Size(678, 32);
            this.layoutControlItem1.Text = "Platform / Product: ";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(124, 17);
            this.layoutControlItem1.TextToControlDistance = 5;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navigationFrame1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(740, 499);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton1;
            this.layoutControlItem4.Location = new System.Drawing.Point(678, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(62, 32);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.AutoSize = false;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.nbiMembers,
            this.nbiClasses,
            this.nbiNSpaces,
            this.nbiArticles});
            this.officeNavigationBar1.Location = new System.Drawing.Point(12, 543);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(736, 59);
            this.officeNavigationBar1.TabIndex = 6;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            // 
            // nbiMembers
            // 
            this.nbiMembers.Name = "nbiMembers";
            this.nbiMembers.Text = "Members";
            // 
            // nbiClasses
            // 
            this.nbiClasses.Name = "nbiClasses";
            this.nbiClasses.Text = "Classes";
            // 
            // nbiNSpaces
            // 
            this.nbiNSpaces.Name = "nbiNSpaces";
            this.nbiNSpaces.Text = "Namespaces";
            // 
            // nbiArticles
            // 
            this.nbiArticles.Name = "nbiArticles";
            this.nbiArticles.Text = "Articles";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Settings";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Current Directory: D:/LongName/LongName/LongName/LongName/LongName";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.officeNavigationBar1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 531);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(740, 63);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 614);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Help Link Generator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.pageMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiMembers;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiClasses;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiNSpaces;
        private DevExpress.XtraBars.Navigation.NavigationBarItem nbiArticles;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMembers;
        private DevExpress.XtraBars.Navigation.NavigationPage pageClasses;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private ucAPIMember ucAPIMember1;
        private DevExpress.XtraBars.Navigation.NavigationPage pageNSpaces;
        private DevExpress.XtraBars.Navigation.NavigationPage pageArticles;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}

