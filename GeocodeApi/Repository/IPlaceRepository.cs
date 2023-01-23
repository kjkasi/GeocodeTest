using GeocodeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeApi.Repository
{
    public interface IPlaceRepository
    {
        public Task<IEnumerable<Place>> GetAllPlaceAsync();
        public Task<Place> GetPlaceAsync(int PlaceId);
        public Task<Place> CreatePlaceAsync(Place place);
        public Task<bool> DeletePlaceAsync(int PlaceId);
        public Task<IEnumerable<Place>> SearchPlaceByText(string searchText);

    }
}
