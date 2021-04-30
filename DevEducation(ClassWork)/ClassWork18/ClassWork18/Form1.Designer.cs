
namespace ClassWork18
{
    partial class mainDrawingSurface
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
            this.mainPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicture
            // 
            this.mainPicture.BackColor = System.Drawing.Color.White;
            this.mainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPicture.Location = new System.Drawing.Point(0, 0);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(1067, 526);
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            this.mainPicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseClick);
            this.mainPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPicture_MouseMove);
            // 
            // mainDrawingSurface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 526);
            this.Controls.Add(this.mainPicture);
            this.Name = "mainDrawingSurface";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.mainDrawingSurface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicture;
    }
}

