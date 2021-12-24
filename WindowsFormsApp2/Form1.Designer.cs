
namespace WindowsFormsApp2
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
            this.yazıKaydırma1 = new WindowsFormsApp2.YazıKaydırma();
            this.SuspendLayout();
            // 
            // yazıKaydırma1
            // 
            this.yazıKaydırma1.Color = System.Drawing.Color.Empty;
            this.yazıKaydırma1.Hız = 0;
            this.yazıKaydırma1.Location = new System.Drawing.Point(116, 58);
            this.yazıKaydırma1.Mesaj = null;
            this.yazıKaydırma1.Name = "yazıKaydırma1";
            this.yazıKaydırma1.Size = new System.Drawing.Size(385, 254);
            this.yazıKaydırma1.TabIndex = 0;
            
            
            // asdf
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yazıKaydırma1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private YazıKaydırma yazıKaydırma1;
    }
}

