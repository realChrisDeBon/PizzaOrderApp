namespace Pizza
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            settings_menu = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            modifyListToolStripMenuItem = new ToolStripMenuItem();
            defaultBrowserToolStripMenuItem = new ToolStripMenuItem();
            firefoxToolStripMenuItem = new ToolStripMenuItem();
            braveToolStripMenuItem = new ToolStripMenuItem();
            chromeToolStripMenuItem = new ToolStripMenuItem();
            iExplorerToolStripMenuItem = new ToolStripMenuItem();
            settings_menu.SuspendLayout();
            SuspendLayout();
            // 
            // settings_menu
            // 
            settings_menu.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            settings_menu.Location = new Point(0, 0);
            settings_menu.Name = "settings_menu";
            settings_menu.Size = new Size(229, 24);
            settings_menu.TabIndex = 0;
            settings_menu.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modifyListToolStripMenuItem, defaultBrowserToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // modifyListToolStripMenuItem
            // 
            modifyListToolStripMenuItem.Name = "modifyListToolStripMenuItem";
            modifyListToolStripMenuItem.Size = new Size(180, 22);
            modifyListToolStripMenuItem.Text = "Edit list";
            modifyListToolStripMenuItem.Click += modifyListToolStripMenuItem_Click;
            // 
            // defaultBrowserToolStripMenuItem
            // 
            defaultBrowserToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { firefoxToolStripMenuItem, braveToolStripMenuItem, chromeToolStripMenuItem, iExplorerToolStripMenuItem });
            defaultBrowserToolStripMenuItem.Name = "defaultBrowserToolStripMenuItem";
            defaultBrowserToolStripMenuItem.Size = new Size(180, 22);
            defaultBrowserToolStripMenuItem.Text = "Default browser";
            // 
            // firefoxToolStripMenuItem
            // 
            firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
            firefoxToolStripMenuItem.Size = new Size(180, 22);
            firefoxToolStripMenuItem.Text = "Firefox";
            firefoxToolStripMenuItem.Click += firefoxToolStripMenuItem_Click;
            // 
            // braveToolStripMenuItem
            // 
            braveToolStripMenuItem.CheckOnClick = true;
            braveToolStripMenuItem.Name = "braveToolStripMenuItem";
            braveToolStripMenuItem.Size = new Size(180, 22);
            braveToolStripMenuItem.Text = "Brave";
            braveToolStripMenuItem.Click += braveToolStripMenuItem_Click;
            // 
            // chromeToolStripMenuItem
            // 
            chromeToolStripMenuItem.CheckOnClick = true;
            chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            chromeToolStripMenuItem.Size = new Size(180, 22);
            chromeToolStripMenuItem.Text = "Chrome";
            chromeToolStripMenuItem.Click += chromeToolStripMenuItem_Click;
            // 
            // iExplorerToolStripMenuItem
            // 
            iExplorerToolStripMenuItem.CheckOnClick = true;
            iExplorerToolStripMenuItem.Name = "iExplorerToolStripMenuItem";
            iExplorerToolStripMenuItem.Size = new Size(180, 22);
            iExplorerToolStripMenuItem.Text = "IExplorer";
            iExplorerToolStripMenuItem.Click += iExplorerToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 441);
            Controls.Add(settings_menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = settings_menu;
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Pizza";
            Load += MainForm_Load;
            settings_menu.ResumeLayout(false);
            settings_menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip settings_menu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem modifyListToolStripMenuItem;
        private ToolStripMenuItem defaultBrowserToolStripMenuItem;
        private ToolStripMenuItem firefoxToolStripMenuItem;
        private ToolStripMenuItem braveToolStripMenuItem;
        private ToolStripMenuItem chromeToolStripMenuItem;
        private ToolStripMenuItem iExplorerToolStripMenuItem;
    }
}