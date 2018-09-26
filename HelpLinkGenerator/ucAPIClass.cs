using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.IO;
using DevExpress.XtraGrid.Views.Base;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;

namespace HelpLinkGenerator {
    public partial class ucAPIClass : UserControl {
        List<String> memberNames;
        readonly Dictionary<CellKey, object> Differences = new Dictionary<CellKey, object>();
        
        public ucAPIClass() {
            InitializeComponent();
            gridView1.PopupMenuShowing += GridView1_PopupMenuShowing;
        }

        private void GridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.MenuType == GridMenuType.Row) {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();
                menu.Items.Add(CreateMenuItem("Copy Markdown Link - Class", null));
                menu.Items.Add(CreateMenuItem("Copy Markdown Link - Namespace", null));
                menu.Items.Add(CreateMenuItem("Refresh Data", null));
            }
        }

        DXMenuItem CreateMenuItem(string caption, Image image) {
            DXMenuItem item = new DXMenuItem(caption, new EventHandler(OnCanExecute), null, null);
            item.Tag = gridView1.FocusedRowHandle;
            return item;
        }

        void OnCanExecute(object sender, EventArgs e) {
            DXMenuItem item = sender as DXMenuItem;
            switch (item.Caption) {
                case ("Refresh Data"):
                    (this.FindForm() as Form1).RefreshUserControls();
                    break;
                default:
                    Clipboard.SetText(GenerateMarkdownLink(gridView1, item.Caption));
                    break;
            }

        }

        public string GenerateMarkdownLink(GridView sourceView, string objectType) {
            GridView view = sourceView;
            string NamespaceName = view.GetFocusedRowCellDisplayText("Namespace");
            string ClassName = view.GetFocusedRowCellDisplayText("Class");
            string ClassLink = "[](xref:" + NamespaceName + "." + ClassName + ")";
            string NamespaceLink = "[](xref:" + NamespaceName + ")";
            switch (objectType) {
                case ("Copy Markdown Link - Class"):
                    return ClassLink;
                case ("Copy Markdown Link - Namespace"):
                    return NamespaceLink;
                default: return String.Empty;
            }
        }

        private void UnboundSource1_ValueNeeded(object sender, DevExpress.Data.UnboundSourceValueNeededEventArgs e) {

            if (this.Differences.Count > 0) {
                object rv;
                //if the dictionary contains modified data for the current cell, it will be taken 
                if (this.Differences.TryGetValue(new CellKey(e.RowIndex, e.PropertyName), out rv)) {
                    e.Value = rv;
                    return;
                }
            }
            //otherwise, a control will receive default data from the array 

            e.Value = GetDefaultData(e.RowIndex, e.PropertyName);
        }

        public GridControl GetGridControl {
            get { return gridControl1; }
        }

        //public string GetCurrentDirectory {
        //    get { return sDir; }
        //}

        private void gridControl1_Load(object sender, EventArgs e) {
            unboundSource1.ValueNeeded += UnboundSource1_ValueNeeded;
            CreateData((this.FindForm() as Form1).LoadDefaultPath());
        }

        IOverlaySplashScreenHandle ShowProgressPanel() {
            return SplashScreenManager.ShowOverlayForm(this);
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }
        public void RefreshData(string path) {
            unboundSource1.SetRowCount(0);
            IOverlaySplashScreenHandle handle = null;
            try {
                handle = ShowProgressPanel();
                CreateData(path);
        }
            finally {
                CloseProgressPanel(handle);
    }
}


        public void CreateData(string path) {
            Form1 parent = this.FindForm() as Form1;
            //fullpath = parent.LoadDefaultPath() + "\\" + parent.GetActiveProduct() + "\\apidoc"
            memberNames = SearchEngineCore.GetFullFieldNames(
                path, //repoPath - (this.FindForm() as Form1).LoadDefaultPath()
                (this.FindForm() as Form1).GetActiveProduct(), //productName
                (this.FindForm() as Form1).GetActiveType());  //selected module
            unboundSource1.SetRowCount(memberNames.Count);
            //unboundSource1.SetRowCount(100);

        }



        //this custom structure allows you to compare control data with dictionary entries 
        private struct CellKey : IEquatable<CellKey> {
            int rowIndex;
            string propertyName;
            public int RowIndex { get { return rowIndex; } }
            public string PropertyName { get { return propertyName; } }
            public CellKey(int rowIndex, string propertyName) {
                this.rowIndex = rowIndex;
                this.propertyName = propertyName;
            }
            public bool Equals(CellKey other) {
                return this.RowIndex == other.RowIndex && this.PropertyName == other.PropertyName;
            }
            public override int GetHashCode() {
                return unchecked(RowIndex * 257 + (string.IsNullOrEmpty(this.PropertyName) ? 0 : this.PropertyName[0]));
            }
            public override bool Equals(object obj) {
                if (obj is CellKey)
                    return Equals((CellKey)obj);
                else
                    return false;
            }
        }

        //retrieve records from the array 
        object GetDefaultData(int rowIndex, string propertyName) {
            string[] splitString = memberNames[rowIndex].Split('\\');
            switch (propertyName) {
                case "Namespace":
                    return splitString[0];
                case "Class":
                    return splitString[1];
                

                default:
                    return String.Empty;
            }

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {

        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Clipboard.SetText(buttonEdit1.Text);
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            GridView view = sender as GridView;
            //string NamespaceName = view.GetFocusedRowCellDisplayText("Namespace");
            //string ClassName = view.GetFocusedRowCellDisplayText("Class");
            //// [ClassName.MemberName](xref:NamespaceName.ClassName.MemberName)
            //buttonEdit1.EditValue = "[](xref:" + NamespaceName + "." + ClassName + ")";
            buttonEdit1.EditValue = GenerateMarkdownLink(view, "Copy Markdown Link - Class");
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) {
                Clipboard.SetText(buttonEdit1.Text);
                e.Handled = true;
            }
        }
    }
}
