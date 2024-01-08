

using Microsoft.Extensions.Configuration.UserSecrets;
using ProductApp.Models;
using ProductApp.Repositories;
namespace ProductApp.Services;

public class UserService:IUserService{

     List<User> users =new List<User>();
     UserRepositoryManager mgr=new UserRepositoryManager();
    string fileName=@"D:\DotNet\DotNet\ProductApp\User.json";
    public List<User> GetAll()
    {
        users=mgr.DeSerialize(fileName);
        return users;
    }

    public User GetBYId(int id){
        users=mgr.DeSerialize(fileName);
        User User=users.Find(p=>p.Id==id);
        return User;
    }

    public List<User> AddNewUser(User user){
        List<User> users=new List<User>();
        // prod.Add(new Product{Id=1, Title="Pen", Price=20.0f});
        // prod.Add(new Product{Id=2, Title="Book", Price=100.0f});
        // prod.Add(new Product{Id=3, Title="Marker", Price=40.0f});
        UserRepositoryManager mgr=new UserRepositoryManager();
        string fileName=@"D:\DotNet\DotNet\ProductApp\product.json";
        users=mgr.DeSerialize(fileName);
        users.Add(user);
        mgr.Serialize(users,fileName);
        return users;
    }
}