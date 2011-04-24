/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.21
 *
 * Sample of background operation handling with  with controls embedded in form (Windows.Forms version)
 *****************************************************************************/

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement;

namespace Skatech.Tests.TestEmbedded
{
  // Main form of application
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    // This method start async operation with using toolbar controls
    private void StartLongOperationCaseA(object sender, EventArgs e)
    {
      // get background operation executing mode
      bool abortable = menuItemOptions_AbortableA.Checked;
      bool notifable = menuItemOptions_NotifableA.Checked;

      // prepare main form controls
      toolStrip.Enabled = menuStrip.Enabled = false;
      toolStripProgressBar.Visible = toolStripLabelProgress.Visible = true;
      toolStripProgressBar.Style = (notifable) ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;

      // run operation in background mode
      var args = DoWorkEmbeddedHelper.Show(LongOperation, "Hello, world!",
        notifable, abortable, this, toolStripProgressBar.ProgressBar, toolStripLabelProgress);

      // add opertion result to listview
      var item = new ListViewItem(args.Cancelled ? "Cancelled" : "Finished");
      item.SubItems.Add(args.Cancelled ? string.Empty : (string)args.Result);
      listView.Items.Add(item);

      // restore controls state
      toolStripProgressBar.Visible = toolStripLabelProgress.Visible = false;
      toolStrip.Enabled = menuStrip.Enabled = true;
    }

    // This method start async operation with using statusbar controls
    private void StartLongOperationCaseB(object sender, EventArgs e)
    {
      // get background operation executing mode
      bool abortable = menuItemOptions_AbortableB.Checked;
      bool notifable = menuItemOptions_NotifableB.Checked;

      // prepare main form controls
      toolStrip.Enabled = menuStrip.Enabled = false;
      statusStripProgressBar.Visible = statusStripLabelProgress.Visible = true;
      statusStripProgressBar.Style = (notifable) ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;

      // run operation in background mode
      var args = DoWorkEmbeddedHelper.Show(LongOperation,"Hello, world!",
        notifable, abortable, this, statusStripProgressBar.ProgressBar, statusStripLabelProgress);

      // add opertion result to listview
      var item = new ListViewItem(args.Cancelled ? "Cancelled" : "Finished");
      item.SubItems.Add(args.Cancelled ? string.Empty : (string)args.Result);
      listView.Items.Add(item);

      // restore controls state
      statusStripProgressBar.Visible = statusStripLabelProgress.Visible = false;
      toolStrip.Enabled = menuStrip.Enabled = true;
    }

    // This method represent long operation you want to run in background mode
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
