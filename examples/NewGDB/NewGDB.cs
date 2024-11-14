// Copyright (c) 2024 Bentley Systems, Incorporated. All rights reserved.
using GeoEngine.Core.GXNet;
using Geosoft.Desktop.GXNet;
using Geosoft.GX.Controls;
using System;
using System.Windows.Forms;

namespace NewGDB
{
   public partial class NewGDB : BaseForm
   {
      #region Constructors/Destructors

      public NewGDB()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();
      }

      public NewGDB(IntPtr pGeo)
         : base(pGeo)
      {
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }

      #endregion Constructors/Destructors

      #region BaseForm Overrides

      protected override void InitializeForm()
      {
         StartGrowFormDuringTranslation();
         TranslateControls();
         base.InitializeForm();
         FillComboBoxes();

         EndGrowFormDuringTranslation();
      }

      #endregion BaseForm Overrides

      #region Entry Point Method

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
               Result = ShowDialog();
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
         return 1;
      }

      #endregion Entry Point Method

      #region Execute Command

      private void Execute()
      {
         // Always validate using this call first
         string strError = String.Empty;
         if (!bValidateDialog(ref strError, false))
            ShowErrorAndExit(strError);

         // --- is the database loaded? ---

         var szName = "";
         m_sDBName.GetFilePath(ref szName);
         CSTR.IFileExt(szName, ".gdb", ref szName, GeoEngine.Core.GXNet.Constant.FILE_EXT_FORCE);
         if (CEDB.iLoaded(szName) == 1) CEDB.UnLoad(szName);

         // --- Get Parameters ---

         int iLines = m_iLines.iGetValue();
         int iChannels = m_iChannels.iGetValue();
         int iCompress = Convert.ToInt32(m_cbCompression.strGetValue());
         int iPageSize = Convert.ToInt32(m_cbMaxData.strGetValue());

         int iBlobs = ini.GetInt("BLOBS");
         int iUsers = ini.GetInt("USERS");
         int iErase = ini.GetInt("ERASE");
         string szSuper = ini.GetString("SUPER");
         string szPassword = ini.GetString("PASSWORD");
         string szCurDB = ini.GetString("CURDB");

         int iMinBlobs = iLines + iChannels + 100;
         if (iBlobs < iMinBlobs)
            iBlobs = iMinBlobs;

         if (iUsers <= 0 || iUsers == GeoEngine.Core.GXNet.Constant.iDUMMY)
            iUsers = 10;

         if (iErase <= 0 || iErase == GeoEngine.Core.GXNet.Constant.iDUMMY)
         {
            iErase = Convert.ToInt32(iLines * iChannels * 0.05);
            if (iErase < 100) iErase = 100;
            if (iErase > 10000) iErase = 10000;
         }

         if (szSuper.Length == 0)
            szSuper = "SUPER";

         if (szPassword.Length == 0)
            szPassword = "";

         if (szCurDB.Length > 0 && szCurDB.CompareTo(szName) == 0)
            ShowErrorAndExit(_("Specified database is protected against overwrite."));

         if (CSYS.iScript() == 0)
            CPROJ.iRemoveDocument(szName);

         CDB.CreateComp(szName, iLines, iChannels, iBlobs, iUsers, iErase, szSuper, szPassword, iPageSize, iCompress);

         if (CSYS.iScript() != 1)
         {
            CEDB.LoadNew(szName);
         }
      }

      #endregion Execute Command

      #region Event Handlers

      private void btnOK_Click(object sender, EventArgs e)
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
               MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            CSYS.iClearErrAP();
            // This to not close the dialog
            DialogResult = DialogResult.None;
         }
      }

      private void m_cbMaxData_SelectedValueChanged(object sender, EventArgs e)
      {
         m_cbMaxDataPerChan.SetValue(m_cbMaxData.strGetValue());
      }

      private void m_cbMaxDataPerChan_SelectedValueChanged(object sender, EventArgs e)
      {
         m_cbMaxData.SetValue(m_cbMaxDataPerChan.strGetValue());
      }

      #endregion Event Handlers

      #region Helper Methods

      public void FillComboBoxes()
      {
         // --- For 8.5 restrict larger page sizes to a select "in" group ---

         bool bigData = (CSYS.iInteractive() == 0) || (CSYS.iGetInt(ini.GroupName, _n("PAGESIZE")) > 16384);

         // --- In the following two controls, the "Value" part
         //     is the pagesize; the two controls are locked together ---

         m_cbMaxDataPerChan.AddItem(_("4 Megabytes"), 64);
         m_cbMaxDataPerChan.AddItem(_("8 Megabytes"), 128);
         m_cbMaxDataPerChan.AddItem(_("16 Megabytes"), 256);
         m_cbMaxDataPerChan.AddItem(_("32 Megabytes"), 512);
         m_cbMaxDataPerChan.AddItem(_("64 Megabytes (Standard)"), 1024);
         m_cbMaxDataPerChan.AddItem(_("128 Megabytes"), 2048);
         m_cbMaxDataPerChan.AddItem(_("256 Megabytes"), 4096);
         m_cbMaxDataPerChan.AddItem(_("512 Megabytes"), 8192);
         m_cbMaxDataPerChan.AddItem(_("1 Gigabyte"), 16384);
         if (bigData)
         {
            m_cbMaxDataPerChan.AddItem(_("2 Gigabytes"), 32768);
            m_cbMaxDataPerChan.AddItem(_("4 Gigabytes"), 65536);
            m_cbMaxDataPerChan.AddItem(_("8 Gigabytes"), 131072);
            m_cbMaxDataPerChan.AddItem(_("16 Gigabytes"), 262144);
            m_cbMaxDataPerChan.AddItem(_("32 Gigabytes"), 524288);
            m_cbMaxDataPerChan.AddItem(_("64 Gigabytes"), 1048576);
         }

         m_cbMaxData.AddItem(_("256 Gigabytes"), 64);
         m_cbMaxData.AddItem(_("512 Gigabytes"), 128);
         m_cbMaxData.AddItem(_("1 Terabyte"), 256);
         m_cbMaxData.AddItem(_("2 Terabytes"), 512);
         m_cbMaxData.AddItem(_("4 Terabytes (Standard)"), 1024);
         m_cbMaxData.AddItem(_("8 Terabytes"), 2048);
         m_cbMaxData.AddItem(_("16 Terabytes"), 4096);
         m_cbMaxData.AddItem(_("32 Terabytes"), 8192);
         m_cbMaxData.AddItem(_("64 Terabytes"), 16384);
         if (bigData)
         {
            m_cbMaxData.AddItem(_("128 Terabytes"), 32768);
            m_cbMaxData.AddItem(_("256 Terabytes"), 65536);
            m_cbMaxData.AddItem(_("512 Terabytes"), 131072);
            m_cbMaxData.AddItem(_("1 Exabyte"), 262144);
            m_cbMaxData.AddItem(_("2 Exabytes"), 524288);
            m_cbMaxData.AddItem(_("4 Exabytes"), 1048576);
         }

         m_cbCompression.AddItem(_("No compression"), 0);
         m_cbCompression.AddItem(_("Compress for speed"), 1);
         m_cbCompression.AddItem(_("Compress for size"), 2);

         string szCompression = string.Empty;
         if (CSYS.IiGlobal("MONTAJ.DB_COMPRESS", ref szCompression) == 0)
            m_cbCompression.SetValue(szCompression);

         ini.RefreshControls();
         m_cbMaxData.SetValue(m_cbMaxDataPerChan.strGetValue());
      }

      public string GetCompressionBoxValue(int index)
      {
         return m_cbCompression.Items[index].ToString();
      }

      public string GetMaxDataPerChanBoxValue(int index)
      {
         return m_cbMaxDataPerChan.Items[index].ToString();
      }

      public string GetMaxDataBoxValue(int index)
      {
         return m_cbMaxData.Items[index].ToString();
      }

      #endregion Helper Methods
   }
}