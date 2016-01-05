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

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Color, Color>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.MotorType, MotorType>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleType, VehicleType>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleModel, VehicleModel>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Vehicle, Vehicle>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Vehicle, VehicleConsult>()
                .ForMember(dest => dest.Color,
                    opts => opts.MapFrom(src => src.Color.Name))
                .ForMember(dest => dest.MotorType,
                    opts => opts.MapFrom(src => src.MotorType.Name))
                .ForMember(dest => dest.Type,
                    opts => opts.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.Make,
                    opts => opts.MapFrom(src => src.Model.VehicleMake.Name))
                .ForMember(dest => dest.Model,
                    opts => opts.MapFrom(src => src.Model.Name))
                ;


            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Category, Category>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Make, Make>().ReverseMap();


            AutoMapper.Mapper.AssertConfigurationIsValid();
        }

    }
}