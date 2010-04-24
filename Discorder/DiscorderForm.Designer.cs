namespace Discorder
{
    partial class DiscorderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscorderForm));
            this.leftRightSplitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchResultListView = new BrightIdeasSoftware.TreeListView();
            this.numCol = new BrightIdeasSoftware.OLVColumn();
            this.resultTitleCOl = new BrightIdeasSoftware.OLVColumn();
            this.resultSumCol = new BrightIdeasSoftware.OLVColumn();
            this.searchResultImageList = new System.Windows.Forms.ImageList(this.components);
            this.prevPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.pagePosLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.releaseDetailsControl = new Discorder.ReleaseDetailsControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.fileListOLV = new BrightIdeasSoftware.ObjectListView();
            this.fileNameCol = new BrightIdeasSoftware.OLVColumn();
            this.fileSizeCol = new BrightIdeasSoftware.OLVColumn();
            this.modifiedCol = new BrightIdeasSoftware.OLVColumn();
            this.createdCol = new BrightIdeasSoftware.OLVColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoMatchFileNamecheckBox = new System.Windows.Forms.CheckBox();
            this.volumeMeter2 = new NAudio.Gui.VolumeMeter();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testfiletreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftRightSplitContainer.Panel1.SuspendLayout();
            this.leftRightSplitContainer.Panel2.SuspendLayout();
            this.leftRightSplitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultListView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileListOLV)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftRightSplitContainer
            // 
            this.leftRightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftRightSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.leftRightSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.leftRightSplitContainer.Name = "leftRightSplitContainer";
            // 
            // leftRightSplitContainer.Panel1
            // 
            this.leftRightSplitContainer.Panel1.Controls.Add(this.groupBox1);
            this.leftRightSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // leftRightSplitContainer.Panel2
            // 
            this.leftRightSplitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.leftRightSplitContainer.Size = new System.Drawing.Size(1176, 638);
            this.leftRightSplitContainer.SplitterDistance = 577;
            this.leftRightSplitContainer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(565, 626);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discogs";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(6, 19);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(553, 601);
            this.splitContainer3.SplitterDistance = 242;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 242);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Controls.Add(this.searchTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchTypeComboBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchResultListView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.prevPageButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.nextPageButton, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.pagePosLabel, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 223);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.searchTextBox, 2);
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(411, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(490, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(54, 24);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Items.AddRange(new object[] {
            "All",
            "Artist",
            "Label",
            "Release",
            "Catalog Numbers"});
            this.searchTypeComboBox.Location = new System.Drawing.Point(420, 3);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(64, 21);
            this.searchTypeComboBox.TabIndex = 2;
            // 
            // searchResultListView
            // 
            this.searchResultListView.AllColumns.Add(this.numCol);
            this.searchResultListView.AllColumns.Add(this.resultTitleCOl);
            this.searchResultListView.AllColumns.Add(this.resultSumCol);
            this.searchResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numCol,
            this.resultTitleCOl,
            this.resultSumCol});
            this.tableLayoutPanel2.SetColumnSpan(this.searchResultListView, 4);
            this.searchResultListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResultListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultListView.FullRowSelect = true;
            this.searchResultListView.GridLines = true;
            this.searchResultListView.Location = new System.Drawing.Point(3, 33);
            this.searchResultListView.MultiSelect = false;
            this.searchResultListView.Name = "searchResultListView";
            this.searchResultListView.OwnerDraw = true;
            this.searchResultListView.RowHeight = 24;
            this.searchResultListView.ShowGroups = false;
            this.searchResultListView.Size = new System.Drawing.Size(541, 157);
            this.searchResultListView.SmallImageList = this.searchResultImageList;
            this.searchResultListView.TabIndex = 3;
            this.searchResultListView.UseCompatibleStateImageBehavior = false;
            this.searchResultListView.View = System.Windows.Forms.View.Details;
            this.searchResultListView.VirtualMode = true;
            this.searchResultListView.SelectionChanged += new System.EventHandler(this.searchResultListView_SelectionChanged);
            // 
            // numCol
            // 
            this.numCol.AspectName = "";
            this.numCol.HeaderFont = null;
            this.numCol.MaximumWidth = 60;
            this.numCol.MinimumWidth = 60;
            this.numCol.Text = "#";
            // 
            // resultTitleCOl
            // 
            this.resultTitleCOl.AspectName = "";
            this.resultTitleCOl.HeaderFont = null;
            this.resultTitleCOl.Text = "Title";
            this.resultTitleCOl.Width = 200;
            // 
            // resultSumCol
            // 
            this.resultSumCol.AspectName = "";
            this.resultSumCol.AutoCompleteEditor = false;
            this.resultSumCol.FillsFreeSpace = true;
            this.resultSumCol.HeaderFont = null;
            this.resultSumCol.Text = "Summary";
            // 
            // searchResultImageList
            // 
            this.searchResultImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("searchResultImageList.ImageStream")));
            this.searchResultImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.searchResultImageList.Images.SetKeyName(0, "releaseIcon.png");
            this.searchResultImageList.Images.SetKeyName(1, "labelIcon.gif");
            this.searchResultImageList.Images.SetKeyName(2, "artistIcon.png");
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(3, 196);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(54, 23);
            this.prevPageButton.TabIndex = 4;
            this.prevPageButton.Text = "<<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(490, 196);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(54, 23);
            this.nextPageButton.TabIndex = 5;
            this.nextPageButton.Text = ">>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // pagePosLabel
            // 
            this.pagePosLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagePosLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.pagePosLabel, 2);
            this.pagePosLabel.Location = new System.Drawing.Point(239, 201);
            this.pagePosLabel.Name = "pagePosLabel";
            this.pagePosLabel.Size = new System.Drawing.Size(68, 13);
            this.pagePosLabel.TabIndex = 6;
            this.pagePosLabel.Text = "Page 1 of 56";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.releaseDetailsControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 355);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Release Details";
            // 
            // releaseDetailsControl
            // 
            this.releaseDetailsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.releaseDetailsControl.Location = new System.Drawing.Point(3, 16);
            this.releaseDetailsControl.MinimumSize = new System.Drawing.Size(350, 300);
            this.releaseDetailsControl.Name = "releaseDetailsControl";
            this.releaseDetailsControl.Release = null;
            this.releaseDetailsControl.Size = new System.Drawing.Size(547, 336);
            this.releaseDetailsControl.TabIndex = 0;
            this.releaseDetailsControl.Track = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 459);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File List";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel3.Controls.Add(this.browseButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.filePathLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fileListOLV, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(577, 440);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(501, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(73, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(3, 8);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(295, 13);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "C:\\Documents and Settings\\eric.anastas\\Desktop\\Discorder";
            // 
            // fileListOLV
            // 
            this.fileListOLV.AllColumns.Add(this.fileNameCol);
            this.fileListOLV.AllColumns.Add(this.fileSizeCol);
            this.fileListOLV.AllColumns.Add(this.modifiedCol);
            this.fileListOLV.AllColumns.Add(this.createdCol);
            this.fileListOLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListOLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameCol,
            this.fileSizeCol,
            this.modifiedCol,
            this.createdCol});
            this.tableLayoutPanel3.SetColumnSpan(this.fileListOLV, 2);
            this.fileListOLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileListOLV.Location = new System.Drawing.Point(3, 32);
            this.fileListOLV.Name = "fileListOLV";
            this.fileListOLV.ShowGroups = false;
            this.fileListOLV.Size = new System.Drawing.Size(571, 405);
            this.fileListOLV.TabIndex = 2;
            this.fileListOLV.UseCompatibleStateImageBehavior = false;
            this.fileListOLV.View = System.Windows.Forms.View.Details;
            // 
            // fileNameCol
            // 
            this.fileNameCol.AspectName = "Name";
            this.fileNameCol.HeaderFont = null;
            this.fileNameCol.Text = "File Name";
            this.fileNameCol.Width = 120;
            // 
            // fileSizeCol
            // 
            this.fileSizeCol.HeaderFont = null;
            this.fileSizeCol.Text = "File Size";
            this.fileSizeCol.Width = 112;
            // 
            // modifiedCol
            // 
            this.modifiedCol.HeaderFont = null;
            this.modifiedCol.Text = "Modified";
            this.modifiedCol.Width = 87;
            // 
            // createdCol
            // 
            this.createdCol.HeaderFont = null;
            this.createdCol.Text = "Created";
            this.createdCol.Width = 82;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Location = new System.Drawing.Point(6, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 161);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recording";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.autoMatchFileNamecheckBox, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.volumeMeter2, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.volumeMeter1, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(288, 142);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.SetColumnSpan(this.textBox1, 3);
            this.textBox1.Location = new System.Drawing.Point(68, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name:";
            // 
            // autoMatchFileNamecheckBox
            // 
            this.autoMatchFileNamecheckBox.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.autoMatchFileNamecheckBox, 3);
            this.autoMatchFileNamecheckBox.Location = new System.Drawing.Point(68, 114);
            this.autoMatchFileNamecheckBox.Name = "autoMatchFileNamecheckBox";
            this.autoMatchFileNamecheckBox.Size = new System.Drawing.Size(131, 17);
            this.autoMatchFileNamecheckBox.TabIndex = 4;
            this.autoMatchFileNamecheckBox.Text = "Automatic File Naming";
            this.autoMatchFileNamecheckBox.UseVisualStyleBackColor = true;
            // 
            // volumeMeter2
            // 
            this.volumeMeter2.Amplitude = 1F;
            this.volumeMeter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeMeter2.Location = new System.Drawing.Point(261, 3);
            this.volumeMeter2.MaxDb = 18F;
            this.volumeMeter2.MinDb = -60F;
            this.volumeMeter2.Name = "volumeMeter2";
            this.tableLayoutPanel4.SetRowSpan(this.volumeMeter2, 2);
            this.volumeMeter2.Size = new System.Drawing.Size(24, 75);
            this.volumeMeter2.TabIndex = 7;
            this.volumeMeter2.Text = "recVolMeterL";
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 1F;
            this.volumeMeter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeMeter1.Location = new System.Drawing.Point(231, 3);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.tableLayoutPanel4.SetRowSpan(this.volumeMeter1, 2);
            this.volumeMeter1.Size = new System.Drawing.Size(24, 75);
            this.volumeMeter1.TabIndex = 6;
            this.volumeMeter1.Text = "recVolMeterL";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Location = new System.Drawing.Point(306, 471);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(283, 161);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Playback / Editing";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tESTToolStripMenuItem.Text = "TEST";
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // collapseToolStripMenuItem1
            // 
            this.collapseToolStripMenuItem1.Name = "collapseToolStripMenuItem1";
            this.collapseToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.collapseToolStripMenuItem1.Text = "Discogs";
            this.collapseToolStripMenuItem1.Click += new System.EventHandler(this.collapseToolStripMenuItem1_Click);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.collapseToolStripMenuItem.Text = "Local Files";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.collapseToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.discogsToolStripMenuItem,
            this.localFilesToolStripMenuItem,
            this.testToolStripMenuItem1,
            this.testfiletreamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // discogsToolStripMenuItem
            // 
            this.discogsToolStripMenuItem.Name = "discogsToolStripMenuItem";
            this.discogsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.discogsToolStripMenuItem.Text = "Discogs";
            this.discogsToolStripMenuItem.Click += new System.EventHandler(this.discogsToolStripMenuItem_Click);
            // 
            // localFilesToolStripMenuItem
            // 
            this.localFilesToolStripMenuItem.Name = "localFilesToolStripMenuItem";
            this.localFilesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.localFilesToolStripMenuItem.Text = "Local Files";
            this.localFilesToolStripMenuItem.Click += new System.EventHandler(this.localFilesToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem1
            // 
            this.testToolStripMenuItem1.Name = "testToolStripMenuItem1";
            this.testToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.testToolStripMenuItem1.Text = "test";
            this.testToolStripMenuItem1.Click += new System.EventHandler(this.testToolStripMenuItem1_Click);
            // 
            // testfiletreamToolStripMenuItem
            // 
            this.testfiletreamToolStripMenuItem.Name = "testfiletreamToolStripMenuItem";
            this.testfiletreamToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.testfiletreamToolStripMenuItem.Text = "testfiletream";
            this.testfiletreamToolStripMenuItem.Click += new System.EventHandler(this.testfiletreamToolStripMenuItem_Click);
            // 
            // DiscorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 662);
            this.Controls.Add(this.leftRightSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "DiscorderForm";
            this.Text = "Discorder";
            this.leftRightSplitContainer.Panel1.ResumeLayout(false);
            this.leftRightSplitContainer.Panel2.ResumeLayout(false);
            this.leftRightSplitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultListView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileListOLV)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer leftRightSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private BrightIdeasSoftware.TreeListView searchResultListView;
        private BrightIdeasSoftware.OLVColumn resultTitleCOl;
        private BrightIdeasSoftware.OLVColumn resultSumCol;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseToolStripMenuItem1;
        private ReleaseDetailsControl releaseDetailsControl;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ImageList searchResultImageList;
        private BrightIdeasSoftware.OLVColumn numCol;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label pagePosLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label filePathLabel;
        private BrightIdeasSoftware.ObjectListView fileListOLV;
        private BrightIdeasSoftware.OLVColumn fileNameCol;
        private BrightIdeasSoftware.OLVColumn fileSizeCol;
        private BrightIdeasSoftware.OLVColumn modifiedCol;
        private BrightIdeasSoftware.OLVColumn createdCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testfiletreamToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoMatchFileNamecheckBox;
        private NAudio.Gui.VolumeMeter volumeMeter2;
        private NAudio.Gui.VolumeMeter volumeMeter1;
    }
}

