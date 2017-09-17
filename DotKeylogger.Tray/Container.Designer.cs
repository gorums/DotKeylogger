namespace DotKeylogger.Tray
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem = new System.Windows.Forms.MenuItem();
            this.trayComponent = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem});
            // 
            // menuItem
            // 
            this.menuItem.Index = 0;
            this.menuItem.Text = "E&xit";
            this.menuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // trayComponent
            // 
            this.trayComponent.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayComponent.BalloonTipText = "DotKeylogger";
            this.trayComponent.BalloonTipTitle = "DotKeylogger";
            this.trayComponent.ContextMenu = this.contextMenu;
            this.trayComponent.Icon = ((System.Drawing.Icon)(resources.GetObject("trayComponent.Icon")));
            this.trayComponent.Text = "DotKeylogger";
            // 
            // Container
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Container";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayComponent;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem menuItem;
    }
}

