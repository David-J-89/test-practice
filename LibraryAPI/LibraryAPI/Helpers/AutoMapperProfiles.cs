using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryAPI.Dtos;
using LibraryAPI.Models;




namespace LibraryAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<LibraryAsset, AssetForListDto>();

            CreateMap<LibraryAsset, AssetForDetailedDto>();
        }
    }
}
