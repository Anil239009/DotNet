

using ProductApp.Models;
using ProductApp.Repositories;
namespace ProductApp.Services;

public class UserService:IUserService{

     List<User> users =new List<User>();
     UserRepositoryManager mgr=new USerRepositoryManager();
    string fileName=@"D:\DotNet\DotNet\ProductApp\User.json";
    public List<User> GetAll()
    {
        users=mgr.DeSerialize(fileName);
        return users;
    }

    public User GetBYId(int id){
        prod=mgr.DeSerialize(fileName);
        User product=prod.Find(p=>p.Id==id);
        return product;
    }

    public List<User> AddNewUser(User prod){
        List<User> produts=new List<User>();
        // prod.Add(new Product{Id=1, Title="Pen", Price=20.0f});
        // prod.Add(new Product{Id=2, Title="Book", Price=100.0f});
        // prod.Add(new Product{Id=3, Title="Marker", Price=40.0f});
        RepositoryManager mgr=new RepositoryManager();
        string fileName=@"D:\DotNet\DotNet\ProductApp\product.json";
        produts=mgr.DeSerialize(fileName);
        produts.Add(prod);
        mgr.Serialize(produts,fileName);
        return produts;
    }
}