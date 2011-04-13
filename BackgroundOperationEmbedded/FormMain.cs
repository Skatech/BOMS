﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement;

namespace BackgroundOperationEmbedded
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void StartLongOperationCaseA(object sender, EventArgs e)
    {
      SwitchMenuStrips(false);
      toolStripProgressBar.Visible = toolStripProgressLabel.Visible = true;

      var args = DoWorkEmbeddedHelper.Show(LongOperation, "Hello, world!", true, true, toolStripProgressBar.ProgressBar, toolStripProgressLabel);

      ListViewItem item = new ListViewItem(args.Cancelled ? "Cancelled" : "Finished");
      item.SubItems.Add(args.Cancelled ? string.Empty : (string)args.Result);
      listView.Items.Add(item);

      toolStripProgressBar.Visible = toolStripProgressLabel.Visible = false;
      SwitchMenuStrips(true);
    }

    private void StartLongOperationCaseB(object sender, EventArgs e)
    {
      SwitchMenuStrips(false);
      statusStripProgressBar.Visible = statusStripLabelResult.Visible = true;

      var args = DoWorkEmbeddedHelper.Show(LongOperation, "Hello, world!", true, true, statusStripProgressBar.ProgressBar, statusStripLabelResult);
      
      ListViewItem item = new ListViewItem(args.Cancelled ? "Cancelled" : "Finished");
      item.SubItems.Add(args.Cancelled ? string.Empty : (string)args.Result);
      listView.Items.Add(item);

      statusStripProgressBar.Visible = statusStripLabelResult.Visible = false;
      SwitchMenuStrips(true);
    }

    private void SwitchMenuStrips(bool enabled)
    {
      toolStrip.Enabled = enabled;
      menuStrip.Enabled = enabled;
    }

    private void LongOperation(object sender, DoWorkEventArgs args)
    {
      // arbitrary object passed by caller as argument
      var argument = (string)args.Argument;
      var worker = (BackgroundWorker)sender;

      // main background operation cycle sample (replace with your code)
      string result = string.Empty;
      foreach (char chr in argument)
      {
        // background operation cancellation block (remove if your operation non calcellable)
        if (worker.WorkerSupportsCancellation && worker.CancellationPending)
        {
          break;
        }
        // background operation report progress block (remove if your operation non notifable)
        if (worker.WorkerReportsProgress)
        {
          worker.ReportProgress(result.Length * 100 / argument.Length, "Processing data...");
        }

        // adds char from argument to result one by one
        result += chr;

        // demonstration delay (remove in real project)
        Thread.Sleep(250);
      }

      // after operation complete report progress and operation state (remove if your operation non notifable)
      if (worker.WorkerReportsProgress)
      {
        if (worker.CancellationPending)
        {
          worker.ReportProgress(0, "Processing cancelled");
        }
        else
        {
          worker.ReportProgress(100, "Processing finished");
        }
      }
      // delay before dialog was closed when enabled autoclose mode
      Thread.Sleep(500);

      // returning to caller background operation cancelled state
      args.Cancel = worker.CancellationPending;
      // returning to caller background operation result
      args.Result = result;
    }

    private void menuItemFile_Exit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
