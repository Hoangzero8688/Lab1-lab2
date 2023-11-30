using Lab2.Models;
using Lab2.Repo;

namespace Lab2.Service
{
    public class ProductService : IproductSV
    {
        private readonly IProductRepo _repo;

        public ProductService(IProductRepo productRepo) 
        {
              _repo = productRepo;
        }

        public void Add(Product product)
        {
            _repo.Add(product);
        }

        public void Delete(int id)
        {
           _repo.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
      
            return _repo.GetAll();
        }

        public Product GetbyID(int id)
        {
            return _repo.GetbyID(id);
        }

        public void Update(Product product, int id)
        {
            _repo.Update(product, id);
        }
    }
}
