namespace arcega_contact_tracing
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
            this.formTitle = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtbxFullName = new System.Windows.Forms.TextBox();
            this.labelMobilePhoneNumber = new System.Windows.Forms.Label();
            this.txtbxMobilePhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtbxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblCompleteAddress = new System.Windows.Forms.Label();
            this.txtbxCompleteAddress = new System.Windows.Forms.TextBox();
            this.lblDateOfVisit = new System.Windows.Forms.Label();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtbxDateOfVisit = new System.Windows.Forms.TextBox();
            this.txtbxTimeIn = new System.Windows.Forms.TextBox();
            this.txtbxTimeOut = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtbxTemperature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.formTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.formTitle.Location = new System.Drawing.Point(360, 42);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(184, 22);
            this.formTitle.TabIndex = 0;
            this.formTitle.Text = "Contact Tracing Form";
            this.formTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelFullName
            // 
            this.labelFullName.AccessibleName = "";
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFullName.Location = new System.Drawing.Point(12, 106);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(99, 18);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "FULL NAME :";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFullName.Click += new System.EventHandler(this.labelFullName_Click);
            // 
            // txtbxFullName
            // 
            this.txtbxFullName.Location = new System.Drawing.Point(212, 108);
            this.txtbxFullName.Name = "txtbxFullName";
            this.txtbxFullName.Size = new System.Drawing.Size(202, 20);
            this.txtbxFullName.TabIndex = 2;
            this.txtbxFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMobilePhoneNumber
            // 
            this.labelMobilePhoneNumber.AccessibleName = "";
            this.labelMobilePhoneNumber.AutoSize = true;
            this.labelMobilePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobilePhoneNumber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMobilePhoneNumber.Location = new System.Drawing.Point(12, 133);
            this.labelMobilePhoneNumber.Name = "labelMobilePhoneNumber";
            this.labelMobilePhoneNumber.Size = new System.Drawing.Size(200, 18);
            this.labelMobilePhoneNumber.TabIndex = 3;
            this.labelMobilePhoneNumber.Text = "MOBILE/PHONE NUMBER :";
            this.labelMobilePhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxMobilePhoneNumber
            // 
            this.txtbxMobilePhoneNumber.Location = new System.Drawing.Point(212, 134);
            this.txtbxMobilePhoneNumber.Name = "txtbxMobilePhoneNumber";
            this.txtbxMobilePhoneNumber.Size = new System.Drawing.Size(202, 20);
            this.txtbxMobilePhoneNumber.TabIndex = 4;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AccessibleName = "";
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEmailAddress.Location = new System.Drawing.Point(12, 157);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(135, 18);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "EMAIL ADDRESS :";
            this.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxEmailAddress
            // 
            this.txtbxEmailAddress.Location = new System.Drawing.Point(212, 160);
            this.txtbxEmailAddress.Name = "txtbxEmailAddress";
            this.txtbxEmailAddress.Size = new System.Drawing.Size(202, 20);
            this.txtbxEmailAddress.TabIndex = 6;
            // 
            // lblCompleteAddress
            // 
            this.lblCompleteAddress.AccessibleName = "";
            this.lblCompleteAddress.AutoSize = true;
            this.lblCompleteAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteAddress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCompleteAddress.Location = new System.Drawing.Point(12, 184);
            this.lblCompleteAddress.Name = "lblCompleteAddress";
            this.lblCompleteAddress.Size = new System.Drawing.Size(175, 18);
            this.lblCompleteAddress.TabIndex = 7;
            this.lblCompleteAddress.Text = "COMPLETE ADDRESS :";
            this.lblCompleteAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxCompleteAddress
            // 
            this.txtbxCompleteAddress.Location = new System.Drawing.Point(212, 186);
            this.txtbxCompleteAddress.Name = "txtbxCompleteAddress";
            this.txtbxCompleteAddress.Size = new System.Drawing.Size(481, 20);
            this.txtbxCompleteAddress.TabIndex = 8;
            // 
            // lblDateOfVisit
            // 
            this.lblDateOfVisit.AccessibleName = "";
            this.lblDateOfVisit.AutoSize = true;
            this.lblDateOfVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfVisit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateOfVisit.Location = new System.Drawing.Point(443, 106);
            this.lblDateOfVisit.Name = "lblDateOfVisit";
            this.lblDateOfVisit.Size = new System.Drawing.Size(118, 18);
            this.lblDateOfVisit.TabIndex = 9;
            this.lblDateOfVisit.Text = "DATE OF VISIT :";
            this.lblDateOfVisit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AccessibleName = "";
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeIn.Location = new System.Drawing.Point(443, 133);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(69, 18);
            this.lblTimeIn.TabIndex = 10;
            this.lblTimeIn.Text = "TIME IN :";
            this.lblTimeIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AccessibleName = "";
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTimeOut.Location = new System.Drawing.Point(443, 162);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(87, 18);
            this.lblTimeOut.TabIndex = 11;
            this.lblTimeOut.Text = "TIME OUT :";
            this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxDateOfVisit
            // 
            this.txtbxDateOfVisit.Location = new System.Drawing.Point(567, 108);
            this.txtbxDateOfVisit.Name = "txtbxDateOfVisit";
            this.txtbxDateOfVisit.Size = new System.Drawing.Size(126, 20);
            this.txtbxDateOfVisit.TabIndex = 12;
            // 
            // txtbxTimeIn
            // 
            this.txtbxTimeIn.Location = new System.Drawing.Point(567, 134);
            this.txtbxTimeIn.Name = "txtbxTimeIn";
            this.txtbxTimeIn.Size = new System.Drawing.Size(126, 20);
            this.txtbxTimeIn.TabIndex = 13;
            // 
            // txtbxTimeOut
            // 
            this.txtbxTimeOut.Location = new System.Drawing.Point(567, 160);
            this.txtbxTimeOut.Name = "txtbxTimeOut";
            this.txtbxTimeOut.Size = new System.Drawing.Size(126, 20);
            this.txtbxTimeOut.TabIndex = 14;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(251, 391);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(140, 29);
            this.buttonDone.TabIndex = 15;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDoneClick);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AccessibleName = "";
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTemperature.Location = new System.Drawing.Point(12, 212);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(129, 18);
            this.lblTemperature.TabIndex = 16;
            this.lblTemperature.Text = "TEMPERATURE :";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxTemperature
            // 
            this.txtbxTemperature.Location = new System.Drawing.Point(212, 213);
            this.txtbxTemperature.Name = "txtbxTemperature";
            this.txtbxTemperature.Size = new System.Drawing.Size(97, 20);
            this.txtbxTemperature.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.txtbxTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.txtbxTimeOut);
            this.Controls.Add(this.txtbxTimeIn);
            this.Controls.Add(this.txtbxDateOfVisit);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.lblDateOfVisit);
            this.Controls.Add(this.txtbxCompleteAddress);
            this.Controls.Add(this.lblCompleteAddress);
            this.Controls.Add(this.txtbxEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.txtbxMobilePhoneNumber);
            this.Controls.Add(this.labelMobilePhoneNumber);
            this.Controls.Add(this.txtbxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.formTitle);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtbxFullName;
        private System.Windows.Forms.Label labelMobilePhoneNumber;
        private System.Windows.Forms.TextBox txtbxMobilePhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtbxEmailAddress;
        private System.Windows.Forms.Label lblCompleteAddress;
        private System.Windows.Forms.TextBox txtbxCompleteAddress;
        private System.Windows.Forms.Label lblDateOfVisit;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.TextBox txtbxDateOfVisit;
        private System.Windows.Forms.TextBox txtbxTimeIn;
        private System.Windows.Forms.TextBox txtbxTimeOut;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtbxTemperature;
    }
}

