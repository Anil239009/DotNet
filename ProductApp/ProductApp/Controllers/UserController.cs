using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Services;

public class USerController:Controller{

    private IProductService _psvc;
    public ProductController(IProductService psvc){
        this._psvc=psvc;
    }
    [HttpGet]
    public IActionResult Index(){
        List<Product>products=_psvc.GetAll();
        ViewData["products"]=products;
         return View();
    }
    [HttpPost]
    public IActionResult Index(Product prod){
      
         return View();
    }
    [HttpGet]
    public IActionResult Details(int id){
        Product product=this._psvc.GetBYId(id);
        ViewData["product"]=product;
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(int Prodid, string prodname,float Prodprice){
        // Console.WriteLine(prod.Id+" "+prod.Title);
        List<Product>products=this._psvc.AddNewProduct(new Product{Id=Prodid, Title=prodname, Price=Prodprice});
        ViewData["products"]=products;
        return View();
    }

    
}