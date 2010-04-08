﻿namespace Discorder
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftRightSplitContainer
            // 
            this.leftRightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftRightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.leftRightSplitContainer.Name = "leftRightSplitContainer";
            // 
            // leftRightSplitContainer.Panel1
            // 
            this.leftRightSplitContainer.Panel1.Controls.Add(this.groupBox1);
            this.leftRightSplitContainer.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // leftRightSplitContainer.Panel2
            // 
            this.leftRightSplitContainer.Panel2.Controls.Add(this.groupBox2);
            this.leftRightSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(6);
            this.leftRightSplitContainer.Size = new System.Drawing.Size(1136, 695);
            this.leftRightSplitContainer.SplitterDistance = 542;
            this.leftRightSplitContainer.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(530, 683);
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
            this.splitContainer3.Size = new System.Drawing.Size(518, 658);
            this.splitContainer3.SplitterDistance = 299;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(518, 299);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 280);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // searchTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.searchTextBox, 2);
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTextBox.Location = new System.Drawing.Point(3, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(376, 20);
            this.searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(455, 3);
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
            this.searchTypeComboBox.Location = new System.Drawing.Point(385, 3);
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
            this.searchResultListView.Size = new System.Drawing.Size(506, 214);
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
            this.prevPageButton.Location = new System.Drawing.Point(3, 253);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(54, 23);
            this.prevPageButton.TabIndex = 4;
            this.prevPageButton.Text = "<<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(455, 253);
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
            this.pagePosLabel.Location = new System.Drawing.Point(222, 258);
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
            this.groupBox3.Size = new System.Drawing.Size(518, 355);
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
            this.releaseDetailsControl.Size = new System.Drawing.Size(512, 336);
            this.releaseDetailsControl.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 683);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local Files";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 78);
            this.button3.TabIndex = 0;
            this.button3.Text = "TEST TREE VIEW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // DiscorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 695);
            this.Controls.Add(this.leftRightSplitContainer);
            this.Name = "DiscorderForm";
            this.Text = "Form1";
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
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList searchResultImageList;
        private BrightIdeasSoftware.OLVColumn numCol;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Label pagePosLabel;
        private System.Windows.Forms.Button button3;
    }
}

