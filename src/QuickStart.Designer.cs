namespace TextEditor {
    partial class QuickStart {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {

            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickStart));
            this.lblQuickStart = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnNewDocument = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnBlankDoc = new System.Windows.Forms.Button();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCreateBlankDoc = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelCreateBlankDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuickStart
            // 
            this.lblQuickStart.AutoSize = true;
            this.lblQuickStart.BackColor = System.Drawing.Color.Transparent;
            this.lblQuickStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblQuickStart.Font = new System.Drawing.Font("Segoe UI Semilight", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuickStart.ForeColor = System.Drawing.Color.Black;
            this.lblQuickStart.Location = new System.Drawing.Point(33, 75);
            this.lblQuickStart.Name = "lblQuickStart";
            this.lblQuickStart.Size = new System.Drawing.Size(193, 57);
            this.lblQuickStart.TabIndex = 1;
            this.lblQuickStart.Text = "Welcome";
            this.lblQuickStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.Black;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.Location = new System.Drawing.Point(4, 180);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(243, 152);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "  📁 \r\nOpen";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.BackColor = System.Drawing.Color.Transparent;
            this.btnNewDocument.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewDocument.FlatAppearance.BorderSize = 0;
            this.btnNewDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDocument.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewDocument.ForeColor = System.Drawing.Color.Black;
            this.btnNewDocument.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewDocument.Location = new System.Drawing.Point(7, 337);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(240, 162);
            this.btnNewDocument.TabIndex = 10;
            this.btnNewDocument.Text = "  📝 \r\nNew";
            this.btnNewDocument.UseVisualStyleBackColor = false;
            this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.lblQuickStart);
            this.panelMenu.Controls.Add(this.btnBrowse);
            this.panelMenu.Controls.Add(this.btnNewDocument);
            this.panelMenu.Location = new System.Drawing.Point(-6, -20);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(251, 712);
            this.panelMenu.TabIndex = 13;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(9, 617);
            this.btnAbout.MaximumSize = new System.Drawing.Size(240, 65);
            this.btnAbout.MinimumSize = new System.Drawing.Size(240, 65);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(240, 65);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnBlankDoc
            // 
            this.btnBlankDoc.BackColor = System.Drawing.Color.Transparent;
            this.btnBlankDoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBlankDoc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBlankDoc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBlankDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlankDoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlankDoc.ForeColor = System.Drawing.Color.White;
            this.btnBlankDoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBlankDoc.Location = new System.Drawing.Point(500, 290);
            this.btnBlankDoc.Name = "btnBlankDoc";
            this.btnBlankDoc.Size = new System.Drawing.Size(223, 118);
            this.btnBlankDoc.TabIndex = 20;
            this.btnBlankDoc.Text = "  📃 \r\nBlank document";
            this.btnBlankDoc.UseVisualStyleBackColor = false;
            this.btnBlankDoc.Click += new System.EventHandler(this.btnBlankDoc_Click);
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTemplate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTemplate.Font = new System.Drawing.Font("Segoe UI Semilight", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemplate.ForeColor = System.Drawing.Color.Gray;
            this.lblTemplate.Location = new System.Drawing.Point(181, 206);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(365, 57);
            this.lblTemplate.TabIndex = 19;
            this.lblTemplate.Text = "Choose a template";
            this.lblTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Location = new System.Drawing.Point(536, 589);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(149, 38);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(371, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 38);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCreateBlankDoc
            // 
            this.panelCreateBlankDoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCreateBlankDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCreateBlankDoc.Controls.Add(this.btnMin);
            this.panelCreateBlankDoc.Controls.Add(this.btnCancel);
            this.panelCreateBlankDoc.Controls.Add(this.btnClose);
            this.panelCreateBlankDoc.Controls.Add(this.lblTemplate);
            this.panelCreateBlankDoc.Controls.Add(this.btnContinue);
            this.panelCreateBlankDoc.Location = new System.Drawing.Point(249, 2);
            this.panelCreateBlankDoc.Name = "panelCreateBlankDoc";
            this.panelCreateBlankDoc.Size = new System.Drawing.Size(714, 658);
            this.panelCreateBlankDoc.TabIndex = 19;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.LightGray;
            this.btnMin.Location = new System.Drawing.Point(580, -5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(65, 40);
            this.btnMin.TabIndex = 22;
            this.btnMin.Text = "─";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(647, -4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 40);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseDown);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // QuickStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(960, 663);
            this.Controls.Add(this.btnBlankDoc);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCreateBlankDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuickStart_FormClosing);
            this.Load += new System.EventHandler(this.QuickStart_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelCreateBlankDoc.ResumeLayout(false);
            this.panelCreateBlankDoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblQuickStart;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnBlankDoc;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelCreateBlankDoc;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
    }
}
