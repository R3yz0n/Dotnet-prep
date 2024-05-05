// LINQ is a data querying API that provides querying capabilities to . NET languages with a syntax similar to a SQL. 
// From where select  orderby count sum distinct
internal class LINQ
{

    public static void Main()
    {
        List<Employee> employees = new List<Employee>(){
            new Employee(){Id=1,Name="Sagar",Salary=10000,Department="IT"},
            new Employee(){Id=1,Name="Prem",Salary=100,Department="IT"},
            new Employee(){Id=1,Name="Rabin",Salary=20,Department="IT"},
            new Employee(){Id=1,Name="Aashish",Salary=200,Department="IT"},
        };

        var selectEmployee = from e in employees where e.Salary > 100 orderby e.Name select e;
        // var selectEmployee = employees.Where(e => e.Salary > 100 && true).OrderBy(e => e.Name).Distinct().Select(e => e);
        // var sum = employees.Sum(e => e.Salary);
        // var sum = from e in employees sum;

        foreach (var e in selectEmployee)
        {
            System.Console.WriteLine(e.Name);
        }
    }
}

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Salary { get; set; }
    public string? Department { get; set; }



}