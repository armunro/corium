using System.ComponentModel;

namespace Corium.WindowsClient.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InitialsFilePath = new System.Windows.Forms.LinkLabel();
            this.l1 = new System.Windows.Forms.Label();
            this.Sources = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initials File: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Controls.Add(this.InitialsFilePath);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.Sources);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 245);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initials";
            // 
            // InitialsFilePath
            // 
            this.InitialsFilePath.Location = new System.Drawing.Point(115, 20);
            this.InitialsFilePath.Name = "InitialsFilePath";
            this.InitialsFilePath.Size = new System.Drawing.Size(449, 23);
            this.InitialsFilePath.TabIndex = 6;
            this.InitialsFilePath.TabStop = true;
            this.InitialsFilePath.Text = "C:\\somefile.initials.json";
            this.InitialsFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InitialsFilePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InitialsFilePath_LinkClicked);
            // 
            // l1
            // 
            this.l1.Location = new System.Drawing.Point(7, 43);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(142, 25);
            this.l1.TabIndex = 5;
            this.l1.Text = "Toolset Sources";
            this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sources
            // 
            this.Sources.FormattingEnabled = true;
            this.Sources.ItemHeight = 15;
            this.Sources.Location = new System.Drawing.Point(7, 71);
            this.Sources.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Sources.Name = "Sources";
            this.Sources.Size = new System.Drawing.Size(557, 64);
            this.Sources.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(7, 141);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(103, 26);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Lets Go";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 270);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Fira Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Corium";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button StartButton;

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.LinkLabel InitialsFilePath;
        private System.Windows.Forms.ListBox Sources;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}