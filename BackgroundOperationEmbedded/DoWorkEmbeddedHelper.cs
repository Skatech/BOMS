/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.13
 *
 * DoWorkEmbeddedHelper - Windows.Forms background operation management with controls embedded in main window
 *****************************************************************************/

using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement
{  
  /// <summary>
  /// Background operation management with controls embedded in main window
  /// </summary>
  class DoWorkEmbeddedHelper
  {
    public static RunWorkerCompletedEventArgs Show(
      DoWorkEventHandler work, object argument, bool notifable, bool cancellable, ProgressBar progressbar, ToolStripLabel statuslabel)
    {
      var result = (RunWorkerCompletedEventArgs)null;
      var worker = new BackgroundWorker();
      worker.WorkerReportsProgress = notifable;
      worker.WorkerSupportsCancellation = cancellable;
      worker.DoWork += work;

      // background operation completed event handler
      worker.RunWorkerCompleted += (ss, ee) =>
      {
        result = ee;
      };

      // background operation progress report event handler
      if (worker.WorkerReportsProgress)
      {
        progressbar.Style = ProgressBarStyle.Blocks;
        worker.ProgressChanged += (ss, ee) =>
        {
          progressbar.Value = ee.ProgressPercentage;          
          string newtitle = ee.UserState as string;
          statuslabel.Text = newtitle ?? statuslabel.Text;
        };
      }

      FormClosingEventHandler formclosing = (ss, ee) =>
      {
        if (ee.Cancel = true && worker.WorkerSupportsCancellation)
          worker.CancelAsync();
      };

      KeyEventHandler formkeydown = (ss, ee) =>
      {
        if (ee.KeyCode == Keys.Escape && worker.WorkerSupportsCancellation)
            worker.CancelAsync();
      };

      progressbar.FindForm().FormClosing += formclosing;
      progressbar.FindForm().ActiveControl.KeyDown += formkeydown;

      worker.RunWorkerAsync(argument);

      while (worker.IsBusy)
      {
        Application.DoEvents();
        Thread.Sleep(10);
      }

      progressbar.FindForm().ActiveControl.KeyDown -= formkeydown;
      progressbar.FindForm().FormClosing -= formclosing;
      return result;
    }
  }
}
