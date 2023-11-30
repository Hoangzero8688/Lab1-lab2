using ExamNet104.Context;
using Lab2.Context;
using Lab2.Models;

namespace Lab2.Repo
{
    public class ProductRepo: IProductRepo
    {

        private readonly MyDbContext _context;

        public ProductRepo(MyDbContext myDbConext)
        {
            _context = myDbConext;
        }

        public void Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _context.Products.FirstOrDefault(p => p.Id == id);
            _context.Remove(rs);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            var result =  _context.Products.ToList();
            return result;
        }

        public Product GetbyID(int id)
        {
            var results = _context.Products.FirstOrDefault(p => p.Id == id);
            return results;
        }

        public void Update(Product product, int id)
        {

            _context.Update(product);
            _context.SaveChanges();
        }
    }
}
