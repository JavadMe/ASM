namespace ASM
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.faylToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cixisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.JournalLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StaffLink = new System.Windows.Forms.LinkLabel();
            this.StudentsLink = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ASMDataSet = new ASM.ASMDataSet();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Details_btn = new System.Windows.Forms.Button();
            this.Find_btn = new System.Windows.Forms.Button();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new ASM.ASMDataSetTableAdapters.studentsTableAdapter();
            this.staffTableAdapter = new ASM.ASMDataSetTableAdapters.staffTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faylToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faylToolStripMenuItem
            // 
            this.faylToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cixisToolStripMenuItem});
            this.faylToolStripMenuItem.Name = "faylToolStripMenuItem";
            this.faylToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.faylToolStripMenuItem.Text = "Fayl";
            // 
            // cixisToolStripMenuItem
            // 
            this.cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            this.cixisToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.cixisToolStripMenuItem.Text = "Cixis";
            this.cixisToolStripMenuItem.Click += new System.EventHandler(this.cixisToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 29);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muellim";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tabControl4);
            this.panel2.Controls.Add(this.tabControl3);
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(7, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 511);
            this.panel2.TabIndex = 2;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Location = new System.Drawing.Point(10, 373);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(223, 128);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(215, 99);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "List";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(10, 135);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(223, 213);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.JournalLink);
            this.tabPage3.Controls.Add(this.linkLabel7);
            this.tabPage3.Controls.Add(this.linkLabel6);
            this.tabPage3.Controls.Add(this.linkLabel5);
            this.tabPage3.Controls.Add(this.linkLabel4);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(215, 184);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cari təhsil muəssisəsi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // JournalLink
            // 
            this.JournalLink.AutoSize = true;
            this.JournalLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.JournalLink.Location = new System.Drawing.Point(20, 16);
            this.JournalLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JournalLink.Name = "JournalLink";
            this.JournalLink.Size = new System.Drawing.Size(90, 17);
            this.JournalLink.TabIndex = 0;
            this.JournalLink.TabStop = true;
            this.JournalLink.Text = "Sinif jurnalı";
            this.JournalLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.JournalLink_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.Location = new System.Drawing.Point(20, 156);
            this.linkLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(60, 17);
            this.linkLabel7.TabIndex = 0;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Təqvim";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.Location = new System.Drawing.Point(20, 107);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(182, 34);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Şagirdin qiymətləndirmə\ncədvəli";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.Location = new System.Drawing.Point(20, 75);
            this.linkLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(148, 17);
            this.linkLabel5.TabIndex = 0;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Sinfə məsul şəxslər";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.Location = new System.Drawing.Point(20, 46);
            this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(63, 17);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Fənnlər";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(11, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(223, 123);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.StaffLink);
            this.tabPage2.Controls.Add(this.StudentsLink);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(215, 94);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Əsas obyektlər";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StaffLink
            // 
            this.StaffLink.AutoSize = true;
            this.StaffLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.StaffLink.Location = new System.Drawing.Point(20, 44);
            this.StaffLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffLink.Name = "StaffLink";
            this.StaffLink.Size = new System.Drawing.Size(50, 17);
            this.StaffLink.TabIndex = 0;
            this.StaffLink.TabStop = true;
            this.StaffLink.Text = "Heyət";
            this.StaffLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StaffLink_LinkClicked);
            // 
            // StudentsLink
            // 
            this.StudentsLink.AutoSize = true;
            this.StudentsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.StudentsLink.Location = new System.Drawing.Point(20, 15);
            this.StudentsLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StudentsLink.Name = "StudentsLink";
            this.StudentsLink.Size = new System.Drawing.Size(74, 17);
            this.StudentsLink.TabIndex = 0;
            this.StudentsLink.TabStop = true;
            this.StudentsLink.Text = "Sagirdlər";
            this.StudentsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentsLink_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(251, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(849, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Siyahi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.ASMDataSet;
            // 
            // ASMDataSet
            // 
            this.ASMDataSet.DataSetName = "ASMDataSet";
            this.ASMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.Enabled = false;
            this.Add_btn.Image = global::ASM.Properties.Resources.add;
            this.Add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_btn.Location = new System.Drawing.Point(801, 34);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(100, 28);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Əlavə et";
            this.Add_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_btn.Enabled = false;
            this.Delete_btn.Image = global::ASM.Properties.Resources.pagecross;
            this.Delete_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_btn.Location = new System.Drawing.Point(909, 34);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(100, 28);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Sil";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Details_btn
            // 
            this.Details_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Details_btn.Enabled = false;
            this.Details_btn.Image = global::ASM.Properties.Resources.loupe;
            this.Details_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Details_btn.Location = new System.Drawing.Point(693, 34);
            this.Details_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Details_btn.Name = "Details_btn";
            this.Details_btn.Size = new System.Drawing.Size(100, 28);
            this.Details_btn.TabIndex = 3;
            this.Details_btn.Text = "Baxış";
            this.Details_btn.UseVisualStyleBackColor = true;
            this.Details_btn.Click += new System.EventHandler(this.Details_btn_Click);
            // 
            // Find_btn
            // 
            this.Find_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Find_btn.Enabled = false;
            this.Find_btn.Image = global::ASM.Properties.Resources.sort_rating_descending_icon;
            this.Find_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Find_btn.Location = new System.Drawing.Point(1017, 34);
            this.Find_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(100, 28);
            this.Find_btn.TabIndex = 4;
            this.Find_btn.Text = "Süzgəc";
            this.Find_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.ASMDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 588);
            this.Controls.Add(this.Find_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Details_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1117, 624);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əsas pəncərə";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faylToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cixisToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.LinkLabel StaffLink;
        private System.Windows.Forms.LinkLabel StudentsLink;
        private System.Windows.Forms.LinkLabel JournalLink;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Details_btn;
        private ASMDataSet ASMDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private ASMDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private ASMDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button Find_btn;
    }
}