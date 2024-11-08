// Copyright (c) 2024 Bentley Systems, Incorporated. All rights reserved.
using GeoEngine.Core.GXNet;
using Geosoft.GX.Controls;
using System;
using System.Windows.Forms;

// Please retain the following line to make future critical updates to GXs based on old templates easier
// CREATED FROM: Geosoft Simple GX Template version 7.0.0

// README FIRST!
//
// TODO: Search for all the occurances of "TODO:" below and follow the instructions to get
//       your GX up and running quickly. You can delete the TODOs as you complete/read them
//       to clean up the source.
//
//       Once you are familiar enough with the workflow of GX creation you can make a new form
//       from this template, cut out all the TODO: comments you want and make your own streamlined
//       template using the File->Export Template... menu option in Visual Studio.

// TODO: Chooses a namespace to use below. For instance:
//       Geosoft prefixes all their GX .Net GXs' namespaces with
//       Geosoft.GX.... followed by a functional grouping.
namespace EmptySampleTemplates
{
   // TODO: 1. Describe your new class below in the summary. You can add extra notes about the class in the remarks section.
   //
   //       2. Now may also be a good oppurtunity to set the following properties in the designer:
   //
   //             HelpTopicID:      If used or set the HelpButton property to false to not display the
   //                               button in the titlebar.
   //
   //
   //       3. Add GX Controls and any other needed Windows forms controls from the toolbox to the form sizing
   //          and positioning everything as needed. Give each control a funtional name indicating that it is a
   //          member of the form and what kind of control it is (e.g. m_cmbAssayList for a combobox containing a
   //          list of assay options). This makes for readable and maintainable code.
   //
   //       4. For every GX Control added define an entry in the INI component.
   //          Document any scripting parameters in the XML documentation below, e.g.:
   //
   //          /// <scriptparam group="GXPARAMGROUP" name="GXPARAM">This parameter is the example parameter.</scriptparam>
   //
   /// <summary>
   ///
   /// </summary>

   // Language attribute should match what this GX does (ie. NewGDB's attribute is [Translation("core", "GX/Database")])
   [Translation("core", "GX/Sample")]
   public partial class GX1 : BaseForm
   {
      // TODO: The code in this region can generally be left alone unless you needed to do special
      //       management and cleanup of resources.

      #region Constructors/Destructors

      /// <summary>
      /// Default constructor
      /// </summary>
      /// <remarks>
      /// Use this constructor for instantiating this class from within other GX .Net based forms
      /// </remarks>
      public GX1()
      : base()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();
         TranslateControls();
      }

      /// <summary>
      /// Constructor with GX handle
      /// </summary>
      /// <param name="iGeo">Geosoft handle from montaj with which to initialize the BaseForm</param>
      /// <remarks>
      /// This constructor will be used if this GX is instantiated from within montaj (e.g. a menu entry)
      /// </remarks>
      public GX1(IntPtr pGeo)
            : base(pGeo)
      {
         InitializeComponent();
         TranslateControls();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         // TODO: If any resources are used which may need cleanup at the end of GX execution this is the place to
         //       clean it up. This can include locked GX objects, files, child forms etc. For example:
         //
         // if (m_dlgPreview != null)
         //    m_dlgPreview.Dispose();
         // m_dlgPreview = null;
         //
         // if (m_strTempFile.Length > 0 && File.Exists(m_strTempFile))
         //    File.Delete(m_strTempFile);

         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #endregion Constructors/Destructors

      // TODO: The overrided methods in the region below does any extra work needed during the various
      //       parts of the GX flow (initialization, validation etc.) which cannot be provided by the controls
      //       alone. Some controls will validate themselves without having to add any extra code here and where
      //       possible that functionality should be used without having to add any code here (e.g. the Required
      //       property, or the MaximumValue on the EditIntControl).
      //
      // NOTE: Do not use a message box in these overrides if you intend to use the GX in the non-interactive
      //       scripting environment. The use of ShowErrorAndExit, CSYS.DisplayMessage etc. are preferred.

      #region BaseForm Overrides

      /// <summary>
      /// Override to do extra initialization (combobox lst init etc.)
      /// </summary>
      /// <remarks>The derived class should call this function in the appropriate place</remarks>
      protected override void InitializeForm()
      {
         StartGrowFormDuringTranslation();
         TranslateControls();
         base.InitializeForm();

         // TODO: If needed add extra initialization/pre-validation here, for example:
         //
         //
         // CEDB hEDB = null;
         // CDB hDB = null;
         // try
         // {
         //    hEDB = CEDB.Current();
         //    hDB = hEDB.Lock();
         //    CLST hChanLST = CLST.Create(128);
         //    hDB.ArrayLST(hChanLST);
         //
         //    if (hChanLST.iSize() < 2)
         //       ShowErrorAndExit(_("At least two array channels are required."));
         //    m_cmbData.Init(hChanLST, GeoEngine.Core.GXNet.Constant.LST_ITEM_NAME);
         // }
         // finally
         // {
         //    if (hDB == null)
         //       hEDB.UnLock();
         // }

         EndGrowFormDuringTranslation();
      }

      /// <summary>
      /// Override to do extra validation
      /// </summary>
      /// <param name="strINIError">
      /// </param>
      /// <param name="bUseErrorProvider">
      /// </param>
      /// <returns>true if validation is successful</returns>
      public override bool bValidateDialog(ref string strINIError, bool bUseErrorProvider)
      {
         bool bValid = true;

         // Do base dialog validation first (this will validate all controls based on their properties first)

         if (!base.bValidateDialog(ref strINIError, bUseErrorProvider))
            bValid = false;

         if (bValid)
         {
            // TODO: Add any more complex validation logic here. Not that 3 things need to happen for validation failures:
            //
            //       1. bValid should be set to false.
            //       2. Create a string describing the problem and if the bUseErrorProvider parameter is true set this
            //          error and the control in question to the base class' ControlErrorProvider.SetError method.
            //       3. Append an error string to the strINIError string parameter decribing the problem. The convenient
            //          FormatINIErrorString of the GX Controls may be used if the problem lies in a specific control,
            //          This ensures logical errors are reported during scripting of GXs.
            //
            //       For Example:
            //
            //
            // int iNGrids = m_EditNumGrids.iGetValue();
            // double dStartElev = m_EditStartElev.dGetValue();
            // double dElevInc = m_EditElevInc.dGetValue();
            //
            // if (iNGrids != GeoEngine.Core.GXNet.Constant.iDUMMY && dStartElev == GeoEngine.Core.GXNet.Constant.rDUMMY)
            // {
            //    bValid = false;
            //    strError = "The starting elevation must be defined if the number of grids is defined.";
            //    if (bUseErrorProvider)
            //       this.ControlErrorProvider.SetError(m_EditStartElev, strError);
            //    strINIError += m_EditStartElev.FormatINIErrorString(strError);
            // }
            // if (iNGrids > 1 && dElevInc == GeoEngine.Core.GXNet.Constant.rDUMMY)
            // {
            //    bValid = false;
            //    strError = "The elevation increment must be defined if the number of grids is defined and is greater 1.";
            //    if (bUseErrorProvider)
            //       this.ControlErrorProvider.SetError(m_EditElevInc, strError);
            //    strINIError += m_EditElevInc.FormatINIErrorString(strError);
            // }
            // else if (dElevInc == 0.0 && iNGrids > 1)
            // {
            //    bValid = false;
            //    strError = "The elevation increment must not be zero if the number of grids is defined and is greater 1.";
            //    if (bUseErrorProvider)
            //       this.ControlErrorProvider.SetError(m_EditElevInc, strError);
            //    strINIError += m_EditElevInc.FormatINIErrorString(strError);
            // }
         }
         return bValid;
      }

      #endregion BaseForm Overrides

      // TODO: This region contains the first method called by montaj after instantiating the GX.
      //       In general the code inside may be left as is.

      #region Entry Point Method

      /// <summary>
      /// Run the GX.
      /// </summary>
      [CGXAttribute("")]
      public int Run()
      {
         DialogResult Result = DialogResult.OK;

         try
         {
            // Initialize the form
            InitializeForm();

            // Are we running interactively?

            if (CSYS.iInteractive() != 0)
               Result = this.ShowDialog();
            else
               ini.RefreshControls();
         }
         catch (ApplicationException e)
         {
            // An empty message indicates a CSYS.Cancel()
            if (e.Message.Length > 0)
               ShowErrorAndExit(e.Message);
            else
               Result = DialogResult.Cancel;
         }
         catch (Exception e)
         {
            ShowErrorAndExit(CreateGXFailureMessage(e.Message));
         }

         if (Result == DialogResult.OK)
         {
            try
            {
               Execute();
               return 0;
            }
            catch (Exception e)
            {
               // An empty message indicates a cancel
               if (e.Message.Length > 0)
                  ShowErrorAndExit(e.Message);
            }
         }
         else
            return 2;

         return 1;
      }

      #endregion Entry Point Method

      // TODO: This is where the processing happens in the GX and is probably where most of the real coding
      //       will happen. Some sample code below with comments may help you along here.

      #region Execute Method

      private void Execute()
      {
         // Always validate using this call first
         string strError = String.Empty;
         if (!bValidateDialog(ref strError, false))
            ShowErrorAndExit(strError);

         // TODO: Get the control values. The GX Controls internals would have already initialized
         //       any controls and validation in the internals and overrides above would have already
         //       taken place ath this point so in most case no further validation is needed.
         //       For example:

         // string strOption = String.Empty;
         // double dScale;
         //
         // dScale = m_RealScale.dGetValue();
         // ...
         //

         // TODO: In some cases GXs behave differently in non-interactive modes and extra options can be passed,
         //       the code below is an example of how the getting of the values and validation should be handled in this case.
         //       For example:

         // if (CSYS.iInteractive() == 0)
         // {
         //    CSYS.GtString("GXPARAMGROUP", "NONINTERACTIVEOPTION", ref strOption);
         //
         //    // Validate
         //
         //    if (strOtion.Length == 0) ShowErrorAndExit(_("ArcGIS LYR file name not specified"));
         // }
         //

         // TODO: Do the work, cleaning up any resources used (try/finally).
         //       For example:

         // CEDB hEDB = null;
         // CDB hDB = null;
         // int iXCh = GeoEngine.Core.GXNet.Constant.NULLSYMB;
         // int iYCh = GeoEngine.Core.GXNet.Constant.NULLSYMB;
         try
         {
            // hEDB = CEDB.Current();
            // hDB = hEDB.Lock();
            //
            // if (strOption.Length > 0)
            // {
            //    ...
            // }
            //
            // // Get and lock the X and Y channels
            // int iXCh = hDB.GetXYZChanSymb(GeoEngine.Core.GXNet.Constant.DB_CHAN_X);
            // int iYCh = hDB.GetXYZChanSymb(GeoEngine.Core.GXNet.Constant.DB_CHAN_Y);
            // if(iXCh == GeoEngine.Core.GXNet.Constant.NULLSYMB)
            //    ShowErrorAndExit(_("The current X channel was not found in the current database."));
            // if(iYCh == GeoEngine.Core.GXNet.Constant.NULLSYMB)
            //    ShowErrorAndExit(_("The current Y channel was not found in the current database."));
            // hDB.LockSymb(iXCh, GeoEngine.Core.GXNet.Constant.DB_LOCK_READONLY, GeoEngine.Core.GXNet.Constant.DB_WAIT_INFINITY);
            // hDB.LockSymb(iYCh, GeoEngine.Core.GXNet.Constant.DB_LOCK_READONLY, GeoEngine.Core.GXNet.Constant.DB_WAIT_INFINITY);
            // ....
         }
         finally
         {
            // if (hDB != null)
            // {
            //    hDB.UnLockAllSymb();
            //    hEDB.UnLock();
            // }
         }
      }

      #endregion Execute Method

      // TODO: Organize any event handlers added (either manually or through the designer) in the region below. Event
      //       handlers may be used to provide interactive changes to the form appearance based on user input which
      //       can deliver a more natural user experience (e.g. enabling/disabling controls based on reaction
      //       to a SelectedValueChanged event from a ComboBoxControl).
      //
      //       Note: The default behaviour for the OK button has already been added. None is needed for the Cancel button
      //       in most cases.
      //
      //       Should any extra logic be needed it is generally a good idea to add it to the BaseForm overrides above
      //       rather than inside m_btnOK_Click which will make things easier to maintain as well as maintain the ability
      //       of the GX to run in non-interactive (scripting) mode and function logically.

      #region Event Handlers

      private void m_btnOK_Click(object sender, EventArgs e)
      {
         try
         {
            if (!bValidateDialog())
            {
               // This to not close the dialog
               DialogResult = DialogResult.None;
               return;
            }
            ini.SyncDiskToMatchCurrentControls();
         }
         catch (Exception ex)
         {
            // Show errors and clear it so that it will not present again on GX exit
            if (ex.Message.Length > 0)
               MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            CSYS.iClearErrAP();
            // This to not close the dialog
            DialogResult = DialogResult.None;
         }
      }

      #endregion Event Handlers
   }
}