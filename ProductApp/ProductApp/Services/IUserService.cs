using ProductApp.Models;

namespace ProductApp.Services;

public interface IUserService{
    public List<User> GetAll();

     public User GetBYId(int id);

     public List<User> AddNewUser(User prod); 
        
    
}