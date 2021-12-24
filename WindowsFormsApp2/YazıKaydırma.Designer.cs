
namespace WindowsFormsApp2
{
    partial class YazıKaydırma
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
            this.components = new System.ComponentModel.Container();
            this.lblKayanYazı = new System.Windows.Forms.Label();
            this.txtYazı = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnSol = new System.Windows.Forms.Button();
            this.bntRenk = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btDurdur = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnYavas = new System.Windows.Forms.Button();
            this.bntHızlı = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtHız = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblKayanYazı
            // 
            this.lblKayanYazı.AutoSize = true;
            this.lblKayanYazı.Location = new System.Drawing.Point(16, 184);
            this.lblKayanYazı.Name = "lblKayanYazı";
            this.lblKayanYazı.Size = new System.Drawing.Size(66, 17);
            this.lblKayanYazı.TabIndex = 0;
            this.lblKayanYazı.Text = "Mesajınız";
            // 
            // txtYazı
            // 
            this.txtYazı.Location = new System.Drawing.Point(88, 38);
            this.txtYazı.Name = "txtYazı";
            this.txtYazı.Size = new System.Drawing.Size(286, 22);
            this.txtYazı.TabIndex = 1;
            this.txtYazı.TextChanged += new System.EventHandler(this.txtYazı_TextChanged);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(3, 43);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(70, 17);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Mesajınız:";
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(234, 9);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(67, 23);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // bntRenk
            // 
            this.bntRenk.Location = new System.Drawing.Point(88, 66);
            this.bntRenk.Name = "bntRenk";
            this.bntRenk.Size = new System.Drawing.Size(67, 23);
            this.bntRenk.TabIndex = 3;
            this.bntRenk.Text = "Renk";
            this.bntRenk.UseVisualStyleBackColor = true;
            this.bntRenk.Click += new System.EventHandler(this.bntRenk_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(88, 9);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(67, 23);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btDurdur
            // 
            this.btDurdur.Location = new System.Drawing.Point(161, 9);
            this.btDurdur.Name = "btDurdur";
            this.btDurdur.Size = new System.Drawing.Size(67, 23);
            this.btDurdur.TabIndex = 3;
            this.btDurdur.Text = "Durdur";
            this.btDurdur.UseVisualStyleBackColor = true;
            this.btDurdur.Click += new System.EventHandler(this.btDurdur_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(307, 9);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(67, 23);
            this.btnSag.TabIndex = 3;
            this.btnSag.Text = ">>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnYavas
            // 
            this.btnYavas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYavas.Location = new System.Drawing.Point(234, 66);
            this.btnYavas.Name = "btnYavas";
            this.btnYavas.Size = new System.Drawing.Size(67, 23);
            this.btnYavas.TabIndex = 3;
            this.btnYavas.Text = "Yavaşlat";
            this.btnYavas.UseVisualStyleBackColor = true;
            this.btnYavas.Click += new System.EventHandler(this.btnYavas_Click);
            // 
            // bntHızlı
            // 
            this.bntHızlı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntHızlı.Location = new System.Drawing.Point(161, 66);
            this.bntHızlı.Name = "bntHızlı";
            this.bntHızlı.Size = new System.Drawing.Size(67, 23);
            this.bntHızlı.TabIndex = 3;
            this.bntHızlı.Text = "Hızlandır";
            this.bntHızlı.UseVisualStyleBackColor = true;
            this.bntHızlı.Click += new System.EventHandler(this.bntHızlı_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(307, 94);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(67, 23);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Ayarlı";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtHız
            // 
            this.txtHız.Location = new System.Drawing.Point(307, 66);
            this.txtHız.Name = "txtHız";
            this.txtHız.Size = new System.Drawing.Size(67, 22);
            this.txtHız.TabIndex = 4;
            // 
            // YazıKaydırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHız);
            this.Controls.Add(this.btDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.bntRenk);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.bntHızlı);
            this.Controls.Add(this.btnYavas);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.txtYazı);
            this.Controls.Add(this.lblKayanYazı);
            this.Name = "YazıKaydırma";
            this.Size = new System.Drawing.Size(385, 254);
            this.Load += new System.EventHandler(this.YazıKaydırma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKayanYazı;
        private System.Windows.Forms.TextBox txtYazı;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button bntRenk;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btDurdur;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnYavas;
        private System.Windows.Forms.Button bntHızlı;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtHız;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
