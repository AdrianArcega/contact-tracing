﻿namespace arcega_contact_tracing
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblAllData = new System.Windows.Forms.Label();
            this.txtbxFilterDate = new System.Windows.Forms.TextBox();
            this.lblFilterDate = new System.Windows.Forms.Label();
            this.lblMDY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(424, 235);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(195, 63);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display all data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplayDataClick);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(424, 112);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(195, 63);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter Data";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilterClick);
            // 
            // lblAllData
            // 
            this.lblAllData.AutoSize = true;
            this.lblAllData.BackColor = System.Drawing.Color.Transparent;
            this.lblAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllData.Location = new System.Drawing.Point(33, 256);
            this.lblAllData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllData.Name = "lblAllData";
            this.lblAllData.Size = new System.Drawing.Size(331, 20);
            this.lblAllData.TabIndex = 2;
            this.lblAllData.Text = "All data collected from contact tracing";
            // 
            // txtbxFilterDate
            // 
            this.txtbxFilterDate.Location = new System.Drawing.Point(93, 131);
            this.txtbxFilterDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFilterDate.Name = "txtbxFilterDate";
            this.txtbxFilterDate.Size = new System.Drawing.Size(211, 22);
            this.txtbxFilterDate.TabIndex = 3;
            // 
            // lblFilterDate
            // 
            this.lblFilterDate.AutoSize = true;
            this.lblFilterDate.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterDate.Location = new System.Drawing.Point(33, 88);
            this.lblFilterDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterDate.Name = "lblFilterDate";
            this.lblFilterDate.Size = new System.Drawing.Size(124, 20);
            this.lblFilterDate.TabIndex = 4;
            this.lblFilterDate.Text = "Filter by Date";
            // 
            // lblMDY
            // 
            this.lblMDY.AutoSize = true;
            this.lblMDY.BackColor = System.Drawing.Color.Transparent;
            this.lblMDY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDY.Location = new System.Drawing.Point(92, 112);
            this.lblMDY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDY.Name = "lblMDY";
            this.lblMDY.Size = new System.Drawing.Size(115, 20);
            this.lblMDY.TabIndex = 5;
            this.lblMDY.Text = "MM-DD-YYYY";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::arcega_contact_tracing.Properties.Resources.appbackground_65_nature_outdoors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 393);
            this.Controls.Add(this.lblMDY);
            this.Controls.Add(this.lblFilterDate);
            this.Controls.Add(this.txtbxFilterDate);
            this.Controls.Add(this.lblAllData);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblAllData;
        private System.Windows.Forms.TextBox txtbxFilterDate;
        private System.Windows.Forms.Label lblFilterDate;
        private System.Windows.Forms.Label lblMDY;
    }
}