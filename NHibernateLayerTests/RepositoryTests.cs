using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutoRepair.DataAccess.Entities;
using AutoRepair.DataAccess.NHibernate;
using FluentAssertions;
using NHibernate;
using NHibernate.Impl;
using Xunit;

namespace NHibernateLayerTests
{
    public class RepositoryTests
    {
        private const string _connectionString = @"Server = localhost; Port = 3306; Database = autorepair; Uid = pmu; Pwd = 55367390; Pooling=true;";

        [Fact]
        public void Add_5_Clients()
        {
            var helper = new NHibernateHelper(_connectionString);
            for (int i = 0; i < 5; i++)
            {
                var repository = new Repository<Client>(helper.SessionFactory);
                repository.Add(new Client
                {
                    FirstName = $"Client {i + 1}",
                    LastName = $"LastName Client {i + 1}",
                    MobilePhone = (i + 10).ToString(),
                    Nit = (i+100).ToString(),
                    Phone = (i+1000).ToString()
                });
            }
        }

        [Fact]
        public void Add_5_Categories()
        {
            var helper = new NHibernateHelper(_connectionString);
            for (int i = 1; i < 6; i++)
            {
                var repository = new Repository<Category>(helper.SessionFactory);
                repository.Add(new Category
                {
                    Name = "Category " + i
                });
            }
        }

        [Fact]
        public void Add_5_ProductMakes()
        {
            var helper = new NHibernateHelper(_connectionString);
            for (int i = 1; i < 6; i++)
            {
                var repository = new Repository<Make>(helper.SessionFactory);
                repository.Add(new Make
                {
                    Name = "Make " + i
                });
            }
        }

        [Fact]
        public void Add_5_Products()
        {
            var helper = new NHibernateHelper(_connectionString);
            for (int i = 1; i < 6; i++)
            {
                var repository = new Repository<Product>(helper.SessionFactory);
                repository.Add(new Product
                {
                    Code = "Code " + i,
                    Name = "Product " + i,
                    Description = "Description for product " + i,
                    CostPrice = (decimal) 10.5 + i,
                    SalePrice = (decimal)10.5 + i,
                    Stock = (decimal) 100 + i,
                    Category = new Category
                    {
                        Id = i,
                        Name = "Category " + i
                    },
                    Make = new Make
                    {
                        Id = i,
                        Name = "Make " + i
                    }
                });
            }
        }

        [Fact]
        public void Get_All_Products()
        {
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<Product>(helper.SessionFactory);
            var listProducts = repository.All().ToList();
            listProducts.Count().Should().BeGreaterThan(0);
            listProducts[0].Category.Should().NotBeNull();
        }

        [Fact]
        public void Get_All_VehicleMakesAndVehicleModelsRelated()
        {
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<VehicleMake>(helper.SessionFactory);
            var makes = repository.All().ToList();
            makes.Count().Should().BeGreaterThan(0);
            makes[0].VehicleModels.Should().NotBeNull();
        }

        [Fact]
        public void Get_All_VehicleModelsByMakeId()
        {
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<VehicleModel>(helper.SessionFactory);
            var vehicleModels = repository.FilterBy(x => x.VehicleMake.Id == 5);
            vehicleModels.Count().Should().BeGreaterThan(0);
            //makes[0].VehicleModels.Should().NotBeNull();
        }

        [Fact]
        public void Get_All_Vehicles()
        {
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<Vehicle>(helper.SessionFactory);
            var vehicles = repository.All().ToList();
            vehicles.Count().Should().BeGreaterThan(0);
            vehicles[0].Color.Should().NotBeNull();
            vehicles[0].MotorType.Should().NotBeNull();
            vehicles[0].Type.Should().NotBeNull();

        }

        [Fact]
        public void Get_All_Orders()
        {
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<WorkOrder>(helper.SessionFactory);
            var workOrders = repository.All().ToList();
            workOrders.Count().Should().BeGreaterThan(0);
        }

        [Fact]
        public void Add_200000_WorkOrders()
        {
            
            var helper = new NHibernateHelper(_connectionString);
            var repository = new Repository<WorkOrder>(helper.SessionFactory);
            var clientList = new List<Client>();
            var vehicleList = new List<Vehicle>();
            var productList = new List<Product>();

            for (int i = 1; i <= 200000; i++)
            {
                var idCreated = repository.AddAndReturnIdCreated(new WorkOrder
                {
                    Client = GetClient(ref clientList, helper),
                    Date = GetDate(),
                    Description = GetDescriptionRandomly(),
                    Status = WorkOrderStatus.Finalized,
                    Vehicle = GetVehicle(ref vehicleList, helper),
                });
                
                var workOrder = repository.FindBy(idCreated);

                workOrder.WorkOrderDetails = GetWorkOrderDetails(ref productList, workOrder,helper);
                workOrder.ServiceCosts = GetServiceCosts(workOrder);

                repository.Merge(workOrder);
                
                Console.WriteLine("WorkOrder " + i + " Created.");

            }

        }

        private string GetDescriptionRandomly()
        {
            var descriptions = new List<string>
            {
                @"This forum is now a read-only archive. All commenting, posting, registration services have been turned off. Those needing community support and/or wanting to ask questions should refer to the Tag/Forum map, and to http://spring.io/questions for a curated list of stackoverflow tags that Pivotal engineers, and the community, monitor.",
                @"Hey, I'm currently working on the crafting system for my game. I have an item database, recipe database, and an inventory. Inside the recipe database, I have a list of Items that the player must have inside their inventory to craft the item.",
                @"You need to take a time and study some basic algoritms. Some simple programing tutorial will teach you some basic algorithms like this. For example, I found this: http://forum.unity3d.com/threads/185095-Unity-C-Tutorial-Series I wrote a sample js (not compiled) script that do something like it.",
                @"If I step that loop with the debugger during runtime I get different values (which is what I want). However, if I put a breakpoint two lines below that code, all members of the mac array have equal value.",
                @"Every time you do new Random() it is initialized using the clock. This means that in a tight loop you get the same value lots of times. You should keep a single Random instance and keep using Next on the same instance.",
                @"Basically, Next is going to change the internal state of the Random instance. If we do that at the same time from multiple threads, you could argue we've just made the outcome even more random, but what we are actually doing is potentially breaking the internal implementation, and we could also start getting the same numbers from different threads, which might be a problem - and might not. The guarantee of what happens internally is the bigger issue, though; since Random does not make any guarantees of thread-safety. Thus there are two valid approaches",
                @"Certainly; it synchronizes access, so that if multiple threads are calling your static RandomNumber method, they don't trip over each-other and cause an error. Only one thread will ever be inside the lock statement at once, since they are all sharing a single lock object (syncLock).",
                @"As a general rule, all static methods should be made thread-safe, since it is hard to guarantee that multiple threads won't call it at the same time. It is not usually necessary to make instance (i.e. non-static) methods thread-safe",
                @"Florin - there is no difference re stack based between the two. Static fields are just as much external state, and will absolutely be shared between callers. With instances, there is a good chance that different threads have different instances (a common pattern). With statics, it is guaranteed that they all share (not including [ThreadStatic])",
                @"Agreed, this solves the locking problem, but isn't this still a highly complicated solution to a trivial problem: that you need to write ''two'' lines of code to generate a random number instead of one. Is this really worth it to save reading one simple line of code?",
                @"if you cannot prove the uniformity of Guid generation , then it is wrong to use it as random (and the Hash would be another step away from uniformity). Likewise, collisions aren't an issue: uniformity of collision is. Concerning the Guid generation not being on hardware anymore I'm going to RTFM, my bad (any reference?)"
            };

            return descriptions[StaticRandom.Instance.Next(descriptions.Count)];
        }

        private IList<ServiceCost> GetServiceCosts(WorkOrder workOrder)
        {
            return new List<ServiceCost>
            {
                new ServiceCost
                {
                    WorkOrder = workOrder,
                    Description = @"Every time you do new Random() it is initialized . This means that in a tight loop you get the same value lots of times.",
                    Cost = StaticRandom.Instance.Next(10,100)

                },
                 new ServiceCost
                {
                    WorkOrder = workOrder,
                    Description = @"For more information, look at the Random class, though please note.",
                    Cost = StaticRandom.Instance.Next(10,100)

                },
                  new ServiceCost
                {
                    WorkOrder = workOrder,
                    Description = @"However, because the clock has finite resolution, using the parameterless constructor to create different Random objects.",
                    Cost = StaticRandom.Instance.Next(10,100)

                },
                   new ServiceCost
                {
                    WorkOrder = workOrder,
                    Description = @"No need to seed the random - it does that on creation.",
                    Cost = StaticRandom.Instance.Next(10,100)

                },
                new ServiceCost
                {
                    WorkOrder = workOrder,
                    Description = @"You could use Jon Skeet's StaticRandom method inside the MiscUtil class library that he built for a pseudo-random number.",
                    Cost = StaticRandom.Instance.Next(10,100)

                }
            };
        }

        private IList<WorkOrderDetail> GetWorkOrderDetails(ref List<Product> products, WorkOrder workOrder, NHibernateHelper helper)
        {
            
            if (!products.Any())
            {
                var repository = new Repository<Product>(helper.SessionFactory);
                var list = new List<int> {23, 24, 25, 27, 28, 29, 30, 31};
                products = repository.FilterBy(x => list.Contains(x.Id)).ToList();

            }

            //var random = new Random();
            return new List<WorkOrderDetail>
            {
                new WorkOrderDetail
                {
                    WorkOrder = workOrder,
                    Product = products[StaticRandom.Instance.Next(products.Count)],
                    Quantity = StaticRandom.Instance.Next(1,10),
                    SalePrice = StaticRandom.Instance.Next(1,10),
                    CostPrice = StaticRandom.Instance.Next(11,15),
                },
                new WorkOrderDetail
                {
                    WorkOrder = workOrder,
                    Product = products[StaticRandom.Instance.Next(products.Count)],
                    Quantity = StaticRandom.Instance.Next(1,10),
                    SalePrice = StaticRandom.Instance.Next(1,10),
                    CostPrice = StaticRandom.Instance.Next(11,15),
                },
                new WorkOrderDetail
                {
                    WorkOrder = workOrder,
                    Product = products[StaticRandom.Instance.Next(products.Count)],
                    Quantity = StaticRandom.Instance.Next(1,10),
                    SalePrice = StaticRandom.Instance.Next(1,10),
                    CostPrice = StaticRandom.Instance.Next(11,15),
                },
                new WorkOrderDetail
                {
                    WorkOrder = workOrder,
                    Product = products[StaticRandom.Instance.Next(products.Count)],
                    Quantity = StaticRandom.Instance.Next(1,10),
                    SalePrice = StaticRandom.Instance.Next(1,10),
                    CostPrice = StaticRandom.Instance.Next(11,15),
                },
                new WorkOrderDetail
                {
                    WorkOrder = workOrder,
                    Product = products[StaticRandom.Instance.Next(products.Count)],
                    Quantity = StaticRandom.Instance.Next(1,10),
                    SalePrice = StaticRandom.Instance.Next(1,10),
                    CostPrice = StaticRandom.Instance.Next(11,15),
                }
            };
        }

        private Vehicle GetVehicle(ref List<Vehicle> vehicles, NHibernateHelper helper)
        {
            if (!vehicles.Any())
            {
                var repository = new Repository<Vehicle>(helper.SessionFactory);
                var list = new List<int> { 1, 2, 8, 9 };
                vehicles = repository.FilterBy(x => list.Contains(x.Id)).ToList();

            }
            //var random = new Random();
            var index = StaticRandom.Instance.Next(vehicles.Count);
            return vehicles[index];
        }

        private DateTime GetDate()
        {
            //var random = new Random();
            var month = StaticRandom.Instance.Next(1, 13);
            var day = StaticRandom.Instance.Next(1, 29);
            var year = StaticRandom.Instance.Next(2016, 2020);
            return new DateTime(year,month,day);
        }

        private Client GetClient(ref List<Client> clients, NHibernateHelper helper)
        {
            if (!clients.Any())
            {
                var repository = new Repository<Client>(helper.SessionFactory);
                var list = new List<int> {11, 24, 25, 26};
                clients = repository.FilterBy(x => list.Contains(x.Id)).ToList();
                
            }
            //var random = new Random();
            //var index = random.Next(clients.Count);
            var index = StaticRandom.Instance.Next(clients.Count);
            return clients[index];
        }
    }


    public static class StaticRandom
    {
        private static int seed;

        private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
            (() => new Random(Interlocked.Increment(ref seed)));

        static StaticRandom()
        {
            seed = Environment.TickCount;
        }

        public static Random Instance { get { return threadLocal.Value; } }
    }
}