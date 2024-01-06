using ProductApp.Models;

namespace ProductApp.Services;

public interface IProductService{
    public List<Product> GetAll();

     public Product GetBYId(int id);

     public List<Product> AddNewProduct(Product prod); 
        
    
}