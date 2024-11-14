// Copyright (c) 2024 Bentley Systems, Incorporated. All rights reserved.
using Geosoft.GX.Controls;

namespace EmptySampleTemplates
{
   partial class Wizard1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wizard1));
         this.m_viewsColumnModel = new XPTable.Models.ColumnModel();
         this.m_colTemplateViews = new XPTable.Models.TextColumn();
         this.m_colMapViews = new XPTable.Models.ComboBoxColumn();
         this.m_colDrawDataIndex = new XPTable.Models.CheckBoxColumn();
         this.m_colDrawDataIndexColor = new XPTable.Models.ColorColumn();
         this.m_colDrawDataIndexThick = new XPTable.Models.NumberColumn();
         this.m_viewsTableModel = new XPTable.Models.TableModel();
         this.m_wizardPage1 = new Geosoft.GX.Controls.WizardPage();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.m_wizardPage2 = new Geosoft.GX.Controls.WizardPage();
         this.label3 = new System.Windows.Forms.Label();
         this.m_wizardPage3 = new Geosoft.GX.Controls.WizardPage();
         this.label5 = new System.Windows.Forms.Label();
         this.m_wizardPage4 = new Geosoft.GX.Controls.WizardPage();
         this.label4 = new System.Windows.Forms.Label();
         this.ini = new Geosoft.GX.Controls.INI(this.components);
         this.m_wizardPage1.SuspendLayout();
         this.m_wizardPage2.SuspendLayout();
         this.m_wizardPage3.SuspendLayout();
         this.m_wizardPage4.SuspendLayout();
         this.SuspendLayout();
         //
         // m_viewsColumnModel
         //
         this.m_viewsColumnModel.Columns.AddRange(new XPTable.Models.Column[]
         {
            this.m_colTemplateViews,
            this.m_colMapViews,
            this.m_colDrawDataIndex,
            this.m_colDrawDataIndexColor,
            this.m_colDrawDataIndexThick
         });
         //
         // m_colTemplateViews
         //
         this.m_colTemplateViews.Editable = false;
         this.m_colTemplateViews.Sortable = false;
         resources.ApplyResources(this.m_colTemplateViews, "m_colTemplateViews");
         this.m_colTemplateViews.Width = 145;
         //
         // m_colMapViews
         //
         this.m_colMapViews.Sortable = false;
         resources.ApplyResources(this.m_colMapViews, "m_colMapViews");
         this.m_colMapViews.Width = 145;
         //
         // m_colDrawDataIndex
         //
         this.m_colDrawDataIndex.Alignment = XPTable.Models.ColumnAlignment.Center;
         this.m_colDrawDataIndex.Sortable = false;
         resources.ApplyResources(this.m_colDrawDataIndex, "m_colDrawDataIndex");
         this.m_colDrawDataIndex.Width = 38;
         //
         // m_colDrawDataIndexColor
         //
         this.m_colDrawDataIndexColor.Alignment = XPTable.Models.ColumnAlignment.Center;
         this.m_colDrawDataIndexColor.ShowColorName = false;
         this.m_colDrawDataIndexColor.Sortable = false;
         resources.ApplyResources(this.m_colDrawDataIndexColor, "m_colDrawDataIndexColor");
         this.m_colDrawDataIndexColor.Width = 65;
         //
         // m_colDrawDataIndexThick
         //
         this.m_colDrawDataIndexThick.Alignment = XPTable.Models.ColumnAlignment.Center;
         this.m_colDrawDataIndexThick.Increment = new decimal(new int[]
         {
            5,
            0,
            0,
            65536
         });
         this.m_colDrawDataIndexThick.Minimum = new decimal(new int[]
         {
            1,
            0,
            0,
            65536
         });
         this.m_colDrawDataIndexThick.Sortable = false;
         resources.ApplyResources(this.m_colDrawDataIndexThick, "m_colDrawDataIndexThick");
         this.m_colDrawDataIndexThick.Width = 90;
         //
         // m_wizardPage1
         //
         this.m_wizardPage1.Controls.Add(this.label2);
         this.m_wizardPage1.Controls.Add(this.label1);
         resources.ApplyResources(this.m_wizardPage1, "m_wizardPage1");
         this.m_wizardPage1.Name = "m_wizardPage1";
         //
         // label2
         //
         resources.ApplyResources(this.label2, "label2");
         this.label2.Name = "label2";
         //
         // label1
         //
         resources.ApplyResources(this.label1, "label1");
         this.label1.Name = "label1";
         //
         // m_wizardPage2
         //
         this.m_wizardPage2.Controls.Add(this.label3);
         resources.ApplyResources(this.m_wizardPage2, "m_wizardPage2");
         this.m_wizardPage2.Name = "m_wizardPage2";
         //
         // label3
         //
         resources.ApplyResources(this.label3, "label3");
         this.label3.Name = "label3";
         //
         // m_wizardPage3
         //
         this.m_wizardPage3.Controls.Add(this.label5);
         resources.ApplyResources(this.m_wizardPage3, "m_wizardPage3");
         this.m_wizardPage3.Name = "m_wizardPage3";
         //
         // label5
         //
         resources.ApplyResources(this.label5, "label5");
         this.label5.Name = "label5";
         //
         // m_wizardPage4
         //
         this.m_wizardPage4.Controls.Add(this.label4);
         resources.ApplyResources(this.m_wizardPage4, "m_wizardPage4");
         this.m_wizardPage4.Name = "m_wizardPage4";
         //
         // label4
         //
         resources.ApplyResources(this.label4, "label4");
         this.label4.Name = "label4";
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
         // Wizard1
         //
         resources.ApplyResources(this, "$this");
         this.Controls.Add(this.m_wizardPage4);
         this.Controls.Add(this.m_wizardPage1);
         this.Controls.Add(this.m_wizardPage3);
         this.Controls.Add(this.m_wizardPage2);
         this.HelpTopicID = "geogxnet.GX_MAPPRODUCTION_MAKESHEETS";
         this.Name = "Wizard1";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
         this.Text = "Wizard GX Template";
         this.Controls.SetChildIndex(this.m_wizardPage2, 0);
         this.Controls.SetChildIndex(this.m_wizardPage3, 0);
         this.Controls.SetChildIndex(this.m_wizardPage1, 0);
         this.Controls.SetChildIndex(this.m_wizardPage4, 0);
         this.m_wizardPage1.ResumeLayout(false);
         this.m_wizardPage1.PerformLayout();
         this.m_wizardPage2.ResumeLayout(false);
         this.m_wizardPage2.PerformLayout();
         this.m_wizardPage3.ResumeLayout(false);
         this.m_wizardPage3.PerformLayout();
         this.m_wizardPage4.ResumeLayout(false);
         this.m_wizardPage4.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private XPTable.Models.ColumnModel m_viewsColumnModel;
      private XPTable.Models.TableModel m_viewsTableModel;
      private XPTable.Models.TextColumn m_colTemplateViews;
      private XPTable.Models.ComboBoxColumn m_colMapViews;
      private XPTable.Models.CheckBoxColumn m_colDrawDataIndex;
      private XPTable.Models.ColorColumn m_colDrawDataIndexColor;
      private XPTable.Models.NumberColumn m_colDrawDataIndexThick;
      private WizardPage m_wizardPage1;
      private WizardPage m_wizardPage2;
      private WizardPage m_wizardPage3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label5;
      private WizardPage m_wizardPage4;
      private System.Windows.Forms.Label label4;
      private INI ini;
   }
}