namespace Corium.WindowsClient.Forms
{
    sealed partial class CoriumWindowForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.MaximizeButton = new FontAwesome.Sharp.IconButton();
            this.MinimizeButton = new FontAwesome.Sharp.IconButton();
            this.BackButton = new FontAwesome.Sharp.IconButton();
            this.ForwardButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.MaximizeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 22);
            this.panel1.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.LightCoral;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(695, 22);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "TeamCity";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblTitle_DoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // LogPanel
            // 
            this.LogPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogPanel.Controls.Add(this.txtOutput);
            this.LogPanel.Location = new System.Drawing.Point(0, 26);
            this.LogPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(695, 214);
            this.LogPanel.TabIndex = 7;
            this.LogPanel.Visible = false;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.Gray;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(695, 214);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = " ";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.SlateGray;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.ExitButton.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitButton.IconSize = 18;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.Location = new System.Drawing.Point(672, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0D;
            this.ExitButton.Size = new System.Drawing.Size(23, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.SlateGray;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MaximizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.MaximizeButton.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeButton.IconSize = 18;
            this.MaximizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MaximizeButton.Location = new System.Drawing.Point(649, 0);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Rotation = 0D;
            this.MaximizeButton.Size = new System.Drawing.Size(23, 23);
            this.MaximizeButton.TabIndex = 10;
            this.MaximizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.SlateGray;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeButton.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.MinimizeButton.IconSize = 18;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinimizeButton.Location = new System.Drawing.Point(626, -1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Rotation = 0D;
            this.MinimizeButton.Size = new System.Drawing.Size(23, 23);
            this.MinimizeButton.TabIndex = 11;
            this.MinimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.SlateGray;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BackButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BackButton.IconColor = System.Drawing.Color.White;
            this.BackButton.IconSize = 18;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.Location = new System.Drawing.Point(0, 1);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Rotation = 0D;
            this.BackButton.Size = new System.Drawing.Size(23, 23);
            this.BackButton.TabIndex = 12;
            this.BackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.SlateGray;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ForwardButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ForwardButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ForwardButton.IconColor = System.Drawing.Color.White;
            this.ForwardButton.IconSize = 18;
            this.ForwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ForwardButton.Location = new System.Drawing.Point(23, 1);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Rotation = 0D;
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 13;
            this.ForwardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ForwardButton.UseVisualStyleBackColor = false;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 603);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.panel1);
            this.Name = "BrowserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BrowserForm";
            this.panel1.ResumeLayout(false);
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.TextBox txtOutput;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton MaximizeButton;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private FontAwesome.Sharp.IconButton BackButton;
        private FontAwesome.Sharp.IconButton ForwardButton;
    }
}