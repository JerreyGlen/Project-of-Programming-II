namespace ÜbungenPr2
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPolyline = new System.Windows.Forms.ToolStripButton();
            this.InformationenButton = new System.Windows.Forms.ToolStripButton();
            this.ShowLinesButton8 = new System.Windows.Forms.ToolStripButton();
            this.ShowCirclesButton = new System.Windows.Forms.ToolStripButton();
            this.ShowPolylineButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonOpen,
            this.toolStripButtonSave,
            this.toolStripButtonLine,
            this.toolStripButtonCircle,
            this.toolStripButtonPolyline,
            this.InformationenButton,
            this.ShowLinesButton8,
            this.ShowCirclesButton,
            this.ShowPolylineButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(43, 44);
            this.toolStripButtonNew.Text = "New";
            this.toolStripButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(49, 44);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(44, 44);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(40, 44);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(50, 44);
            this.toolStripButtonCircle.Text = "Circle";
            this.toolStripButtonCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonPolyline
            // 
            this.toolStripButtonPolyline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPolyline.Image")));
            this.toolStripButtonPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPolyline.Name = "toolStripButtonPolyline";
            this.toolStripButtonPolyline.Size = new System.Drawing.Size(64, 44);
            this.toolStripButtonPolyline.Text = "Polyline";
            this.toolStripButtonPolyline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPolyline.Click += new System.EventHandler(this.toolStripButtonPolyline_Click);
            // 
            // InformationenButton
            // 
            this.InformationenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InformationenButton.Image = ((System.Drawing.Image)(resources.GetObject("InformationenButton.Image")));
            this.InformationenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InformationenButton.Name = "InformationenButton";
            this.InformationenButton.Size = new System.Drawing.Size(107, 44);
            this.InformationenButton.Text = "Informationen";
            this.InformationenButton.Click += new System.EventHandler(this.InformationenButton_Click);
            // 
            // ShowLinesButton8
            // 
            this.ShowLinesButton8.Checked = true;
            this.ShowLinesButton8.CheckOnClick = true;
            this.ShowLinesButton8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowLinesButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowLinesButton8.Image = ((System.Drawing.Image)(resources.GetObject("ShowLinesButton8.Image")));
            this.ShowLinesButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowLinesButton8.Name = "ShowLinesButton8";
            this.ShowLinesButton8.Size = new System.Drawing.Size(46, 44);
            this.ShowLinesButton8.Text = "Lines";
            this.ShowLinesButton8.Click += new System.EventHandler(this.ShowLinesButton8_Click);
            // 
            // ShowCirclesButton
            // 
            this.ShowCirclesButton.Checked = true;
            this.ShowCirclesButton.CheckOnClick = true;
            this.ShowCirclesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCirclesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowCirclesButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowCirclesButton.Image")));
            this.ShowCirclesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowCirclesButton.Name = "ShowCirclesButton";
            this.ShowCirclesButton.Size = new System.Drawing.Size(56, 44);
            this.ShowCirclesButton.Text = "Circles";
            this.ShowCirclesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShowCirclesButton.Click += new System.EventHandler(this.ShowCirclesButton_Click);
            // 
            // ShowPolylineButton
            // 
            this.ShowPolylineButton.Checked = true;
            this.ShowPolylineButton.CheckOnClick = true;
            this.ShowPolylineButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowPolylineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShowPolylineButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowPolylineButton.Image")));
            this.ShowPolylineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowPolylineButton.Name = "ShowPolylineButton";
            this.ShowPolylineButton.Size = new System.Drawing.Size(70, 44);
            this.ShowPolylineButton.Text = "Polylines";
            this.ShowPolylineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ShowPolylineButton.Click += new System.EventHandler(this.ShowPolylineButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(81, 20);
            this.toolStripStatus.Text = "Anweisung";
            this.toolStripStatus.Click += new System.EventHandler(this.toolStripStatus_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 343);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonPolyline;
        private System.Windows.Forms.ToolStripButton InformationenButton;
        private System.Windows.Forms.ToolStripButton ShowLinesButton8;
        private System.Windows.Forms.ToolStripButton ShowCirclesButton;
        private System.Windows.Forms.ToolStripButton ShowPolylineButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

