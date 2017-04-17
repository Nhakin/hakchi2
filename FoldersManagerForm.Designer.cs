namespace com.clusterrr.hakchi_gui
{
    partial class FoldersManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoldersManagerForm));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonNewFolder = new System.Windows.Forms.Button();
            this.listViewContent = new System.Windows.Forms.ListView();
            this.groupBoxSplitModes = new System.Windows.Forms.GroupBox();
            this.buttonNoFoldersOriginal = new System.Windows.Forms.Button();
            this.buttonNoFolders = new System.Windows.Forms.Button();
            this.buttonFoldersLetters = new System.Windows.Forms.Button();
            this.buttonFoldersEquallyOriginal = new System.Windows.Forms.Button();
            this.buttonFoldersLettersOriginal = new System.Windows.Forms.Button();
            this.buttonFoldersEqually = new System.Windows.Forms.Button();
            this.groupBoxArt = new System.Windows.Forms.GroupBox();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSep = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelElementCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxSplitModes.SuspendLayout();
            this.groupBoxArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.comboBoxPosition);
            this.splitContainer.Panel2.Controls.Add(this.labelPosition);
            this.splitContainer.Panel2.Controls.Add(this.buttonNewFolder);
            this.splitContainer.Panel2.Controls.Add(this.listViewContent);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxSplitModes);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxArt);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(784, 475);
            this.splitContainer.SplitterDistance = 280;
            this.splitContainer.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(280, 475);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_BeforeLabelEdit);
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView_ItemDrag);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView_KeyDown);
            this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "32x_sm.png");
            this.imageList.Images.SetKeyName(1, "32x_sm_tr.png");
            this.imageList.Images.SetKeyName(2, "2600_sm.png");
            this.imageList.Images.SetKeyName(3, "2600_sm_tr.png");
            this.imageList.Images.SetKeyName(4, "app_sm.png");
            this.imageList.Images.SetKeyName(5, "app_sm_tr.png");
            this.imageList.Images.SetKeyName(6, "arcade_sm.png");
            this.imageList.Images.SetKeyName(7, "arcade_sm_tr.png");
            this.imageList.Images.SetKeyName(8, "famicom_sm.png");
            this.imageList.Images.SetKeyName(9, "famicom_sm_tr.png");
            this.imageList.Images.SetKeyName(10, "fds_sm.png");
            this.imageList.Images.SetKeyName(11, "fds_sm_tr.png");
            this.imageList.Images.SetKeyName(12, "folder_sm.png");
            this.imageList.Images.SetKeyName(13, "folder_sm_tr.png");
            this.imageList.Images.SetKeyName(14, "gb_sm.png");
            this.imageList.Images.SetKeyName(15, "gb_sm_tr.png");
            this.imageList.Images.SetKeyName(16, "gba_sm.png");
            this.imageList.Images.SetKeyName(17, "gba_sm_tr.png");
            this.imageList.Images.SetKeyName(18, "gbc_sm.png");
            this.imageList.Images.SetKeyName(19, "gbc_sm_tr.png");
            this.imageList.Images.SetKeyName(20, "genesis_sm.png");
            this.imageList.Images.SetKeyName(21, "genesis_sm_tr.png");
            this.imageList.Images.SetKeyName(22, "gg_sm.png");
            this.imageList.Images.SetKeyName(23, "gg_sm_tr.png");
            this.imageList.Images.SetKeyName(24, "n64_sm.png");
            this.imageList.Images.SetKeyName(25, "n64_sm_tr.png");
            this.imageList.Images.SetKeyName(26, "neogeo_sm.png");
            this.imageList.Images.SetKeyName(27, "neogeo_sm_tr.png");
            this.imageList.Images.SetKeyName(28, "nes_sm.png");
            this.imageList.Images.SetKeyName(29, "nes_sm_tr.png");
            this.imageList.Images.SetKeyName(30, "original_sm.png");
            this.imageList.Images.SetKeyName(31, "original_sm_tr.png");
            this.imageList.Images.SetKeyName(32, "pce_sm.png");
            this.imageList.Images.SetKeyName(33, "pce_sm_tr.png");
            this.imageList.Images.SetKeyName(34, "sms_sm.png");
            this.imageList.Images.SetKeyName(35, "sms_sm_tr.png");
            this.imageList.Images.SetKeyName(36, "snes-us_sm.png");
            this.imageList.Images.SetKeyName(37, "snes-us_sm_tr.png");
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Leftmost",
            "Left to the games",
            "Right to the games",
            "Rightmost"});
            this.comboBoxPosition.Location = new System.Drawing.Point(127, 242);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(126, 21);
            this.comboBoxPosition.TabIndex = 2;
            this.comboBoxPosition.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPosition_SelectionChangeCommitted);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(10, 245);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(111, 13);
            this.labelPosition.TabIndex = 21;
            this.labelPosition.Text = "Folder position priority:";
            // 
            // buttonNewFolder
            // 
            this.buttonNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFolder.Location = new System.Drawing.Point(394, 243);
            this.buttonNewFolder.Name = "buttonNewFolder";
            this.buttonNewFolder.Size = new System.Drawing.Size(100, 21);
            this.buttonNewFolder.TabIndex = 3;
            this.buttonNewFolder.Text = "New folder";
            this.buttonNewFolder.UseVisualStyleBackColor = true;
            this.buttonNewFolder.Click += new System.EventHandler(this.buttonNewFolder_Click);
            // 
            // listViewContent
            // 
            this.listViewContent.AllowDrop = true;
            this.listViewContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewContent.LabelEdit = true;
            this.listViewContent.LargeImageList = this.imageList;
            this.listViewContent.Location = new System.Drawing.Point(2, 269);
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.Size = new System.Drawing.Size(492, 206);
            this.listViewContent.SmallImageList = this.imageList;
            this.listViewContent.TabIndex = 1;
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.View = System.Windows.Forms.View.List;
            this.listViewContent.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewContent_AfterLabelEdit);
            this.listViewContent.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewContent_BeforeLabelEdit);
            this.listViewContent.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewContent_ItemDrag);
            this.listViewContent.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.listViewContent.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.listViewContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewContent_KeyDown);
            this.listViewContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewContent_KeyPress);
            this.listViewContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewContent_MouseDoubleClick);
            this.listViewContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
            // 
            // groupBoxSplitModes
            // 
            this.groupBoxSplitModes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSplitModes.Controls.Add(this.buttonNoFoldersOriginal);
            this.groupBoxSplitModes.Controls.Add(this.buttonNoFolders);
            this.groupBoxSplitModes.Controls.Add(this.buttonFoldersLetters);
            this.groupBoxSplitModes.Controls.Add(this.buttonFoldersEquallyOriginal);
            this.groupBoxSplitModes.Controls.Add(this.buttonFoldersLettersOriginal);
            this.groupBoxSplitModes.Controls.Add(this.buttonFoldersEqually);
            this.groupBoxSplitModes.Location = new System.Drawing.Point(240, 12);
            this.groupBoxSplitModes.Name = "groupBoxSplitModes";
            this.groupBoxSplitModes.Size = new System.Drawing.Size(254, 227);
            this.groupBoxSplitModes.TabIndex = 17;
            this.groupBoxSplitModes.TabStop = false;
            this.groupBoxSplitModes.Text = "Create folders structure automatically";
            // 
            // buttonNoFoldersOriginal
            // 
            this.buttonNoFoldersOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoFoldersOriginal.Location = new System.Drawing.Point(129, 22);
            this.buttonNoFoldersOriginal.Name = "buttonNoFoldersOriginal";
            this.buttonNoFoldersOriginal.Size = new System.Drawing.Size(110, 60);
            this.buttonNoFoldersOriginal.TabIndex = 5;
            this.buttonNoFoldersOriginal.Text = "Original games -> Other games";
            this.buttonNoFoldersOriginal.UseVisualStyleBackColor = true;
            this.buttonNoFoldersOriginal.Click += new System.EventHandler(this.buttonNoFoldersOriginal_Click);
            // 
            // buttonNoFolders
            // 
            this.buttonNoFolders.Location = new System.Drawing.Point(13, 22);
            this.buttonNoFolders.Name = "buttonNoFolders";
            this.buttonNoFolders.Size = new System.Drawing.Size(110, 60);
            this.buttonNoFolders.TabIndex = 4;
            this.buttonNoFolders.Text = "No folders";
            this.buttonNoFolders.UseVisualStyleBackColor = true;
            this.buttonNoFolders.Click += new System.EventHandler(this.buttonNoFolders_Click);
            // 
            // buttonFoldersLetters
            // 
            this.buttonFoldersLetters.Location = new System.Drawing.Point(13, 154);
            this.buttonFoldersLetters.Name = "buttonFoldersLetters";
            this.buttonFoldersLetters.Size = new System.Drawing.Size(110, 60);
            this.buttonFoldersLetters.TabIndex = 8;
            this.buttonFoldersLetters.Text = "Split by first letter";
            this.buttonFoldersLetters.UseVisualStyleBackColor = true;
            this.buttonFoldersLetters.Click += new System.EventHandler(this.buttonFoldersLetters_Click);
            // 
            // buttonFoldersEquallyOriginal
            // 
            this.buttonFoldersEquallyOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFoldersEquallyOriginal.Location = new System.Drawing.Point(129, 88);
            this.buttonFoldersEquallyOriginal.Name = "buttonFoldersEquallyOriginal";
            this.buttonFoldersEquallyOriginal.Size = new System.Drawing.Size(110, 60);
            this.buttonFoldersEquallyOriginal.TabIndex = 7;
            this.buttonFoldersEquallyOriginal.Text = "Original games -> Split equally";
            this.buttonFoldersEquallyOriginal.UseVisualStyleBackColor = true;
            this.buttonFoldersEquallyOriginal.Click += new System.EventHandler(this.buttonFoldersEquallyOriginal_Click);
            // 
            // buttonFoldersLettersOriginal
            // 
            this.buttonFoldersLettersOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFoldersLettersOriginal.Location = new System.Drawing.Point(129, 154);
            this.buttonFoldersLettersOriginal.Name = "buttonFoldersLettersOriginal";
            this.buttonFoldersLettersOriginal.Size = new System.Drawing.Size(110, 60);
            this.buttonFoldersLettersOriginal.TabIndex = 9;
            this.buttonFoldersLettersOriginal.Text = "Original games -> Split by first letter";
            this.buttonFoldersLettersOriginal.UseVisualStyleBackColor = true;
            this.buttonFoldersLettersOriginal.Click += new System.EventHandler(this.buttonFoldersLettersOriginal_Click);
            // 
            // buttonFoldersEqually
            // 
            this.buttonFoldersEqually.Location = new System.Drawing.Point(13, 88);
            this.buttonFoldersEqually.Name = "buttonFoldersEqually";
            this.buttonFoldersEqually.Size = new System.Drawing.Size(110, 60);
            this.buttonFoldersEqually.TabIndex = 6;
            this.buttonFoldersEqually.Text = "Split equally";
            this.buttonFoldersEqually.UseVisualStyleBackColor = true;
            this.buttonFoldersEqually.Click += new System.EventHandler(this.buttonFoldersEqually_Click);
            // 
            // groupBoxArt
            // 
            this.groupBoxArt.Controls.Add(this.pictureBoxArt);
            this.groupBoxArt.Location = new System.Drawing.Point(13, 12);
            this.groupBoxArt.Name = "groupBoxArt";
            this.groupBoxArt.Size = new System.Drawing.Size(221, 227);
            this.groupBoxArt.TabIndex = 16;
            this.groupBoxArt.TabStop = false;
            this.groupBoxArt.Text = "Menu icon";
            // 
            // pictureBoxArt
            // 
            this.pictureBoxArt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxArt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxArt.Location = new System.Drawing.Point(9, 15);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(203, 203);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArt.TabIndex = 14;
            this.pictureBoxArt.TabStop = false;
            this.pictureBoxArt.Click += new System.EventHandler(this.pictureBoxArt_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripMenuItemSep,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 120);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.newFolderToolStripMenuItem.Text = "Create new folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.renameToolStripMenuItem.Text = "Rename folder";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // toolStripMenuItemSep
            // 
            this.toolStripMenuItemSep.Name = "toolStripMenuItemSep";
            this.toolStripMenuItemSep.Size = new System.Drawing.Size(207, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelElementCount
            // 
            this.labelElementCount.AutoSize = true;
            this.labelElementCount.Location = new System.Drawing.Point(12, 13);
            this.labelElementCount.Name = "labelElementCount";
            this.labelElementCount.Size = new System.Drawing.Size(79, 13);
            this.labelElementCount.TabIndex = 19;
            this.labelElementCount.Text = "Folder statistics";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Controls.Add(this.labelElementCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 38);
            this.panel2.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(678, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 25);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(572, 7);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 25);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FoldersManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "FoldersManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folders Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TreeContructorForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxSplitModes.ResumeLayout(false);
            this.groupBoxArt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxArt;
        private System.Windows.Forms.PictureBox pictureBoxArt;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxSplitModes;
        private System.Windows.Forms.Button buttonNoFoldersOriginal;
        private System.Windows.Forms.Button buttonNoFolders;
        private System.Windows.Forms.Button buttonFoldersLetters;
        private System.Windows.Forms.Button buttonFoldersEquallyOriginal;
        private System.Windows.Forms.Button buttonFoldersLettersOriginal;
        private System.Windows.Forms.Button buttonFoldersEqually;
        private System.Windows.Forms.ListView listViewContent;
        private System.Windows.Forms.Label labelElementCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Button buttonNewFolder;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemSep;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}