using ProductApp.Models;
namespace ProductApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class RepositoryManager{
    public void Serialize(List<Product> products,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var ProductJson=JsonSerializer.Serialize<List<Product>>(products,options);
    File.WriteAllText(fileName,ProductJson);
   
    }
    public List<Product> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Product> NewProduct = JsonSerializer.Deserialize<List<Product>>(jsonString);
              
        return NewProduct;
    }
}