
namespace WindowsFormsApp1.baseTable
{
    partial class classTable
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
            this.dataGridViewclass = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxmajor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewclass
            // 
            this.dataGridViewclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclass.Location = new System.Drawing.Point(92, 115);
            this.dataGridViewclass.Name = "dataGridViewclass";
            this.dataGridViewclass.RowHeadersWidth = 62;
            this.dataGridViewclass.RowTemplate.Height = 30;
            this.dataGridViewclass.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewclass.TabIndex = 0;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(443, 49);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(135, 56);
            this.button.TabIndex = 1;
            this.button.Text = "查询";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(149, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "专  业：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.UseMnemonic = false;
            // 
            // comboBoxmajor
            // 
            this.comboBoxmajor.FormattingEnabled = true;
            this.comboBoxmajor.Items.AddRange(new object[] {
            "计算机",
            "软件工程",
            "物联网",
            "大数据"});
            this.comboBoxmajor.Location = new System.Drawing.Point(263, 69);
            this.comboBoxmajor.Name = "comboBoxmajor";
            this.comboBoxmajor.Size = new System.Drawing.Size(121, 26);
            this.comboBoxmajor.TabIndex = 3;
            // 
            // classTable
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.comboBoxmajor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.dataGridViewclass);
            this.Name = "classTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级基本表";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lable专业;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewclass;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxmajor;
    }
}