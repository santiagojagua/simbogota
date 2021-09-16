using System;
using System.Collections.Generic;
using System.Text;

namespace simbogotaClassLibrary
{
    public class tramite
    {
        int tipotramite { get; set; }
        public organismotransito organismotransito { get; set; }
        DateTime fechatramite { get; set; }
        public persona vendedor { get; set; }
        public persona comprador { get; set; }
        public vehiculo vehiculo { get; set; }
        string observaciones { get; set; }
    }
}
