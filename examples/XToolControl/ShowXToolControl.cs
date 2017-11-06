using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoEngine.Core.GXNet;
using Geosoft.Desktop.GXNet;


namespace TestXToolControl
{
   public class ShowXToolControl : IDisposable
   {
      protected CGXNETCore m_hGxNet;

      public ShowXToolControl(IntPtr pGeo)
      {
         m_hGxNet = new CGXNETCore(pGeo);
      }

      public void Dispose()
      {
         if (m_hGxNet != null)
            m_hGxNet.Dispose();
         m_hGxNet = null;
      }

      [CGXAttribute("")]
      public void Show()
      {
         using (var meta = CMETA.Create())
            CGUI.LaunchSingleGeoDOTNETXToolEx("XToolControl.dll", "TestXToolControl.XToolControl", meta, XTOOL_ALIGNConstant.ANY, XTOOL_DOCKConstant.RIGHT, 200, 328);
      }
   }
}
