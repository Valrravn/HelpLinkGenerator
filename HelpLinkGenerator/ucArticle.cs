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
using DevExpress.XtraEditors;

namespace HelpLinkGenerator {
    public partial class ucArticle : UserControl {
        List<Article> customDocNames;
        readonly Dictionary<CellKey, object> Differences = new Dictionary<CellKey, object>();
        
        public ucArticle() {
            InitializeComponent();
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
            string fullpath = path + "\\" + (this.FindForm() as Form1).GetActiveProduct() + "\\articles";
            if (Directory.Exists(fullpath)) {
                customDocNames = SearchEngineCore.GetCustomDocs(
                path, //repoPath - (this.FindForm() as Form1).LoadDefaultPath()
                (this.FindForm() as Form1).GetActiveProduct()); //productName
                unboundSource1.SetRowCount(customDocNames.Count);
            }
            else {
                unboundSource1.SetRowCount(0);
                XtraMessageBox.Show("The path '" + fullpath + "' does not exist");
            }
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
            switch (propertyName) {
                case "ID":
                    return (customDocNames[rowIndex] as Article).ID;
                case "Title":
                    return (customDocNames[rowIndex] as Article).Name;
                case "Owner":
                    return (customDocNames[rowIndex] as Article).Owner;
                case "Full Name":
                    return (customDocNames[rowIndex] as Article).FullName;
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
            string Title = view.GetFocusedRowCellDisplayText("Title");
            string ID = view.GetFocusedRowCellDisplayText("ID");
            // [Ribbon Form](xref:114562)
            buttonEdit1.EditValue = "[" + Title + "](xref:" + ID + ")";
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) {
                Clipboard.SetText(buttonEdit1.Text);
                e.Handled = true;
            }
        }
    }
}
