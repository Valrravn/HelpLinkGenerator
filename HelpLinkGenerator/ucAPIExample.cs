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
    public partial class ucAPIExample : UserControl {
        List<String> memberNames;
        readonly Dictionary<CellKey, object> Differences = new Dictionary<CellKey, object>();
        
        public ucAPIExample() {
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
            string fullpath = path + "\\" + (this.FindForm() as Form1).GetActiveProduct() + "\\" + (this.FindForm() as Form1).GetActiveType();
            if (Directory.Exists(fullpath)) {
                memberNames = SearchEngineCore.GetFullFieldNames(
                path, //repoPath - (this.FindForm() as Form1).LoadDefaultPath()
                (this.FindForm() as Form1).GetActiveProduct(), //productName
                (this.FindForm() as Form1).GetActiveType());  //selected module
                unboundSource1.SetRowCount(memberNames.Count);
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
            string fullExampleName = memberNames[rowIndex];
            string pattern = @"\d+$";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string exampleNoMD = fullExampleName.Remove(fullExampleName.Length - 3, 3); //remove .md extension
            string exampleNoMDID = rgx.Replace(exampleNoMD, replacement); //remove numeric ID
            string exampleID = exampleNoMD.Replace(exampleNoMDID, "");

            switch (propertyName) {
                case "Example Name":
                    return exampleNoMDID; 
                case "ID":
                    return exampleID;
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
            string ExampleName = view.GetFocusedRowCellDisplayText("Example Name");
            string ID = view.GetFocusedRowCellDisplayText("ID");
            // [!include[DataBarFormatRuleAtDesignTimeAndInCode](~/examples\databarformatruleatdesigntimeandincode4932.md)]
            buttonEdit1.EditValue = "[!include[" + ExampleName + @"](~/examples\" + ExampleName + ID + ".md)]";
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) {
                Clipboard.SetText(buttonEdit1.Text);
                e.Handled = true;
            }
        }
    }
}
