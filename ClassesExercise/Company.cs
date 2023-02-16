using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    public class Company
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employee> Employees { get; set; }

        public Company(string name, DateTime createdOn) 
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (Employee e in Employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} works for {this.Name} as {e.Title} since {e.StartDate.ToShortDateString()}.");
            }
            
        }
    }
}
