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
using System.Drawing;
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
      statusStripLabelHelp.Visible = true;
      toolStripProgressBar.Visible = toolStripLabelProgress.Visible = true;
      toolStripProgressBar.Style = (notifable) ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;

      // add opertion result to listview
      var item = new ListViewItem("Operation A");
      item.Group = listView.Groups["groupRunning"];
      item.ForeColor = Color.Blue;
      item.SubItems.Add("Running");
      listView.Items.Add(item);

      // run operation in background mode
      var args = DoWorkEmbeddedHelper.Show(LongOperation, "Hello, world!",
        notifable, abortable, this, toolStripProgressBar.ProgressBar, toolStripLabelProgress);

      // update opertion result
      item.Group = listView.Groups[(args.Cancelled) ? "groupCanceled" : "groupFinished"];
      item.ForeColor = (args.Cancelled) ? Color.Red : Color.Green;
      item.SubItems[1].Text = (args.Cancelled) ? "Cancelled" : "Finished";
      item.SubItems.Add((args.Cancelled) ? string.Empty : (string)args.Result);

      // restore controls state
      toolStripProgressBar.Visible = toolStripLabelProgress.Visible = false;
      statusStripLabelHelp.Visible = false;
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
      statusStripLabelHelp.Visible = true;
      statusStripProgressBar.Visible = statusStripLabelProgress.Visible = true;
      statusStripProgressBar.Style = (notifable) ? ProgressBarStyle.Blocks : ProgressBarStyle.Marquee;

      // add opertion result to listview
      var item = new ListViewItem("Operation B");
      item.Group = listView.Groups["groupRunning"];
      item.ForeColor = Color.Blue;
      item.SubItems.Add("Running");      
      listView.Items.Add(item);

      // run operation in background mode
      var args = DoWorkEmbeddedHelper.Show(LongOperation,"Hello, world!",
        notifable, abortable, this, statusStripProgressBar.ProgressBar, statusStripLabelProgress);

      // update opertion result
      item.Group = listView.Groups[(args.Cancelled) ? "groupCanceled" : "groupFinished"];
      item.ForeColor = (args.Cancelled) ? Color.Red : Color.Green;
      item.SubItems[1].Text = (args.Cancelled) ? "Cancelled" : "Finished";
      item.SubItems.Add((args.Cancelled) ? string.Empty : (string)args.Result);

      // restore controls state
      statusStripProgressBar.Visible = statusStripLabelProgress.Visible = false;
      statusStripLabelHelp.Visible = false;
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

    // process menu close command
    private void OnExit(object sender, EventArgs e)
    {
      Close();
    }

    // save settings after form closed event
    private void OnFormClosed(object sender, FormClosedEventArgs e)
    {
      var settings = Properties.Settings.Default;
      settings.OperationA_Abortable = menuItemOptions_AbortableA.Checked;
      settings.OperationA_Notifable = menuItemOptions_NotifableA.Checked;
      settings.OperationB_Abortable = menuItemOptions_AbortableB.Checked;
      settings.OperationB_Notifable = menuItemOptions_NotifableB.Checked;
      settings.Save();
    }
  }
}
