namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeichnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPolyline = new System.Windows.Forms.ToolStripButton();
            this.InformationenButton = new System.Windows.Forms.ToolStripButton();
            this.showLinesButton = new System.Windows.Forms.ToolStripButton();
            this.showCirclesButton = new System.Windows.Forms.ToolStripButton();
            this.showPolyLineButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zeichnenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // zeichnenToolStripMenuItem
            // 
            this.zeichnenToolStripMenuItem.Name = "zeichnenToolStripMenuItem";
            this.zeichnenToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.zeichnenToolStripMenuItem.Text = "Zeichnen";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
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
            this.showLinesButton,
            this.showCirclesButton,
            this.showPolyLineButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
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
            this.toolStripButtonLine.Size = new System.Drawing.Size(60, 44);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCircle.Image")));
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(70, 44);
            this.toolStripButtonCircle.Text = "Circle";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonPolyline
            // 
            this.toolStripButtonPolyline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPolyline.Image")));
            this.toolStripButtonPolyline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPolyline.Name = "toolStripButtonPolyline";
            this.toolStripButtonPolyline.Size = new System.Drawing.Size(84, 44);
            this.toolStripButtonPolyline.Text = "Polyline";
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
            // showLinesButton
            // 
            this.showLinesButton.Checked = true;
            this.showLinesButton.CheckOnClick = true;
            this.showLinesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLinesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showLinesButton.Image = ((System.Drawing.Image)(resources.GetObject("showLinesButton.Image")));
            this.showLinesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showLinesButton.Name = "showLinesButton";
            this.showLinesButton.Size = new System.Drawing.Size(46, 44);
            this.showLinesButton.Text = "Lines";
            this.showLinesButton.Click += new System.EventHandler(this.showLinesButton_Click);
            // 
            // showCirclesButton
            // 
            this.showCirclesButton.Checked = true;
            this.showCirclesButton.CheckOnClick = true;
            this.showCirclesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCirclesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showCirclesButton.Image = ((System.Drawing.Image)(resources.GetObject("showCirclesButton.Image")));
            this.showCirclesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showCirclesButton.Name = "showCirclesButton";
            this.showCirclesButton.Size = new System.Drawing.Size(50, 44);
            this.showCirclesButton.Text = "Circle";
            this.showCirclesButton.Click += new System.EventHandler(this.showCirclesButton_Click);
            // 
            // showPolyLineButton
            // 
            this.showPolyLineButton.Checked = true;
            this.showPolyLineButton.CheckOnClick = true;
            this.showPolyLineButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPolyLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showPolyLineButton.Image = ((System.Drawing.Image)(resources.GetObject("showPolyLineButton.Image")));
            this.showPolyLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showPolyLineButton.Name = "showPolyLineButton";
            this.showPolyLineButton.Size = new System.Drawing.Size(70, 44);
            this.showPolyLineButton.Text = "Polylines";
            this.showPolyLineButton.Click += new System.EventHandler(this.showPolyLineButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "Informationen";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(103, 20);
            this.toolStripStatusLabel1.Text = "Informationen";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 343);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeichnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonPolyline;
        private System.Windows.Forms.ToolStripButton InformationenButton;
        private System.Windows.Forms.ToolStripButton showLinesButton;
        private System.Windows.Forms.ToolStripButton showCirclesButton;
        private System.Windows.Forms.ToolStripButton showPolyLineButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

