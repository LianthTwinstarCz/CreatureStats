namespace CreatureStats
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchResultListView = new System.Windows.Forms.ListView();
            this.CreatureEntryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreatureNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchListViewRowCount = new System.Windows.Forms.RichTextBox();
            this.CreatureTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.NameOrIdComboBox = new System.Windows.Forms.ComboBox();
            this.NameOrIdTextBox = new System.Windows.Forms.TextBox();
            this.CreatureSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AdvancedFilterComboBox = new System.Windows.Forms.ComboBox();
            this.AdvancedFilterTextBox = new System.Windows.Forms.TextBox();
            this.FlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.FlagsComboBox = new System.Windows.Forms.ComboBox();
            this.FlagsEnumComboBox = new System.Windows.Forms.ComboBox();
            this.FlagsEnumValuesComboBox = new System.Windows.Forms.ComboBox();
            this.CreatureInformativeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewGroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateTextBox = new System.Windows.Forms.TextBox();
            this.VendorOrTrainerTabPage = new System.Windows.Forms.TabPage();
            this.CreatureTabControl.SuspendLayout();
            this.CreatureSearchGroupBox.SuspendLayout();
            this.FlagsGroupBox.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.ListViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchResultListView
            // 
            this.SearchResultListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.SearchResultListView.AllowColumnReorder = true;
            this.SearchResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CreatureEntryColumnHeader,
            this.CreatureNameColumnHeader});
            this.SearchResultListView.FullRowSelect = true;
            this.SearchResultListView.GridLines = true;
            this.SearchResultListView.HideSelection = false;
            this.SearchResultListView.Location = new System.Drawing.Point(8, 66);
            this.SearchResultListView.Margin = new System.Windows.Forms.Padding(4);
            this.SearchResultListView.MultiSelect = false;
            this.SearchResultListView.Name = "SearchResultListView";
            this.SearchResultListView.Size = new System.Drawing.Size(339, 355);
            this.SearchResultListView.TabIndex = 7;
            this.SearchResultListView.UseCompatibleStateImageBehavior = false;
            this.SearchResultListView.View = System.Windows.Forms.View.Details;
            this.SearchResultListView.VirtualMode = true;
            this.SearchResultListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.SearchResultsListViewRetrieveVItem);
            this.SearchResultListView.SelectedIndexChanged += new System.EventHandler(this.SearchResultListViewSelectedIndexChanged);
            // 
            // CreatureEntryColumnHeader
            // 
            this.CreatureEntryColumnHeader.Text = "Creature Entry";
            this.CreatureEntryColumnHeader.Width = 81;
            // 
            // CreatureNameColumnHeader
            // 
            this.CreatureNameColumnHeader.Text = "Creature Name";
            this.CreatureNameColumnHeader.Width = 170;
            // 
            // SearchListViewRowCount
            // 
            this.SearchListViewRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchListViewRowCount.BackColor = System.Drawing.Color.Honeydew;
            this.SearchListViewRowCount.Location = new System.Drawing.Point(8, 434);
            this.SearchListViewRowCount.Margin = new System.Windows.Forms.Padding(4);
            this.SearchListViewRowCount.Name = "SearchListViewRowCount";
            this.SearchListViewRowCount.ReadOnly = true;
            this.SearchListViewRowCount.Size = new System.Drawing.Size(339, 0);
            this.SearchListViewRowCount.TabIndex = 12;
            this.SearchListViewRowCount.Text = "";
            // 
            // CreatureTabControl
            // 
            this.CreatureTabControl.Controls.Add(this.MainTabPage);
            this.CreatureTabControl.Controls.Add(this.VendorOrTrainerTabPage);
            this.CreatureTabControl.Location = new System.Drawing.Point(27, 33);
            this.CreatureTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.CreatureTabControl.Name = "CreatureTabControl";
            this.CreatureTabControl.SelectedIndex = 0;
            this.CreatureTabControl.Size = new System.Drawing.Size(293, 22);
            this.CreatureTabControl.TabIndex = 9;
            this.CreatureTabControl.SelectedIndexChanged += new System.EventHandler(this.CreatureTabControlSelectedIndexChanged);
            // 
            // MainTabPage
            // 
            this.MainTabPage.Location = new System.Drawing.Point(4, 25);
            this.MainTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.MainTabPage.Size = new System.Drawing.Size(285, 0);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Creature Info";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // NameOrIdComboBox
            // 
            this.NameOrIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameOrIdComboBox.FormattingEnabled = true;
            this.NameOrIdComboBox.Items.AddRange(new object[] {
            "Creature ID",
            "Creature Name"});
            this.NameOrIdComboBox.Location = new System.Drawing.Point(8, 22);
            this.NameOrIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameOrIdComboBox.Name = "NameOrIdComboBox";
            this.NameOrIdComboBox.Size = new System.Drawing.Size(129, 24);
            this.NameOrIdComboBox.TabIndex = 3;
            // 
            // NameOrIdTextBox
            // 
            this.NameOrIdTextBox.Location = new System.Drawing.Point(147, 25);
            this.NameOrIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameOrIdTextBox.Name = "NameOrIdTextBox";
            this.NameOrIdTextBox.Size = new System.Drawing.Size(99, 22);
            this.NameOrIdTextBox.TabIndex = 4;
            this.NameOrIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameOrIdOrGUIDKeyDown);
            // 
            // CreatureSearchGroupBox
            // 
            this.CreatureSearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatureSearchGroupBox.Controls.Add(this.NameOrIdComboBox);
            this.CreatureSearchGroupBox.Controls.Add(this.SearchButton);
            this.CreatureSearchGroupBox.Controls.Add(this.NameOrIdTextBox);
            this.CreatureSearchGroupBox.Controls.Add(this.AdvancedFilterComboBox);
            this.CreatureSearchGroupBox.Controls.Add(this.AdvancedFilterTextBox);
            this.CreatureSearchGroupBox.Location = new System.Drawing.Point(899, 33);
            this.CreatureSearchGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatureSearchGroupBox.Name = "CreatureSearchGroupBox";
            this.CreatureSearchGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.CreatureSearchGroupBox.Size = new System.Drawing.Size(356, 128);
            this.CreatureSearchGroupBox.TabIndex = 11;
            this.CreatureSearchGroupBox.TabStop = false;
            this.CreatureSearchGroupBox.Text = "Creature Search";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(255, 22);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 28);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search!";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchMouseClickEvent);
            // 
            // AdvancedFilterComboBox
            // 
            this.AdvancedFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdvancedFilterComboBox.FormattingEnabled = true;
            this.AdvancedFilterComboBox.IntegralHeight = false;
            this.AdvancedFilterComboBox.ItemHeight = 16;
            this.AdvancedFilterComboBox.Items.AddRange(new object[] {
            "Advanced Filter",
            "MapId",
            "ModelId",
            "MinLevel",
            "MaxLevel",
            "FactionA",
            "FactionH",
            "VehicleId"});
            this.AdvancedFilterComboBox.Location = new System.Drawing.Point(10, 76);
            this.AdvancedFilterComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdvancedFilterComboBox.Name = "AdvancedFilterComboBox";
            this.AdvancedFilterComboBox.Size = new System.Drawing.Size(237, 24);
            this.AdvancedFilterComboBox.TabIndex = 11;
            this.AdvancedFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.AdvancedFilterComboBoxSelectedIndexChanged);
            // 
            // AdvancedFilterTextBox
            // 
            this.AdvancedFilterTextBox.Location = new System.Drawing.Point(255, 78);
            this.AdvancedFilterTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdvancedFilterTextBox.Name = "AdvancedFilterTextBox";
            this.AdvancedFilterTextBox.Size = new System.Drawing.Size(92, 22);
            this.AdvancedFilterTextBox.TabIndex = 6;
            this.AdvancedFilterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdvancedFilterTextBoxKeyDown);
            // 
            // FlagsGroupBox
            // 
            this.FlagsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FlagsGroupBox.Controls.Add(this.FlagsComboBox);
            this.FlagsGroupBox.Controls.Add(this.FlagsEnumComboBox);
            this.FlagsGroupBox.Controls.Add(this.FlagsEnumValuesComboBox);
            this.FlagsGroupBox.Location = new System.Drawing.Point(897, 177);
            this.FlagsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.FlagsGroupBox.Name = "FlagsGroupBox";
            this.FlagsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.FlagsGroupBox.Size = new System.Drawing.Size(356, 89);
            this.FlagsGroupBox.TabIndex = 0;
            this.FlagsGroupBox.TabStop = false;
            this.FlagsGroupBox.Text = "Flag Search";
            // 
            // FlagsComboBox
            // 
            this.FlagsComboBox.Items.AddRange(new object[] {
            "Unit Flags",
            "Dynamic Flags",
            "NPC Flags",
            "Extra Flags",
            "Type Flags",
            "Unit Class",
            "Mechanic Immune Mask"});
            this.FlagsComboBox.Location = new System.Drawing.Point(8, 23);
            this.FlagsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FlagsComboBox.Name = "FlagsComboBox";
            this.FlagsComboBox.Size = new System.Drawing.Size(92, 24);
            this.FlagsComboBox.TabIndex = 14;
            this.FlagsComboBox.SelectedIndexChanged += new System.EventHandler(this.FlagsComboBoxSelectedIndexChanged);
            // 
            // FlagsEnumComboBox
            // 
            this.FlagsEnumComboBox.Items.AddRange(new object[] {
            "==",
            "!="});
            this.FlagsEnumComboBox.Location = new System.Drawing.Point(109, 23);
            this.FlagsEnumComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FlagsEnumComboBox.Name = "FlagsEnumComboBox";
            this.FlagsEnumComboBox.Size = new System.Drawing.Size(129, 24);
            this.FlagsEnumComboBox.TabIndex = 15;
            this.FlagsEnumComboBox.SelectedIndexChanged += new System.EventHandler(this.FlagsSelectedIndexChanged);
            // 
            // FlagsEnumValuesComboBox
            // 
            this.FlagsEnumValuesComboBox.DropDownHeight = 500;
            this.FlagsEnumValuesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlagsEnumValuesComboBox.DropDownWidth = 302;
            this.FlagsEnumValuesComboBox.IntegralHeight = false;
            this.FlagsEnumValuesComboBox.ItemHeight = 16;
            this.FlagsEnumValuesComboBox.Location = new System.Drawing.Point(248, 23);
            this.FlagsEnumValuesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FlagsEnumValuesComboBox.Name = "FlagsEnumValuesComboBox";
            this.FlagsEnumValuesComboBox.Size = new System.Drawing.Size(91, 24);
            this.FlagsEnumValuesComboBox.TabIndex = 12;
            // 
            // CreatureInformativeRichTextBox
            // 
            this.CreatureInformativeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatureInformativeRichTextBox.BackColor = System.Drawing.Color.Honeydew;
            this.CreatureInformativeRichTextBox.Location = new System.Drawing.Point(27, 53);
            this.CreatureInformativeRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CreatureInformativeRichTextBox.Name = "CreatureInformativeRichTextBox";
            this.CreatureInformativeRichTextBox.ReadOnly = true;
            this.CreatureInformativeRichTextBox.Size = new System.Drawing.Size(863, 619);
            this.CreatureInformativeRichTextBox.TabIndex = 8;
            this.CreatureInformativeRichTextBox.Text = "";
            this.CreatureInformativeRichTextBox.TextChanged += new System.EventHandler(this.CreatureInformativeTextChanged);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1257, 28);
            this.MainMenu.TabIndex = 12;
            this.MainMenu.Text = "Main Menu";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.InfoToolStripMenuItem.Text = "About...";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // ListViewGroupBox
            // 
            this.ListViewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewGroupBox.Controls.Add(this.UpdateTextBox);
            this.ListViewGroupBox.Controls.Add(this.SearchListViewRowCount);
            this.ListViewGroupBox.Controls.Add(this.SearchResultListView);
            this.ListViewGroupBox.Location = new System.Drawing.Point(899, 244);
            this.ListViewGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewGroupBox.Name = "ListViewGroupBox";
            this.ListViewGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ListViewGroupBox.Size = new System.Drawing.Size(356, 430);
            this.ListViewGroupBox.TabIndex = 12;
            this.ListViewGroupBox.TabStop = false;
            this.ListViewGroupBox.Text = "List Search";
            // 
            // UpdateTextBox
            // 
            this.UpdateTextBox.Location = new System.Drawing.Point(8, 28);
            this.UpdateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateTextBox.Name = "UpdateTextBox";
            this.UpdateTextBox.Size = new System.Drawing.Size(339, 22);
            this.UpdateTextBox.TabIndex = 13;
            this.UpdateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateTextBoxKeyDown);
            // 
            // VendorOrTrainerTabPage
            // 
            this.VendorOrTrainerTabPage.Location = new System.Drawing.Point(4, 25);
            this.VendorOrTrainerTabPage.Name = "Vendor/Trainer Info";
            this.VendorOrTrainerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VendorOrTrainerTabPage.Size = new System.Drawing.Size(285, 0);
            this.VendorOrTrainerTabPage.TabIndex = 1;
            this.VendorOrTrainerTabPage.Text = "VendorOrTrainerTabPage";
            this.VendorOrTrainerTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 688);
            this.Controls.Add(this.CreatureSearchGroupBox);
            this.Controls.Add(this.ListViewGroupBox);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.CreatureInformativeRichTextBox);
            this.Controls.Add(this.FlagsGroupBox);
            this.Controls.Add(this.CreatureTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creature Stats";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.CreatureTabControl.ResumeLayout(false);
            this.CreatureSearchGroupBox.ResumeLayout(false);
            this.CreatureSearchGroupBox.PerformLayout();
            this.FlagsGroupBox.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ListViewGroupBox.ResumeLayout(false);
            this.ListViewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Variables for search criterias
        private System.Windows.Forms.TextBox        NameOrIdTextBox;
        private System.Windows.Forms.ComboBox       NameOrIdComboBox;
        private System.Windows.Forms.GroupBox       CreatureSearchGroupBox;
        private System.Windows.Forms.Button         SearchButton;
        private System.Windows.Forms.ListView       SearchResultListView;
        private System.Windows.Forms.TabControl     CreatureTabControl;
        private System.Windows.Forms.TabPage        MainTabPage;
        private System.Windows.Forms.TabPage        VendorOrTrainerTabPage;
        private System.Windows.Forms.RichTextBox    CreatureInformativeRichTextBox;
        private System.Windows.Forms.ColumnHeader   CreatureEntryColumnHeader;
        private System.Windows.Forms.ColumnHeader   CreatureNameColumnHeader;
        private System.Windows.Forms.ComboBox       AdvancedFilterComboBox;
        private System.Windows.Forms.TextBox        AdvancedFilterTextBox;
        private System.Windows.Forms.RichTextBox    SearchListViewRowCount;
        private System.Windows.Forms.GroupBox       ListViewGroupBox;
        private System.Windows.Forms.GroupBox       FlagsGroupBox;
        private System.Windows.Forms.ComboBox       FlagsComboBox;
        private System.Windows.Forms.ComboBox       FlagsEnumComboBox;
        private System.Windows.Forms.ComboBox       FlagsEnumValuesComboBox;
        private System.Windows.Forms.TextBox        UpdateTextBox;

        // Menu
        private System.Windows.Forms.MenuStrip         MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
    }
}
