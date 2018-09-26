using DevExpress.XtraLayout;

namespace HelpLinkGenerator {
    partial class ucArticle {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucArticle));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty1 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty2 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty3 = new DevExpress.Data.UnboundSourceProperty();
            DevExpress.Data.UnboundSourceProperty unboundSourceProperty4 = new DevExpress.Data.UnboundSourceProperty();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonEdit1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(396, 496);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Location = new System.Drawing.Point(12, 450);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEdit1.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Copy", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit1.Size = new System.Drawing.Size(372, 34);
            this.buttonEdit1.StyleController = this.layoutControl1;
            this.buttonEdit1.TabIndex = 5;
            this.buttonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.unboundSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(372, 414);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Load += new System.EventHandler(this.gridControl1_Load);
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            // 
            // unboundSource1
            // 
            unboundSourceProperty1.DisplayName = "ID";
            unboundSourceProperty1.Name = "ID";
            unboundSourceProperty1.PropertyType = typeof(string);
            unboundSourceProperty2.DisplayName = "Title";
            unboundSourceProperty2.Name = "Title";
            unboundSourceProperty2.PropertyType = typeof(string);
            unboundSourceProperty3.DisplayName = "Owner";
            unboundSourceProperty3.Name = "Owner";
            unboundSourceProperty3.PropertyType = typeof(string);
            unboundSourceProperty4.DisplayName = "Full Name";
            unboundSourceProperty4.Name = "Full Name";
            unboundSourceProperty4.PropertyType = typeof(string);
            this.unboundSource1.Properties.Add(unboundSourceProperty1);
            this.unboundSource1.Properties.Add(unboundSourceProperty2);
            this.unboundSource1.Properties.Add(unboundSourceProperty3);
            this.unboundSource1.Properties.Add(unboundSourceProperty4);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTitle,
            this.colOwner,
            this.colFullName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", "{0}  Articles")});
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 1;
            this.colTitle.Width = 172;
            // 
            // colOwner
            // 
            this.colOwner.FieldName = "Owner";
            this.colOwner.Name = "colOwner";
            this.colOwner.Visible = true;
            this.colOwner.VisibleIndex = 2;
            this.colOwner.Width = 97;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "Full Name";
            this.colFullName.Name = "colFullName";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(396, 496);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 418);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlItem2.Control = this.buttonEdit1;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 418);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 58);
            this.layoutControlItem2.Text = "Markdown Link";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 17);
            // 
            // ucArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucArticle";
            this.Size = new System.Drawing.Size(396, 496);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private LayoutControlItem layoutControlItem1;
        private LayoutControlItem layoutControlItem2;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colOwner;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
    }
}
