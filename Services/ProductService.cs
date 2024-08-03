using northwind_project.Data;
using northwind_project.Models;
using northwind_project.Services.Interface;

namespace northwind_project.Services
{
    public class ProductService : IProductService
    {
        private readonly NorthwindContext _northwindContext;

        public ProductService(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
