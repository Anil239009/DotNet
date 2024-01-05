using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Services;

public class ProductController:Controller{

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
    [HttpGet]
    public IActionResult Details(int id){
        Product product=this._psvc.GetBYId(id);
        ViewData["product"]=product;
        return View();
    }

    public IActionResult AddProduct(){
        return View();
    }
}