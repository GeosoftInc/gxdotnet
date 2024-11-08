// Copyright (c) 2024 Bentley Systems, Incorporated. All rights reserved.
namespace NewGDB
{
   partial class NewGDB
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGDB));
         Geosoft.GX.Controls.IntParameter intParameter1 = new Geosoft.GX.Controls.IntParameter();
         Geosoft.GX.Controls.IntParameter intParameter2 = new Geosoft.GX.Controls.IntParameter();
         Geosoft.GX.Controls.IntParameter intParameter3 = new Geosoft.GX.Controls.IntParameter();
         Geosoft.GX.Controls.IntParameter intParameter4 = new Geosoft.GX.Controls.IntParameter();
         Geosoft.GX.Controls.IntParameter intParameter5 = new Geosoft.GX.Controls.IntParameter();
         Geosoft.GX.Controls.StringParameter stringParameter1 = new Geosoft.GX.Controls.StringParameter();
         Geosoft.GX.Controls.StringParameter stringParameter2 = new Geosoft.GX.Controls.StringParameter();
         Geosoft.GX.Controls.StringParameter stringParameter3 = new Geosoft.GX.Controls.StringParameter();
         Geosoft.GX.Controls.StringParameter stringParameter4 = new Geosoft.GX.Controls.StringParameter();
         Geosoft.GX.Controls.StringParameter stringParameter5 = new Geosoft.GX.Controls.StringParameter();
         Geosoft.GX.Controls.StringParameter stringParameter6 = new Geosoft.GX.Controls.StringParameter();
         this.m_iLines = new Geosoft.GX.Controls.EditIntControl();
         this.m_iChannels = new Geosoft.GX.Controls.EditIntControl();
         this.m_sDBName = new Geosoft.GX.Controls.FileEditControl();
         this.m_cbCompression = new Geosoft.GX.Controls.ComboBoxControl();
         this.lDBName = new Geosoft.GX.Controls.LabelControl();
         this.lLines = new Geosoft.GX.Controls.LabelControl();
         this.lChannels = new Geosoft.GX.Controls.LabelControl();
         this.lCompression = new Geosoft.GX.Controls.LabelControl();
         this.panelAdvanced = new Geosoft.GX.Controls.PanelControl();
         this.btnCancel = new Geosoft.GX.Controls.ButtonControl();
         this.btnOK = new Geosoft.GX.Controls.ButtonControl();
         this.btnAdvance = new Geosoft.GX.Controls.AdvancedButtonControl();
         this.lMaxData = new Geosoft.GX.Controls.LabelControl();
         this.m_cbMaxData = new Geosoft.GX.Controls.ComboBoxControl();
         this.lMaxDataPerChan = new Geosoft.GX.Controls.LabelControl();
         this.m_cbMaxDataPerChan = new Geosoft.GX.Controls.ComboBoxControl();
         this.ini = new Geosoft.GX.Controls.INI(this.components);
         this.panelAdvanced.SuspendLayout();
         this.SuspendLayout();
         //
         // m_iLines
         //
         resources.ApplyResources(this.m_iLines, "m_iLines");
         this.m_iLines.DefaultValue = 200;
         this.m_iLines.ErrorProviderBuddy = null;
         this.m_iLines.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_iLines.INIComponent = null;
         this.m_iLines.MaximumLength = 32767;
         this.m_iLines.MaximumValue = -2147483647;
         this.m_iLines.MinimumValue = 1;
         this.m_iLines.Name = "m_iLines";
         this.m_iLines.Value = 200;
         //
         // m_iChannels
         //
         resources.ApplyResources(this.m_iChannels, "m_iChannels");
         this.m_iChannels.DefaultValue = 50;
         this.m_iChannels.ErrorProviderBuddy = null;
         this.m_iChannels.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_iChannels.INIComponent = null;
         this.m_iChannels.MaximumLength = 32767;
         this.m_iChannels.MaximumValue = -2147483647;
         this.m_iChannels.MinimumValue = 1;
         this.m_iChannels.Name = "m_iChannels";
         this.m_iChannels.Value = 50;
         //
         // m_sDBName
         //
         resources.ApplyResources(this.m_sDBName, "m_sDBName");
         this.m_sDBName.BrowseListItems = null;
         this.m_sDBName.ErrorProviderBuddy = null;
         this.m_sDBName.FileOpenSave = Geosoft.GX.Controls.FileOpenSaveEnum.Save;
         this.m_sDBName.Filters = new Geosoft.GX.Controls.Helpers.FileFilters[]
         {
            Geosoft.GX.Controls.Helpers.FileFilters.GDB
         };
         this.m_sDBName.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_sDBName.INIComponent = null;
         this.m_sDBName.Name = "m_sDBName";
         this.m_sDBName.RequiredFileExtension = "";
         //
         // m_cbCompression
         //
         resources.ApplyResources(this.m_cbCompression, "m_cbCompression");
         this.m_cbCompression.DataSource = null;
         this.m_cbCompression.DefaultValue = "Compress for size";
         this.m_cbCompression.ErrorProviderBuddy = null;
         this.m_cbCompression.Force = false;
         this.m_cbCompression.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_cbCompression.INIComponent = null;
         this.m_cbCompression.Name = "m_cbCompression";
         this.m_cbCompression.NameOrAlias = Geosoft.GX.Controls.ListItemEnum.Alias;
         this.m_cbCompression.Required = true;
         //
         // lDBName
         //
         this.lDBName.BuddyControl = this.m_sDBName;
         resources.ApplyResources(this.lDBName, "lDBName");
         this.lDBName.Name = "lDBName";
         //
         // lLines
         //
         this.lLines.BuddyControl = this.m_iLines;
         resources.ApplyResources(this.lLines, "lLines");
         this.lLines.Name = "lLines";
         //
         // lChannels
         //
         this.lChannels.BuddyControl = this.m_iChannels;
         resources.ApplyResources(this.lChannels, "lChannels");
         this.lChannels.Name = "lChannels";
         //
         // lCompression
         //
         this.lCompression.BuddyControl = this.m_cbCompression;
         resources.ApplyResources(this.lCompression, "lCompression");
         this.lCompression.Name = "lCompression";
         //
         // panelAdvanced
         //
         resources.ApplyResources(this.panelAdvanced, "panelAdvanced");
         this.panelAdvanced.Controls.Add(this.btnCancel);
         this.panelAdvanced.Controls.Add(this.btnOK);
         this.panelAdvanced.Controls.Add(this.btnAdvance);
         this.panelAdvanced.Name = "panelAdvanced";
         //
         // btnCancel
         //
         resources.ApplyResources(this.btnCancel, "btnCancel");
         this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.RealMaximumSize = new System.Drawing.Size(1000, 23);
         this.btnCancel.RealMinimumSize = new System.Drawing.Size(20, 23);
         this.btnCancel.UseVisualStyleBackColor = true;
         //
         // btnOK
         //
         resources.ApplyResources(this.btnOK, "btnOK");
         this.btnOK.BackColor = System.Drawing.SystemColors.Control;
         this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnOK.Name = "btnOK";
         this.btnOK.RealMaximumSize = new System.Drawing.Size(1000, 23);
         this.btnOK.RealMinimumSize = new System.Drawing.Size(20, 23);
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         //
         // btnAdvance
         //
         resources.ApplyResources(this.btnAdvance, "btnAdvance");
         this.btnAdvance.Name = "btnAdvance";
         //
         // lMaxData
         //
         this.lMaxData.BuddyControl = this.m_cbMaxData;
         resources.ApplyResources(this.lMaxData, "lMaxData");
         this.lMaxData.Name = "lMaxData";
         //
         // m_cbMaxData
         //
         resources.ApplyResources(this.m_cbMaxData, "m_cbMaxData");
         this.m_cbMaxData.DataSource = null;
         this.m_cbMaxData.DefaultValue = "4 Terabytes (Standard)";
         this.m_cbMaxData.ErrorProviderBuddy = null;
         this.m_cbMaxData.Force = true;
         this.m_cbMaxData.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_cbMaxData.INIComponent = null;
         this.m_cbMaxData.Name = "m_cbMaxData";
         this.m_cbMaxData.NameOrAlias = Geosoft.GX.Controls.ListItemEnum.Alias;
         this.m_cbMaxData.SelectedValueChanged += new System.EventHandler(this.m_cbMaxData_SelectedValueChanged);
         //
         // lMaxDataPerChan
         //
         this.lMaxDataPerChan.BuddyControl = this.m_cbMaxDataPerChan;
         resources.ApplyResources(this.lMaxDataPerChan, "lMaxDataPerChan");
         this.lMaxDataPerChan.Name = "lMaxDataPerChan";
         //
         // m_cbMaxDataPerChan
         //
         resources.ApplyResources(this.m_cbMaxDataPerChan, "m_cbMaxDataPerChan");
         this.m_cbMaxDataPerChan.DataSource = null;
         this.m_cbMaxDataPerChan.DefaultValue = "64 Megabytes (Standard)";
         this.m_cbMaxDataPerChan.ErrorProviderBuddy = null;
         this.m_cbMaxDataPerChan.Force = true;
         this.m_cbMaxDataPerChan.GrowthAnchorFamilyBehaviour = Geosoft.GX.Controls.Helpers.GrowParentAnchorFamilyBehaviour.MoveAndGrow;
         this.m_cbMaxDataPerChan.INIComponent = null;
         this.m_cbMaxDataPerChan.Name = "m_cbMaxDataPerChan";
         this.m_cbMaxDataPerChan.NameOrAlias = Geosoft.GX.Controls.ListItemEnum.Alias;
         this.m_cbMaxDataPerChan.SelectedValueChanged += new System.EventHandler(this.m_cbMaxDataPerChan_SelectedValueChanged);
         //
         // ini
         //
         this.ini.ContainerControl = this;
         this.ini.GroupName = "CREATE";
         this.ini.GSColorParameters = new Geosoft.GX.Controls.GSColorParameter[0];
         intParameter1.BuddyControl = this.m_iLines;
         intParameter1.DefaultValue = 200;
         intParameter1.HelpDescription = "(none)";
         intParameter1.Name = "LINES";
         intParameter2.BuddyControl = this.m_iChannels;
         intParameter2.DefaultValue = 50;
         intParameter2.HelpDescription = "(none)";
         intParameter2.Name = "CHANNELS";
         intParameter3.BuddyControl = null;
         intParameter3.DefaultValue = -1;
         intParameter3.HelpDescription = "(none)";
         intParameter3.Name = "BLOBS";
         intParameter4.BuddyControl = null;
         intParameter4.DefaultValue = -1;
         intParameter4.HelpDescription = "(none)";
         intParameter4.Name = "USERS";
         intParameter5.BuddyControl = null;
         intParameter5.DefaultValue = -1;
         intParameter5.HelpDescription = "(none)";
         intParameter5.Name = "ERASE";
         this.ini.IntParameters = new Geosoft.GX.Controls.IntParameter[]
         {
            intParameter1,
            intParameter2,
            intParameter3,
            intParameter4,
            intParameter5
         };
         this.ini.RealParameters = new Geosoft.GX.Controls.RealParameter[0];
         stringParameter1.BuddyControl = this.m_sDBName;
         stringParameter1.DefaultValue = "";
         stringParameter1.HelpDescription = "(none)";
         stringParameter1.Name = "NAME";
         stringParameter2.BuddyControl = this.m_cbCompression;
         stringParameter2.DefaultValue = "2";
         stringParameter2.HelpDescription = "(none)";
         stringParameter2.Name = "COMPRESSION";
         stringParameter3.BuddyControl = this.m_cbMaxDataPerChan;
         stringParameter3.DefaultValue = "1024";
         stringParameter3.HelpDescription = "(none)";
         stringParameter3.Name = "PAGESIZE";
         stringParameter4.BuddyControl = null;
         stringParameter4.DefaultValue = "";
         stringParameter4.HelpDescription = "(none)";
         stringParameter4.Name = "SUPER";
         stringParameter5.BuddyControl = null;
         stringParameter5.DefaultValue = "";
         stringParameter5.HelpDescription = "(none)";
         stringParameter5.Name = "PASSWORD";
         stringParameter6.BuddyControl = null;
         stringParameter6.DefaultValue = "";
         stringParameter6.HelpDescription = "(none)";
         stringParameter6.Name = "CURDB";
         this.ini.StringParameters = new Geosoft.GX.Controls.StringParameter[]
         {
            stringParameter1,
            stringParameter2,
            stringParameter3,
            stringParameter4,
            stringParameter5,
            stringParameter6
         };
         //
         // NewGDB
         //
         this.AcceptButton = this.btnOK;
         this.CancelButton = this.btnCancel;
         resources.ApplyResources(this, "$this");
         this.Controls.Add(this.m_cbMaxDataPerChan);
         this.Controls.Add(this.m_cbMaxData);
         this.Controls.Add(this.lMaxDataPerChan);
         this.Controls.Add(this.lMaxData);
         this.Controls.Add(this.panelAdvanced);
         this.Controls.Add(this.m_cbCompression);
         this.Controls.Add(this.m_iChannels);
         this.Controls.Add(this.m_iLines);
         this.Controls.Add(this.m_sDBName);
         this.Controls.Add(this.lCompression);
         this.Controls.Add(this.lChannels);
         this.Controls.Add(this.lLines);
         this.Controls.Add(this.lDBName);
         this.HelpTopicID = "geogxnet.GEOSOFT_GX_NEWGDB_NEWGDB_RUN";
         this.Name = "NewGDB";
         this.panelAdvanced.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Geosoft.GX.Controls.LabelControl lDBName;
      private Geosoft.GX.Controls.LabelControl lLines;
      private Geosoft.GX.Controls.LabelControl lChannels;
      private Geosoft.GX.Controls.LabelControl lCompression;
      private Geosoft.GX.Controls.FileEditControl m_sDBName;
      private Geosoft.GX.Controls.EditIntControl m_iLines;
      private Geosoft.GX.Controls.EditIntControl m_iChannels;
      private Geosoft.GX.Controls.ComboBoxControl m_cbCompression;
      private Geosoft.GX.Controls.PanelControl panelAdvanced;
      private Geosoft.GX.Controls.LabelControl lMaxData;
      private Geosoft.GX.Controls.LabelControl lMaxDataPerChan;
      private Geosoft.GX.Controls.ComboBoxControl m_cbMaxData;
      private Geosoft.GX.Controls.ComboBoxControl m_cbMaxDataPerChan;
      private Geosoft.GX.Controls.AdvancedButtonControl btnAdvance;
      private Geosoft.GX.Controls.ButtonControl btnCancel;
      private Geosoft.GX.Controls.ButtonControl btnOK;
      private Geosoft.GX.Controls.INI ini;
   }
}