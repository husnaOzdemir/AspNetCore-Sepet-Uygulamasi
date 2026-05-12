using WebApplication10.Models;

namespace WebApplication10.Data
{
    public interface IDatabase
    {
        List<Product> GetAll();
        Product Get(int id);
    }
}
