using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GeoEngine.Core.GXNetX;
using GeoEngine.Core.GXNetX.Windows;
using Geosoft.Desktop.GXNetX;

namespace GoogleMapsTool
{
   /// <summary>
   /// Based on the work of Petr Zaburannyi who implemented this for ArcMap.
   /// More information can be found at the following links:
   ///
   /// http://arcscripts.esri.com/details.asp?dbid=15487
   /// http://zaburannyy.narod.ru/imap/google/arcgis/
   /// </summary>
   public partial class MapTool : ToolControl
   {
      private bool m_bEnabled = true;
      private CGXNETCore m_GEO;
      private CMETA m_META;
      CPJ m_PJ = null;
      private ChangeProjectionDelegate m_ChPrjDel;
      private ChangeLocationDelegate m_ChLocDel;
      private ChangeAreaDelegate m_ChAreaDel;

      public MapTool()
      {
         InitializeComponent();
      }

      protected override void Dispose(bool disposing)
      {
         if (m_PJ != null)
            m_PJ.Dispose();
         m_PJ = null;
         if (m_META != null)
            m_META.Dispose();
         m_META = null;
         if (m_GEO != null)
            m_GEO.Dispose();
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      public override bool bInitializeToolControl(CGXNETCore pGEO, CMETA pMETA, ChangeProjectionDelegate pChPrjDel, ChangeLocationDelegate pChLocDel, ChangeAreaDelegate pChAreaDel, ref string szName)
      {
         szName = "Google Maps Tool";

         m_GEO = pGEO;
         m_META = pMETA;
         m_ChPrjDel = pChPrjDel;
         m_ChLocDel = pChLocDel;
         m_ChAreaDel = pChAreaDel;

         return true;
      }

      private void toolStripButtonEnable_Click(object sender, EventArgs e)
      {
         m_bEnabled = true;
         toolStripButtonRefresh.Enabled = true;
      }

      private void toolStripButtonDisable_Click(object sender, EventArgs e)
      {
         m_bEnabled = false;
         toolStripButtonRefresh.Enabled = false;
      }

      private void toolStripButtonRefresh_Click(object sender, EventArgs e)
      {
         webBrowser.Refresh();
      }

      private void MapTool_ChangeArea(double dMinX, double dMinY, double dMaxX, double dMaxY)
      {
         if (m_bEnabled)
         {
            try
            {
               if (m_PJ != null)
                  m_PJ.ProjectBoundingRectangle(ref dMinX, ref dMinY, ref dMaxX, ref dMaxY);

               webBrowser.Navigate(String.Format(
                                      System.Globalization.CultureInfo.InvariantCulture,
                                      "http://yourwebsite.com/map.html?x1={0}&y1={1}&x2={2}&y2={3}",
                                      dMinX, dMinY, dMaxX, dMaxY));
            }
            catch
            {
               // Ignore errors
            }
         }
      }

      private void MapTool_ChangeProjection(CIPJ IPJ)
      {
         if (m_bEnabled)
         {
            if (m_PJ != null)
               m_PJ.Dispose();
            m_PJ = CPJ.CreateIPJ(m_GEO, IPJ, null);
         }
         IPJ.Dispose();
      }
   }
}
