namespace EmployeeManager
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
            menuStrip1 = new MenuStrip();
            mnFile = new ToolStripMenuItem();
            mnOpen = new ToolStripMenuItem();
            mnSave = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabInsertEm = new TabPage();
            btnInsert = new Button();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabEmList = new TabPage();
            listViewEm = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            errorChuaNhap = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabInsertEm.SuspendLayout();
            tabEmList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorChuaNhap).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(496, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnFile
            // 
            mnFile.DropDownItems.AddRange(new ToolStripItem[] { mnOpen, mnSave });
            mnFile.Name = "mnFile";
            mnFile.Size = new Size(37, 20);
            mnFile.Text = "File";
            // 
            // mnOpen
            // 
            mnOpen.Name = "mnOpen";
            mnOpen.Size = new Size(180, 22);
            mnOpen.Text = "Open";
            mnOpen.Click += mnOpen_Click;
            // 
            // mnSave
            // 
            mnSave.Name = "mnSave";
            mnSave.Size = new Size(180, 22);
            mnSave.Text = "Save";
            mnSave.Click += mnSave_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInsertEm);
            tabControl1.Controls.Add(tabEmList);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(426, 228);
            tabControl1.TabIndex = 1;
            // 
            // tabInsertEm
            // 
            tabInsertEm.Controls.Add(btnInsert);
            tabInsertEm.Controls.Add(txtAddress);
            tabInsertEm.Controls.Add(txtAge);
            tabInsertEm.Controls.Add(txtName);
            tabInsertEm.Controls.Add(label3);
            tabInsertEm.Controls.Add(label2);
            tabInsertEm.Controls.Add(label1);
            tabInsertEm.Location = new Point(4, 24);
            tabInsertEm.Name = "tabInsertEm";
            tabInsertEm.Padding = new Padding(3);
            tabInsertEm.Size = new Size(418, 200);
            tabInsertEm.TabIndex = 0;
            tabInsertEm.Text = "Insert Employee";
            tabInsertEm.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(188, 143);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(105, 37);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(121, 114);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(239, 23);
            txtAddress.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(121, 72);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(239, 23);
            txtAge.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 23);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 122);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // tabEmList
            // 
            tabEmList.Controls.Add(listViewEm);
            tabEmList.Location = new Point(4, 24);
            tabEmList.Name = "tabEmList";
            tabEmList.Padding = new Padding(3);
            tabEmList.Size = new Size(418, 200);
            tabEmList.TabIndex = 1;
            tabEmList.Text = "Employee List";
            tabEmList.UseVisualStyleBackColor = true;
            // 
            // listViewEm
            // 
            listViewEm.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewEm.Location = new Point(31, 6);
            listViewEm.Name = "listViewEm";
            listViewEm.Size = new Size(364, 172);
            listViewEm.TabIndex = 0;
            listViewEm.UseCompatibleStateImageBehavior = false;
            listViewEm.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Age";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Address";
            columnHeader3.Width = 180;
            // 
            // errorChuaNhap
            // 
            errorChuaNhap.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 288);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Employee Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabInsertEm.ResumeLayout(false);
            tabInsertEm.PerformLayout();
            tabEmList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorChuaNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnFile;
        private ToolStripMenuItem mnOpen;
        private ToolStripMenuItem mnSave;
        private TabControl tabControl1;
        private TabPage tabInsertEm;
        private TabPage tabEmList;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsert;
        private TextBox txtAddress;
        private TextBox txtAge;
        private TextBox txtName;
        private ListView listViewEm;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ErrorProvider errorChuaNhap;
    }
}