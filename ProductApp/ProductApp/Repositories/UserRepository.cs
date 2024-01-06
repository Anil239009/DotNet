using ProductApp.Models;
namespace ProductApp.Repositories;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class UserRepositoryManager
{
    public void Serialize(List<User> users,string fileName){

    var options=new JsonSerializerOptions {IncludeFields=true};
    var UserJson=JsonSerializer.Serialize<List<User>>(users,options);
    File.WriteAllText(fileName,UserJson);
   
    }
    public List<User> DeSerialize(string fileName){
   
         //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<User> NewUser = JsonSerializer.Deserialize<List<User>>(jsonString);
              
        return NewUser;
    }
}