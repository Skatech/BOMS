namespace Skatech.Tests.TestDialog
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
      this.buttonStart = new System.Windows.Forms.Button();
      this.comboCloseOnComplete = new System.Windows.Forms.ComboBox();
      this.comboReportProgress = new System.Windows.Forms.ComboBox();
      this.comboSupportCancellation = new System.Windows.Forms.ComboBox();
      this.labelCloseOnComplete = new System.Windows.Forms.Label();
      this.labelReportProgress = new System.Windows.Forms.Label();
      this.labelSupportCancellation = new System.Windows.Forms.Label();
      this.labelResult = new System.Windows.Forms.Label();
      this.labelArgumentText = new System.Windows.Forms.Label();
      this.textArgumentText = new System.Windows.Forms.TextBox();
      this.labelResultValue = new System.Windows.Forms.Label();
      this.labelTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonStart.Location = new System.Drawing.Point(166, 244);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(75, 23);
      this.buttonStart.TabIndex = 1;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // comboCloseOnComplete
      // 
      this.comboCloseOnComplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboCloseOnComplete.FormattingEnabled = true;
      this.comboCloseOnComplete.Items.AddRange(new object[] {
            "No",
            "Yes"});
      this.comboCloseOnComplete.Location = new System.Drawing.Point(120, 86);
      this.comboCloseOnComplete.Name = "comboCloseOnComplete";
      this.comboCloseOnComplete.Size = new System.Drawing.Size(121, 21);
      this.comboCloseOnComplete.TabIndex = 2;
      // 
      // comboReportProgress
      // 
      this.comboReportProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboReportProgress.FormattingEnabled = true;
      this.comboReportProgress.Items.AddRange(new object[] {
            "No",
            "Yes"});
      this.comboReportProgress.Location = new System.Drawing.Point(120, 113);
      this.comboReportProgress.Name = "comboReportProgress";
      this.comboReportProgress.Size = new System.Drawing.Size(121, 21);
      this.comboReportProgress.TabIndex = 3;
      // 
      // comboSupportCancellation
      // 
      this.comboSupportCancellation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboSupportCancellation.FormattingEnabled = true;
      this.comboSupportCancellation.Items.AddRange(new object[] {
            "No",
            "Yes"});
      this.comboSupportCancellation.Location = new System.Drawing.Point(120, 140);
      this.comboSupportCancellation.Name = "comboSupportCancellation";
      this.comboSupportCancellation.Size = new System.Drawing.Size(121, 21);
      this.comboSupportCancellation.TabIndex = 4;
      // 
      // labelCloseOnComplete
      // 
      this.labelCloseOnComplete.AutoSize = true;
      this.labelCloseOnComplete.Location = new System.Drawing.Point(20, 89);
      this.labelCloseOnComplete.Name = "labelCloseOnComplete";
      this.labelCloseOnComplete.Size = new System.Drawing.Size(94, 13);
      this.labelCloseOnComplete.TabIndex = 5;
      this.labelCloseOnComplete.Text = "Close on complete";
      this.labelCloseOnComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelReportProgress
      // 
      this.labelReportProgress.AutoSize = true;
      this.labelReportProgress.Location = new System.Drawing.Point(32, 116);
      this.labelReportProgress.Name = "labelReportProgress";
      this.labelReportProgress.Size = new System.Drawing.Size(82, 13);
      this.labelReportProgress.TabIndex = 6;
      this.labelReportProgress.Text = "Report progress";
      this.labelReportProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelSupportCancellation
      // 
      this.labelSupportCancellation.AutoSize = true;
      this.labelSupportCancellation.Location = new System.Drawing.Point(10, 143);
      this.labelSupportCancellation.Name = "labelSupportCancellation";
      this.labelSupportCancellation.Size = new System.Drawing.Size(104, 13);
      this.labelSupportCancellation.TabIndex = 7;
      this.labelSupportCancellation.Text = "Support cancellation";
      this.labelSupportCancellation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Location = new System.Drawing.Point(29, 217);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(84, 13);
      this.labelResult.TabIndex = 8;
      this.labelResult.Text = "Operation result:";
      // 
      // labelArgumentText
      // 
      this.labelArgumentText.AutoSize = true;
      this.labelArgumentText.Location = new System.Drawing.Point(27, 173);
      this.labelArgumentText.Name = "labelArgumentText";
      this.labelArgumentText.Size = new System.Drawing.Size(87, 13);
      this.labelArgumentText.TabIndex = 10;
      this.labelArgumentText.Text = "Form border style";
      this.labelArgumentText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // textArgumentText
      // 
      this.textArgumentText.Location = new System.Drawing.Point(120, 170);
      this.textArgumentText.Name = "textArgumentText";
      this.textArgumentText.Size = new System.Drawing.Size(121, 20);
      this.textArgumentText.TabIndex = 11;
      // 
      // labelResultValue
      // 
      this.labelResultValue.AutoSize = true;
      this.labelResultValue.Location = new System.Drawing.Point(116, 217);
      this.labelResultValue.Name = "labelResultValue";
      this.labelResultValue.Size = new System.Drawing.Size(43, 13);
      this.labelResultValue.TabIndex = 12;
      this.labelResultValue.Text = "<none>";
      // 
      // labelTitle
      // 
      this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
      this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      this.labelTitle.Location = new System.Drawing.Point(0, 0);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(253, 58);
      this.labelTitle.TabIndex = 13;
      this.labelTitle.Text = "Background Operations\r\nManaging Sample";
      this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(253, 279);
      this.Controls.Add(this.labelTitle);
      this.Controls.Add(this.labelResultValue);
      this.Controls.Add(this.textArgumentText);
      this.Controls.Add(this.labelArgumentText);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.labelSupportCancellation);
      this.Controls.Add(this.labelReportProgress);
      this.Controls.Add(this.labelCloseOnComplete);
      this.Controls.Add(this.comboSupportCancellation);
      this.Controls.Add(this.comboReportProgress);
      this.Controls.Add(this.comboCloseOnComplete);
      this.Controls.Add(this.buttonStart);
      this.Name = "FormMain";
      this.Text = "SimpleDialogWF";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonStart;
    private System.Windows.Forms.ComboBox comboCloseOnComplete;
    private System.Windows.Forms.ComboBox comboReportProgress;
    private System.Windows.Forms.ComboBox comboSupportCancellation;
    private System.Windows.Forms.Label labelCloseOnComplete;
    private System.Windows.Forms.Label labelReportProgress;
    private System.Windows.Forms.Label labelSupportCancellation;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Label labelArgumentText;
    private System.Windows.Forms.TextBox textArgumentText;
    private System.Windows.Forms.Label labelResultValue;
    private System.Windows.Forms.Label labelTitle;
  }
}

