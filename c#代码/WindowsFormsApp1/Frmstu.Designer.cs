
namespace WindowsFormsApp1
{
    partial class frmstu
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
            this.button成绩查询 = new System.Windows.Forms.Button();
            this.button课表查询 = new System.Windows.Forms.Button();
            this.button绩点 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button成绩查询
            // 
            this.button成绩查询.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button成绩查询.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button成绩查询.Location = new System.Drawing.Point(250, 331);
            this.button成绩查询.Name = "button成绩查询";
            this.button成绩查询.Size = new System.Drawing.Size(173, 80);
            this.button成绩查询.TabIndex = 0;
            this.button成绩查询.Text = "成绩查询";
            this.button成绩查询.UseVisualStyleBackColor = false;
            this.button成绩查询.Click += new System.EventHandler(this.button成绩查询_Click);
            // 
            // button课表查询
            // 
            this.button课表查询.BackColor = System.Drawing.SystemColors.Highlight;
            this.button课表查询.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button课表查询.Location = new System.Drawing.Point(567, 331);
            this.button课表查询.Name = "button课表查询";
            this.button课表查询.Size = new System.Drawing.Size(169, 80);
            this.button课表查询.TabIndex = 1;
            this.button课表查询.Text = "课表查询";
            this.button课表查询.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button课表查询.UseVisualStyleBackColor = false;
            this.button课表查询.Click += new System.EventHandler(this.button课表查询_Click);
            // 
            // button绩点
            // 
            this.button绩点.BackColor = System.Drawing.SystemColors.Desktop;
            this.button绩点.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button绩点.Location = new System.Drawing.Point(860, 331);
            this.button绩点.Name = "button绩点";
            this.button绩点.Size = new System.Drawing.Size(169, 80);
            this.button绩点.TabIndex = 2;
            this.button绩点.Text = "绩点查询";
            this.button绩点.UseVisualStyleBackColor = false;
            this.button绩点.Click += new System.EventHandler(this.button绩点_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1154, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "账户设置";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(674, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 28);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("仿宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(533, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "已修学分：";
            // 
            // frmstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button绩点);
            this.Controls.Add(this.button课表查询);
            this.Controls.Add(this.button成绩查询);
            this.Name = "frmstu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmstu_FormClosing);
            this.Load += new System.EventHandler(this.frmstu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button成绩查询;
        private System.Windows.Forms.Button button课表查询;
        private System.Windows.Forms.Button button绩点;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}