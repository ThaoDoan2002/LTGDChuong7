namespace PhotoAlbum
{
    partial class PhotoAlbum
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoAlbum));
            treeFolder = new TreeView();
            imgFolder = new ImageList(components);
            picFile = new PictureBox();
            pnImg = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picFile).BeginInit();
            SuspendLayout();
            // 
            // treeFolder
            // 
            treeFolder.ImageIndex = 0;
            treeFolder.ImageList = imgFolder;
            treeFolder.Location = new Point(12, 12);
            treeFolder.Name = "treeFolder";
            treeFolder.SelectedImageIndex = 0;
            treeFolder.Size = new Size(152, 422);
            treeFolder.TabIndex = 0;
            treeFolder.BeforeCollapse += treeFolder_BeforeCollapse;
            treeFolder.BeforeExpand += treeFolder_BeforeExpand;
            treeFolder.AfterSelect += treeFolder_AfterSelect;
            // 
            // imgFolder
            // 
            imgFolder.ColorDepth = ColorDepth.Depth8Bit;
            imgFolder.ImageStream = (ImageListStreamer)resources.GetObject("imgFolder.ImageStream");
            imgFolder.TransparentColor = Color.Transparent;
            imgFolder.Images.SetKeyName(0, "images.jpg");
            imgFolder.Images.SetKeyName(1, "pngtree-vector-folder-icon-png-image_3997349.jpg");
            // 
            // picFile
            // 
            picFile.BackColor = SystemColors.GradientActiveCaption;
            picFile.Location = new Point(183, 12);
            picFile.Name = "picFile";
            picFile.Size = new Size(605, 303);
            picFile.SizeMode = PictureBoxSizeMode.Zoom;
            picFile.TabIndex = 1;
            picFile.TabStop = false;
            // 
            // pnImg
            // 
            pnImg.BackColor = Color.Linen;
            pnImg.Location = new Point(183, 334);
            pnImg.Name = "pnImg";
            pnImg.Size = new Size(605, 100);
            pnImg.TabIndex = 2;
            // 
            // PhotoAlbum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnImg);
            Controls.Add(picFile);
            Controls.Add(treeFolder);
            Name = "PhotoAlbum";
            Text = "PhotoAlbum";
            Load += PhotoAlbum_Load;
            ((System.ComponentModel.ISupportInitialize)picFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeFolder;
        private PictureBox picFile;
        private FlowLayoutPanel pnImg;
        private ImageList imgFolder;
    }
}