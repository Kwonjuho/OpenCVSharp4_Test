namespace OpenCV
{
    partial class Matches
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
            this.btnMatches = new System.Windows.Forms.Button();
            this.txtKeyPoint1 = new System.Windows.Forms.TextBox();
            this.txtKeyPoint2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMatches
            // 
            this.btnMatches.Location = new System.Drawing.Point(681, 511);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(102, 50);
            this.btnMatches.TabIndex = 0;
            this.btnMatches.Text = "유사도 검출";
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMatches_MouseDown);
            // 
            // txtKeyPoint1
            // 
            this.txtKeyPoint1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyPoint1.Location = new System.Drawing.Point(118, 32);
            this.txtKeyPoint1.Name = "txtKeyPoint1";
            this.txtKeyPoint1.Size = new System.Drawing.Size(175, 21);
            this.txtKeyPoint1.TabIndex = 1;
            // 
            // txtKeyPoint2
            // 
            this.txtKeyPoint2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyPoint2.Location = new System.Drawing.Point(118, 59);
            this.txtKeyPoint2.Name = "txtKeyPoint2";
            this.txtKeyPoint2.Size = new System.Drawing.Size(175, 21);
            this.txtKeyPoint2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtScore);
            this.groupBox1.Controls.Add(this.txtKeyPoint1);
            this.groupBox1.Controls.Add(this.txtKeyPoint2);
            this.groupBox1.Location = new System.Drawing.Point(474, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검출값";
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Location = new System.Drawing.Point(118, 86);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(175, 21);
            this.txtScore.TabIndex = 6;
            // 
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matches";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Matches_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.TextBox txtKeyPoint1;
        private System.Windows.Forms.TextBox txtKeyPoint2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtScore;
    }
}