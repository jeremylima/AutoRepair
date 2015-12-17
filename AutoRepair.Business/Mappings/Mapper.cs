using System.Diagnostics;
using AutoRepair.Business.Models;

namespace AutoRepair.Business.Mappings
{
    public class Mapper
    {
        public static void CreateMaps()
        {
            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Client, Client>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Product, Product>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Product, ProductConsult>()
                .ForMember(dest => dest.Category,
                    opts => opts.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.Make,
                    opts => opts.MapFrom(src => src.Make.Name))
                ;

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Category, Category>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Make, Make>().ReverseMap();


            AutoMapper.Mapper.AssertConfigurationIsValid();
        }

    }
}