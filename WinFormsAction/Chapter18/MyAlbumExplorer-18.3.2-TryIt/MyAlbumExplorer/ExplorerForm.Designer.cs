namespace MyAlbumExplorer
{
	partial class ExplorerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.albumTree = new System.Windows.Forms.TreeView();
			this.spbxPhoto = new Manning.MyPhotoControls.ScrollablePictureBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.albumTree);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.spbxPhoto);
			this.splitContainer1.Size = new System.Drawing.Size(442, 266);
			this.splitContainer1.SplitterDistance = 147;
			this.splitContainer1.TabIndex = 0;
			// 
			// albumTree
			// 
			this.albumTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.albumTree.Location = new System.Drawing.Point(0, 0);
			this.albumTree.Name = "albumTree";
			this.albumTree.ShowNodeToolTips = true;
			this.albumTree.Size = new System.Drawing.Size(147, 266);
			this.albumTree.TabIndex = 0;
			this.albumTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.albumTree_AfterSelect);
			this.albumTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.albumTree_BeforeSelect);
			// 
			// spbxPhoto
			// 
			this.spbxPhoto.AllowScrollBars = true;
			this.spbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spbxPhoto.Image = null;
			this.spbxPhoto.Location = new System.Drawing.Point(0, 0);
			this.spbxPhoto.Name = "spbxPhoto";
			this.spbxPhoto.Size = new System.Drawing.Size(291, 266);
			this.spbxPhoto.TabIndex = 0;
			this.spbxPhoto.TabStop = false;
			// 
			// ExplorerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 266);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ExplorerForm";
			this.Text = "Album Explorer";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spbxPhoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView albumTree;
		private Manning.MyPhotoControls.ScrollablePictureBox spbxPhoto;
	}
}

