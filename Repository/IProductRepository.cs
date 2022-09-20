using ProductMicroservice.Model;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

       Product GetProductByID(int ProductId);

       void InsertProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int ProductId);

        void Save();
    }
}
