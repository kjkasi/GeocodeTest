using GeocodeApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeocodeApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly ILogger<PlaceController> _logger;
        private readonly IPlaceRepository _placeRepository;

        public PlaceController(ILogger<PlaceController> logger, IPlaceRepository placeRepository)
        {
            _logger = logger;
            _placeRepository = placeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPlacesAsync()
        {
            var items = await _placeRepository.GetAllPlaceAsync();
            return Ok(items);
        }

        [HttpGet]
        public async Task<ActionResult> SearchPlaceAsync(string searchText)
        {
            var items = await _placeRepository.SearchPlaceByText(searchText);
            return Ok(items);
        }
    }
}
