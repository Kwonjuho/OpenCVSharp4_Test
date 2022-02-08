namespace OpenCV
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCam = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMatches = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnForm = new System.Windows.Forms.Panel();
            this.btnEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCam,
            this.btnConvert,
            this.btnMatches,
            this.convertToolStripMenuItem,
            this.btnEdge});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCam
            // 
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(46, 20);
            this.btnCam.Text = "CAM";
            this.btnCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCam_MouseDown);
            // 
            // btnMatches
            // 
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(64, 20);
            this.btnMatches.Text = "Matches";
            this.btnMatches.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMatches_MouseDown);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.convertToolStripMenuItem.Text = "Bitwise operation";
            this.convertToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.convertToolStripMenuItem_MouseDown);
            // 
            // btnConvert
            // 
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(61, 20);
            this.btnConvert.Text = "Convert";
            this.btnConvert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnConvert_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnForm
            // 
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 24);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1264, 635);
            this.pnForm.TabIndex = 2;
            // 
            // btnEdge
            // 
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(101, 20);
            this.btnEdge.Text = "Edge Detection";
            this.btnEdge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEdge_MouseDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnForm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenCV Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMatches;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.ToolStripMenuItem btnCam;
        private System.Windows.Forms.ToolStripMenuItem btnConvert;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnEdge;
    }
}

