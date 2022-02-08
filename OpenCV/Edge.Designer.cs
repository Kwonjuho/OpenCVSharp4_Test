namespace OpenCV
{
    partial class Edge
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
            this.btnEdge = new System.Windows.Forms.Button();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbImg = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdge
            // 
            this.btnEdge.Location = new System.Drawing.Point(1132, 582);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(120, 41);
            this.btnEdge.TabIndex = 0;
            this.btnEdge.Text = "Edge";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEdge_MouseDown);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(1006, 582);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(120, 41);
            this.btnFileOpen.TabIndex = 6;
            this.btnFileOpen.Text = "OpenFile";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFileOpen_MouseDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(343, 58);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(600, 450);
            this.pbImg.TabIndex = 11;
            this.pbImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aspect ratio 4:3";
            // 
            // Edge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdge);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edge";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Edge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImg;
        private System.Windows.Forms.Label label1;
    }
}