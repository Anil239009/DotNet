
using MySql.Data.MySqlClient;
using ProductApp.Models;
namespace HRAPP.Repositories.Connected;

public class ProductDBManager{
    public ProductDBManager(){}
    public List<Product> GetAll(){
        List<Product> products=new List<Product>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=iacsd0923";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText="SELECT * from product";
        try{
            con.Open();
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read()){
                int id= int.Parse(reader["pid"].ToString());
                string?  name= reader["name"].ToString();
                float  price=float.Parse(reader["price"].ToString());
                Product prod=new Product();
                prod.Id=id;
                prod.Title=name;
                prod.Price=price;
               products.Add(prod);
            } 
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }
        return products;
    }
    public  Product GetById(int id){

        Console.WriteLine(" Getting Employee Details");
        Product  product=new Product();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=@"server=localhost; port=3306; user=root; password=root123; database=transflower";
        MySqlCommand cmd=new MySqlCommand();
        cmd.Connection=con;
        cmd.CommandText="SELECT * from product WHERE pid="+ id;
        try{
            con.Open();
            MySqlDataReader reader=cmd.ExecuteReader();
            if(reader.Read()){
                int id1= int.Parse(reader["pid"].ToString());
                string?  name= reader["name"].ToString();
                float  price=float.Parse(reader["price"].ToString());
                Product prod=new Product();
                prod.Id=id1;
                prod.Title=name;
                prod.Price=price;  
            } 
            reader.Close();
        }
        catch(Exception e){
            
        }
        finally{
            con.Close();
        }
        return product;
    }
}