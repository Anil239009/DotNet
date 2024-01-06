

using ProductApp.Models;
using ProductApp.Repositories;
namespace ProductApp.Services;

public class ProductService:IProductService{

    public List<Product> GetAll()
    {
        List<Product> prod=new List<Product>();
        // prod.Add(new Product{Id=1, Title="Pen", Price=20.0f});
        // prod.Add(new Product{Id=2, Title="Book", Price=100.0f});
        // prod.Add(new Product{Id=3, Title="Marker", Price=40.0f});
        RepositoryManager mgr=new RepositoryManager();
        string fileName=@"D:\DotNet\DotNet\ProductApp\product.json";
        prod=mgr.DeSerialize(fileName);
        return prod;
    }

    public Product GetBYId(int id){
         List<Product> prod=new List<Product>();
        // prod.Add(new Product{Id=1, Title="Pen", Price=20.0f});
        // prod.Add(new Product{Id=2, Title="Book", Price=100.0f});
        // prod.Add(new Product{Id=3, Title="Marker", Price=40.0f});
        RepositoryManager mgr=new RepositoryManager();
        string fileName=@"C:\Users\dac\Desktop\vaibhav_anil\DotNet\ProductApp\product.json";
        prod=mgr.DeSerialize(fileName);
        Product product=prod.Find(p=>p.Id==id);
        return product;
    }

    public List<Product> AddNewProduct(Product prod){
        List<Product> produts=new List<Product>();
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