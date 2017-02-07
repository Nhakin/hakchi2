﻿namespace com.clusterrr.hakchi_gui
{
    partial class TreeContructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeContructorForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxArt = new System.Windows.Forms.GroupBox();
            this.pictureBoxArt = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxSplitModes = new System.Windows.Forms.GroupBox();
            this.buttonNoFoldersOriginal = new System.Windows.Forms.Button();
            this.buttonNoFolders = new System.Windows.Forms.Button();
            this.buttonFoldersLetters = new System.Windows.Forms.Button();
            this.buttonFoldersEquallyOriginal = new System.Windows.Forms.Button();
            this.buttonFoldersLettersOriginal = new System.Windows.Forms.Button();
            this.buttonFoldersEqually = new System.Windows.Forms.Button();
            this.listViewContent = new System.Windows.Forms.ListView();
            this.labelElementCount = new System.Windows.Forms.Label();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxArt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxSplitModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.FullRowSelect = true;
            this.treeView.HideSelection = false;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.ShowRootLines = false;
            this.treeView.Size = new System.Drawing.Size(280, 475);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_BeforeLabelEdit);
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_AfterLabelEdit);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "folder_sm.png");
            this.imageList.Images.SetKeyName(1, "blank_sm.png");
            this.imageList.Images.SetKeyName(2, "original_sm.png");
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
            this.splitContainer.Panel2.Controls.Add(this.labelElementCount);
            this.splitContainer.Panel2.Controls.Add(this.listViewContent);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxSplitModes);
            this.splitContainer.Panel2.Controls.Add(this.groupBoxArt);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(784, 475);
            this.splitContainer.SplitterDistance = 280;
            this.splitContainer.TabIndex = 2;
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
            this.pictureBoxArt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxArt.Location = new System.Drawing.Point(9, 15);
            this.pictureBoxArt.Name = "pictureBoxArt";
            this.pictureBoxArt.Size = new System.Drawing.Size(203, 203);
            this.pictureBoxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArt.TabIndex = 14;
            this.pictureBoxArt.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonOk);
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
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(572, 7);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 25);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
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
            this.groupBoxSplitModes.Location = new System.Drawing.Point(252, 12);
            this.groupBoxSplitModes.Name = "groupBoxSplitModes";
            this.groupBoxSplitModes.Size = new System.Drawing.Size(236, 227);
            this.groupBoxSplitModes.TabIndex = 17;
            this.groupBoxSplitModes.TabStop = false;
            this.groupBoxSplitModes.Text = "Create folders structure automatically";
            // 
            // buttonNoFoldersOriginal
            // 
            this.buttonNoFoldersOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNoFoldersOriginal.Location = new System.Drawing.Point(122, 22);
            this.buttonNoFoldersOriginal.Name = "buttonNoFoldersOriginal";
            this.buttonNoFoldersOriginal.Size = new System.Drawing.Size(100, 60);
            this.buttonNoFoldersOriginal.TabIndex = 21;
            this.buttonNoFoldersOriginal.Text = "Original games -> Other games";
            this.buttonNoFoldersOriginal.UseVisualStyleBackColor = true;
            this.buttonNoFoldersOriginal.Click += new System.EventHandler(this.buttonNoFoldersOriginal_Click);
            // 
            // buttonNoFolders
            // 
            this.buttonNoFolders.Location = new System.Drawing.Point(13, 22);
            this.buttonNoFolders.Name = "buttonNoFolders";
            this.buttonNoFolders.Size = new System.Drawing.Size(100, 60);
            this.buttonNoFolders.TabIndex = 20;
            this.buttonNoFolders.Text = "No folders";
            this.buttonNoFolders.UseVisualStyleBackColor = true;
            this.buttonNoFolders.Click += new System.EventHandler(this.buttonNoFolders_Click);
            // 
            // buttonFoldersLetters
            // 
            this.buttonFoldersLetters.Location = new System.Drawing.Point(13, 154);
            this.buttonFoldersLetters.Name = "buttonFoldersLetters";
            this.buttonFoldersLetters.Size = new System.Drawing.Size(100, 60);
            this.buttonFoldersLetters.TabIndex = 24;
            this.buttonFoldersLetters.Text = "Split by first letter";
            this.buttonFoldersLetters.UseVisualStyleBackColor = true;
            this.buttonFoldersLetters.Click += new System.EventHandler(this.buttonFoldersLetters_Click);
            // 
            // buttonFoldersEquallyOriginal
            // 
            this.buttonFoldersEquallyOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFoldersEquallyOriginal.Location = new System.Drawing.Point(122, 88);
            this.buttonFoldersEquallyOriginal.Name = "buttonFoldersEquallyOriginal";
            this.buttonFoldersEquallyOriginal.Size = new System.Drawing.Size(100, 60);
            this.buttonFoldersEquallyOriginal.TabIndex = 23;
            this.buttonFoldersEquallyOriginal.Text = "Original games -> Split equally";
            this.buttonFoldersEquallyOriginal.UseVisualStyleBackColor = true;
            this.buttonFoldersEquallyOriginal.Click += new System.EventHandler(this.buttonFoldersEquallyOriginal_Click);
            // 
            // buttonFoldersLettersOriginal
            // 
            this.buttonFoldersLettersOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFoldersLettersOriginal.Location = new System.Drawing.Point(122, 154);
            this.buttonFoldersLettersOriginal.Name = "buttonFoldersLettersOriginal";
            this.buttonFoldersLettersOriginal.Size = new System.Drawing.Size(100, 60);
            this.buttonFoldersLettersOriginal.TabIndex = 25;
            this.buttonFoldersLettersOriginal.Text = "Original games -> Split by first letter";
            this.buttonFoldersLettersOriginal.UseVisualStyleBackColor = true;
            this.buttonFoldersLettersOriginal.Click += new System.EventHandler(this.buttonFoldersLettersOriginal_Click);
            // 
            // buttonFoldersEqually
            // 
            this.buttonFoldersEqually.Location = new System.Drawing.Point(13, 88);
            this.buttonFoldersEqually.Name = "buttonFoldersEqually";
            this.buttonFoldersEqually.Size = new System.Drawing.Size(100, 60);
            this.buttonFoldersEqually.TabIndex = 22;
            this.buttonFoldersEqually.Text = "Split equally";
            this.buttonFoldersEqually.UseVisualStyleBackColor = true;
            this.buttonFoldersEqually.Click += new System.EventHandler(this.buttonFoldersEqually_Click);
            // 
            // listViewContent
            // 
            this.listViewContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewContent.LabelEdit = true;
            this.listViewContent.LargeImageList = this.imageList;
            this.listViewContent.Location = new System.Drawing.Point(2, 258);
            this.listViewContent.Name = "listViewContent";
            this.listViewContent.Size = new System.Drawing.Size(492, 217);
            this.listViewContent.SmallImageList = this.imageList;
            this.listViewContent.TabIndex = 18;
            this.listViewContent.UseCompatibleStateImageBehavior = false;
            this.listViewContent.View = System.Windows.Forms.View.List;
            this.listViewContent.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewContent_AfterLabelEdit);
            this.listViewContent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewContent_MouseDoubleClick);
            // 
            // labelElementCount
            // 
            this.labelElementCount.AutoSize = true;
            this.labelElementCount.Location = new System.Drawing.Point(10, 242);
            this.labelElementCount.Name = "labelElementCount";
            this.labelElementCount.Size = new System.Drawing.Size(0, 13);
            this.labelElementCount.TabIndex = 19;
            // 
            // TreeContructorForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "TreeContructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TreeContructorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TreeContructorForm_FormClosed);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxArt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxSplitModes.ResumeLayout(false);
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
    }
}