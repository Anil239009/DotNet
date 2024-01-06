using ProductApp.Models;

namespace ProductApp.Services;

public interface IUserService{
    public List<Product> GetAll();

     public Product GetBYId(int id);

     public List<Product> AddNewUser(Product prod); 
        
    
}