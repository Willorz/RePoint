namespace RePoint
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
            this.readpath_tb = new System.Windows.Forms.TextBox();
            this.savepath_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ratio_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trans_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readpath_tb
            // 
            this.readpath_tb.Location = new System.Drawing.Point(163, 51);
            this.readpath_tb.Name = "readpath_tb";
            this.readpath_tb.Size = new System.Drawing.Size(419, 21);
            this.readpath_tb.TabIndex = 0;
            // 
            // savepath_tb
            // 
            this.savepath_tb.Location = new System.Drawing.Point(163, 98);
            this.savepath_tb.Name = "savepath_tb";
            this.savepath_tb.Size = new System.Drawing.Size(419, 21);
            this.savepath_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "原始路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "存储路径";
            // 
            // ratio_tb
            // 
            this.ratio_tb.Location = new System.Drawing.Point(163, 165);
            this.ratio_tb.Name = "ratio_tb";
            this.ratio_tb.Size = new System.Drawing.Size(101, 21);
            this.ratio_tb.TabIndex = 0;
            this.ratio_tb.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "缩放比例";
            // 
            // trans_btn
            // 
            this.trans_btn.Location = new System.Drawing.Point(506, 224);
            this.trans_btn.Name = "trans_btn";
            this.trans_btn.Size = new System.Drawing.Size(76, 25);
            this.trans_btn.TabIndex = 2;
            this.trans_btn.Text = "转换";
            this.trans_btn.UseVisualStyleBackColor = true;
            this.trans_btn.Click += new System.EventHandler(this.trans_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 274);
            this.Controls.Add(this.trans_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ratio_tb);
            this.Controls.Add(this.savepath_tb);
            this.Controls.Add(this.readpath_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox readpath_tb;
        private System.Windows.Forms.TextBox savepath_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ratio_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button trans_btn;
    }
}

