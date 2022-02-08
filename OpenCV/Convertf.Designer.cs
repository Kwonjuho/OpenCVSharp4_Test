namespace OpenCV
{
    partial class Convertf
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
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btn3ChColor = new System.Windows.Forms.Button();
            this.btnSymmetry = new System.Windows.Forms.Button();
            this.btnScaleUp = new System.Windows.Forms.Button();
            this.btnScaleDown = new System.Windows.Forms.Button();
            this.btnResizeSet = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.pbImg2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFileSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnBinarization = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(118, 64);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(500, 375);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(32, 34);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(90, 41);
            this.btnFileOpen.TabIndex = 1;
            this.btnFileOpen.Text = "OpenFile";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFileOpen_MouseDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(175, 34);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(120, 41);
            this.btnGrayscale.TabIndex = 2;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGrayscale_MouseDown);
            // 
            // btn3ChColor
            // 
            this.btn3ChColor.Location = new System.Drawing.Point(175, 81);
            this.btn3ChColor.Name = "btn3ChColor";
            this.btn3ChColor.Size = new System.Drawing.Size(120, 41);
            this.btn3ChColor.TabIndex = 2;
            this.btn3ChColor.Text = "3Ch Color";
            this.btn3ChColor.UseVisualStyleBackColor = true;
            this.btn3ChColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3ChColor_MouseDown);
            // 
            // btnSymmetry
            // 
            this.btnSymmetry.Location = new System.Drawing.Point(301, 81);
            this.btnSymmetry.Name = "btnSymmetry";
            this.btnSymmetry.Size = new System.Drawing.Size(120, 41);
            this.btnSymmetry.TabIndex = 2;
            this.btnSymmetry.Text = "Symmetry";
            this.btnSymmetry.UseVisualStyleBackColor = true;
            this.btnSymmetry.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSymmetry_MouseDown);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(427, 34);
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(120, 41);
            this.btnScaleUp.TabIndex = 2;
            this.btnScaleUp.Text = "Scale Up";
            this.btnScaleUp.UseVisualStyleBackColor = true;
            this.btnScaleUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScaleUp_MouseDown);
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(427, 81);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(120, 41);
            this.btnScaleDown.TabIndex = 2;
            this.btnScaleDown.Text = "Scale Down";
            this.btnScaleDown.UseVisualStyleBackColor = true;
            this.btnScaleDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScaleDown_MouseDown);
            // 
            // btnResizeSet
            // 
            this.btnResizeSet.Location = new System.Drawing.Point(553, 34);
            this.btnResizeSet.Name = "btnResizeSet";
            this.btnResizeSet.Size = new System.Drawing.Size(119, 41);
            this.btnResizeSet.TabIndex = 2;
            this.btnResizeSet.Text = "Resize Setting";
            this.btnResizeSet.UseVisualStyleBackColor = true;
            this.btnResizeSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResizeSet_MouseDown);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(301, 34);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(120, 41);
            this.btnCut.TabIndex = 2;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCut_MouseDown);
            // 
            // pbImg2
            // 
            this.pbImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg2.Location = new System.Drawing.Point(624, 64);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(500, 375);
            this.pbImg2.TabIndex = 3;
            this.pbImg2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aspect ratio 4:3";
            // 
            // btnFileSave
            // 
            this.btnFileSave.Location = new System.Drawing.Point(32, 81);
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(90, 40);
            this.btnFileSave.TabIndex = 5;
            this.btnFileSave.Text = "SaveFile";
            this.btnFileSave.UseVisualStyleBackColor = true;
            this.btnFileSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFileSave_MouseDown);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(553, 81);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(117, 41);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnResize_MouseDown);
            // 
            // btnBinarization
            // 
            this.btnBinarization.Location = new System.Drawing.Point(678, 34);
            this.btnBinarization.Name = "btnBinarization";
            this.btnBinarization.Size = new System.Drawing.Size(119, 41);
            this.btnBinarization.TabIndex = 7;
            this.btnBinarization.Text = "Binarization";
            this.btnBinarization.UseVisualStyleBackColor = true;
            this.btnBinarization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBinarization_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrayscale);
            this.groupBox1.Controls.Add(this.btnFileSave);
            this.groupBox1.Controls.Add(this.btnBinarization);
            this.groupBox1.Controls.Add(this.btn3ChColor);
            this.groupBox1.Controls.Add(this.btnFileOpen);
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Controls.Add(this.btnSymmetry);
            this.groupBox1.Controls.Add(this.btnScaleUp);
            this.groupBox1.Controls.Add(this.btnScaleDown);
            this.groupBox1.Controls.Add(this.btnResizeSet);
            this.groupBox1.Controls.Add(this.btnCut);
            this.groupBox1.Location = new System.Drawing.Point(203, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // Convertf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImg2);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Convertf";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Convert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btn3ChColor;
        private System.Windows.Forms.Button btnSymmetry;
        private System.Windows.Forms.Button btnScaleUp;
        private System.Windows.Forms.Button btnScaleDown;
        private System.Windows.Forms.Button btnResizeSet;
        private System.Windows.Forms.Button btnCut;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFileSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnBinarization;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}