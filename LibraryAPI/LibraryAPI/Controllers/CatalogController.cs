using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILibraryAsset _assets;
        private readonly IMapper _mapper;

        public CatalogController(ILibraryAsset assets, IMapper mapper)
        {
            _assets = assets;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var assets = await _assets.GetAll();

            var assetsToReturn = _mapper.Map<IEnumerable<AssetForListDto>>(assets);

            return Ok(assetsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsset(int id)
        {
            var asset = await _assets.GetAsset(id);

            var assetToReturn = _mapper.Map<AssetForDetailedDto>(asset);

            return Ok(assetToReturn);
            

            //14:12 in video, detail.cshtml
        }
    }
}