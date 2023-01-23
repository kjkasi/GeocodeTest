using GeocodeApi.Contexts;
using GeocodeApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeApi.Repository
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly AppDbContext _context;

        public PlaceRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<Place> CreatePlaceAsync(Place place)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePlaceAsync(int PlaceId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Place>> GetAllPlaceAsync()
        {
            return await _context.PlaceItems.ToListAsync();
        }

        public Task<Place> GetPlaceAsync(int PlaceId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Place>> SearchPlaceByText(string searchText)
        {
            var items = await _context.PlaceItems.Where(x => EF.Functions.Like(x.Name, $"%{searchText}%")).ToListAsync();
            return items;
        }
    }
}
