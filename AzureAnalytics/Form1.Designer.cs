﻿namespace AzureAnalytics
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
            this.GrabButton = new System.Windows.Forms.Button();
            this.Apps = new System.Windows.Forms.ComboBox();
            this.PurgeButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ServerResponse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // GrabButton
            // 
            this.GrabButton.Enabled = false;
            this.GrabButton.Location = new System.Drawing.Point(8, 45);
            this.GrabButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrabButton.Name = "GrabButton";
            this.GrabButton.Size = new System.Drawing.Size(259, 38);
            this.GrabButton.TabIndex = 0;
            this.GrabButton.Text = "Grab";
            this.GrabButton.UseVisualStyleBackColor = true;
            this.GrabButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apps
            // 
            this.Apps.FormattingEnabled = true;
            this.Apps.Location = new System.Drawing.Point(8, 13);
            this.Apps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Apps.Name = "Apps";
            this.Apps.Size = new System.Drawing.Size(261, 24);
            this.Apps.TabIndex = 1;
            this.Apps.SelectedIndexChanged += new System.EventHandler(this.Apps_SelectedIndexChanged);
            // 
            // PurgeButton
            // 
            this.PurgeButton.Enabled = false;
            this.PurgeButton.Location = new System.Drawing.Point(8, 96);
            this.PurgeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PurgeButton.Name = "PurgeButton";
            this.PurgeButton.Size = new System.Drawing.Size(259, 39);
            this.PurgeButton.TabIndex = 2;
            this.PurgeButton.Text = "Purge";
            this.PurgeButton.UseVisualStyleBackColor = true;
            this.PurgeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(288, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 132);
            this.listBox1.TabIndex = 3;
            // 
            // ServerResponse
            // 
            this.ServerResponse.FormattingEnabled = true;
            this.ServerResponse.ItemHeight = 16;
            this.ServerResponse.Location = new System.Drawing.Point(8, 158);
            this.ServerResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ServerResponse.Name = "ServerResponse";
            this.ServerResponse.Size = new System.Drawing.Size(541, 100);
            this.ServerResponse.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 291);
            this.Controls.Add(this.ServerResponse);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PurgeButton);
            this.Controls.Add(this.Apps);
            this.Controls.Add(this.GrabButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mass Analytics Purge for Mobiel Center";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GrabButton;
        private System.Windows.Forms.ComboBox Apps;
        private System.Windows.Forms.Button PurgeButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox ServerResponse;
    }
}

