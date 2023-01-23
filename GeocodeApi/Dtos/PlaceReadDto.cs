using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeApi.Dtos
{
    public class PlaceReadDto
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string PlaceDesc { get; set; }
    }
}
