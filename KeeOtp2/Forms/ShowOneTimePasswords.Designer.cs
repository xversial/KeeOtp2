﻿namespace KeeOtp2
{
    partial class ShowOneTimePasswords
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
            this.timerUpdateTotp = new System.Windows.Forms.Timer(this.components);
            this.labelOtp = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.groupboxTotp = new System.Windows.Forms.GroupBox();
            this.linkLabelIncorrect = new System.Windows.Forms.LinkLabel();
            this.buttonCopyTotp = new System.Windows.Forms.Button();
            this.buttonShowQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.groupboxTotp.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOtp
            // 
            this.labelOtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOtp.BackColor = System.Drawing.SystemColors.Control;
            this.labelOtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtp.Location = new System.Drawing.Point(6, 16);
            this.labelOtp.Name = "labelOtp";
            this.labelOtp.Size = new System.Drawing.Size(339, 73);
            this.labelOtp.TabIndex = 0;
            this.labelOtp.Text = "000000";
            this.labelOtp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOtp.Click += new System.EventHandler(this.labelOtp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(288, 170);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(93, 170);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBanner.Location = new System.Drawing.Point(-2, 0);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(379, 58);
            this.pictureBoxBanner.TabIndex = 7;
            this.pictureBoxBanner.TabStop = false;
            // 
            // groupboxTotp
            // 
            this.groupboxTotp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxTotp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupboxTotp.Controls.Add(this.linkLabelIncorrect);
            this.groupboxTotp.Controls.Add(this.labelOtp);
            this.groupboxTotp.Location = new System.Drawing.Point(12, 64);
            this.groupboxTotp.Name = "groupboxTotp";
            this.groupboxTotp.Size = new System.Drawing.Size(351, 96);
            this.groupboxTotp.TabIndex = 8;
            this.groupboxTotp.TabStop = false;
            this.groupboxTotp.Text = "TOTP";
            // 
            // linkLabelIncorrect
            // 
            this.linkLabelIncorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelIncorrect.AutoSize = true;
            this.linkLabelIncorrect.Location = new System.Drawing.Point(290, 0);
            this.linkLabelIncorrect.Name = "linkLabelIncorrect";
            this.linkLabelIncorrect.Size = new System.Drawing.Size(55, 13);
            this.linkLabelIncorrect.TabIndex = 11;
            this.linkLabelIncorrect.TabStop = true;
            this.linkLabelIncorrect.Text = "Incorrect?";
            this.linkLabelIncorrect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWrong_LinkClicked);
            // 
            // buttonCopyTotp
            // 
            this.buttonCopyTotp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyTotp.Location = new System.Drawing.Point(207, 170);
            this.buttonCopyTotp.Name = "buttonCopyTotp";
            this.buttonCopyTotp.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyTotp.TabIndex = 9;
            this.buttonCopyTotp.Text = "Copy";
            this.buttonCopyTotp.UseVisualStyleBackColor = true;
            this.buttonCopyTotp.Click += new System.EventHandler(this.buttonCopyTotp_Click);
            // 
            // buttonShowQR
            // 
            this.buttonShowQR.Location = new System.Drawing.Point(12, 170);
            this.buttonShowQR.Name = "buttonShowQR";
            this.buttonShowQR.Size = new System.Drawing.Size(75, 23);
            this.buttonShowQR.TabIndex = 10;
            this.buttonShowQR.Text = "Show QR*";
            this.buttonShowQR.UseVisualStyleBackColor = true;
            this.buttonShowQR.Click += new System.EventHandler(this.buttonShowQR_Click);
            // 
            // ShowOneTimePasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(375, 208);
            this.Controls.Add(this.buttonShowQR);
            this.Controls.Add(this.buttonCopyTotp);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.groupboxTotp);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowOneTimePasswords";
            this.Text = "Timed Passwords";
            this.Load += new System.EventHandler(this.ShowOneTimePasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.groupboxTotp.ResumeLayout(false);
            this.groupboxTotp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdateTotp;
        private System.Windows.Forms.Label labelOtp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.GroupBox groupboxTotp;
        private System.Windows.Forms.Button buttonCopyTotp;
        private System.Windows.Forms.Button buttonShowQR;
        private System.Windows.Forms.LinkLabel linkLabelIncorrect;
    }
}