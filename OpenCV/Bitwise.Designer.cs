namespace OpenCV
{
    partial class Bitwise
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
            this.pbImg1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pbImgAND = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnBitwise = new System.Windows.Forms.Button();
            this.pbImgOR = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pbImgCompare = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pbImgNOT = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pbImgXOR = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgNOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgXOR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg1
            // 
            this.pbImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg1.Location = new System.Drawing.Point(48, 120);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(493, 370);
            this.pbImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg1.TabIndex = 0;
            this.pbImg1.TabStop = false;
            // 
            // pbImgAND
            // 
            this.pbImgAND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgAND.Location = new System.Drawing.Point(549, 120);
            this.pbImgAND.Name = "pbImgAND";
            this.pbImgAND.Size = new System.Drawing.Size(220, 165);
            this.pbImgAND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgAND.TabIndex = 0;
            this.pbImgAND.TabStop = false;
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
            // btnBitwise
            // 
            this.btnBitwise.Location = new System.Drawing.Point(1132, 582);
            this.btnBitwise.Name = "btnBitwise";
            this.btnBitwise.Size = new System.Drawing.Size(120, 41);
            this.btnBitwise.TabIndex = 8;
            this.btnBitwise.Text = "Bitwise";
            this.btnBitwise.UseVisualStyleBackColor = true;
            this.btnBitwise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBitwise_MouseDown);
            // 
            // pbImgOR
            // 
            this.pbImgOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgOR.Location = new System.Drawing.Point(775, 120);
            this.pbImgOR.Name = "pbImgOR";
            this.pbImgOR.Size = new System.Drawing.Size(220, 165);
            this.pbImgOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgOR.TabIndex = 0;
            this.pbImgOR.TabStop = false;
            // 
            // pbImgCompare
            // 
            this.pbImgCompare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgCompare.Location = new System.Drawing.Point(775, 325);
            this.pbImgCompare.Name = "pbImgCompare";
            this.pbImgCompare.Size = new System.Drawing.Size(220, 165);
            this.pbImgCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgCompare.TabIndex = 0;
            this.pbImgCompare.TabStop = false;
            // 
            // pbImgNOT
            // 
            this.pbImgNOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgNOT.Location = new System.Drawing.Point(547, 325);
            this.pbImgNOT.Name = "pbImgNOT";
            this.pbImgNOT.Size = new System.Drawing.Size(220, 165);
            this.pbImgNOT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgNOT.TabIndex = 0;
            this.pbImgNOT.TabStop = false;
            // 
            // pbImgXOR
            // 
            this.pbImgXOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImgXOR.Location = new System.Drawing.Point(1001, 120);
            this.pbImgXOR.Name = "pbImgXOR";
            this.pbImgXOR.Size = new System.Drawing.Size(220, 165);
            this.pbImgXOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgXOR.TabIndex = 0;
            this.pbImgXOR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "AND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "XOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(773, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "COMPARE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Aspect ratio 4:3";
            // 
            // Bitwise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.btnBitwise);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbImgXOR);
            this.Controls.Add(this.pbImgNOT);
            this.Controls.Add(this.pbImgCompare);
            this.Controls.Add(this.pbImgOR);
            this.Controls.Add(this.pbImgAND);
            this.Controls.Add(this.pbImg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bitwise";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bitwise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgNOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgXOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pbImg1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImgAND;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnBitwise;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImgOR;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImgCompare;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImgNOT;
        private OpenCvSharp.UserInterface.PictureBoxIpl pbImgXOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}