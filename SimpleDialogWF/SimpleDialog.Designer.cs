namespace Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement
{
  partial class SimpleDialog
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
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.labelTitle = new System.Windows.Forms.Label();
      this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.layoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // progressBar
      // 
      this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progressBar.Location = new System.Drawing.Point(10, 50);
      this.progressBar.Margin = new System.Windows.Forms.Padding(10);
      this.progressBar.MinimumSize = new System.Drawing.Size(200, 0);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(250, 13);
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 1;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.BackColor = System.Drawing.SystemColors.Window;
      this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
      this.labelTitle.Location = new System.Drawing.Point(10, 10);
      this.labelTitle.Margin = new System.Windows.Forms.Padding(10);
      this.labelTitle.MinimumSize = new System.Drawing.Size(250, 0);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(250, 20);
      this.labelTitle.TabIndex = 2;
      this.labelTitle.Text = "Title Title Title Title Title";
      this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // layoutPanel
      // 
      this.layoutPanel.AutoSize = true;
      this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.layoutPanel.BackColor = System.Drawing.SystemColors.Window;
      this.layoutPanel.Controls.Add(this.labelTitle);
      this.layoutPanel.Controls.Add(this.progressBar);
      this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.layoutPanel.Location = new System.Drawing.Point(0, 0);
      this.layoutPanel.Name = "layoutPanel";
      this.layoutPanel.Size = new System.Drawing.Size(271, 73);
      this.layoutPanel.TabIndex = 3;
      this.layoutPanel.WrapContents = false;
      // 
      // DialogBackgroundWork
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.ClientSize = new System.Drawing.Size(271, 73);
      this.Controls.Add(this.layoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DialogBackgroundWork";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Caption Caption Caption";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogBackgroundWork_FormClosing);
      this.Shown += new System.EventHandler(this.DialogBackgroundWork_Shown);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DialogBackgroundWork_KeyDown);
      this.layoutPanel.ResumeLayout(false);
      this.layoutPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label labelTitle;
    private System.Windows.Forms.FlowLayoutPanel layoutPanel;
  }
}