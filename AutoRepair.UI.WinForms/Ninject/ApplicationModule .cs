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