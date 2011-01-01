namespace OOP_kurs
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
            this.axisXY = new System.Windows.Forms.PictureBox();
            this.axisXZ = new System.Windows.Forms.PictureBox();
            this.axisYZ = new System.Windows.Forms.PictureBox();
            this.viewPort3D = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axisXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisXZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort3D)).BeginInit();
            this.SuspendLayout();
            // 
            // axisXY
            // 
            this.axisXY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.axisXY.Location = new System.Drawing.Point(13, 18);
            this.axisXY.Name = "axisXY";
            this.axisXY.Size = new System.Drawing.Size(185, 185);
            this.axisXY.TabIndex = 0;
            this.axisXY.TabStop = false;
            this.axisXY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisXY_MouseDown);
            this.axisXY.Paint += new System.Windows.Forms.PaintEventHandler(this.axisXY_Paint);
            // 
            // axisXZ
            // 
            this.axisXZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.axisXZ.Location = new System.Drawing.Point(204, 18);
            this.axisXZ.Name = "axisXZ";
            this.axisXZ.Size = new System.Drawing.Size(185, 185);
            this.axisXZ.TabIndex = 1;
            this.axisXZ.TabStop = false;
            this.axisXZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisXZ_MouseDown);
            // 
            // axisYZ
            // 
            this.axisYZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.axisYZ.Location = new System.Drawing.Point(13, 209);
            this.axisYZ.Name = "axisYZ";
            this.axisYZ.Size = new System.Drawing.Size(185, 185);
            this.axisYZ.TabIndex = 2;
            this.axisYZ.TabStop = false;
            this.axisYZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.axisYZ_MouseDown);
            // 
            // viewPort3D
            // 
            this.viewPort3D.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewPort3D.Location = new System.Drawing.Point(395, 18);
            this.viewPort3D.Name = "viewPort3D";
            this.viewPort3D.Size = new System.Drawing.Size(374, 376);
            this.viewPort3D.TabIndex = 3;
            this.viewPort3D.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 463);
            this.Controls.Add(this.viewPort3D);
            this.Controls.Add(this.axisYZ);
            this.Controls.Add(this.axisXZ);
            this.Controls.Add(this.axisXY);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axisXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisXZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axisYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPort3D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox axisXY;
        private System.Windows.Forms.PictureBox axisXZ;
        private System.Windows.Forms.PictureBox axisYZ;
        private System.Windows.Forms.PictureBox viewPort3D;
    }
}

