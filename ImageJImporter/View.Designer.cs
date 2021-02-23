﻿
namespace ImageJImporter
{
    partial class View
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
            this.ViewFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuSaveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSeedList = new System.Windows.Forms.ListBox();
            this.uxEditSeed = new System.Windows.Forms.Button();
            this.uxViewSeed = new System.Windows.Forms.Button();
            this.uxTextViewer = new System.Windows.Forms.TextBox();
            this.uxToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.uxSaveSeed = new System.Windows.Forms.Button();
            this.ViewFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewFormMenuStrip
            // 
            this.ViewFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.ViewFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ViewFormMenuStrip.Name = "ViewFormMenuStrip";
            this.ViewFormMenuStrip.Size = new System.Drawing.Size(543, 25);
            this.ViewFormMenuStrip.TabIndex = 0;
            this.ViewFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuOpenFile,
            this.uxMenuSaveFile,
            this.uxMenuSaveFileAs});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxMenuOpenFile
            // 
            this.uxMenuOpenFile.Name = "uxMenuOpenFile";
            this.uxMenuOpenFile.Size = new System.Drawing.Size(180, 22);
            this.uxMenuOpenFile.Text = "Open";
            this.uxMenuOpenFile.ToolTipText = "Allows you to load a file into the program. It\'s meant to use .txt files, so I\'m " +
    "not sure what would happen if you imported other file types.";
            // 
            // uxMenuSaveFile
            // 
            this.uxMenuSaveFile.Name = "uxMenuSaveFile";
            this.uxMenuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.uxMenuSaveFile.Text = "Save";
            this.uxMenuSaveFile.ToolTipText = "Allows you to save the current data back into the original file you opened.";
            // 
            // uxMenuSaveFileAs
            // 
            this.uxMenuSaveFileAs.Name = "uxMenuSaveFileAs";
            this.uxMenuSaveFileAs.Size = new System.Drawing.Size(180, 22);
            this.uxMenuSaveFileAs.Text = "Save As";
            this.uxMenuSaveFileAs.ToolTipText = "Allows you to save the seed data you\'ve edited as a new .txt file with the same s" +
    "tructure as the original file.";
            // 
            // uxSeedList
            // 
            this.uxSeedList.FormattingEnabled = true;
            this.uxSeedList.Location = new System.Drawing.Point(12, 28);
            this.uxSeedList.Name = "uxSeedList";
            this.uxSeedList.Size = new System.Drawing.Size(200, 251);
            this.uxSeedList.TabIndex = 1;
            this.uxToolTip.SetToolTip(this.uxSeedList, "This is a list of all the seeds loaded into the program. You have to select a see" +
        "d here before you can edit or view its information.");
            // 
            // uxEditSeed
            // 
            this.uxEditSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEditSeed.Location = new System.Drawing.Point(328, 252);
            this.uxEditSeed.Name = "uxEditSeed";
            this.uxEditSeed.Size = new System.Drawing.Size(98, 27);
            this.uxEditSeed.TabIndex = 3;
            this.uxEditSeed.Text = "Edit Seed Data";
            this.uxToolTip.SetToolTip(this.uxEditSeed, "Allows you to start editing the seed you have selected in the list to the left.");
            this.uxEditSeed.UseVisualStyleBackColor = true;
            // 
            // uxViewSeed
            // 
            this.uxViewSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxViewSeed.Location = new System.Drawing.Point(218, 252);
            this.uxViewSeed.Name = "uxViewSeed";
            this.uxViewSeed.Size = new System.Drawing.Size(104, 27);
            this.uxViewSeed.TabIndex = 2;
            this.uxViewSeed.Text = "View Seed Data";
            this.uxToolTip.SetToolTip(this.uxViewSeed, "Allows you to view the data for the seed you have selected without the worry of a" +
        "ccidentally editing it.");
            this.uxViewSeed.UseVisualStyleBackColor = true;
            // 
            // uxTextViewer
            // 
            this.uxTextViewer.Location = new System.Drawing.Point(218, 28);
            this.uxTextViewer.Multiline = true;
            this.uxTextViewer.Name = "uxTextViewer";
            this.uxTextViewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.uxTextViewer.Size = new System.Drawing.Size(318, 218);
            this.uxTextViewer.TabIndex = 5;
            this.uxToolTip.SetToolTip(this.uxTextViewer, "This allows you to view the data for the seed you are editing. You can also save " +
        "the data for this seed by clicking a button.");
            this.uxTextViewer.WordWrap = false;
            // 
            // uxToolTip
            // 
            this.uxToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.uxToolTip.ToolTipTitle = "What This Does:";
            // 
            // uxSaveSeed
            // 
            this.uxSaveSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSaveSeed.Location = new System.Drawing.Point(432, 252);
            this.uxSaveSeed.Name = "uxSaveSeed";
            this.uxSaveSeed.Size = new System.Drawing.Size(104, 27);
            this.uxSaveSeed.TabIndex = 4;
            this.uxSaveSeed.Text = "Save Seed Data";
            this.uxToolTip.SetToolTip(this.uxSaveSeed, "Allows you to save the data for this seed. Won\'t affect anything unless you also " +
        "save the file after doing this.");
            this.uxSaveSeed.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 287);
            this.Controls.Add(this.uxSaveSeed);
            this.Controls.Add(this.uxTextViewer);
            this.Controls.Add(this.uxViewSeed);
            this.Controls.Add(this.uxEditSeed);
            this.Controls.Add(this.uxSeedList);
            this.Controls.Add(this.ViewFormMenuStrip);
            this.MainMenuStrip = this.ViewFormMenuStrip;
            this.Name = "View";
            this.Text = "ImageJ Importer";
            this.ViewFormMenuStrip.ResumeLayout(false);
            this.ViewFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ViewFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxMenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem uxMenuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem uxMenuSaveFileAs;
        private System.Windows.Forms.ListBox uxSeedList;
        private System.Windows.Forms.ToolTip uxToolTip;
        private System.Windows.Forms.Button uxEditSeed;
        private System.Windows.Forms.Button uxViewSeed;
        private System.Windows.Forms.TextBox uxTextViewer;
        private System.Windows.Forms.Button uxSaveSeed;
    }
}

