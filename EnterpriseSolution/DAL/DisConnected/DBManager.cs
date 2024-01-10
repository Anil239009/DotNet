using System.Data;
using BOL;
using MySql.Data.MySqlClient;

namespace DAL.DisConnected;

public class MySqlDBManager
{
    public MySqlDBManager() { }
    public List<Employee> GetAll()
    {
        List<Employee> employees = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=anil";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from employees";
        try
        {
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string? firstName = reader["firstName"].ToString();
                string? lastName = reader["lastName"].ToString();
                string? email = reader["email"].ToString();
                string? address = reader["address"].ToString();
                Employee emp = new Employee();
                emp.Id = id;
                emp.FirstName = firstName;
                emp.LastName = lastName;
                emp.Address = address;
                emp.Email = email;
                employees.Add(emp);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            con.Close();
        }
        return employees;
    }
    public Employee GetById(int id)
    {
        Employee emp = new Employee();
        bool status = false;
        //Insert disconnected code to be written
        List<Employee> employees = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=iacsd0923";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from employee";
        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtEmployees = ds.Tables[0];
            DataRowCollection rows = dtEmployees.Rows;
            DataRow[] foundRows = dtEmployees.Select("Id =" + id); //*******
            Console.WriteLine("Found " + foundRows.Length);
            DataRow theRow = foundRows[0];
            Console.WriteLine(theRow["id"].ToString() + " " + theRow["firstName"].ToString());
            emp.Id = int.Parse(theRow["id"].ToString());
            emp.FirstName = theRow["firstName"].ToString();
            emp.LastName = theRow["lastName"].ToString();
            emp.Address = theRow["email"].ToString();
            emp.Email = theRow["email"].ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return emp;
    }
    public bool Insert(Employee emp)
    {
        bool status = false;
        //Insert disconnected code to be written
        List<Employee> employees = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=anil";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from employees";
        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtEmployees = ds.Tables[0];
            DataRowCollection rows = dtEmployees.Rows;
            DataRow row = dtEmployees.NewRow();
            row["firstName"] = emp.FirstName;
            row["lastName"] = emp.LastName;
            row["email"] = emp.Email;
            row["address"] = emp.Address;
            rows.Add(row);
            da.Update(ds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return status;
    }

    public bool Update(Employee emp)
    {
        bool status = false;
        List<Employee> employees = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=anil";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from employees";

        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtEmployees = ds.Tables[0];
            DataRowCollection rows = dtEmployees.Rows;

             DataColumn[] keyColumn = new DataColumn[1];
            keyColumn[0] = dtEmployees.Columns["id"];
            dtEmployees.PrimaryKey = keyColumn;

            DataRow theRow = rows.Find(emp.Id);

            theRow["id"] = emp.Id;
            theRow["firstName"] = emp.FirstName;
            theRow["lastName"] = emp.LastName;
            theRow["email"] = emp.Email;
            theRow["address"] = emp.Address;

          
            Console.WriteLine(theRow["id"].ToString()+ " "+theRow["firstName"].ToString());
            da.Update(ds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return status;
    }
    public bool Delete(int id)
    {
        Console.WriteLine("in delete method of disconnected dal");
        bool status = false;
        //Insert disconnected code to be written
        List<Employee> employees = new List<Employee>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = @"server=localhost; port=3306; user=root; password=root123; database=anil";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT * from employees";
        try
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            da.Fill(ds);
            DataTable dtEmployees = ds.Tables[0];
            DataRowCollection rows = dtEmployees.Rows;
            /* DataRow[] foundRows = dtEmployees.Select("Id =" + id); //*******
             Console.WriteLine("Found " + foundRows.Length);
             DataRow theRow = foundRows[0];
             Console.WriteLine(theRow["id"].ToString() + " " + theRow["firstName"].ToString());
             rows.Remove(theRow);
             if(ds.Tables.CanRemove(dtEmployees))
             rows.RemoveAt(0);
             */
            DataColumn[] keyColumn = new DataColumn[1];
            keyColumn[0] = dtEmployees.Columns["id"];
            dtEmployees.PrimaryKey = keyColumn;

            DataRow theRow = rows.Find(id);
            theRow.Delete();
            //rows.Remove(theRow);
            da.Update(ds);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return status;
    }

}