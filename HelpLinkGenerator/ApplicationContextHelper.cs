using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelpLinkGenerator {
    class ApplicationContextHelper : ApplicationContext {
        //Component declarations
        private NotifyIcon TrayIcon;
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem RestoreMenuItem;
        private ToolStripMenuItem CloseMenuItem;
        bool closeFlag = false;
        Form1 mainForm;
        public ApplicationContextHelper() {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            TrayIcon.Visible = false;
            mainForm = new Form1();
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.Resize += MainForm_Resize;
            mainForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (!closeFlag) {
                e.Cancel = true;
                mainForm.Hide();
                TrayIcon.Visible = true;
                CloseToTrayBalloonText();
                TrayIcon.ShowBalloonTip(500);
                DoubleClickBalloonText();
            }
            else e.Cancel = false;
        }

        

        private void MainForm_Resize(object sender, EventArgs e) {
            if (mainForm.WindowState == FormWindowState.Minimized) {
                mainForm.Hide();
                TrayIcon.Visible = true;
            }
        }

        public void DoubleClickBalloonText() {
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText =
              "Thanks for using this crap" + Environment.NewLine + "New versions can (maybe) be found at ....";
            TrayIcon.BalloonTipTitle = "You called Master?";
        }

        public void CloseToTrayBalloonText() {
            TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
            TrayIcon.BalloonTipText =
              "The application is still running. Double-click to restore or right-click to exit.";
            TrayIcon.BalloonTipTitle = "";
        }

        private void InitializeComponent() {
            TrayIcon = new NotifyIcon();
            DoubleClickBalloonText();




            TrayIcon.Text = "Double-click to restore";

            //The icon is added to the project resources.
            //Here I assume that the name of the file is 'TrayIcon.ico'
            TrayIcon.Icon = Properties.Resources.chain_icon;

            //Optional - handle doubleclicks on the icon:
            TrayIcon.DoubleClick += TrayIcon_DoubleClick;

            //Optional - Add a context menu to the TrayIcon:
            TrayIconContextMenu = new ContextMenuStrip();
            RestoreMenuItem = new ToolStripMenuItem();
            CloseMenuItem = new ToolStripMenuItem();
            TrayIconContextMenu.SuspendLayout();

            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] {
            this.RestoreMenuItem, this.CloseMenuItem});
            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.Size = new Size(153, 190);
            // 
            // RestoreMenuItem
            // 
            this.RestoreMenuItem.Name = "CloseMenuItem";
            this.RestoreMenuItem.Size = new Size(152, 22);
            this.RestoreMenuItem.Text = "Restore";
            this.RestoreMenuItem.Click += new EventHandler(this.TrayIcon_DoubleClick);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new Size(152, 22);
            this.CloseMenuItem.Text = "Exit";
            this.CloseMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);

            TrayIconContextMenu.ResumeLayout(false);
            TrayIcon.ContextMenuStrip = TrayIconContextMenu;
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            //Cleanup so that the icon will be removed when the application is closed
            TrayIcon.Visible = false;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e) {
            mainForm.Show();
            mainForm.WindowState = FormWindowState.Normal;
            TrayIcon.Visible = false;
        }

        private void CloseMenuItem_Click(object sender, EventArgs e) {
            closeFlag = true;
            Application.Exit();
        }
    }
}