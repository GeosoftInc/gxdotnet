using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using GeoEngine.Core.GXNetX;
using GeoEngine.Core.GXNetX.Windows;

namespace TestXToolControl
{
   /// <summary>
   /// Summary description for XToolControl
   /// </summary>
   public class XToolControl : ToolControl
   {
      private System.Windows.Forms.Label m_lblX;
      private System.Windows.Forms.TextBox m_tbX;
      private System.Windows.Forms.TextBox m_tbY;
      private System.Windows.Forms.TextBox m_tbZ;
      private System.Windows.Forms.TextBox m_tbXMin;
      private System.Windows.Forms.TextBox m_tbYMin;
      private System.Windows.Forms.TextBox m_tbXMax;
      private System.Windows.Forms.Label m_lblY;
      private System.Windows.Forms.Label m_lblZ;
      private System.Windows.Forms.Label m_lblXMin;
      private System.Windows.Forms.Label m_lblYMin;
      private System.Windows.Forms.Label m_lblXMax;
      private System.Windows.Forms.Label m_lblYMax;
      private System.Windows.Forms.TextBox m_tbYMax;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      private CGXNETCore m_GEO;
      private CMETA m_META;
      private ChangeProjectionDelegate m_ChPrjDel;
      private ChangeLocationDelegate m_ChLocDel;
      private System.Windows.Forms.Label m_lblPRJ;
      private System.Windows.Forms.GroupBox m_grpPRJ;
      private System.Windows.Forms.GroupBox m_grpUnits;
      private System.Windows.Forms.Label m_lblUnits;
      private ChangeAreaDelegate m_ChAreaDel;
      private bool m_bUpdating;

      public XToolControl()
      {
         // This call is required by the Windows.Forms Form Designer.
         InitializeComponent();

         m_bUpdating = false;
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (components != null)
               components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.m_lblX = new System.Windows.Forms.Label();
         this.m_tbX = new System.Windows.Forms.TextBox();
         this.m_tbY = new System.Windows.Forms.TextBox();
         this.m_tbZ = new System.Windows.Forms.TextBox();
         this.m_tbXMin = new System.Windows.Forms.TextBox();
         this.m_tbYMin = new System.Windows.Forms.TextBox();
         this.m_tbXMax = new System.Windows.Forms.TextBox();
         this.m_lblY = new System.Windows.Forms.Label();
         this.m_lblZ = new System.Windows.Forms.Label();
         this.m_lblXMin = new System.Windows.Forms.Label();
         this.m_lblYMin = new System.Windows.Forms.Label();
         this.m_lblXMax = new System.Windows.Forms.Label();
         this.m_lblYMax = new System.Windows.Forms.Label();
         this.m_tbYMax = new System.Windows.Forms.TextBox();
         this.m_lblPRJ = new System.Windows.Forms.Label();
         this.m_grpPRJ = new System.Windows.Forms.GroupBox();
         this.m_grpUnits = new System.Windows.Forms.GroupBox();
         this.m_lblUnits = new System.Windows.Forms.Label();
         this.m_grpUnits.SuspendLayout();
         this.SuspendLayout();
         //
         // m_lblX
         //
         this.m_lblX.Location = new System.Drawing.Point(8, 10);
         this.m_lblX.Name = "m_lblX";
         this.m_lblX.Size = new System.Drawing.Size(40, 16);
         this.m_lblX.TabIndex = 0;
         this.m_lblX.Text = "X";
         //
         // m_tbX
         //
         this.m_tbX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                              | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbX.Location = new System.Drawing.Point(56, 8);
         this.m_tbX.Name = "m_tbX";
         this.m_tbX.Size = new System.Drawing.Size(128, 20);
         this.m_tbX.TabIndex = 1;
         this.m_tbX.Text = "0";
         this.m_tbX.TextChanged += new System.EventHandler(this.m_tbXYZ_TextChanged);
         //
         // m_tbY
         //
         this.m_tbY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                              | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbY.Location = new System.Drawing.Point(56, 36);
         this.m_tbY.Name = "m_tbY";
         this.m_tbY.Size = new System.Drawing.Size(128, 20);
         this.m_tbY.TabIndex = 2;
         this.m_tbY.Text = "0";
         this.m_tbY.TextChanged += new System.EventHandler(this.m_tbXYZ_TextChanged);
         //
         // m_tbZ
         //
         this.m_tbZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                              | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbZ.Location = new System.Drawing.Point(56, 64);
         this.m_tbZ.Name = "m_tbZ";
         this.m_tbZ.Size = new System.Drawing.Size(128, 20);
         this.m_tbZ.TabIndex = 3;
         this.m_tbZ.Text = "0";
         this.m_tbZ.TextChanged += new System.EventHandler(this.m_tbXYZ_TextChanged);
         //
         // m_tbXMin
         //
         this.m_tbXMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbXMin.BackColor = System.Drawing.SystemColors.GrayText;
         this.m_tbXMin.Enabled = false;
         this.m_tbXMin.Location = new System.Drawing.Point(56, 92);
         this.m_tbXMin.Name = "m_tbXMin";
         this.m_tbXMin.Size = new System.Drawing.Size(128, 20);
         this.m_tbXMin.TabIndex = 4;
         this.m_tbXMin.Text = "0";
         //
         // m_tbYMin
         //
         this.m_tbYMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbYMin.BackColor = System.Drawing.SystemColors.GrayText;
         this.m_tbYMin.Enabled = false;
         this.m_tbYMin.Location = new System.Drawing.Point(56, 120);
         this.m_tbYMin.Name = "m_tbYMin";
         this.m_tbYMin.Size = new System.Drawing.Size(128, 20);
         this.m_tbYMin.TabIndex = 5;
         this.m_tbYMin.Text = "0";
         //
         // m_tbXMax
         //
         this.m_tbXMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbXMax.BackColor = System.Drawing.SystemColors.GrayText;
         this.m_tbXMax.Enabled = false;
         this.m_tbXMax.Location = new System.Drawing.Point(56, 148);
         this.m_tbXMax.Name = "m_tbXMax";
         this.m_tbXMax.Size = new System.Drawing.Size(128, 20);
         this.m_tbXMax.TabIndex = 6;
         this.m_tbXMax.Text = "0";
         //
         // m_lblY
         //
         this.m_lblY.Location = new System.Drawing.Point(8, 38);
         this.m_lblY.Name = "m_lblY";
         this.m_lblY.Size = new System.Drawing.Size(40, 16);
         this.m_lblY.TabIndex = 7;
         this.m_lblY.Text = "Y";
         //
         // m_lblZ
         //
         this.m_lblZ.Location = new System.Drawing.Point(8, 66);
         this.m_lblZ.Name = "m_lblZ";
         this.m_lblZ.Size = new System.Drawing.Size(40, 16);
         this.m_lblZ.TabIndex = 8;
         this.m_lblZ.Text = "Z";
         //
         // m_lblXMin
         //
         this.m_lblXMin.Location = new System.Drawing.Point(8, 94);
         this.m_lblXMin.Name = "m_lblXMin";
         this.m_lblXMin.Size = new System.Drawing.Size(40, 16);
         this.m_lblXMin.TabIndex = 9;
         this.m_lblXMin.Text = "XMin";
         //
         // m_lblYMin
         //
         this.m_lblYMin.Location = new System.Drawing.Point(8, 122);
         this.m_lblYMin.Name = "m_lblYMin";
         this.m_lblYMin.Size = new System.Drawing.Size(40, 16);
         this.m_lblYMin.TabIndex = 10;
         this.m_lblYMin.Text = "XMax";
         //
         // m_lblXMax
         //
         this.m_lblXMax.Location = new System.Drawing.Point(8, 150);
         this.m_lblXMax.Name = "m_lblXMax";
         this.m_lblXMax.Size = new System.Drawing.Size(40, 16);
         this.m_lblXMax.TabIndex = 11;
         this.m_lblXMax.Text = "YMin";
         //
         // m_lblYMax
         //
         this.m_lblYMax.Location = new System.Drawing.Point(8, 178);
         this.m_lblYMax.Name = "m_lblYMax";
         this.m_lblYMax.Size = new System.Drawing.Size(40, 16);
         this.m_lblYMax.TabIndex = 12;
         this.m_lblYMax.Text = "YMax";
         //
         // m_tbYMax
         //
         this.m_tbYMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_tbYMax.BackColor = System.Drawing.SystemColors.GrayText;
         this.m_tbYMax.Enabled = false;
         this.m_tbYMax.Location = new System.Drawing.Point(56, 176);
         this.m_tbYMax.Name = "m_tbYMax";
         this.m_tbYMax.Size = new System.Drawing.Size(128, 20);
         this.m_tbYMax.TabIndex = 13;
         this.m_tbYMax.Text = "0";
         //
         // m_lblPRJ
         //
         this.m_lblPRJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_lblPRJ.Location = new System.Drawing.Point(16, 272);
         this.m_lblPRJ.Name = "m_lblPRJ";
         this.m_lblPRJ.Size = new System.Drawing.Size(168, 40);
         this.m_lblPRJ.TabIndex = 14;
         this.m_lblPRJ.Text = "Projection Text";
         //
         // m_grpPRJ
         //
         this.m_grpPRJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
         this.m_grpPRJ.Location = new System.Drawing.Point(8, 248);
         this.m_grpPRJ.Name = "m_grpPRJ";
         this.m_grpPRJ.Size = new System.Drawing.Size(184, 72);
         this.m_grpPRJ.TabIndex = 15;
         this.m_grpPRJ.TabStop = false;
         this.m_grpPRJ.Text = "Projection";
         //
         // m_grpUnits
         //
         this.m_grpUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
         this.m_grpUnits.Controls.Add(this.m_lblUnits);
         this.m_grpUnits.Location = new System.Drawing.Point(8, 200);
         this.m_grpUnits.Name = "m_grpUnits";
         this.m_grpUnits.Size = new System.Drawing.Size(184, 40);
         this.m_grpUnits.TabIndex = 16;
         this.m_grpUnits.TabStop = false;
         this.m_grpUnits.Text = "Units";
         //
         // m_lblUnits
         //
         this.m_lblUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
         this.m_lblUnits.Location = new System.Drawing.Point(8, 16);
         this.m_lblUnits.Name = "m_lblUnits";
         this.m_lblUnits.Size = new System.Drawing.Size(168, 16);
         this.m_lblUnits.TabIndex = 0;
         this.m_lblUnits.Text = "Units Text";
         //
         // XToolControl
         //
         this.Controls.Add(this.m_grpUnits);
         this.Controls.Add(this.m_lblPRJ);
         this.Controls.Add(this.m_grpPRJ);
         this.Controls.Add(this.m_tbYMax);
         this.Controls.Add(this.m_lblYMax);
         this.Controls.Add(this.m_lblXMax);
         this.Controls.Add(this.m_lblYMin);
         this.Controls.Add(this.m_lblXMin);
         this.Controls.Add(this.m_lblZ);
         this.Controls.Add(this.m_lblY);
         this.Controls.Add(this.m_tbXMax);
         this.Controls.Add(this.m_tbYMin);
         this.Controls.Add(this.m_tbXMin);
         this.Controls.Add(this.m_tbZ);
         this.Controls.Add(this.m_tbY);
         this.Controls.Add(this.m_tbX);
         this.Controls.Add(this.m_lblX);
         this.Name = "XToolControl";
         this.Size = new System.Drawing.Size(200, 328);
         this.ChangeArea += new ChangeAreaDelegate(this.XToolControl_ChangeArea);
         this.ChangeProjection += new ChangeProjectionDelegate(this.XToolControl_ChangeProjection);
         this.ChangeLocation += new ChangeLocationDelegate(this.XToolControl_ChangeLocation);
         this.GeneralInfo += new GeneralInfoDelegate(this.XToolControl_GeneralInfo);
         this.m_grpUnits.ResumeLayout(false);
         this.ResumeLayout(false);

      }
      #endregion

      public override bool bInitializeToolControl(CGXNETCore pGEO, CMETA pMETA, ChangeProjectionDelegate pChPrjDel, ChangeLocationDelegate pChLocDel, ChangeAreaDelegate pChAreaDel, ref string szName)
      {
         szName = "XToolControl";

         m_GEO = pGEO;
         m_META = pMETA;
         m_ChPrjDel = pChPrjDel;
         m_ChLocDel = pChLocDel;
         m_ChAreaDel = pChAreaDel;

         return true;
      }

      private void XToolControl_ChangeArea(double dXMin, double dYMin, double dXMax, double dYMax)
      {
         if (dXMin != Constant.rDUMMY)
            m_tbXMin.Text = dXMin.ToString();
         else
            m_tbXMin.Text = "*";
         if (dYMin != Constant.rDUMMY)
            m_tbYMin.Text = dYMin.ToString();
         else
            m_tbYMin.Text = "*";
         if (dXMax != Constant.rDUMMY)
            m_tbXMax.Text = dXMax.ToString();
         else
            m_tbXMax.Text = "*";
         if (dYMax != Constant.rDUMMY)
            m_tbYMax.Text = dYMax.ToString();
         else
            m_tbYMax.Text = "*";
      }

      private void XToolControl_ChangeLocation(double dX, double dY, double dZ)
      {
         m_bUpdating = true;

         if (dX != Constant.rDUMMY)
            m_tbX.Text = dX.ToString();
         else
            m_tbX.Text = "*";
         if (dY != Constant.rDUMMY)
            m_tbY.Text = dY.ToString();
         else
            m_tbY.Text = "*";
         if (dZ != Constant.rDUMMY)
            m_tbZ.Text = dZ.ToString();
         else
            m_tbZ.Text = "*";

         m_bUpdating = false;
      }

      private void XToolControl_ChangeProjection(CIPJ pIPJ)
      {
         double dbl = 0;
         String str = "";

         pIPJ.IGetDisplayName(ref str);
         m_lblPRJ.Text = str;

         pIPJ.IGetUnits(ref dbl, ref str);
         m_lblUnits.Text = str;
      }

      private void XToolControl_GeneralInfo(String szClass, String szInfo)
      {
         m_lblPRJ.Text = szClass;
         m_lblUnits.Text = szInfo;
      }


      private bool bGetTBDouble(System.Windows.Forms.TextBox tb, ref double d)
      {
         bool bRet = false;
         try
         {
            if (tb.Text == "*")
               d = Constant.rDUMMY;
            else
               d = Convert.ToDouble(tb.Text);

            bRet = true;
         }
         catch
         {
            MessageBox.Show("You must enter a valid number (or '*' for dummy).", "Number Entry Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tb.Focus();
         }

         return bRet;
      }

      private void m_tbXYZ_TextChanged(object sender, System.EventArgs e)
      {
         if (!m_bUpdating)
         {
            double dX = 0.0, dY = 0.0, dZ = 0.0;

            if (bGetTBDouble(m_tbX, ref dX) && bGetTBDouble(m_tbY, ref dY) && bGetTBDouble(m_tbZ, ref dZ))
               m_ChLocDel(dX, dY, dZ);
         }
      }
   }
}
