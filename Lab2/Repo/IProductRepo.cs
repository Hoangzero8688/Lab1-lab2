using ExamNet104.Context;
using Lab2.Models;

namespace Lab2.Repo
{
    public interface  IProductRepo
    {
        public IEnumerable<Product> GetAll();

        Product GetbyID (int id);

        public void Delete(int id);

        public void Update(Product product, int id);

        public void Add(Product product);
    }
}
