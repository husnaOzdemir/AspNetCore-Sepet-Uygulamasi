using WebApplication10.Models;

namespace WebApplication10.Data
{
    public class YDatabase : IDatabase
    {
        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        public Product Get(int id)
        {
            return new Product();
        }


    }
}
