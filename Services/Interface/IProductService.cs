using northwind_project.Models;

namespace northwind_project.Services.Interface
{
    public interface IProductService
    {
        public List<Product> GetProducts();

        public Product GetProductById(int id);

    }
}
