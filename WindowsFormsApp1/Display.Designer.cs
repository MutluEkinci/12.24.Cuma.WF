
namespace WindowsFormsApp1
{
    partial class Display
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p1 = new System.Windows.Forms.Panel();
            this.p7 = new System.Windows.Forms.Panel();
            this.p4 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.p6 = new System.Windows.Forms.Panel();
            this.p5 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(3, 3);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(50, 6);
            this.p1.TabIndex = 0;
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(3, 68);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(50, 6);
            this.p7.TabIndex = 0;
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(3, 136);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(50, 6);
            this.p4.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(3, 12);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(6, 50);
            this.p2.TabIndex = 1;
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(47, 12);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(6, 50);
            this.p6.TabIndex = 1;
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(47, 80);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(6, 50);
            this.p5.TabIndex = 1;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(3, 80);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(6, 50);
            this.p3.TabIndex = 1;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p1);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(63, 151);
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p7;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.Panel p6;
        private System.Windows.Forms.Panel p5;
        private System.Windows.Forms.Panel p3;
    }
}
