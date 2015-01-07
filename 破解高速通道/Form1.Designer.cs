namespace 破解高速通道
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxFile1 = new ToolSet.TextboxFile();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxFile1
            // 
            this.textboxFile1.Filter = "所有文件|*";
            this.textboxFile1.Location = new System.Drawing.Point(12, 12);
            this.textboxFile1.Name = "textboxFile1";
            this.textboxFile1.Size = new System.Drawing.Size(428, 23);
            this.textboxFile1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "破解";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 92);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxFile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ToolSet.TextboxFile textboxFile1;
        private System.Windows.Forms.Button button1;
    }
}

