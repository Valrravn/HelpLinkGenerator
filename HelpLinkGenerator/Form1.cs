using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelpLinkGenerator {

    public partial class Form1 : XtraForm {
        string rePath;
        private XtraFolderBrowserDialog folderBrowserDialog1;

        public Form1() {
            this.Icon = HelpLinkGenerator.Properties.Resources.chain_icon;
            InitializeComponent();
            this.folderBrowserDialog1 = new XtraFolderBrowserDialog();
            folderBrowserDialog1.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide;
            //check folder first launch
            if (!File.Exists(@"Data\DefaultRepoPath.txt")) {
                System.IO.Directory.CreateDirectory(@"Data");
                File.Create(@"Data\DefaultRepoPath.txt");
            }
            //load default repository path
            if (LoadDefaultPath() == String.Empty) {
                if (SelectRepoFolder() != DialogResult.OK) System.Environment.Exit(0);
            }
            RetrieveProductList();

            comboBoxEdit1.EditValueChanged += ComboBoxEdit1_EditValueChanged;
            SaveRepoDirectory();
        }


        private void ComboBoxEdit1_EditValueChanged(object sender, EventArgs e) {
            RefreshUserControls();
        }

        public void RefreshUserControls() {
            switch (GetActiveType()) {
                case ("Members"):
                    pageMembers.Controls.OfType<ucAPIMember>().First().RefreshData(rePath);
                    break;
                case ("Classes"):
                    pageClasses.Controls.OfType<ucAPIClass>().First().RefreshData(rePath);
                    break;
                case ("Namespaces"):
                    pageNSpaces.Controls.OfType<ucAPINspace>().First().RefreshData(rePath);
                    break;
                case ("Examples"):
                    pageExamples.Controls.OfType<ucAPIExample>().First().RefreshData(rePath);
                    break;
                case ("Templates"):
                    pageTemplates.Controls.OfType<ucTemplate>().First().RefreshData(rePath);
                    break;
                case ("Articles"):
                    pageArticles.Controls.OfType<ucArticle>().First().RefreshData(rePath);
                    break;
            }
        }

        public string GetActiveProduct() {
            return comboBoxEdit1.EditValue.ToString();
        }

        public string GetActiveType() {
            return officeNavigationBar1.SelectedItem.Text;
        }

        public string LoadDefaultPath() {
            return rePath = System.IO.File.ReadAllText(@"Data\DefaultRepoPath.txt");
        }

        public DialogResult SelectRepoFolder() {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                rePath = folderBrowserDialog1.SelectedPath;

            }
            return result;
        }


        public void SaveRepoDirectory() {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"Data\DefaultRepoPath.txt", rePath);
        }

        public void RetrieveProductList() {
            comboBoxEdit1.Properties.Items.Clear();
            foreach (string s in Directory.GetDirectories(rePath)) {
                comboBoxEdit1.Properties.Items.Add(s.Remove(0, rePath.Length + 1));
            }
            comboBoxEdit1.EditValue = comboBoxEdit1.Properties.Items[0];
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            SelectRepoFolder();
            RetrieveProductList();
            RefreshUserControls();
            SaveRepoDirectory();
        }

        private void officeNavigationBar1_SelectedItemChanged(object sender, NavigationBarItemEventArgs e) {
            switch (e.Item.Text) {
                case ("Members"): navigationFrame2.SelectedPage = pageMembers; pageMembers.Controls.OfType<ucAPIMember>().First().RefreshData(rePath); break;
                case ("Classes"): navigationFrame2.SelectedPage = pageClasses; pageClasses.Controls.OfType<ucAPIClass>().First().RefreshData(rePath);  break;
                case ("Namespaces"): navigationFrame2.SelectedPage = pageNSpaces; pageNSpaces.Controls.OfType<ucAPINspace>().First().RefreshData(rePath);  break;
                case ("Examples"): navigationFrame2.SelectedPage = pageExamples; pageExamples.Controls.OfType<ucAPIExample>().First().RefreshData(rePath); break;
                case ("Templates"): navigationFrame2.SelectedPage = pageTemplates; pageTemplates.Controls.OfType<ucTemplate>().First().RefreshData(rePath); break;
                case ("Articles"): navigationFrame2.SelectedPage = pageArticles; pageArticles.Controls.OfType<ucArticle>().First().RefreshData(rePath); break;
            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e) {
            CheckButton button = sender as CheckButton;

            if (button.Checked == true) UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.TwentyGold);
                else UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.Twenty);
        }

        private void Form1_Resize(object sender, EventArgs e) {
            //if (this.WindowState == FormWindowState.Minimized) {
            //    Hide();
            //    notifyIcon1.Visible = true;
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            //Show();
            //this.WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F5) RefreshUserControls();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            RefreshUserControls();
        }
    }
}
