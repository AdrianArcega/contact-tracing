namespace arcega_contact_tracing
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.lblScanQR = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picbxCam = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScanQR
            // 
            this.lblScanQR.AutoSize = true;
            this.lblScanQR.BackColor = System.Drawing.Color.Transparent;
            this.lblScanQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanQR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScanQR.Location = new System.Drawing.Point(286, 20);
            this.lblScanQR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanQR.Name = "lblScanQR";
            this.lblScanQR.Size = new System.Drawing.Size(250, 46);
            this.lblScanQR.TabIndex = 1;
            this.lblScanQR.Text = "QR Scanner";
            this.lblScanQR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(258, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(358, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picbxCam
            // 
            this.picbxCam.BackColor = System.Drawing.SystemColors.Control;
            this.picbxCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxCam.Location = new System.Drawing.Point(163, 139);
            this.picbxCam.Name = "picbxCam";
            this.picbxCam.Size = new System.Drawing.Size(502, 462);
            this.picbxCam.TabIndex = 4;
            this.picbxCam.TabStop = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(294, 626);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(242, 41);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRunClick);
            // 
            // timerRun
            // 
            this.timerRun.Tick += new System.EventHandler(this.timerRunTick);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arcega_contact_tracing.Properties.Resources.appbackground_65_nature_outdoors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 738);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.picbxCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblScanQR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.Load += new System.EventHandler(this.form7Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbxCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScanQR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picbxCam;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timerRun;
    }
}