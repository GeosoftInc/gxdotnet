using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using GeoEngine.Core.GXNet;
using Geosoft.Desktop.GXNet;

namespace GoogleMapsTool
{
    public class MapGX : CGX_NET
    {
        public MapGX(IntPtr pGeo) : base (pGeo)
        {
        }

        [CGXAttribute("")]
        public void AddGMapsTool()
        {
            CMETA hMETA = CMETA.Create();
            CGUI.LaunchGeoDOTNETXTool("GoogleMapsTool.dll", "GoogleMapsTool.MapTool", hMETA);
        }
    }
}
