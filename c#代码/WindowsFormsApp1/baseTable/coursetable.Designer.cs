
namespace WindowsFormsApp1.baseTable
{
    partial class courseTable
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
            this.dataGridViewcourse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxcourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewcourse
            // 
            this.dataGridViewcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcourse.Location = new System.Drawing.Point(90, 118);
            this.dataGridViewcourse.Name = "dataGridViewcourse";
            this.dataGridViewcourse.RowHeadersWidth = 62;
            this.dataGridViewcourse.RowTemplate.Height = 30;
            this.dataGridViewcourse.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewcourse.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "班  级:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(487, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxcourse
            // 
            this.comboBoxcourse.FormattingEnabled = true;
            this.comboBoxcourse.Items.AddRange(new object[] {
            "计科1901",
            "计科1902",
            "软工1901",
            "软工1902",
            "物联网1901",
            "物联网1902",
            "大数据1901",
            "大数据1902"});
            this.comboBoxcourse.Location = new System.Drawing.Point(309, 65);
            this.comboBoxcourse.Name = "comboBoxcourse";
            this.comboBoxcourse.Size = new System.Drawing.Size(136, 26);
            this.comboBoxcourse.TabIndex = 4;
            // 
            // courseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.comboBoxcourse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewcourse);
            this.Name = "courseTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程基本表";
            this.Load += new System.EventHandler(this.courseTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxcourse;
    }
}