namespace Skatech.Tests.TestEmbedded
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
      System.Windows.Forms.ToolStripMenuItem menuItemOptions;
      System.Windows.Forms.ToolStripSeparator menuItemOptions_Separator;
      System.Windows.Forms.ToolStripButton toolStripButtonFile_StartA;
      this.menuItemFile_StartB = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemFile_Separator = new System.Windows.Forms.ToolStripSeparator();
      this.menuItemOptions_AbortableA = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemOptions_NotifableA = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemOptions_AbortableB = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemOptions_NotifableB = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusStripLabelProgress = new System.Windows.Forms.ToolStripStatusLabel();
      this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.listView = new System.Windows.Forms.ListView();
      this.columnHeaderOperationStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.toolStrip = new System.Windows.Forms.ToolStrip();
      this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.toolStripLabelProgress = new System.Windows.Forms.ToolStripLabel();
      menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
      menuItemFile_StartA = new System.Windows.Forms.ToolStripMenuItem();
      menuItemFile_Exit = new System.Windows.Forms.ToolStripMenuItem();
      toolStripButtonFile_StartB = new System.Windows.Forms.ToolStripButton();
      columnHeaderOperationResult = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      menuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
      menuItemOptions_Separator = new System.Windows.Forms.ToolStripSeparator();
      toolStripButtonFile_StartA = new System.Windows.Forms.ToolStripButton();
      this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer.ContentPanel.SuspendLayout();
      this.toolStripContainer.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer.SuspendLayout();
      this.statusStrip.SuspendLayout();
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
      // menuItemOptions
      // 
      menuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOptions_AbortableA,
            this.menuItemOptions_NotifableA,
            menuItemOptions_Separator,
            this.menuItemOptions_AbortableB,
            this.menuItemOptions_NotifableB});
      menuItemOptions.Name = "menuItemOptions";
      menuItemOptions.Size = new System.Drawing.Size(61, 20);
      menuItemOptions.Text = "&Options";
      // 
      // menuItemOptions_AbortableA
      // 
      this.menuItemOptions_AbortableA.Checked = true;
      this.menuItemOptions_AbortableA.CheckOnClick = true;
      this.menuItemOptions_AbortableA.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuItemOptions_AbortableA.Name = "menuItemOptions_AbortableA";
      this.menuItemOptions_AbortableA.Size = new System.Drawing.Size(290, 22);
      this.menuItemOptions_AbortableA.Text = "Background operation abortable (case A)";
      // 
      // menuItemOptions_NotifableA
      // 
      this.menuItemOptions_NotifableA.Checked = true;
      this.menuItemOptions_NotifableA.CheckOnClick = true;
      this.menuItemOptions_NotifableA.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuItemOptions_NotifableA.Name = "menuItemOptions_NotifableA";
      this.menuItemOptions_NotifableA.Size = new System.Drawing.Size(290, 22);
      this.menuItemOptions_NotifableA.Text = "Background operation notifable (case A)";
      // 
      // menuItemOptions_Separator
      // 
      menuItemOptions_Separator.Name = "menuItemOptions_Separator";
      menuItemOptions_Separator.Size = new System.Drawing.Size(287, 6);
      // 
      // menuItemOptions_AbortableB
      // 
      this.menuItemOptions_AbortableB.Checked = true;
      this.menuItemOptions_AbortableB.CheckOnClick = true;
      this.menuItemOptions_AbortableB.CheckState = System.Windows.Forms.CheckState.Checked;
      this.menuItemOptions_AbortableB.Name = "menuItemOptions_AbortableB";
      this.menuItemOptions_AbortableB.Size = new System.Drawing.Size(290, 22);
      this.menuItemOptions_AbortableB.Text = "Background operation abortable (case B)";
      // 
      // menuItemOptions_NotifableB
      // 
      this.menuItemOptions_NotifableB.CheckOnClick = true;
      this.menuItemOptions_NotifableB.Name = "menuItemOptions_NotifableB";
      this.menuItemOptions_NotifableB.Size = new System.Drawing.Size(290, 22);
      this.menuItemOptions_NotifableB.Text = "Background operation notifable (case B)";
      // 
      // toolStripButtonFile_StartA
      // 
      toolStripButtonFile_StartA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      toolStripButtonFile_StartA.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFile_StartA.Image")));
      toolStripButtonFile_StartA.ImageTransparentColor = System.Drawing.Color.Magenta;
      toolStripButtonFile_StartA.Name = "toolStripButtonFile_StartA";
      toolStripButtonFile_StartA.Size = new System.Drawing.Size(23, 22);
      toolStripButtonFile_StartA.Text = "Start background operation (case A)";
      toolStripButtonFile_StartA.Click += new System.EventHandler(this.StartLongOperationCaseA);
      // 
      // toolStripContainer
      // 
      // 
      // toolStripContainer.BottomToolStripPanel
      // 
      this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
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
      // statusStrip
      // 
      this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelProgress,
            this.statusStripProgressBar});
      this.statusStrip.Location = new System.Drawing.Point(0, 0);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(449, 22);
      this.statusStrip.TabIndex = 0;
      // 
      // statusStripLabelProgress
      // 
      this.statusStripLabelProgress.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.statusStripLabelProgress.Name = "statusStripLabelProgress";
      this.statusStripLabelProgress.Size = new System.Drawing.Size(332, 17);
      this.statusStripLabelProgress.Spring = true;
      this.statusStripLabelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.statusStripLabelProgress.Visible = false;
      // 
      // statusStripProgressBar
      // 
      this.statusStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.statusStripProgressBar.AutoSize = false;
      this.statusStripProgressBar.MarqueeAnimationSpeed = 50;
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
      this.listView.FullRowSelect = true;
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
            menuItemFile,
            menuItemOptions});
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
            toolStripButtonFile_StartA,
            toolStripButtonFile_StartB,
            this.toolStripProgressBar,
            this.toolStripLabelProgress});
      this.toolStrip.Location = new System.Drawing.Point(0, 24);
      this.toolStrip.Name = "toolStrip";
      this.toolStrip.Size = new System.Drawing.Size(449, 25);
      this.toolStrip.Stretch = true;
      this.toolStrip.TabIndex = 1;
      // 
      // toolStripProgressBar
      // 
      this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripProgressBar.AutoSize = false;
      this.toolStripProgressBar.MarqueeAnimationSpeed = 50;
      this.toolStripProgressBar.Name = "toolStripProgressBar";
      this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
      this.toolStripProgressBar.Visible = false;
      // 
      // toolStripLabelProgress
      // 
      this.toolStripLabelProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripLabelProgress.AutoSize = false;
      this.toolStripLabelProgress.Name = "toolStripLabelProgress";
      this.toolStripLabelProgress.Size = new System.Drawing.Size(200, 22);
      this.toolStripLabelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.toolStripLabelProgress.Visible = false;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(449, 262);
      this.Controls.Add(this.toolStripContainer);
      this.KeyPreview = true;
      this.MainMenuStrip = this.menuStrip;
      this.MinimumSize = new System.Drawing.Size(465, 300);
      this.Name = "FormMain";
      this.Text = "Embedded sample";
      this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer.ContentPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer.TopToolStripPanel.PerformLayout();
      this.toolStripContainer.ResumeLayout(false);
      this.toolStripContainer.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.toolStrip.ResumeLayout(false);
      this.toolStrip.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStripContainer toolStripContainer;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStrip toolStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusStripLabelProgress;
    private System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
    private System.Windows.Forms.ToolStripSeparator menuItemFile_Separator;
    private System.Windows.Forms.ToolStripLabel toolStripLabelProgress;
    private System.Windows.Forms.ListView listView;
    private System.Windows.Forms.ColumnHeader columnHeaderOperationStatus;
    private System.Windows.Forms.ToolStripMenuItem menuItemFile_StartB;
    private System.Windows.Forms.ToolStripMenuItem menuItemOptions_AbortableA;
    private System.Windows.Forms.ToolStripMenuItem menuItemOptions_AbortableB;
    private System.Windows.Forms.ToolStripMenuItem menuItemOptions_NotifableA;
    private System.Windows.Forms.ToolStripMenuItem menuItemOptions_NotifableB;
  }
}

