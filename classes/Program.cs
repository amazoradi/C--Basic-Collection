using System;
using System.Collections.Generic;

namespace classes
{
  class Program
  {
    // static void Main(string[] args)
    // {

    // }
    public class Employee
    {
      public Employee(string firstName, string lastName, string title, DateTime startDate){
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StartDate = startDate;
      }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Title { get; set; }
      public DateTime StartDate { get; }
    
    }

    public class Company
    {

      public Company(DateTime dateFounded, string name){
        DateFounded = dateFounded;
        CompanyName = name;
        
      }
      public DateTime DateFounded { get; }
      public string CompanyName { get; }
      public List<Employee> Employees { get; set; }

      public void ListEmployees(){
        foreach(Employee emp in Employees){
          Console.WriteLine($"{emp.FirstName} {emp.LastName} is a {emp.Title} at {this.CompanyName}");
        }

      }
  
    }

    class Programs
    {
      static void Main(string[] args)
      {
        Company NSS = new Company(DateTime.Now, "Nashville Software School");

        Employee Austin = new Employee("Austin", "Zoradi", "Developer", DateTime.Now);
        Employee Jess = new Employee("Jessica", "BarnDog", "Sloth Dev", DateTime.Now);
        Employee Zac = new Employee("Zacky", "Sack", "Number Cruncher", DateTime.Now);

        List<Employee> emps = new List<Employee>();

        emps.Add(Austin);
        emps.Add(Jess);
        emps.Add(Zac);
        
        NSS.Employees = emps;
        NSS.ListEmployees();

    
      }
    }
  }
}
