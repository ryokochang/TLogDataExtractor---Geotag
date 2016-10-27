namespace TLogDataExtractor
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.loadParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveParameterListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.extratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_geo = new System.Windows.Forms.Panel();
            this.button_Sync = new System.Windows.Forms.Button();
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.label_img = new System.Windows.Forms.Label();
            this.label_log = new System.Windows.Forms.Label();
            this.textBox_img = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_img = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_extract = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedParametersTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileParametersTree = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_geo.SuspendLayout();
            this.panel_extract.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem2,
            this.extratorToolStripMenuItem,
            this.geoTagToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.loadParametersToolStripMenuItem,
            this.saveParameterListToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(175, 6);
            // 
            // loadParametersToolStripMenuItem
            // 
            this.loadParametersToolStripMenuItem.Name = "loadParametersToolStripMenuItem";
            this.loadParametersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadParametersToolStripMenuItem.Text = "&Load Parameter List";
            this.loadParametersToolStripMenuItem.Click += new System.EventHandler(this.loadParametersToolStripMenuItem_Click);
            // 
            // saveParameterListToolStripMenuItem
            // 
            this.saveParameterListToolStripMenuItem.Name = "saveParameterListToolStripMenuItem";
            this.saveParameterListToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveParameterListToolStripMenuItem.Text = "Save Parameter List";
            this.saveParameterListToolStripMenuItem.Click += new System.EventHandler(this.saveParameterListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShowShortcutKeys = false;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // extratorToolStripMenuItem
            // 
            this.extratorToolStripMenuItem.Name = "extratorToolStripMenuItem";
            this.extratorToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.extratorToolStripMenuItem.Text = "Extrator";
            this.extratorToolStripMenuItem.Click += new System.EventHandler(this.extratorToolStripMenuItem_Click);
            // 
            // geoTagToolStripMenuItem
            // 
            this.geoTagToolStripMenuItem.Name = "geoTagToolStripMenuItem";
            this.geoTagToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.geoTagToolStripMenuItem.Text = "Geo Tag";
            this.geoTagToolStripMenuItem.Click += new System.EventHandler(this.geoTagToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel_geo
            // 
            this.panel_geo.Controls.Add(this.button_Sync);
            this.panel_geo.Controls.Add(this.textBox_output);
            this.panel_geo.Controls.Add(this.label_img);
            this.panel_geo.Controls.Add(this.label_log);
            this.panel_geo.Controls.Add(this.textBox_img);
            this.panel_geo.Controls.Add(this.textBox_log);
            this.panel_geo.Controls.Add(this.button_img);
            this.panel_geo.Controls.Add(this.button_log);
            this.panel_geo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_geo.Location = new System.Drawing.Point(0, -332);
            this.panel_geo.Name = "panel_geo";
            this.panel_geo.Size = new System.Drawing.Size(634, 362);
            this.panel_geo.TabIndex = 3;
            this.panel_geo.Visible = false;
            // 
            // button_Sync
            // 
            this.button_Sync.Location = new System.Drawing.Point(204, 72);
            this.button_Sync.Name = "button_Sync";
            this.button_Sync.Size = new System.Drawing.Size(231, 38);
            this.button_Sync.TabIndex = 7;
            this.button_Sync.Text = "Synchronize";
            this.button_Sync.UseVisualStyleBackColor = true;
            this.button_Sync.Click += new System.EventHandler(this.button_Sync_Click);
            // 
            // textBox_output
            // 
            this.textBox_output.Location = new System.Drawing.Point(12, 116);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ReadOnly = true;
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_output.Size = new System.Drawing.Size(610, 234);
            this.textBox_output.TabIndex = 6;
            // 
            // label_img
            // 
            this.label_img.AutoSize = true;
            this.label_img.Location = new System.Drawing.Point(12, 42);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(53, 13);
            this.label_img.TabIndex = 5;
            this.label_img.Text = "Img folder";
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Location = new System.Drawing.Point(12, 15);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(61, 13);
            this.label_log.TabIndex = 4;
            this.label_log.Text = "Log file csv";
            // 
            // textBox_img
            // 
            this.textBox_img.Location = new System.Drawing.Point(75, 39);
            this.textBox_img.Name = "textBox_img";
            this.textBox_img.Size = new System.Drawing.Size(466, 20);
            this.textBox_img.TabIndex = 3;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(75, 12);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(466, 20);
            this.textBox_log.TabIndex = 2;
            // 
            // button_img
            // 
            this.button_img.Location = new System.Drawing.Point(547, 39);
            this.button_img.Name = "button_img";
            this.button_img.Size = new System.Drawing.Size(75, 23);
            this.button_img.TabIndex = 1;
            this.button_img.Text = "Browse";
            this.button_img.UseVisualStyleBackColor = true;
            this.button_img.Click += new System.EventHandler(this.button_img_Click);
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(547, 10);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 23);
            this.button_log.TabIndex = 0;
            this.button_log.Text = "Browse";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_extract
            // 
            this.panel_extract.Controls.Add(this.label2);
            this.panel_extract.Controls.Add(this.selectedParametersTree);
            this.panel_extract.Controls.Add(this.label1);
            this.panel_extract.Controls.Add(this.fileParametersTree);
            this.panel_extract.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_extract.Location = new System.Drawing.Point(0, 30);
            this.panel_extract.Name = "panel_extract";
            this.panel_extract.Size = new System.Drawing.Size(634, 356);
            this.panel_extract.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(422, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Parameters";
            // 
            // selectedParametersTree
            // 
            this.selectedParametersTree.CausesValidation = false;
            this.selectedParametersTree.Location = new System.Drawing.Point(316, 67);
            this.selectedParametersTree.Name = "selectedParametersTree";
            this.selectedParametersTree.Size = new System.Drawing.Size(304, 263);
            this.selectedParametersTree.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input File Parameters";
            // 
            // fileParametersTree
            // 
            this.fileParametersTree.CausesValidation = false;
            this.fileParametersTree.Location = new System.Drawing.Point(10, 67);
            this.fileParametersTree.Name = "fileParametersTree";
            this.fileParametersTree.Size = new System.Drawing.Size(300, 263);
            this.fileParametersTree.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 386);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_geo);
            this.Controls.Add(this.panel_extract);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TLogDataExtractor + Geotag";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_geo.ResumeLayout(false);
            this.panel_geo.PerformLayout();
            this.panel_extract.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem loadParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveParameterListToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem extratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geoTagToolStripMenuItem;
        private System.Windows.Forms.Panel panel_geo;
        private System.Windows.Forms.Button button_Sync;
        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Label label_img;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.TextBox textBox_img;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_img;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel_extract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView selectedParametersTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView fileParametersTree;
    }
}

