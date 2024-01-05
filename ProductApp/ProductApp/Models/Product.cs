namespace ProductApp.Models;

[Serializable]
public class Product{
    public int Id{get;set;}

    public string Title{get;set;}

    public float Price{get;set;}

    // public Product(int id,string title,float price){
    //     this.Id=id;
    //     this.Title=title;
    //     this.Price=price;
    // }
}