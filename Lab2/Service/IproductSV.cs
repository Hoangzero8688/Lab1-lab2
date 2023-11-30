using Lab2.Models;

namespace Lab2.Service
{
    public interface IproductSV
    {
        public IEnumerable<Product> GetAll();

        Product GetbyID(int id);

        public void Delete(int id);

        public void Update(Product product, int id);

        public void Add(Product product);
    }
}
