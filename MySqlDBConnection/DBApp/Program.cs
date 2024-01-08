
using MySql.Data.MySqlClient;
Console.WriteLine("Gettting started with .net DB");
MySqlConnection con=new MySqlConnection();
con.ConnectionString=@"server=localhost; port=3306; user=root; password=password; database=transflower";
MySqlCommand cmd=new MySqlCommand();
cmd.Connection=con;
//cmd.CommandText="INSERT INTO departments (name, location) values('sales','Delhi')";
//cmd.CommandText="DELETE from departments  WHERE id=8";
cmd.CommandText="UPDATE departments SET location='Chennai' WHERE id=5";
//cmd.CommandText="SELECT * from departments Where id=2";
try{
    con.Open();
   /*MySqlDataReader reader=cmd.ExecuteReader();
    while(reader.Read()){
        int id= int.Parse(reader["id"].ToString());
        string?  name= reader["name"].ToString();
        string?  location= reader["location"].ToString();
        Console.WriteLine( "Id="+ id+ ", Department= "+ name+ ",  Location= "+location);
    }*/

    cmd.ExecuteNonQuery();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    con.Close();
}
