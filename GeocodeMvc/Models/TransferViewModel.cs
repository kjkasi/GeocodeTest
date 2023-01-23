using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeMvc.Models
{
    public class TransferViewModel
    {
        public PlaceModelView Source { get; set; }
        public PlaceModelView Destination { get; set; }
    }
}
