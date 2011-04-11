/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.09
 *
 * SimpleDialogWF - Windows.Forms simple version of background operation management dialog
 * Delay - Background thread delay helper
 *****************************************************************************/

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement
{
  /// <summary>
  /// Windows.Forms simple version of background operation management dialog
  /// </summary>
  public partial class SimpleDialog : Form
  {
    // background operation argument
    public object m_workarg;

    // automatically close dialog on background operation completing
    public bool m_autoclose;
    
    // aborted state of background operation
    public bool m_isaborted;
    
    // background worker object
    public BackgroundWorker m_worker;

    /// <summary>
    /// Background operation completed event arguments
    /// </summary>
    public RunWorkerCompletedEventArgs CompletedEventArgs { get; private set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public SimpleDialog(
      string caption, string title, bool autoclose, BackgroundWorker worker,
      object argument)
    {
      InitializeComponent();

      Text = caption;
      m_autoclose = autoclose;
      m_worker = worker;
      m_workarg = argument;
      
      ControlBox = m_worker.WorkerSupportsCancellation;
      labelTitle.Text = title;

      // background operation completed event handler
      m_worker.RunWorkerCompleted += (ss, ee) =>
      {
        CompletedEventArgs = ee;
        ControlBox = true;
        if (m_autoclose)
          Close();
      };

      // background operation progress report event handler
      if (m_worker.WorkerReportsProgress)
      {
        progressBar.Style = ProgressBarStyle.Blocks;
        m_worker.ProgressChanged += (ss, ee) =>
        {
          progressBar.Value = ee.ProgressPercentage;
          string newtitle = ee.UserState as string;
          labelTitle.Text = newtitle ?? labelTitle.Text;
        };
      }      
    }

    /// <summary>
    /// Dialog shown event handler
    /// </summary>
    private void DialogBackgroundWork_Shown(object sender, EventArgs e)
    {
      m_worker.RunWorkerAsync(m_workarg);
    }

    /// <summary>
    /// Dialog form closing event handler
    /// </summary>
    private void DialogBackgroundWork_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.Cancel = m_worker.IsBusy)
      {
        if (m_isaborted = m_worker.WorkerSupportsCancellation)
        {
          m_worker.CancelAsync();
        }
      }
      else DialogResult = (m_isaborted) ? DialogResult.Abort : DialogResult.OK;
    }

    /// <summary>
    /// Dialog key down event handler
    /// </summary>
    private void DialogBackgroundWork_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape)
      {
        if (m_worker.IsBusy)
        {
          if (m_worker.WorkerSupportsCancellation)
            m_worker.CancelAsync();
        }
        else Close();
      }      
    }

    /// <summary>
    /// Create background worker, initialize dialog and start background operation
    /// </summary>
    public static RunWorkerCompletedEventArgs Show(
      string caption, string title, bool autoclose,
      DoWorkEventHandler work, object argument, bool notifable, bool cancellable)
    {
      var worker = new BackgroundWorker();
      worker.WorkerReportsProgress = notifable;
      worker.WorkerSupportsCancellation = cancellable;
      worker.DoWork += work;

      return Show(caption, title, autoclose, worker, argument);
    }

    /// <summary>
    /// Initialize dialog and start background operation
    /// </summary>
    public static RunWorkerCompletedEventArgs Show(
      string caption, string title, bool autoclose,
      BackgroundWorker worker, object argument)
    {
      var dialog = new SimpleDialog(caption, title, autoclose, worker, argument);
      dialog.ShowDialog();
      return dialog.CompletedEventArgs;
    }
  }

  /// <summary>
  /// Thread delay helper
  /// </summary>
  public sealed class Delay
  {
    /// <summary>
    /// Origin of the delay period
    /// </summary>
    private DateTime Origin { get; set; }

    /// <summary>
    /// Method return control when specified period from the origin passed
    /// </summary>
    public void WaitRest(int days, int hours, int minutes, int seconds, int milliseconds)
    {
      TimeSpan term = new TimeSpan(days, hours, minutes, seconds, milliseconds);
      TimeSpan rest = term - (DateTime.Now - Origin);
      if (rest.TotalMilliseconds > 0)
        Thread.Sleep(rest);
    }

    /// <summary>
    /// Return new delay with origin initialized from current moment
    /// </summary>
    public static Delay FromNow()
    {
      return new Delay() { Origin = DateTime.Now };
    }
  }
}
