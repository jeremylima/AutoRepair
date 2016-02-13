using System.Diagnostics;
using System.Runtime.Remoting.Channels;
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

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.User, User>()
                .ForMember(dest => dest.Password,
                    opts => opts.Ignore())
                ;

            AutoMapper.Mapper.CreateMap<User,DataAccess.Entities.User>()
                .ForMember(dest => dest.Hash,
                    opts => opts.Ignore())
                .ForMember(dest => dest.Salt,
                    opts => opts.Ignore())
                ;


            AutoMapper.Mapper.CreateMap<DataAccess.Entities.MotorType, MotorType>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleType, VehicleType>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleModel, VehicleModel>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleModel, VehicleModelConsult>()
                .ForMember(dest => dest.VehicleMake,
                    opts => opts.MapFrom(src => src.VehicleMake.Name))
                .ForMember(dest => dest.VehicleMakeId,
                    opts => opts.MapFrom(src => src.VehicleMake.Id))
                ;

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleMake, VehicleMake>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.TransmissionType, TransmissionType>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.VehicleMake, VehicleMakeConsult>().ReverseMap();

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
                .ForMember(dest => dest.TransmissionType,
                    opts => opts.MapFrom(src => src.TransmissionType.Name))
                ;

            AutoMapper.Mapper.CreateMap<Vehicle, VehicleConsult>()
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
                .ForMember(dest => dest.TransmissionType,
                    opts => opts.MapFrom(src => src.TransmissionType.Name))
                ;

           

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Category, Category>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.Make, Make>().ReverseMap();

            /* AutoMapper.Mapper.CreateMap<DataAccess.Entities.WorkOrder, WorkOrder>().ReverseMap()
                 .ForMember(dest=>dest.)
                 ;*/

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.WorkOrder, WorkOrder>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.WorkOrderDetail, WorkOrderDetail>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.WorkOrderDetail, WorkOrderDetailConsult>()
                .ForMember(dest => dest.Product,
                    opts => opts.MapFrom(src => src.Product.Description))
                .ForMember(dest => dest.Code,
                    opts => opts.MapFrom(src => src.Product.Code))
                .ForMember(dest => dest.Id,
                    opts => opts.MapFrom(src => src.Product.Id))
                ;

            AutoMapper.Mapper.CreateMap<WorkOrderDetail, WorkOrderDetailConsult>()
                .ForMember(dest => dest.Product,
                    opts => opts.MapFrom(src => src.Product.Description))
                .ForMember(dest => dest.Code,
                    opts => opts.MapFrom(src => src.Product.Code))
                .ForMember(dest => dest.Id,
                    opts => opts.MapFrom(src => src.Product.Id))
                ;

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.ServiceCost, ServiceCost>().ReverseMap();

            AutoMapper.Mapper.CreateMap<DataAccess.Entities.WorkOrder, WorkOrderConsult>()
                .ForMember(dest => dest.FullClientName,
                    opts => opts.MapFrom(src => src.Client.FirstName + " " + src.Client.LastName))
                .ForMember(dest => dest.VehicleDescription,
                    opts => opts.MapFrom(src =>src.Vehicle.Model.VehicleMake.Name + " " + src.Vehicle.Model.Name + " " + src.Vehicle.Type.Name + " " + src.Vehicle.Color.Name + " - " + src.Vehicle.LicensePlate))
                .ForMember(dest => dest.User,
                    opts => opts.MapFrom(src => src.User.Name))
                ;


            AutoMapper.Mapper.AssertConfigurationIsValid();
        }

    }
}