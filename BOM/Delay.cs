/******************************************************************************
 * (С) Skatech Research Lab, 2000-2011
 * Last change: 2011.04.16
 *
 * Delay - thread delay helper
 *****************************************************************************/

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Skatech.Auxiliary.Dialogs.BackgroundOperationsManagement
{
  /// <summary>
  /// Thread delay helper
  /// </summary>
  public sealed class Delay
  {
    /// <summary>
    /// Origin of the delay period
    /// </summary>
    public DateTime Origin { get; private set; }

    /// <summary>
    /// Method suspend calling thread and return control after
    /// specified period from the origin passed or worker cancelled
    /// </summary>
    public bool WaitRest(int milliseconds, BackgroundWorker worker)
    {
      while (worker == null || !worker.CancellationPending)
      {
        int msecelapsed = Convert.ToInt32((DateTime.Now - Origin).TotalMilliseconds);
        if (msecelapsed < milliseconds)
        {
          Thread.Sleep(Math.Min(10, milliseconds - msecelapsed));
        }
        else break;      
      }
      return (worker == null) ? false : worker.CancellationPending;
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
