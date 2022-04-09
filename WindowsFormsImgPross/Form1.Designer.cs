
namespace WindowsFormsImgPross
{
    partial class Form1
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
            this.pictureImp = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureImp
            // 
            this.pictureImp.Location = new System.Drawing.Point(12, 51);
            this.pictureImp.Name = "pictureImp";
            this.pictureImp.Size = new System.Drawing.Size(243, 210);
            this.pictureImp.TabIndex = 0;
            this.pictureImp.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(22, 290);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(101, 35);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Get Matrix";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMatrix
            // 
            this.txtMatrix.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrix.Location = new System.Drawing.Point(261, 51);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.Size = new System.Drawing.Size(527, 344);
            this.txtMatrix.TabIndex = 2;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(22, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 37);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtMatrix);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.pictureImp);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureImp;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Button btnOpen;
    }
}

