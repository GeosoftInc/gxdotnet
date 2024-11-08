// Copyright (c) 2024 Bentley Systems, Incorporated. All rights reserved.
namespace EmptySampleTemplates
{
   partial class Advanced1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Advanced1));
         this.m_panelButtons = new Geosoft.GX.Controls.PanelControl();
         this.advancedButtonControl1 = new Geosoft.GX.Controls.AdvancedButtonControl();
         this.m_btnOK = new Geosoft.GX.Controls.ButtonControl();
         this.m_btnCancel = new Geosoft.GX.Controls.ButtonControl();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.ini = new Geosoft.GX.Controls.INI(this.components);
         this.m_panelButtons.SuspendLayout();
         this.SuspendLayout();
         //
         // m_panelButtons
         //
         resources.ApplyResources(this.m_panelButtons, "m_panelButtons");
         this.m_panelButtons.Controls.Add(this.advancedButtonControl1);
         this.m_panelButtons.Controls.Add(this.m_btnOK);
         this.m_panelButtons.Controls.Add(this.m_btnCancel);
         this.m_panelButtons.Name = "m_panelButtons";
         //
         // advancedButtonControl1
         //
         resources.ApplyResources(this.advancedButtonControl1, "advancedButtonControl1");
         this.advancedButtonControl1.Name = "advancedButtonControl1";
         //
         // m_btnOK
         //
         resources.ApplyResources(this.m_btnOK, "m_btnOK");
         this.m_btnOK.BackColor = System.Drawing.SystemColors.Control;
         this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.m_btnOK.Name = "m_btnOK";
         this.m_btnOK.RealMaximumSize = new System.Drawing.Size(1000, 23);
         this.m_btnOK.RealMinimumSize = new System.Drawing.Size(20, 23);
         this.m_btnOK.UseVisualStyleBackColor = true;
         this.m_btnOK.Click += new System.EventHandler(this.m_btnOK_Click);
         //
         // m_btnCancel
         //
         resources.ApplyResources(this.m_btnCancel, "m_btnCancel");
         this.m_btnCancel.BackColor = System.Drawing.SystemColors.Control;
         this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.m_btnCancel.Name = "m_btnCancel";
         this.m_btnCancel.RealMaximumSize = new System.Drawing.Size(1000, 23);
         this.m_btnCancel.RealMinimumSize = new System.Drawing.Size(20, 23);
         this.m_btnCancel.UseVisualStyleBackColor = true;
         //
         // label1
         //
         resources.ApplyResources(this.label1, "label1");
         this.label1.Name = "label1";
         //
         // label2
         //
         resources.ApplyResources(this.label2, "label2");
         this.label2.Name = "label2";
         //
         // ini
         //
         this.ini.ContainerControl = this;
         this.ini.GroupName = "GROUPNAME";
         this.ini.GSColorParameters = new Geosoft.GX.Controls.GSColorParameter[0];
         this.ini.IntParameters = new Geosoft.GX.Controls.IntParameter[0];
         this.ini.RealParameters = new Geosoft.GX.Controls.RealParameter[0];
         this.ini.StringParameters = new Geosoft.GX.Controls.StringParameter[0];
         //
         // Advanced1
         //
         this.AcceptButton = this.m_btnOK;
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.m_btnCancel;
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.m_panelButtons);
         this.Name = "Advanced1";
         this.m_panelButtons.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Geosoft.GX.Controls.PanelControl m_panelButtons;
      private Geosoft.GX.Controls.ButtonControl m_btnOK;
      private Geosoft.GX.Controls.ButtonControl m_btnCancel;
      private System.Windows.Forms.Label label1;
      private Geosoft.GX.Controls.AdvancedButtonControl advancedButtonControl1;
      private System.Windows.Forms.Label label2;
      private Geosoft.GX.Controls.INI ini;
   }
}