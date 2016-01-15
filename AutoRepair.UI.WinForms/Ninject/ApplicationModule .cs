using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.Infrastructure;
using AutoRepair.DataAccess.NHibernate;
using NHibernate;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using System.Configuration;
using AutoRepair.Business.Services;

namespace AutoRepair.UI.Ninject
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AutoRepairDb"].ConnectionString;

            NHibernateHelper helper = new NHibernateHelper(connectionString);
            Bind<ISessionFactory>().ToConstant(helper.SessionFactory)
                .InSingletonScope();

            //Bind<IUnitOfWork>().To<UnitOfWork>()
            //.InTransientScope() ;

            //Bind<ISession>().ToProvider(new SessionProvider())
            //.InTransientScope();

            Bind<IIntKeyedRepository<Client>>().To<Repository<Client>>()
            .InTransientScope();
            Bind<IClientManagementService>().To<ClientManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<Product>>().To<Repository<Product>>()
            .InTransientScope();
            Bind<IProductManagementService>().To<ProductManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<Category>>().To<Repository<Category>>()
            .InTransientScope();
            Bind<ICategoryManagementService>().To<CategoryManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<Make>>().To<Repository<Make>>()
            .InTransientScope();
            Bind<IMakeManagementService>().To<MakeManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<Color>>().To<Repository<Color>>()
            .InTransientScope();
            Bind<IColorManagementService>().To<ColorManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<MotorType>>().To<Repository<MotorType>>()
            .InTransientScope();
            Bind<IMotorTypeManagementService>().To<MotorTypeManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<VehicleType>>().To<Repository<VehicleType>>()
            .InTransientScope();
            Bind<IVehicleTypeManagementService>().To<VehicleTypeManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<Vehicle>>().To<Repository<Vehicle>>()
            .InTransientScope();
            Bind<IVehicleManagementService>().To<VehicleManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<VehicleMake>>().To<Repository<VehicleMake>>()
            .InTransientScope();
            Bind<IVehicleMakeManagementService>().To<VehicleMakeManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<VehicleModel>>().To<Repository<VehicleModel>>()
            .InTransientScope();
            Bind<IVehicleModelManagementService>().To<VehicleModelManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<TransmissionType>>().To<Repository<TransmissionType>>()
            .InTransientScope();
            Bind<ITransmissionTypeManagementService>().To<TransmissionTypeManagementService>()
            .InTransientScope();

            Bind<IIntKeyedRepository<ServiceCost>>().To<Repository<ServiceCost>>()
            .InTransientScope();

            Bind<IIntKeyedRepository<WorkOrder>>().To<Repository<WorkOrder>>()
            .InTransientScope();
            Bind<IWorkOrderManagementService>().To<WorkOrderManagementService>()
            .InTransientScope();

        }
    }

    public class SessionProvider : Provider<ISession>
    {
        protected override ISession CreateInstance(IContext context)
        {
            UnitOfWork unitOfWork = (UnitOfWork)context.Kernel.Get<IUnitOfWork>();
            return unitOfWork.Session;
            
        }
    }
}