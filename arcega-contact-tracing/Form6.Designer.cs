namespace arcega_contact_tracing
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lblQRCode = new System.Windows.Forms.Label();
            this.pcbxQRCode = new System.Windows.Forms.PictureBox();
            this.txtbxQRCode = new System.Windows.Forms.TextBox();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.btnSaveQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.BackColor = System.Drawing.Color.Transparent;
            this.lblQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.052F);
            this.lblQRCode.Location = new System.Drawing.Point(12, 26);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(195, 25);
            this.lblQRCode.TabIndex = 0;
            this.lblQRCode.Text = "Generate QR Code";
            // 
            // pcbxQRCode
            // 
            this.pcbxQRCode.Location = new System.Drawing.Point(60, 74);
            this.pcbxQRCode.Name = "pcbxQRCode";
            this.pcbxQRCode.Size = new System.Drawing.Size(401, 392);
            this.pcbxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbxQRCode.TabIndex = 1;
            this.pcbxQRCode.TabStop = false;
            // 
            // txtbxQRCode
            // 
            this.txtbxQRCode.Location = new System.Drawing.Point(522, 74);
            this.txtbxQRCode.Multiline = true;
            this.txtbxQRCode.Name = "txtbxQRCode";
            this.txtbxQRCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxQRCode.Size = new System.Drawing.Size(337, 251);
            this.txtbxQRCode.TabIndex = 2;
            this.txtbxQRCode.Text = resources.GetString("txtbxQRCode.Text");
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(522, 354);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(151, 62);
            this.btnGenerateQR.TabIndex = 3;
            this.btnGenerateQR.Text = "Generate QR Code";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQRClick);
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(708, 354);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(151, 62);
            this.btnSaveQR.TabIndex = 4;
            this.btnSaveQR.Text = "Save QR";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQRClick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arcega_contact_tracing.Properties.Resources.appbackground_65_nature_outdoors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.btnGenerateQR);
            this.Controls.Add(this.txtbxQRCode);
            this.Controls.Add(this.pcbxQRCode);
            this.Controls.Add(this.lblQRCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.PictureBox pcbxQRCode;
        private System.Windows.Forms.TextBox txtbxQRCode;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.Button btnSaveQR;
    }
}