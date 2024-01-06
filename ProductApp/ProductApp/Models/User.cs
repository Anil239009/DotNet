namespace ProductApp.Models;

[Serializable]
public class User{
    public int Id{get;set;}

    public string Name{get;set;}

    public float Email{get;set;}

    // public Product(int id,string title,float price){
    //     this.Id=id;
    //     this.Title=title;
    //     this.Price=price;
    // }
}