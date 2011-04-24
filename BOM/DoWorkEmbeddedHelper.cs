/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.21
 *
 * DoWorkEmbeddedHelper - background operation management helper-primitive with controls embedded in main window (Windows.Forms)
 *****************************************************************************/
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement
{
  /// <summary>
  /// Background operation management with controls embedded in main window
  /// </summary>
  public class DoWorkEmbeddedHelper
  {
    public static RunWorkerCompletedEventArgs Show(DoWorkEventHandler work,
      object argument, bool notifable, bool abortable, Form window)
    {
      return Show(work, argument, notifable, abortable, window, null, null);
    }

    public static RunWorkerCompletedEventArgs Show(
      DoWorkEventHandler work, object argument, bool notifable, bool abortable,
      Form window, ProgressBar progressbar, ToolStripLabel statuslabel)
    {
      var result = (RunWorkerCompletedEventArgs)null;
      var worker = new BackgroundWorker();
      worker.WorkerReportsProgress = notifable;
      worker.WorkerSupportsCancellation = abortable;
      worker.DoWork += work;

      // background operation completed event handler
      worker.RunWorkerCompleted += (ss, ee) =>
      {
        result = ee;
      };

      // background operation progress report event handler
      if (worker.WorkerReportsProgress)
      {
        worker.ProgressChanged += (ss, ee) =>
        {
          if (progressbar != null)
            progressbar.Value = ee.ProgressPercentage;
          if (statuslabel != null)
            statuslabel.Text = (ee.UserState as string) ?? statuslabel.Text;
        };
      }

      // formclosing event handler - prevent form closing and cancel operation if cancellable
      FormClosingEventHandler formclosing = (ss, ee) =>
      {
        if (ee.Cancel = true && worker.WorkerSupportsCancellation)
          worker.CancelAsync();
      };

      // keydown event handler - if you want to cancel operatin with
      // escape key pressed ensure form KeyPreview property is true
      KeyEventHandler formkeydown = (ss, ee) =>
      {
        if (ee.KeyCode == Keys.Escape && worker.WorkerSupportsCancellation)
            worker.CancelAsync();
      };

      // attaching form event handlers
      window.FormClosing += formclosing;
      window.KeyDown += formkeydown;
      
      // run background operation asyncronously
      worker.RunWorkerAsync(argument);

      // while background operation active hold thread and process windows messages in message loop
      while (worker.IsBusy)
      {
        Application.DoEvents();
        Thread.Sleep(10);
      }

      // detaching form event handlers
      window.KeyDown -= formkeydown;
      window.FormClosing -= formclosing;
      return result;
    }
  }

  interface IProgressListener
  {
    void ProgressChanged(BackgroundWorker worker, ProgressChangedEventArgs args);
  }

  class ProgressBarProgressListener : IProgressListener
  {
    public ProgressBar Control { get; set; }

    public virtual void ProgressChanged(BackgroundWorker worker, ProgressChangedEventArgs args)
    {
      Control.Value = args.ProgressPercentage;
    }
  }

  class LabelProgressListener : IProgressListener
  {
    public Label Control { get; set; }

    public virtual void ProgressChanged(BackgroundWorker worker, ProgressChangedEventArgs args)
    {
      Control.Text = (args.UserState as string) ?? Control.Text;
    }  
  }
}
