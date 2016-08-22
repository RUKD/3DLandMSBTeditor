﻿namespace MsbtEditor
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CSVExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BG4ExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manageLZ11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extractUMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lstStrings = new System.Windows.Forms.ListBox();
			this.lblStrings = new System.Windows.Forms.Label();
			this.lblEdit = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.hbxHexView = new Be.Windows.Forms.HexBox();
			this.stsMain = new System.Windows.Forms.StatusStrip();
			this.slbAddress = new System.Windows.Forms.ToolStripStatusLabel();
			this.slbActions = new System.Windows.Forms.ToolStripStatusLabel();
			this.slbStringCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtOriginal = new System.Windows.Forms.TextBox();
			this.txtEdit = new System.Windows.Forms.TextBox();
			this.lblOriginal = new System.Windows.Forms.Label();
			this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.sfdSaveEntity = new System.Windows.Forms.SaveFileDialog();
			this.btnAddLabel = new System.Windows.Forms.Button();
			this.btnDeleteLabel = new System.Windows.Forms.Button();
			this.txtLabelName = new System.Windows.Forms.TextBox();
			this.btnSaveLabel = new System.Windows.Forms.Button();
			this.mnuMain.SuspendLayout();
			this.stsMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(854, 24);
			this.mnuMain.TabIndex = 0;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_open;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_save;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_save_as;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "S&ave as...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_exit;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.searchDirectoryToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_find;
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
			this.findToolStripMenuItem.Text = "&Find";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// searchDirectoryToolStripMenuItem
			// 
			this.searchDirectoryToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_search;
			this.searchDirectoryToolStripMenuItem.Name = "searchDirectoryToolStripMenuItem";
			this.searchDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
			this.searchDirectoryToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
			this.searchDirectoryToolStripMenuItem.Text = "Search Directory";
			this.searchDirectoryToolStripMenuItem.Click += new System.EventHandler(this.searchDirectoryToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CSVExportToolStripMenuItem,
            this.BG4ExplorerToolStripMenuItem,
            this.manageLZ11ToolStripMenuItem,
            this.extractUMSBTToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// exportToolStripMenuItem
			// 
			this.CSVExportToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_export;
			this.CSVExportToolStripMenuItem.Name = "CSVExportToolStripMenuItem";
			this.CSVExportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
			this.CSVExportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.CSVExportToolStripMenuItem.Text = "&Export to CSV";
			this.CSVExportToolStripMenuItem.Click += new System.EventHandler(this.CSVExportToolStripMenuItem_Click);
			// 
			// BG4ExplorerToolStripMenuItem
			// 
			this.BG4ExplorerToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
			this.BG4ExplorerToolStripMenuItem.Name = "BG4ExplorerToolStripMenuItem";
			this.BG4ExplorerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
			this.BG4ExplorerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.BG4ExplorerToolStripMenuItem.Text = "E&xtract BG4";
			this.BG4ExplorerToolStripMenuItem.Click += new System.EventHandler(this.BG4ExplorerToolStripMenuItem_Click);
			// 
			// manageLZ11ToolStripMenuItem
			// 
			this.manageLZ11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decompressToolStripMenuItem,
            this.compressToolStripMenuItem});
			this.manageLZ11ToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_database;
			this.manageLZ11ToolStripMenuItem.Name = "manageLZ11ToolStripMenuItem";
			this.manageLZ11ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.manageLZ11ToolStripMenuItem.Text = "Manage &LZ11";
			// 
			// decompressToolStripMenuItem
			// 
			this.decompressToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
			this.decompressToolStripMenuItem.Name = "decompressToolStripMenuItem";
			this.decompressToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.decompressToolStripMenuItem.Text = "&Decompress";
			this.decompressToolStripMenuItem.Click += new System.EventHandler(this.decompressToolStripMenuItem_Click);
			// 
			// compressToolStripMenuItem
			// 
			this.compressToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_extract;
			this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
			this.compressToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.compressToolStripMenuItem.Text = "&Compress";
			this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
			// 
			// extractUMSBTToolStripMenuItem
			// 
			this.extractUMSBTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.packToolStripMenuItem});
			this.extractUMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_database;
			this.extractUMSBTToolStripMenuItem.Name = "extractUMSBTToolStripMenuItem";
			this.extractUMSBTToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.extractUMSBTToolStripMenuItem.Text = "Manage &UMSBT";
			// 
			// extractToolStripMenuItem
			// 
			this.extractToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
			this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
			this.extractToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.extractToolStripMenuItem.Text = "&Extract";
			this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
			// 
			// packToolStripMenuItem
			// 
			this.packToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_extract;
			this.packToolStripMenuItem.Name = "packToolStripMenuItem";
			this.packToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.packToolStripMenuItem.Text = "&Pack";
			this.packToolStripMenuItem.Click += new System.EventHandler(this.packToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.aboutToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_about;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// lstStrings
			// 
			this.lstStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstStrings.Enabled = false;
			this.lstStrings.FormattingEnabled = true;
			this.lstStrings.IntegralHeight = false;
			this.lstStrings.Location = new System.Drawing.Point(13, 49);
			this.lstStrings.Margin = new System.Windows.Forms.Padding(4);
			this.lstStrings.Name = "lstStrings";
			this.lstStrings.Size = new System.Drawing.Size(271, 427);
			this.lstStrings.Sorted = true;
			this.lstStrings.TabIndex = 1;
			this.lstStrings.SelectedIndexChanged += new System.EventHandler(this.lstStrings_SelectedIndexChanged);
			// 
			// lblStrings
			// 
			this.lblStrings.AutoSize = true;
			this.lblStrings.Location = new System.Drawing.Point(13, 32);
			this.lblStrings.Margin = new System.Windows.Forms.Padding(4);
			this.lblStrings.Name = "lblStrings";
			this.lblStrings.Size = new System.Drawing.Size(42, 13);
			this.lblStrings.TabIndex = 4;
			this.lblStrings.Text = "Strings:";
			// 
			// lblEdit
			// 
			this.lblEdit.AutoSize = true;
			this.lblEdit.Location = new System.Drawing.Point(288, 32);
			this.lblEdit.Margin = new System.Windows.Forms.Padding(4);
			this.lblEdit.Name = "lblEdit";
			this.lblEdit.Size = new System.Drawing.Size(28, 13);
			this.lblEdit.TabIndex = 5;
			this.lblEdit.Text = "Edit:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(288, 265);
			this.label3.Margin = new System.Windows.Forms.Padding(4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Hex View:";
			// 
			// hbxHexView
			// 
			this.hbxHexView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hbxHexView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hbxHexView.Location = new System.Drawing.Point(291, 286);
			this.hbxHexView.Margin = new System.Windows.Forms.Padding(4);
			this.hbxHexView.Name = "hbxHexView";
			this.hbxHexView.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
			this.hbxHexView.Size = new System.Drawing.Size(551, 217);
			this.hbxHexView.StringViewVisible = true;
			this.hbxHexView.TabIndex = 6;
			this.hbxHexView.UseFixedBytesPerLine = true;
			this.hbxHexView.VScrollBarVisible = true;
			this.hbxHexView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hbxSelectAll_KeyDown);
			// 
			// stsMain
			// 
			this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbAddress,
            this.slbActions,
            this.slbStringCount});
			this.stsMain.Location = new System.Drawing.Point(0, 516);
			this.stsMain.Name = "stsMain";
			this.stsMain.Size = new System.Drawing.Size(854, 22);
			this.stsMain.TabIndex = 11;
			// 
			// slbAddress
			// 
			this.slbAddress.Name = "slbAddress";
			this.slbAddress.Size = new System.Drawing.Size(279, 17);
			this.slbAddress.Spring = true;
			this.slbAddress.Text = "Address";
			this.slbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// slbActions
			// 
			this.slbActions.Name = "slbActions";
			this.slbActions.Size = new System.Drawing.Size(279, 17);
			this.slbActions.Spring = true;
			this.slbActions.Text = "Actions";
			// 
			// slbStringCount
			// 
			this.slbStringCount.Name = "slbStringCount";
			this.slbStringCount.Size = new System.Drawing.Size(279, 17);
			this.slbStringCount.Spring = true;
			this.slbStringCount.Text = "Count";
			this.slbStringCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.txtOriginal, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtEdit, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 49);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 209);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// txtOriginal
			// 
			this.txtOriginal.BackColor = System.Drawing.SystemColors.Window;
			this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOriginal.Enabled = false;
			this.txtOriginal.Location = new System.Drawing.Point(279, 0);
			this.txtOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.txtOriginal.Multiline = true;
			this.txtOriginal.Name = "txtOriginal";
			this.txtOriginal.ReadOnly = true;
			this.txtOriginal.Size = new System.Drawing.Size(272, 209);
			this.txtOriginal.TabIndex = 4;
			this.txtOriginal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectAll_KeyDown);
			// 
			// txtEdit
			// 
			this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEdit.Enabled = false;
			this.txtEdit.Location = new System.Drawing.Point(0, 0);
			this.txtEdit.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.txtEdit.Multiline = true;
			this.txtEdit.Name = "txtEdit";
			this.txtEdit.Size = new System.Drawing.Size(271, 209);
			this.txtEdit.TabIndex = 3;
			this.txtEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectAll_KeyDown);
			this.txtEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEdit_KeyUp);
			// 
			// lblOriginal
			// 
			this.lblOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblOriginal.Location = new System.Drawing.Point(567, 32);
			this.lblOriginal.Margin = new System.Windows.Forms.Padding(4);
			this.lblOriginal.Name = "lblOriginal";
			this.lblOriginal.Size = new System.Drawing.Size(48, 13);
			this.lblOriginal.TabIndex = 13;
			this.lblOriginal.Text = "Original:";
			this.lblOriginal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ofdOpenFile
			// 
			this.ofdOpenFile.Filter = "MSBT Files (*.msbt)|*.msbt|All Files (*.*)|*.*";
			// 
			// sfdSaveEntity
			// 
			this.sfdSaveEntity.Filter = "MSBT Files (*.msbt)|*.msbt";
			// 
			// btnAddLabel
			// 
			this.btnAddLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAddLabel.Enabled = false;
			this.btnAddLabel.Image = global::MsbtEditor.Properties.Resources.menu_add;
			this.btnAddLabel.Location = new System.Drawing.Point(234, 481);
			this.btnAddLabel.Name = "btnAddLabel";
			this.btnAddLabel.Size = new System.Drawing.Size(22, 22);
			this.btnAddLabel.TabIndex = 8;
			this.btnAddLabel.UseVisualStyleBackColor = true;
			this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
			// 
			// btnDeleteLabel
			// 
			this.btnDeleteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteLabel.Enabled = false;
			this.btnDeleteLabel.Image = global::MsbtEditor.Properties.Resources.menu_delete;
			this.btnDeleteLabel.Location = new System.Drawing.Point(262, 481);
			this.btnDeleteLabel.Name = "btnDeleteLabel";
			this.btnDeleteLabel.Size = new System.Drawing.Size(22, 22);
			this.btnDeleteLabel.TabIndex = 9;
			this.btnDeleteLabel.UseVisualStyleBackColor = true;
			this.btnDeleteLabel.Click += new System.EventHandler(this.btnDeleteLabel_Click);
			// 
			// txtLabelName
			// 
			this.txtLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtLabelName.Enabled = false;
			this.txtLabelName.Location = new System.Drawing.Point(13, 483);
			this.txtLabelName.Name = "txtLabelName";
			this.txtLabelName.Size = new System.Drawing.Size(187, 20);
			this.txtLabelName.TabIndex = 7;
			// 
			// btnSaveLabel
			// 
			this.btnSaveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveLabel.Enabled = false;
			this.btnSaveLabel.Image = global::MsbtEditor.Properties.Resources.menu_save;
			this.btnSaveLabel.Location = new System.Drawing.Point(206, 481);
			this.btnSaveLabel.Name = "btnSaveLabel";
			this.btnSaveLabel.Size = new System.Drawing.Size(22, 22);
			this.btnSaveLabel.TabIndex = 15;
			this.btnSaveLabel.UseVisualStyleBackColor = true;
			this.btnSaveLabel.Click += new System.EventHandler(this.btnSaveLabel_Click);
			// 
			// frmMain
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(854, 538);
			this.Controls.Add(this.btnSaveLabel);
			this.Controls.Add(this.txtLabelName);
			this.Controls.Add(this.btnDeleteLabel);
			this.Controls.Add(this.btnAddLabel);
			this.Controls.Add(this.lblOriginal);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.stsMain);
			this.Controls.Add(this.hbxHexView);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblEdit);
			this.Controls.Add(this.lblStrings);
			this.Controls.Add(this.lstStrings);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.MinimumSize = new System.Drawing.Size(870, 576);
			this.Name = "frmMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.stsMain.ResumeLayout(false);
			this.stsMain.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstStrings;
        private System.Windows.Forms.Label lblStrings;
		  private System.Windows.Forms.Label lblEdit;
		  private System.Windows.Forms.Label label3;
        private Be.Windows.Forms.HexBox hbxHexView;
		  private System.Windows.Forms.StatusStrip stsMain;
		  private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		  private System.Windows.Forms.ToolStripStatusLabel slbAddress;
		  private System.Windows.Forms.ToolStripStatusLabel slbStringCount;
		  private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		  private System.Windows.Forms.TextBox txtEdit;
		  private System.Windows.Forms.Label lblOriginal;
		  private System.Windows.Forms.OpenFileDialog ofdOpenFile;
		  private System.Windows.Forms.SaveFileDialog sfdSaveEntity;
		  private System.Windows.Forms.TextBox txtOriginal;
		  private System.Windows.Forms.ToolStripStatusLabel slbActions;
		  private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem BG4ExplorerToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem CSVExportToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem extractUMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem manageLZ11ToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem decompressToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
		  private System.Windows.Forms.Button btnAddLabel;
		  private System.Windows.Forms.Button btnDeleteLabel;
		  private System.Windows.Forms.TextBox txtLabelName;
		  private System.Windows.Forms.Button btnSaveLabel;
		  private System.Windows.Forms.ToolStripMenuItem searchDirectoryToolStripMenuItem;
    }
}

