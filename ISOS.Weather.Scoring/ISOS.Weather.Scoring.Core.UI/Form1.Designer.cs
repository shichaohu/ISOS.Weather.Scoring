
namespace ISOS.Weather.Scoring.Core.UI
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
            this.labSour = new System.Windows.Forms.Label();
            this.labCompare = new System.Windows.Forms.Label();
            this.txtSour = new System.Windows.Forms.TextBox();
            this.txtcompare = new System.Windows.Forms.TextBox();
            this.labSelSour = new System.Windows.Forms.Label();
            this.labSelCompare = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtResultMessage = new System.Windows.Forms.TextBox();
            this.labErrCountThreshold = new System.Windows.Forms.Label();
            this.txtErrCountThreshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrCountThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // labSour
            // 
            this.labSour.AutoSize = true;
            this.labSour.BackColor = System.Drawing.Color.White;
            this.labSour.ForeColor = System.Drawing.Color.Black;
            this.labSour.Location = new System.Drawing.Point(50, 51);
            this.labSour.Name = "labSour";
            this.labSour.Size = new System.Drawing.Size(69, 20);
            this.labSour.TabIndex = 0;
            this.labSour.Text = "标准答案";
            // 
            // labCompare
            // 
            this.labCompare.AutoSize = true;
            this.labCompare.BackColor = System.Drawing.Color.White;
            this.labCompare.ForeColor = System.Drawing.Color.Black;
            this.labCompare.Location = new System.Drawing.Point(50, 105);
            this.labCompare.Name = "labCompare";
            this.labCompare.Size = new System.Drawing.Size(69, 20);
            this.labCompare.TabIndex = 1;
            this.labCompare.Text = "考试答案";
            // 
            // txtSour
            // 
            this.txtSour.Enabled = false;
            this.txtSour.Location = new System.Drawing.Point(125, 48);
            this.txtSour.Name = "txtSour";
            this.txtSour.Size = new System.Drawing.Size(721, 27);
            this.txtSour.TabIndex = 2;
            // 
            // txtcompare
            // 
            this.txtcompare.Enabled = false;
            this.txtcompare.Location = new System.Drawing.Point(125, 105);
            this.txtcompare.Name = "txtcompare";
            this.txtcompare.Size = new System.Drawing.Size(721, 27);
            this.txtcompare.TabIndex = 3;
            // 
            // labSelSour
            // 
            this.labSelSour.AutoSize = true;
            this.labSelSour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSelSour.Location = new System.Drawing.Point(852, 51);
            this.labSelSour.Name = "labSelSour";
            this.labSelSour.Size = new System.Drawing.Size(69, 20);
            this.labSelSour.TabIndex = 4;
            this.labSelSour.Text = "选择文件";
            this.labSelSour.Click += new System.EventHandler(this.labSelSour_Click);
            // 
            // labSelCompare
            // 
            this.labSelCompare.AutoSize = true;
            this.labSelCompare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labSelCompare.Location = new System.Drawing.Point(852, 105);
            this.labSelCompare.Name = "labSelCompare";
            this.labSelCompare.Size = new System.Drawing.Size(69, 20);
            this.labSelCompare.TabIndex = 5;
            this.labSelCompare.Text = "选择文件";
            this.labSelCompare.Click += new System.EventHandler(this.labSelCompare_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(752, 532);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(94, 29);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "开始对比";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtResultMessage
            // 
            this.txtResultMessage.Location = new System.Drawing.Point(125, 163);
            this.txtResultMessage.Multiline = true;
            this.txtResultMessage.Name = "txtResultMessage";
            this.txtResultMessage.Size = new System.Drawing.Size(721, 338);
            this.txtResultMessage.TabIndex = 7;
            // 
            // labErrCountThreshold
            // 
            this.labErrCountThreshold.AutoSize = true;
            this.labErrCountThreshold.BackColor = System.Drawing.Color.White;
            this.labErrCountThreshold.ForeColor = System.Drawing.Color.Black;
            this.labErrCountThreshold.Location = new System.Drawing.Point(1002, 52);
            this.labErrCountThreshold.Name = "labErrCountThreshold";
            this.labErrCountThreshold.Size = new System.Drawing.Size(84, 20);
            this.labErrCountThreshold.TabIndex = 8;
            this.labErrCountThreshold.Text = "错误行阈值";
            // 
            // txtErrCountThreshold
            // 
            this.txtErrCountThreshold.Location = new System.Drawing.Point(1092, 49);
            this.txtErrCountThreshold.Name = "txtErrCountThreshold";
            this.txtErrCountThreshold.Size = new System.Drawing.Size(71, 27);
            this.txtErrCountThreshold.TabIndex = 10;
            this.txtErrCountThreshold.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 602);
            this.Controls.Add(this.txtErrCountThreshold);
            this.Controls.Add(this.labErrCountThreshold);
            this.Controls.Add(this.txtResultMessage);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.labSelCompare);
            this.Controls.Add(this.labSelSour);
            this.Controls.Add(this.txtcompare);
            this.Controls.Add(this.txtSour);
            this.Controls.Add(this.labCompare);
            this.Controls.Add(this.labSour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ISOS";
            ((System.ComponentModel.ISupportInitialize)(this.txtErrCountThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labSour;
        private System.Windows.Forms.Label labCompare;
        private System.Windows.Forms.TextBox txtSour;
        private System.Windows.Forms.TextBox txtcompare;
        private System.Windows.Forms.Label labSelSour;
        private System.Windows.Forms.Label labSelCompare;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtResultMessage;
        private System.Windows.Forms.Label labErrCountThreshold;
        private System.Windows.Forms.NumericUpDown txtErrCountThreshold;
    }
}

