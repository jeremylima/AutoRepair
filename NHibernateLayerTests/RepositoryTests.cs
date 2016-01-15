using System.Linq;
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

    }
}