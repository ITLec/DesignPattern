

namespace ITLec.MainProject
{
    using System;
    using System.Collections.Generic;
    using ITLec.BusinessLogic;
    using ITLec.DAL;
    using ITLec.Sql;
    using ITLec.BusinessLogicMock;
    class Program
    {
        static void Main(string[] args)
        {
            ServiceLocator.Reset();
            ServiceLocator.Register< IProductRepository>(new SqlProductRepository());

            ServiceLocator.Register< IProductService>(new ProductService(ServiceLocator.GetService<  IProductRepository>()));


            IProductService service = ServiceLocator.GetService< IProductService>();

         var allProducts=   service.GetAllProducts();


        }
    }

    public static class ServiceLocator
    {
        private static Dictionary< Type, object> services =
            new Dictionary< Type, object>();

        public static void Register< T>(T service)
        {
            services[typeof(T)] = service;
        }

        public static T GetService< T>()
        {
            return (T)services[typeof(T)];
        }
        public static void Reset()
        {
            services.Clear();
        }
    }

}

namespace ITLec.DAL
{
    using System;
    using System.Collections.Generic;
    public class Product
    {
        public string ProductName { get; set; }
    }
    public interface IProductRepository
    {
        IEnumerable< Product> GetAllProducts();
    }
}

namespace ITLec.BusinessLogic
{
    using System.Collections.Generic;
    using ITLec.DAL;

    public interface IProductService
    {
        IEnumerable< Product> GetAllProducts();
    }

}

namespace ITLec.Sql
{
    using System;
    using System.Collections.Generic;
    using ITLec.DAL;
    public class SqlProductRepository : IProductRepository
    {
        public IEnumerable< Product> GetAllProducts()
        {
            List< Product> products = new List< Product>();
            products.Add(new Product { ProductName = "RasheedProduct" });
            products.Add(new Product { ProductName = "GomaaProduct" });
            return products;
        }
    }

}

namespace ITLec.BusinessLogicMock
{
    using System;
    using System.Collections.Generic;
    using ITLec.DAL;
    using ITLec.BusinessLogic;
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("Repository");
            }
            this.repository = repository;
        }

        public IEnumerable< Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }
    }

}
