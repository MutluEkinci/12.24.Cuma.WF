
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.display2 = new WindowsFormsApp1.Display();
            this.display3 = new WindowsFormsApp1.Display();
            this.display4 = new WindowsFormsApp1.Display();
            this.display1 = new WindowsFormsApp1.Display();
            this.label1 = new System.Windows.Forms.Label();
            this.display5 = new WindowsFormsApp1.Display();
            this.display6 = new WindowsFormsApp1.Display();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // display2
            // 
            this.display2.Color = System.Drawing.Color.Purple;
            this.display2.Digit = 0;
            this.display2.Location = new System.Drawing.Point(81, 57);
            this.display2.Name = "display2";
            this.display2.Size = new System.Drawing.Size(63, 151);
            this.display2.TabIndex = 1;
            // 
            // display3
            // 
            this.display3.Color = System.Drawing.Color.Purple;
            this.display3.Digit = 0;
            this.display3.Location = new System.Drawing.Point(219, 57);
            this.display3.Name = "display3";
            this.display3.Size = new System.Drawing.Size(63, 151);
            this.display3.TabIndex = 2;
            // 
            // display4
            // 
            this.display4.Color = System.Drawing.Color.Purple;
            this.display4.Digit = 0;
            this.display4.Location = new System.Drawing.Point(288, 57);
            this.display4.Name = "display4";
            this.display4.Size = new System.Drawing.Size(63, 151);
            this.display4.TabIndex = 3;
            // 
            // display1
            // 
            this.display1.Color = System.Drawing.Color.Purple;
            this.display1.Digit = 0;
            this.display1.Location = new System.Drawing.Point(12, 57);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(63, 151);
            this.display1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(150, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 95);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // display5
            // 
            this.display5.Color = System.Drawing.Color.Purple;
            this.display5.Digit = 0;
            this.display5.Location = new System.Drawing.Point(426, 57);
            this.display5.Name = "display5";
            this.display5.Size = new System.Drawing.Size(63, 151);
            this.display5.TabIndex = 3;
            // 
            // display6
            // 
            this.display6.Color = System.Drawing.Color.Purple;
            this.display6.Digit = 0;
            this.display6.Location = new System.Drawing.Point(495, 57);
            this.display6.Name = "display6";
            this.display6.Size = new System.Drawing.Size(63, 151);
            this.display6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(357, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 95);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.display6);
            this.Controls.Add(this.display5);
            this.Controls.Add(this.display4);
            this.Controls.Add(this.display3);
            this.Controls.Add(this.display2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Display display2;
        private Display display3;
        private Display display4;
        private Display display1;
        private System.Windows.Forms.Label label1;
        private Display display5;
        private Display display6;
        private System.Windows.Forms.Label label2;
    }
}

