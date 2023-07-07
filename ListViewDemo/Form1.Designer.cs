namespace ListViewDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboxDrives = new ComboBox();
            lbDrive = new Label();
            listViewFolder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            imgFolder = new ImageList(components);
            groupViewMode = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupViewMode.SuspendLayout();
            SuspendLayout();
            // 
            // comboxDrives
            // 
            comboxDrives.DropDownStyle = ComboBoxStyle.DropDownList;
            comboxDrives.FormattingEnabled = true;
            comboxDrives.Location = new Point(12, 15);
            comboxDrives.Name = "comboxDrives";
            comboxDrives.Size = new Size(130, 23);
            comboxDrives.TabIndex = 0;
            comboxDrives.SelectedIndexChanged += comboxDrives_SelectedIndexChanged;
            // 
            // lbDrive
            // 
            lbDrive.BackColor = SystemColors.ScrollBar;
            lbDrive.Location = new Point(218, 15);
            lbDrive.Name = "lbDrive";
            lbDrive.Size = new Size(70, 23);
            lbDrive.TabIndex = 1;
            // 
            // listViewFolder
            // 
            listViewFolder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewFolder.FullRowSelect = true;
            listViewFolder.GroupImageList = imgFolder;
            listViewFolder.Location = new Point(12, 55);
            listViewFolder.MultiSelect = false;
            listViewFolder.Name = "listViewFolder";
            listViewFolder.Size = new Size(504, 348);
            listViewFolder.SmallImageList = imgFolder;
            listViewFolder.TabIndex = 2;
            listViewFolder.UseCompatibleStateImageBehavior = false;
            listViewFolder.View = View.Details;
            listViewFolder.ItemSelectionChanged += listViewFolder_ItemSelectionChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File name";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Size";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Last accessed";
            columnHeader3.Width = 200;
            // 
            // imgFolder
            // 
            imgFolder.ColorDepth = ColorDepth.Depth8Bit;
            imgFolder.ImageStream = (ImageListStreamer)resources.GetObject("imgFolder.ImageStream");
            imgFolder.TransparentColor = Color.Transparent;
            imgFolder.Images.SetKeyName(0, "images.jpg");
            imgFolder.Images.SetKeyName(1, "img.png");
            // 
            // groupViewMode
            // 
            groupViewMode.Controls.Add(radioButton5);
            groupViewMode.Controls.Add(radioButton4);
            groupViewMode.Controls.Add(radioButton3);
            groupViewMode.Controls.Add(radioButton2);
            groupViewMode.Controls.Add(radioButton1);
            groupViewMode.Location = new Point(543, 62);
            groupViewMode.Name = "groupViewMode";
            groupViewMode.Size = new Size(119, 199);
            groupViewMode.TabIndex = 3;
            groupViewMode.TabStop = false;
            groupViewMode.Text = "View Mode";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(21, 162);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(47, 19);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Title";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 129);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(60, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Details";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 96);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(43, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "List";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "SmallIcon";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "LargeIcon";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 422);
            Controls.Add(groupViewMode);
            Controls.Add(listViewFolder);
            Controls.Add(lbDrive);
            Controls.Add(comboxDrives);
            Name = "Form1";
            Text = "ListView";
            Load += Form1_Load;
            groupViewMode.ResumeLayout(false);
            groupViewMode.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboxDrives;
        private Label lbDrive;
        private ListView listViewFolder;
        private GroupBox groupViewMode;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ImageList imgFolder;
    }
}