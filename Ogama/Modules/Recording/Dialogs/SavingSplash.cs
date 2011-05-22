// <copyright file="SavingSplash.cs" company="FU Berlin">
// ******************************************************
// OGAMA - open gaze and mouse analyzer 
// Copyright (C) 2010 Adrian Vo�k�hler  
// ------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
// You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// **************************************************************
// </copyright>
// <author>Adrian Vo�k�hler</author>
// <email>adrian.vosskuehler@fu-berlin.de</email>

namespace Ogama.Modules.Recording
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Reflection;
  using System.Text;
  using System.Windows.Forms;

  /// <summary>
  /// Splash <see cref="Form"/> with animated gif and marquee progress bar.
  /// Is invoked from <see cref="RecordModule"/>, when recording is saved.
  /// Informs the user, that database saving and fixation calculation is going on.
  /// </summary>
  public partial class SavingSplash : Form
  {
    ///////////////////////////////////////////////////////////////////////////////
    // Defining Constants                                                        //
    ///////////////////////////////////////////////////////////////////////////////
    #region CONSTANTS
    #endregion //CONSTANTS

    ///////////////////////////////////////////////////////////////////////////////
    // Defining Variables, Enumerations, Events                                  //
    ///////////////////////////////////////////////////////////////////////////////
    #region FIELDS

    /// <summary>
    /// Backgroundworker that indicates saving process 
    /// </summary>
    private BackgroundWorker worker;

    #endregion //FIELDS

    ///////////////////////////////////////////////////////////////////////////////
    // Construction and Initializing methods                                     //
    ///////////////////////////////////////////////////////////////////////////////
    #region CONSTRUCTION

    /// <summary>
    /// Initializes a new instance of the SavingSplash class.
    /// </summary>
    public SavingSplash()
    {
      this.InitializeComponent();
    }

    #endregion //CONSTRUCTION

    ///////////////////////////////////////////////////////////////////////////////
    // Defining Properties                                                       //
    ///////////////////////////////////////////////////////////////////////////////
    #region PROPERTIES

    /// <summary>
    /// Sets the dialogs description.
    /// </summary>
    public string Description
    {
      set { this.dialogTop1.Description = value; }
    }

    /// <summary>
    /// Sets the value of the progress bar.
    /// </summary>
    public int Progress
    {
      set { this.progressBar1.Value = value; }
    }

    /// <summary>
    /// Sets the <see cref="BackgroundWorker"/>. 
    /// When this background worker is cancelled the
    /// splash form will close itself.
    /// </summary>
    /// <value>A <see cref="BackgroundWorker"/> which process should be revisited.</value>
    public BackgroundWorker Worker
    {
      set { this.worker = value; }
    }

    /// <summary>
    /// Sets the style of the progress bar.
    /// </summary>
    public ProgressBarStyle ProgressStyle
    {
      set { this.progressBar1.Style = value; }
    }

    #endregion //PROPERTIES

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler                                                              //
    ///////////////////////////////////////////////////////////////////////////////
    #region EVENTS

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler for UI, Menu, Buttons, Toolbars etc.                         //
    ///////////////////////////////////////////////////////////////////////////////
    #region WINDOWSEVENTHANDLER

    /// <summary>
    /// Starts timer on loading. Timer tick is set in Designer.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">An empty <see cref="EventArgs"/></param>
    private void SavingSplash_Load(object sender, EventArgs e)
    {
      this.updateTimer.Start();
    }

    /// <summary>
    /// The <see cref="Timer.Tick"/> event handler for the
    /// <see cref="Timer"/> <see cref="updateTimer"/>.
    /// Checks for backgroundworker cancellation.
    /// If is set, loading is completed, so close this form.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">An empty <see cref="EventArgs"/></param>
    private void updateTimer_Tick(object sender, EventArgs e)
    {
      if (this.worker.CancellationPending)
      {
        this.updateTimer.Stop();
        this.Close();
      }
    }

    #endregion //WINDOWSEVENTHANDLER

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler for Custom Defined Events                                    //
    ///////////////////////////////////////////////////////////////////////////////
    #region CUSTOMEVENTHANDLER
    #endregion //CUSTOMEVENTHANDLER

    #endregion //EVENTS

    ///////////////////////////////////////////////////////////////////////////////
    // Methods and Eventhandling for Background tasks                            //
    ///////////////////////////////////////////////////////////////////////////////
    #region BACKGROUNDWORKER
    #endregion //BACKGROUNDWORKER

    ///////////////////////////////////////////////////////////////////////////////
    // Inherited methods                                                         //
    ///////////////////////////////////////////////////////////////////////////////
    #region OVERRIDES
    #endregion //OVERRIDES

    ///////////////////////////////////////////////////////////////////////////////
    // Methods for doing main class job                                          //
    ///////////////////////////////////////////////////////////////////////////////
    #region METHODS
    #endregion //METHODS

    ///////////////////////////////////////////////////////////////////////////////
    // Small helping Methods                                                     //
    ///////////////////////////////////////////////////////////////////////////////
    #region HELPER
    #endregion //HELPER
  }
}