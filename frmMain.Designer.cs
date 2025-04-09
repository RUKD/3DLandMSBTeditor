namespace MsbtEditor
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
            this.xMSBTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchExportXMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchImportXMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMSBTModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bG4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BG4ExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractUMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packUMSBTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lZ11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBATempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstStrings = new System.Windows.Forms.ListBox();
            this.lblStrings = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblHexView = new System.Windows.Forms.Label();
            this.hbxHexView = new Be.Windows.Forms.HexBox();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.slbAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbActions = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbStringCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveEntity = new System.Windows.Forms.SaveFileDialog();
            this.btnAddLabel = new System.Windows.Forms.Button();
            this.btnDeleteLabel = new System.Windows.Forms.Button();
            this.txtLabelName = new System.Windows.Forms.TextBox();
            this.btnSaveLabel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.pnlLabelTools = new System.Windows.Forms.Panel();
            this.tlpLabelTools = new System.Windows.Forms.TableLayoutPanel();
            this.splView = new System.Windows.Forms.SplitContainer();
            this.splEdit = new System.Windows.Forms.SplitContainer();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.pnlLabelTools.SuspendLayout();
            this.tlpLabelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splView)).BeginInit();
            this.splView.Panel1.SuspendLayout();
            this.splView.Panel2.SuspendLayout();
            this.splView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splEdit)).BeginInit();
            this.splEdit.Panel1.SuspendLayout();
            this.splEdit.Panel2.SuspendLayout();
            this.splEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.xMSBTToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.mnuMain.Size = new System.Drawing.Size(1708, 46);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_save_as;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.saveAsToolStripMenuItem.Text = "S&ave as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(290, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(293, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.searchDirectoryToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_find;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(466, 44);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // searchDirectoryToolStripMenuItem
            // 
            this.searchDirectoryToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_search;
            this.searchDirectoryToolStripMenuItem.Name = "searchDirectoryToolStripMenuItem";
            this.searchDirectoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.searchDirectoryToolStripMenuItem.Size = new System.Drawing.Size(466, 44);
            this.searchDirectoryToolStripMenuItem.Text = "Search Directory";
            this.searchDirectoryToolStripMenuItem.Click += new System.EventHandler(this.searchDirectoryToolStripMenuItem_Click);
            // 
            // xMSBTToolStripMenuItem1
            // 
            this.xMSBTToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMSBTToolStripMenuItem,
            this.importXMSBTToolStripMenuItem,
            this.batchExportXMSBTToolStripMenuItem,
            this.batchImportXMSBTToolStripMenuItem,
            this.exportXMSBTModToolStripMenuItem});
            this.xMSBTToolStripMenuItem1.Name = "xMSBTToolStripMenuItem1";
            this.xMSBTToolStripMenuItem1.Size = new System.Drawing.Size(109, 38);
            this.xMSBTToolStripMenuItem1.Text = "XMSBT";
            // 
            // exportXMSBTToolStripMenuItem
            // 
            this.exportXMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_export;
            this.exportXMSBTToolStripMenuItem.Name = "exportXMSBTToolStripMenuItem";
            this.exportXMSBTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.exportXMSBTToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportXMSBTToolStripMenuItem.Text = "&Export";
            this.exportXMSBTToolStripMenuItem.Click += new System.EventHandler(this.exportXMSBTToolStripMenuItem_Click);
            // 
            // importXMSBTToolStripMenuItem
            // 
            this.importXMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_import;
            this.importXMSBTToolStripMenuItem.Name = "importXMSBTToolStripMenuItem";
            this.importXMSBTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.importXMSBTToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.importXMSBTToolStripMenuItem.Text = "&Import";
            this.importXMSBTToolStripMenuItem.Click += new System.EventHandler(this.importXMSBTToolStripMenuItem_Click);
            // 
            // batchExportXMSBTToolStripMenuItem
            // 
            this.batchExportXMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_batch_export;
            this.batchExportXMSBTToolStripMenuItem.Name = "batchExportXMSBTToolStripMenuItem";
            this.batchExportXMSBTToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.batchExportXMSBTToolStripMenuItem.Text = "Batch Export";
            this.batchExportXMSBTToolStripMenuItem.Click += new System.EventHandler(this.batchExportXMSBTToolStripMenuItem_Click);
            // 
            // batchImportXMSBTToolStripMenuItem
            // 
            this.batchImportXMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_batch_import;
            this.batchImportXMSBTToolStripMenuItem.Name = "batchImportXMSBTToolStripMenuItem";
            this.batchImportXMSBTToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.batchImportXMSBTToolStripMenuItem.Text = "Batch Import";
            this.batchImportXMSBTToolStripMenuItem.Click += new System.EventHandler(this.batchImportXMSBTToolStripMenuItem_Click);
            // 
            // exportXMSBTModToolStripMenuItem
            // 
            this.exportXMSBTModToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_gamebanana;
            this.exportXMSBTModToolStripMenuItem.Name = "exportXMSBTModToolStripMenuItem";
            this.exportXMSBTModToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportXMSBTModToolStripMenuItem.Text = "Export &Mod";
            this.exportXMSBTModToolStripMenuItem.Click += new System.EventHandler(this.exportXMSBTModToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCSVToolStripMenuItem,
            this.bG4ToolStripMenuItem,
            this.uMSBTToolStripMenuItem,
            this.lZ11ToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(89, 38);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // exportCSVToolStripMenuItem
            // 
            this.exportCSVToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_export;
            this.exportCSVToolStripMenuItem.Name = "exportCSVToolStripMenuItem";
            this.exportCSVToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.exportCSVToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.exportCSVToolStripMenuItem.Text = "&Export to CSV";
            this.exportCSVToolStripMenuItem.Click += new System.EventHandler(this.exportCSVToolStripMenuItem_Click);
            // 
            // bG4ToolStripMenuItem
            // 
            this.bG4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BG4ExplorerToolStripMenuItem});
            this.bG4ToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_database;
            this.bG4ToolStripMenuItem.Name = "bG4ToolStripMenuItem";
            this.bG4ToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.bG4ToolStripMenuItem.Text = "&BG4";
            // 
            // BG4ExplorerToolStripMenuItem
            // 
            this.BG4ExplorerToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
            this.BG4ExplorerToolStripMenuItem.Name = "BG4ExplorerToolStripMenuItem";
            this.BG4ExplorerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.BG4ExplorerToolStripMenuItem.Size = new System.Drawing.Size(256, 44);
            this.BG4ExplorerToolStripMenuItem.Text = "&Extract";
            this.BG4ExplorerToolStripMenuItem.Click += new System.EventHandler(this.BG4ExplorerToolStripMenuItem_Click);
            // 
            // uMSBTToolStripMenuItem
            // 
            this.uMSBTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractUMSBTToolStripMenuItem,
            this.packUMSBTToolStripMenuItem,
            this.extractBatchToolStripMenuItem});
            this.uMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_database;
            this.uMSBTToolStripMenuItem.Name = "uMSBTToolStripMenuItem";
            this.uMSBTToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.uMSBTToolStripMenuItem.Text = "&UMSBT";
            // 
            // extractUMSBTToolStripMenuItem
            // 
            this.extractUMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
            this.extractUMSBTToolStripMenuItem.Name = "extractUMSBTToolStripMenuItem";
            this.extractUMSBTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.extractUMSBTToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.extractUMSBTToolStripMenuItem.Text = "&Extract";
            this.extractUMSBTToolStripMenuItem.Click += new System.EventHandler(this.extractUMSBTToolStripMenuItem_Click);
            // 
            // packUMSBTToolStripMenuItem
            // 
            this.packUMSBTToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_extract;
            this.packUMSBTToolStripMenuItem.Name = "packUMSBTToolStripMenuItem";
            this.packUMSBTToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.packUMSBTToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.packUMSBTToolStripMenuItem.Text = "&Pack";
            this.packUMSBTToolStripMenuItem.Click += new System.EventHandler(this.packUMSBTToolStripMenuItem_Click);
            // 
            // extractBatchToolStripMenuItem
            // 
            this.extractBatchToolStripMenuItem.Name = "extractBatchToolStripMenuItem";
            this.extractBatchToolStripMenuItem.Size = new System.Drawing.Size(276, 44);
            this.extractBatchToolStripMenuItem.Text = "ExtractBatch";
            this.extractBatchToolStripMenuItem.Click += new System.EventHandler(this.extractUMSBTInFolderToolStripMenuItem_Click);
            // 
            // lZ11ToolStripMenuItem
            // 
            this.lZ11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decompressToolStripMenuItem,
            this.compressToolStripMenuItem});
            this.lZ11ToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_database;
            this.lZ11ToolStripMenuItem.Name = "lZ11ToolStripMenuItem";
            this.lZ11ToolStripMenuItem.Size = new System.Drawing.Size(332, 44);
            this.lZ11ToolStripMenuItem.Text = "&LZ11";
            // 
            // decompressToolStripMenuItem
            // 
            this.decompressToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.tab_class;
            this.decompressToolStripMenuItem.Name = "decompressToolStripMenuItem";
            this.decompressToolStripMenuItem.Size = new System.Drawing.Size(278, 44);
            this.decompressToolStripMenuItem.Text = "&Decompress";
            this.decompressToolStripMenuItem.Click += new System.EventHandler(this.decompressToolStripMenuItem_Click);
            // 
            // compressToolStripMenuItem
            // 
            this.compressToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_extract;
            this.compressToolStripMenuItem.Name = "compressToolStripMenuItem";
            this.compressToolStripMenuItem.Size = new System.Drawing.Size(278, 44);
            this.compressToolStripMenuItem.Text = "&Compress";
            this.compressToolStripMenuItem.Click += new System.EventHandler(this.compressToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gBATempToolStripMenuItem,
            this.gitHubToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // gBATempToolStripMenuItem
            // 
            this.gBATempToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_gbatemp;
            this.gBATempToolStripMenuItem.Name = "gBATempToolStripMenuItem";
            this.gBATempToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.gBATempToolStripMenuItem.Text = "GBATemp";
            this.gBATempToolStripMenuItem.Click += new System.EventHandler(this.gBATempToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_git;
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aboutToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(251, 44);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // homeThreadToolStripMenuItem
            // 
            this.homeThreadToolStripMenuItem.Image = global::MsbtEditor.Properties.Resources.menu_url;
            this.homeThreadToolStripMenuItem.Name = "homeThreadToolStripMenuItem";
            this.homeThreadToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.homeThreadToolStripMenuItem.Text = "GBAtemp Thread";
            // 
            // lstStrings
            // 
            this.lstStrings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstStrings.Enabled = false;
            this.lstStrings.FormattingEnabled = true;
            this.lstStrings.IntegralHeight = false;
            this.lstStrings.ItemHeight = 24;
            this.lstStrings.Location = new System.Drawing.Point(0, 28);
            this.lstStrings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstStrings.Name = "lstStrings";
            this.lstStrings.Size = new System.Drawing.Size(253, 807);
            this.lstStrings.Sorted = true;
            this.lstStrings.TabIndex = 1;
            this.lstStrings.SelectedIndexChanged += new System.EventHandler(this.lstStrings_SelectedIndexChanged);
            // 
            // lblStrings
            // 
            this.lblStrings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStrings.Location = new System.Drawing.Point(0, 0);
            this.lblStrings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblStrings.Name = "lblStrings";
            this.lblStrings.Size = new System.Drawing.Size(253, 28);
            this.lblStrings.TabIndex = 4;
            this.lblStrings.Text = "Strings:";
            // 
            // lblEdit
            // 
            this.lblEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEdit.Location = new System.Drawing.Point(0, 0);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(698, 28);
            this.lblEdit.TabIndex = 5;
            this.lblEdit.Text = "Edit:";
            // 
            // lblHexView
            // 
            this.lblHexView.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHexView.Location = new System.Drawing.Point(0, 2);
            this.lblHexView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblHexView.Name = "lblHexView";
            this.lblHexView.Size = new System.Drawing.Size(1415, 28);
            this.lblHexView.TabIndex = 8;
            this.lblHexView.Text = "Hex View:";
            // 
            // hbxHexView
            // 
            this.hbxHexView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hbxHexView.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hbxHexView.Location = new System.Drawing.Point(0, 30);
            this.hbxHexView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.hbxHexView.Name = "hbxHexView";
            this.hbxHexView.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hbxHexView.Size = new System.Drawing.Size(1415, 408);
            this.hbxHexView.StringViewVisible = true;
            this.hbxHexView.TabIndex = 6;
            this.hbxHexView.UseFixedBytesPerLine = true;
            this.hbxHexView.VScrollBarVisible = true;
            this.hbxHexView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hbxSelectAll_KeyDown);
            // 
            // stsMain
            // 
            this.stsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbAddress,
            this.slbActions,
            this.slbStringCount});
            this.stsMain.Location = new System.Drawing.Point(0, 951);
            this.stsMain.Name = "stsMain";
            this.stsMain.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.stsMain.Size = new System.Drawing.Size(1708, 42);
            this.stsMain.TabIndex = 11;
            // 
            // slbAddress
            // 
            this.slbAddress.Name = "slbAddress";
            this.slbAddress.Size = new System.Drawing.Size(559, 32);
            this.slbAddress.Spring = true;
            this.slbAddress.Text = "Address";
            this.slbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slbActions
            // 
            this.slbActions.Name = "slbActions";
            this.slbActions.Size = new System.Drawing.Size(559, 32);
            this.slbActions.Spring = true;
            this.slbActions.Text = "Actions";
            // 
            // slbStringCount
            // 
            this.slbStringCount.Name = "slbStringCount";
            this.slbStringCount.Size = new System.Drawing.Size(559, 32);
            this.slbStringCount.Spring = true;
            this.slbStringCount.Text = "Count";
            this.slbStringCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOriginal
            // 
            this.txtOriginal.BackColor = System.Drawing.SystemColors.Window;
            this.txtOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginal.Enabled = false;
            this.txtOriginal.Location = new System.Drawing.Point(2, 28);
            this.txtOriginal.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ReadOnly = true;
            this.txtOriginal.Size = new System.Drawing.Size(701, 404);
            this.txtOriginal.TabIndex = 4;
            this.txtOriginal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectAll_KeyDown);
            // 
            // txtEdit
            // 
            this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdit.Enabled = false;
            this.txtEdit.Location = new System.Drawing.Point(0, 28);
            this.txtEdit.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(698, 404);
            this.txtEdit.TabIndex = 3;
            this.txtEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSelectAll_KeyDown);
            this.txtEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEdit_KeyUp);
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
            this.btnAddLabel.Enabled = false;
            this.btnAddLabel.Image = global::MsbtEditor.Properties.Resources.menu_add;
            this.btnAddLabel.Location = new System.Drawing.Point(157, 0);
            this.btnAddLabel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAddLabel.Name = "btnAddLabel";
            this.btnAddLabel.Size = new System.Drawing.Size(44, 41);
            this.btnAddLabel.TabIndex = 8;
            this.btnAddLabel.UseVisualStyleBackColor = true;
            this.btnAddLabel.Click += new System.EventHandler(this.btnAddLabel_Click);
            // 
            // btnDeleteLabel
            // 
            this.btnDeleteLabel.Enabled = false;
            this.btnDeleteLabel.Image = global::MsbtEditor.Properties.Resources.menu_delete;
            this.btnDeleteLabel.Location = new System.Drawing.Point(209, 0);
            this.btnDeleteLabel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDeleteLabel.Name = "btnDeleteLabel";
            this.btnDeleteLabel.Size = new System.Drawing.Size(44, 41);
            this.btnDeleteLabel.TabIndex = 9;
            this.btnDeleteLabel.UseVisualStyleBackColor = true;
            this.btnDeleteLabel.Click += new System.EventHandler(this.btnDeleteLabel_Click);
            // 
            // txtLabelName
            // 
            this.txtLabelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLabelName.Enabled = false;
            this.txtLabelName.Location = new System.Drawing.Point(0, 2);
            this.txtLabelName.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.txtLabelName.Name = "txtLabelName";
            this.txtLabelName.Size = new System.Drawing.Size(95, 35);
            this.txtLabelName.TabIndex = 7;
            // 
            // btnSaveLabel
            // 
            this.btnSaveLabel.Enabled = false;
            this.btnSaveLabel.Image = global::MsbtEditor.Properties.Resources.menu_save;
            this.btnSaveLabel.Location = new System.Drawing.Point(105, 0);
            this.btnSaveLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSaveLabel.Name = "btnSaveLabel";
            this.btnSaveLabel.Size = new System.Drawing.Size(44, 41);
            this.btnSaveLabel.TabIndex = 15;
            this.btnSaveLabel.UseVisualStyleBackColor = true;
            this.btnSaveLabel.Click += new System.EventHandler(this.btnSaveLabel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 46);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.pnlMain.Size = new System.Drawing.Size(1708, 905);
            this.pnlMain.TabIndex = 16;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splMain.Location = new System.Drawing.Point(12, 11);
            this.splMain.Margin = new System.Windows.Forms.Padding(6);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.lstStrings);
            this.splMain.Panel1.Controls.Add(this.pnlLabelTools);
            this.splMain.Panel1.Controls.Add(this.lblStrings);
            this.splMain.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.splMain.Panel1MinSize = 255;
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.splView);
            this.splMain.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.splMain.Panel2MinSize = 256;
            this.splMain.Size = new System.Drawing.Size(1684, 883);
            this.splMain.SplitterDistance = 255;
            this.splMain.SplitterWidth = 12;
            this.splMain.TabIndex = 0;
            this.splMain.TabStop = false;
            // 
            // pnlLabelTools
            // 
            this.pnlLabelTools.Controls.Add(this.tlpLabelTools);
            this.pnlLabelTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLabelTools.Location = new System.Drawing.Point(0, 835);
            this.pnlLabelTools.Margin = new System.Windows.Forms.Padding(6);
            this.pnlLabelTools.Name = "pnlLabelTools";
            this.pnlLabelTools.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.pnlLabelTools.Size = new System.Drawing.Size(253, 48);
            this.pnlLabelTools.TabIndex = 0;
            // 
            // tlpLabelTools
            // 
            this.tlpLabelTools.ColumnCount = 4;
            this.tlpLabelTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLabelTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpLabelTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpLabelTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpLabelTools.Controls.Add(this.txtLabelName, 0, 0);
            this.tlpLabelTools.Controls.Add(this.btnDeleteLabel, 3, 0);
            this.tlpLabelTools.Controls.Add(this.btnSaveLabel, 1, 0);
            this.tlpLabelTools.Controls.Add(this.btnAddLabel, 2, 0);
            this.tlpLabelTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLabelTools.Location = new System.Drawing.Point(0, 9);
            this.tlpLabelTools.Margin = new System.Windows.Forms.Padding(6);
            this.tlpLabelTools.Name = "tlpLabelTools";
            this.tlpLabelTools.RowCount = 1;
            this.tlpLabelTools.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLabelTools.Size = new System.Drawing.Size(253, 39);
            this.tlpLabelTools.TabIndex = 0;
            // 
            // splView
            // 
            this.splView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splView.Location = new System.Drawing.Point(2, 0);
            this.splView.Margin = new System.Windows.Forms.Padding(6);
            this.splView.Name = "splView";
            this.splView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splView.Panel1
            // 
            this.splView.Panel1.Controls.Add(this.splEdit);
            this.splView.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            // 
            // splView.Panel2
            // 
            this.splView.Panel2.Controls.Add(this.hbxHexView);
            this.splView.Panel2.Controls.Add(this.lblHexView);
            this.splView.Panel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.splView.Size = new System.Drawing.Size(1415, 883);
            this.splView.SplitterDistance = 434;
            this.splView.SplitterWidth = 11;
            this.splView.TabIndex = 0;
            this.splView.TabStop = false;
            // 
            // splEdit
            // 
            this.splEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splEdit.Location = new System.Drawing.Point(0, 0);
            this.splEdit.Margin = new System.Windows.Forms.Padding(6);
            this.splEdit.Name = "splEdit";
            // 
            // splEdit.Panel1
            // 
            this.splEdit.Panel1.Controls.Add(this.txtEdit);
            this.splEdit.Panel1.Controls.Add(this.lblEdit);
            this.splEdit.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            // 
            // splEdit.Panel2
            // 
            this.splEdit.Panel2.Controls.Add(this.txtOriginal);
            this.splEdit.Panel2.Controls.Add(this.lblOriginal);
            this.splEdit.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.splEdit.Size = new System.Drawing.Size(1415, 432);
            this.splEdit.SplitterDistance = 700;
            this.splEdit.SplitterWidth = 12;
            this.splEdit.TabIndex = 0;
            this.splEdit.TabStop = false;
            // 
            // lblOriginal
            // 
            this.lblOriginal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOriginal.Location = new System.Drawing.Point(2, 0);
            this.lblOriginal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(701, 28);
            this.lblOriginal.TabIndex = 7;
            this.lblOriginal.Text = "Original:";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1708, 993);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1714, 1003);
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.pnlLabelTools.ResumeLayout(false);
            this.tlpLabelTools.ResumeLayout(false);
            this.tlpLabelTools.PerformLayout();
            this.splView.Panel1.ResumeLayout(false);
            this.splView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splView)).EndInit();
            this.splView.ResumeLayout(false);
            this.splEdit.Panel1.ResumeLayout(false);
            this.splEdit.Panel1.PerformLayout();
            this.splEdit.Panel2.ResumeLayout(false);
            this.splEdit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splEdit)).EndInit();
            this.splEdit.ResumeLayout(false);
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
		  private System.Windows.Forms.Label lblHexView;
        private Be.Windows.Forms.HexBox hbxHexView;
		  private System.Windows.Forms.StatusStrip stsMain;
		  private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		  private System.Windows.Forms.ToolStripStatusLabel slbAddress;
		  private System.Windows.Forms.ToolStripStatusLabel slbStringCount;
		  private System.Windows.Forms.TextBox txtEdit;
		  private System.Windows.Forms.OpenFileDialog ofdOpenFile;
		  private System.Windows.Forms.SaveFileDialog sfdSaveEntity;
		  private System.Windows.Forms.TextBox txtOriginal;
		  private System.Windows.Forms.ToolStripStatusLabel slbActions;
		  private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem exportCSVToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem extractUMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem packUMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem lZ11ToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem decompressToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem compressToolStripMenuItem;
		  private System.Windows.Forms.Button btnAddLabel;
		  private System.Windows.Forms.Button btnDeleteLabel;
		  private System.Windows.Forms.TextBox txtLabelName;
		  private System.Windows.Forms.Button btnSaveLabel;
		  private System.Windows.Forms.ToolStripMenuItem searchDirectoryToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem uMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem xMSBTToolStripMenuItem1;
		  private System.Windows.Forms.ToolStripMenuItem exportXMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem importXMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem batchExportXMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem batchImportXMSBTToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem bG4ToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem BG4ExplorerToolStripMenuItem;
		  private System.Windows.Forms.Panel pnlMain;
		  private System.Windows.Forms.SplitContainer splMain;
		  private System.Windows.Forms.Panel pnlLabelTools;
		  private System.Windows.Forms.TableLayoutPanel tlpLabelTools;
		  private System.Windows.Forms.SplitContainer splView;
		  private System.Windows.Forms.SplitContainer splEdit;
		  private System.Windows.Forms.Label lblOriginal;
		  private System.Windows.Forms.ToolStripMenuItem homeThreadToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem gBATempToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
		  private System.Windows.Forms.ToolStripMenuItem exportXMSBTModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractBatchToolStripMenuItem;
    }
}

