using System.Data;

namespace ClassesExercise;

public class Program
{
    static void Main(string[] args)
    {
        Company hH = new Company("Hollifield House", new DateTime(2023, 2, 15, 8, 0, 0));
        Employee deanna = new Employee("Deanna", "Hollifield", "Vice President", new DateTime(1988, 5, 21, 9, 0, 0));
        Employee michael = new Employee("Michael", "Hollifield", "President", new DateTime(1988, 5, 21, 9, 0, 0));
        Employee audrey = new Employee("Audrey", "Hollifield", "Associate", new DateTime(1992, 4, 7, 6, 0, 0));
        Employee nick = new Employee("Nick", "Hollifield", "Associate", new DateTime(1995, 2, 7, 7, 0, 0));

        hH.Employees.Add(deanna);
        hH.Employees.Add(michael);
        hH.Employees.Add(audrey);
        hH.Employees.Add(nick);

        hH.ListEmployees();
    }
}