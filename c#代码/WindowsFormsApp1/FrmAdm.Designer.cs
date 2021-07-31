
namespace WindowsFormsApp1
{
    partial class FrmAdm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生源地信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师信息更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加教师信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.学生信息更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvgradelist = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgradelist)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem,
            this.信息维护ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1478, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师信息查询ToolStripMenuItem,
            this.学生信息查询ToolStripMenuItem,
            this.生源地信息查询ToolStripMenuItem,
            this.班级信息查询ToolStripMenuItem,
            this.课程信息查询ToolStripMenuItem,
            this.专业信息查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            this.信息查询ToolStripMenuItem.Click += new System.EventHandler(this.信息查询ToolStripMenuItem_Click);
            // 
            // 教师信息查询ToolStripMenuItem
            // 
            this.教师信息查询ToolStripMenuItem.Name = "教师信息查询ToolStripMenuItem";
            this.教师信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.教师信息查询ToolStripMenuItem.Text = "教师信息查询";
            this.教师信息查询ToolStripMenuItem.Click += new System.EventHandler(this.教师信息查询ToolStripMenuItem_Click);
            // 
            // 学生信息查询ToolStripMenuItem
            // 
            this.学生信息查询ToolStripMenuItem.Name = "学生信息查询ToolStripMenuItem";
            this.学生信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.学生信息查询ToolStripMenuItem.Text = "学生信息查询";
            this.学生信息查询ToolStripMenuItem.Click += new System.EventHandler(this.学生信息查询ToolStripMenuItem_Click);
            // 
            // 生源地信息查询ToolStripMenuItem
            // 
            this.生源地信息查询ToolStripMenuItem.Name = "生源地信息查询ToolStripMenuItem";
            this.生源地信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.生源地信息查询ToolStripMenuItem.Text = "生源地信息查询";
            this.生源地信息查询ToolStripMenuItem.Click += new System.EventHandler(this.生源地信息查询ToolStripMenuItem_Click);
            // 
            // 班级信息查询ToolStripMenuItem
            // 
            this.班级信息查询ToolStripMenuItem.Name = "班级信息查询ToolStripMenuItem";
            this.班级信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.班级信息查询ToolStripMenuItem.Text = "班级信息查询";
            this.班级信息查询ToolStripMenuItem.Click += new System.EventHandler(this.班级信息查询ToolStripMenuItem_Click);
            // 
            // 课程信息查询ToolStripMenuItem
            // 
            this.课程信息查询ToolStripMenuItem.Name = "课程信息查询ToolStripMenuItem";
            this.课程信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.课程信息查询ToolStripMenuItem.Text = "课程信息查询";
            this.课程信息查询ToolStripMenuItem.Click += new System.EventHandler(this.课程信息查询ToolStripMenuItem_Click);
            // 
            // 专业信息查询ToolStripMenuItem
            // 
            this.专业信息查询ToolStripMenuItem.Name = "专业信息查询ToolStripMenuItem";
            this.专业信息查询ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.专业信息查询ToolStripMenuItem.Text = "专业信息查询";
            this.专业信息查询ToolStripMenuItem.Click += new System.EventHandler(this.专业信息查询ToolStripMenuItem_Click);
            // 
            // 信息维护ToolStripMenuItem
            // 
            this.信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师信息更新ToolStripMenuItem,
            this.学生信息更新ToolStripMenuItem});
            this.信息维护ToolStripMenuItem.Name = "信息维护ToolStripMenuItem";
            this.信息维护ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.信息维护ToolStripMenuItem.Text = "信息维护";
            // 
            // 教师信息更新ToolStripMenuItem
            // 
            this.教师信息更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除教师信息ToolStripMenuItem,
            this.添加教师信息ToolStripMenuItem});
            this.教师信息更新ToolStripMenuItem.Name = "教师信息更新ToolStripMenuItem";
            this.教师信息更新ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.教师信息更新ToolStripMenuItem.Text = "教师信息更新";
            this.教师信息更新ToolStripMenuItem.Click += new System.EventHandler(this.教师信息更新ToolStripMenuItem_Click);
            // 
            // 删除教师信息ToolStripMenuItem
            // 
            this.删除教师信息ToolStripMenuItem.Name = "删除教师信息ToolStripMenuItem";
            this.删除教师信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.删除教师信息ToolStripMenuItem.Text = "删除教师信息";
            this.删除教师信息ToolStripMenuItem.Click += new System.EventHandler(this.删除教师信息ToolStripMenuItem_Click);
            // 
            // 添加教师信息ToolStripMenuItem
            // 
            this.添加教师信息ToolStripMenuItem.Name = "添加教师信息ToolStripMenuItem";
            this.添加教师信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.添加教师信息ToolStripMenuItem.Text = "添加教师信息";
            this.添加教师信息ToolStripMenuItem.Click += new System.EventHandler(this.添加教师信息ToolStripMenuItem_Click);
            // 
            // 学生信息更新ToolStripMenuItem
            // 
            this.学生信息更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除学生信息ToolStripMenuItem,
            this.添加学生信息ToolStripMenuItem});
            this.学生信息更新ToolStripMenuItem.Name = "学生信息更新ToolStripMenuItem";
            this.学生信息更新ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.学生信息更新ToolStripMenuItem.Text = "学生信息更新";
            this.学生信息更新ToolStripMenuItem.Click += new System.EventHandler(this.学生信息更新ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.删除学生信息ToolStripMenuItem.Text = "毕业生删除";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // dgvgradelist
            // 
            this.dgvgradelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgradelist.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvgradelist.Location = new System.Drawing.Point(267, 128);
            this.dgvgradelist.Name = "dgvgradelist";
            this.dgvgradelist.RowHeadersWidth = 62;
            this.dgvgradelist.RowTemplate.Height = 30;
            this.dgvgradelist.Size = new System.Drawing.Size(779, 495);
            this.dgvgradelist.TabIndex = 1;
            this.dgvgradelist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgradelist_CellContentClick);
            // 
            // FrmAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.dgvgradelist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdm_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgradelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生源地信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师信息更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生信息更新ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvgradelist;
        private System.Windows.Forms.ToolStripMenuItem 删除教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加教师信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
    }
}