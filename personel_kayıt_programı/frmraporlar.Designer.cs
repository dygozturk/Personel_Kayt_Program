﻿namespace personel_kayıt_programı
{
    partial class frmraporlar
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // frmraporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 359);
            this.Name = "frmraporlar";
            this.Text = "frmraporlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
    }
}