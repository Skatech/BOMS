namespace BackgroundOperationEmbedded
{
  partial class FormMain
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
      System.Windows.Forms.ToolStripMenuItem menuItemFile;
      System.Windows.Forms.ToolStripMenuItem menuItemFile_StartA;
      System.Windows.Forms.ToolStripMenuItem menuItemFile_Exit;
      System.Windows.Forms.ToolStripButton toolStripButtonFile_StartB;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      System.Windows.Forms.ColumnHeader columnHeaderOperationResult;
      this.menuItemFile_StartB = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemFile_Separator = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusStripLabelResult = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.listView = new System.Windows.Forms.ListView();
      this.columnHeaderOperationStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripButtonFile_StartA = new System.Windows.Forms.ToolStripButton();
      this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.toolStripProgressLabel = new System.Windows.Forms.ToolStripLabel();
      this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
      menuItemFile_StartA = new System.Windows.Forms.ToolStripMenuItem();
      menuItemFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
      toolStripButtonFile_StartB = new System.Windows.Forms.ToolStripButton();
      columnHeaderOperationResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer.ContentPanel.SuspendLayout();
      this.toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.toolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuItemFile
      // 
      menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuItemFile_StartA,
            this.menuItemFile_StartB,
            this.menuItemFile_Separator,
            menuItemFile_Exit});
      menuItemFile.Name = "menuItemFile";
      menuItemFile.Size = new System.Drawing.Size(37, 20);
      menuItemFile.Text = "&File";
      // 
      // menuItemFile_StartA
      // 
      menuItemFile_StartA.Name = "menuItemFile_StartA";
      menuItemFile_StartA.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
      menuItemFile_StartA.Size = new System.Drawing.Size(304, 22);
      menuItemFile_StartA.Text = "Start background operation (case A)";
      menuItemFile_StartA.Click += new System.EventHandler(this.StartLongOperationCaseA);
      // 
      // menuItemFile_StartB
      // 
      this.menuItemFile_StartB.Name = "menuItemFile_StartB";
      this.menuItemFile_StartB.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
      this.menuItemFile_StartB.Size = new System.Drawing.Size(304, 22);
      this.menuItemFile_StartB.Text = "Start background operation (case B)";
      this.menuItemFile_StartB.Click += new System.EventHandler(this.StartLongOperationCaseB);
      // 
      // menuItemFile_Separator
      // 
      this.menuItemFile_Separator.Name = "menuItemFile_Separator";
      this.menuItemFile_Separator.Size = new System.Drawing.Size(301, 6);
      // 
      // menuItemFile_Exit
      // 
      menuItemFile_Exit.Name = "menuItemFile_Exit";
      menuItemFile_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      menuItemFile_Exit.Size = new System.Drawing.Size(304, 22);
      menuItemFile_Exit.Text = "Exit";
      menuItemFile_Exit.Click += new System.EventHandler(this.menuItemFile_Exit_Click);
      // 
      // toolStripButtonFile_StartB
      // 
      toolStripButtonFile_StartB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      toolStripButtonFile_StartB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFile_StartB.Image")));
      toolStripButtonFile_StartB.ImageTransparentColor = System.Drawing.Color.Magenta;
      toolStripButtonFile_StartB.Name = "toolStripButtonFile_StartB";
      toolStripButtonFile_StartB.Size = new System.Drawing.Size(23, 22);
      toolStripButtonFile_StartB.Text = "Start background operation (case B)";
      toolStripButtonFile_StartB.Click += new System.EventHandler(this.StartLongOperationCaseB);
      // 
      // columnHeaderOperationResult
      // 
      columnHeaderOperationResult.Text = "Operation result";
      columnHeaderOperationResult.Width = 300;
      // 
      // toolStripContainer
      // 
      // 
      // toolStripContainer.BottomToolStripPanel
      // 
      this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
      // 
      // toolStripContainer.ContentPanel
      // 
      this.toolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.Window;
      this.toolStripContainer.ContentPanel.Controls.Add(this.listView);
      this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(449, 191);
      this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
      this.toolStripContainer.Name = "toolStripContainer";
      this.toolStripContainer.Size = new System.Drawing.Size(449, 262);
      this.toolStripContainer.TabIndex = 0;
      this.toolStripContainer.Text = "toolStripContainer1";
      // 
      // toolStripContainer.TopToolStripPanel
      // 
      this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
      this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelResult,
            this.statusStripProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(449, 22);
      this.statusStrip1.TabIndex = 0;
      // 
      // statusStripLabelResult
      // 
      this.statusStripLabelResult.AutoSize = false;
      this.statusStripLabelResult.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.statusStripLabelResult.Name = "statusStripLabelResult";
      this.statusStripLabelResult.Size = new System.Drawing.Size(200, 17);
      this.statusStripLabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statusStripProgressBar
      // 
      this.statusStripProgressBar.AutoSize = false;
      this.statusStripProgressBar.MarqueeAnimationSpeed = 1;
      this.statusStripProgressBar.Name = "statusStripProgressBar";
      this.statusStripProgressBar.Size = new System.Drawing.Size(100, 16);
      this.statusStripProgressBar.Visible = false;
      // 
      // listView
      // 
      this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderOperationStatus,
            columnHeaderOperationResult});
      this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listView.Location = new System.Drawing.Point(0, 0);
      this.listView.Name = "listView";
      this.listView.Size = new System.Drawing.Size(449, 191);
      this.listView.TabIndex = 0;
      this.listView.UseCompatibleStateImageBehavior = false;
      this.listView.View = System.Windows.Forms.View.Details;
      // 
      // columnHeaderOperationStatus
      // 
      this.columnHeaderOperationStatus.Text = "Operation status";
      this.columnHeaderOperationStatus.Width = 120;
      // 
      // menuStrip
      // 
      this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuItemFile});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
      this.menuStrip.Size = new System.Drawing.Size(449, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip1";
      // 
      // toolStrip
      // 
      this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFile_StartA,
            toolStripButtonFile_StartB,
            this.toolStripProgressBar,
            this.toolStripProgressLabel,
            this.toolStripButtonCancel});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(449, 25);
      this.toolStrip.Stretch = true;
      this.toolStrip.TabIndex = 1;
      // 
      // toolStripButtonFile_StartA
      // 
      this.toolStripButtonFile_StartA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonFile_StartA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFile_StartA.Image")));
      this.toolStripButtonFile_StartA.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonFile_StartA.Name = "toolStripButtonFile_StartA";
      this.toolStripButtonFile_StartA.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonFile_StartA.Text = "Start background operation (case A)";
      this.toolStripButtonFile_StartA.Click += new System.EventHandler(this.StartLongOperationCaseA);
      // 
      // toolStripProgressBar
      // 
      this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripProgressBar.AutoSize = false;
      this.toolStripProgressBar.MarqueeAnimationSpeed = 1;
      this.toolStripProgressBar.Name = "toolStripProgressBar";
      this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
      this.toolStripProgressBar.Visible = false;
      // 
      // toolStripProgressLabel
      // 
      this.toolStripProgressLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripProgressLabel.Name = "toolStripProgressLabel";
      this.toolStripProgressLabel.Size = new System.Drawing.Size(23, 22);
      this.toolStripProgressLabel.Text = "<>";
      this.toolStripProgressLabel.Visible = false;
      // 
      // toolStripButtonCancel
      // 
      this.toolStripButtonCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
      this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButtonCancel.Name = "toolStripButtonCancel";
      this.toolStripButtonCancel.Size = new System.Drawing.Size(23, 22);
      this.toolStripButtonCancel.Text = "Cancel background operation";
      this.toolStripButtonCancel.Visible = false;
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
      this.toolStripMenuItem2.Text = "121212";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(449, 262);
      this.Controls.Add(this.toolStripContainer);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "FormMain";
      this.Text = "Embedded sample";
      this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer.ContentPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.PerformLayout();
      this.toolStripContainer.ResumeLayout(false);
      this.toolStripContainer.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusStripLabelResult;
    private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
    private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
    private System.Windows.Forms.ToolStripSeparator menuItemFile_Separator;
    private System.Windows.Forms.ToolStripButton toolStripButtonFile_StartA;
    private System.Windows.Forms.ToolStripLabel toolStripProgressLabel;
    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.ColumnHeader columnHeaderOperationStatus;
    private System.Windows.Forms.ToolStripMenuItem menuItemFile_StartB;
  }
}

