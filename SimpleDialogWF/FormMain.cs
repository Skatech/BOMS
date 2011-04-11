/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.09
 *
 * Background operations managing samples
 *****************************************************************************/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement;

namespace BackgroundOperationsManagingSamples
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();

      // setup bindings
      comboCloseOnComplete.DataBindings.Add(new Binding("SelectedIndex", Properties.Settings.Default, "CloseOnComplete"));
      comboReportProgress.DataBindings.Add(new Binding("SelectedIndex", Properties.Settings.Default, "ReportProgress"));
      comboSupportCancellation.DataBindings.Add(new Binding("SelectedIndex", Properties.Settings.Default, "SupportCancellation"));
      textArgumentText.DataBindings.Add(new Binding("Text", Properties.Settings.Default, "ArgumentText"));
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    private void buttonStart_Click(object sender, EventArgs e)
    {
      DoWorkEventHandler work = (wsender, wargs) =>
      {
        // arbitrary object passed by caller as argument
        var argument = (string)wargs.Argument;
        var worker = (BackgroundWorker)wsender;

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
            worker.ReportProgress(result.Length * 100 / argument.Length);
          }
          
          // adds char from argument to result one by one
          result += chr;

          // demonstration delay (remove in real project)
          Thread.Sleep(50);
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
        wargs.Cancel = worker.CancellationPending;
        // returning to caller background operation result
        wargs.Result = result;
      };

      // close status dialog when operation finished
      bool autoclose = (comboCloseOnComplete.SelectedIndex == 1);
      // operation notify progress and status
      bool notifable = (comboReportProgress.SelectedIndex == 1);
      // operation cancellable (press esc, or close dialog to cancel)
      bool cancellable = (comboSupportCancellation.SelectedIndex == 1);
      // object passing to operation as argument
      object userarg = textArgumentText.Text;

      // this call initialize background worker and operation status dialog then start operation
      RunWorkerCompletedEventArgs operation = SimpleDialog.Show(
        "Please be patient", "Processing reports...",
        autoclose, work, userarg, notifable, cancellable);

      // how to using background operation cancelled state and result object
      labelResultValue.ForeColor = (operation.Cancelled) ? Color.Red : Color.Green;
      labelResultValue.Text = (operation.Cancelled) ? "Operation cancelled" : (string)operation.Result;
    }
  }
}
