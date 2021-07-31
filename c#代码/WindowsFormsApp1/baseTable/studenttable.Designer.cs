
namespace WindowsFormsApp1.baseTable
{
    partial class studentTable
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
            this.dataGridViewstudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxstudent = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewstudent
            // 
            this.dataGridViewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudent.Location = new System.Drawing.Point(92, 113);
            this.dataGridViewstudent.Name = "dataGridViewstudent";
            this.dataGridViewstudent.RowHeadersWidth = 62;
            this.dataGridViewstudent.RowTemplate.Height = 30;
            this.dataGridViewstudent.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewstudent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "专业班级：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxstudent
            // 
            this.comboBoxstudent.FormattingEnabled = true;
            this.comboBoxstudent.Items.AddRange(new object[] {
            "计科1901",
            "计科1902",
            "软工1901",
            "软工1902",
            "物联网1901",
            "物联网1902",
            "大数据1901",
            "大数据1902"});
            this.comboBoxstudent.Location = new System.Drawing.Point(317, 60);
            this.comboBoxstudent.Name = "comboBoxstudent";
            this.comboBoxstudent.Size = new System.Drawing.Size(162, 26);
            this.comboBoxstudent.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(503, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxstudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewstudent);
            this.Name = "studentTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生基本表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxstudent;
        private System.Windows.Forms.Button button1;
    }
}