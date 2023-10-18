using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal static class Lists
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Manager> managers = new List<Manager>();
    }
    public static class HRemployee
    {
        public static void HireEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Id: ");
            employee.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            Console.WriteLine("Enter lastName: ");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter Salary: ");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Employee added successfully!");
            Lists.employees.Add(employee);
        }
        public static void FireEmployee()
        {
            Console.WriteLine("Enter Employee Id to Fire: ");
            int RemoveId = int.Parse(Console.ReadLine());

            Employee employee = Lists.employees.Find(x => x.Id == RemoveId);
            if (employee != null)
            {
                Console.WriteLine("Employee fired !");
                Lists.employees.Remove(employee);
            }
            else
            { Console.WriteLine("Employee not found!"); }
        }
        public static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee Id to update information: ");
            int updateId = int.Parse(Console.ReadLine());

            Employee employee = Lists.employees.Find(x => x.Id == updateId);
            if (employee != null)
            {
                Console.WriteLine("Enter new name: ");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Enter new lastname: ");
                employee.LastName = Console.ReadLine();

                Console.WriteLine("Enter new salary: ");
                employee.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Employee information updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }

        }
        public static void ShowEmployee()
        {
            Console.WriteLine("Enter Employee Id to show details: ");
            int showId = int.Parse(Console.ReadLine());
            Employee employee = Lists.employees.Find(x => x.Id == showId);
            if (employee != null)
            {
                Console.WriteLine("Employee ID: " + employee.Id);
                Console.WriteLine("Employee Name: " + employee.Name);
                Console.WriteLine("Department: " + employee.LastName);
                Console.WriteLine("Position: " + employee.Position);
                Console.WriteLine("Salary: " + employee.Salary);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        public static void PromoteEmployee()
        {
            Console.WriteLine("Enter Employee Id You Want to promote: ");
            int updateId = int.Parse(Console.ReadLine());

            Employee employee = Lists.employees.Find(x => x.Id == updateId);
            Manager manager = new Manager();
            if (employee != null)
            {

                Console.WriteLine("Enter New Manager Id: ");
                manager.Id = int.Parse(Console.ReadLine());

                manager.Name = employee.Name;

                manager.LastName = employee.LastName;

                manager.Salary = employee.Salary;

                Lists.managers.Add(manager);
                Lists.employees.Remove(employee);

                Console.WriteLine("the Promotion is successfully done!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }

        }
    }
    public static class HRmanager
    {
        public static void Hire()
        {
            Manager manager = new Manager();
            Console.WriteLine("Enter Manager Id: ");
            manager.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Manager Name: ");
            manager.Name = Console.ReadLine();

            Console.WriteLine("Enter Manager lastName: ");
            manager.LastName = Console.ReadLine();

            Console.WriteLine("Enter Manager Salary: ");
            manager.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Manager added successfully!");
            Lists.managers.Add(manager);
        }
        public static void Fire()
        {
            Console.WriteLine("Enter Manager Id you want to Fire: ");
            int RemoveId = int.Parse(Console.ReadLine());

            Manager manager = Lists.managers.Find(x => x.Id == RemoveId);
            if (manager != null)
            {
                Console.WriteLine("Employee fired !");
                Lists.managers.Remove(manager);
            }
            else
            { Console.WriteLine("Manager not found!"); }
        }
        public static void Update()
        {
            Console.WriteLine("Enter Manager Id to update information: ");
            int updateId = int.Parse(Console.ReadLine());

            Manager manager = Lists.managers.Find(x => x.Id == updateId);
            if (manager != null)
            {
                Console.WriteLine("Enter new name: ");
                manager.Name = Console.ReadLine();

                Console.WriteLine("Enter new lastname: ");
                manager.LastName = Console.ReadLine();

                Console.WriteLine("Enter new salary: ");
                manager.Salary = double.Parse(Console.ReadLine());

                Console.WriteLine("Manager information updated successfully!");
            }
            else
            {
                Console.WriteLine("Manager not found!");
            }

        }
        public static void Show()
        {
            Console.WriteLine("Enter Manager Id to show details: ");
            int showId = int.Parse(Console.ReadLine());
            Manager manager = Lists.managers.Find(x => x.Id == showId);
            if (manager != null)
            {
                Console.WriteLine("ID: " + manager.Id);
                Console.WriteLine("Name: " + manager.Name);
                Console.WriteLine("last Name: " + manager.LastName);
                Console.WriteLine("Position: " + manager.Position);
                Console.WriteLine("Salary: " + manager.Salary);
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }
        public static void DemoteManager()
        {

            Console.WriteLine("Enter Manager Id You Want to demote: ");
            int demoteId = int.Parse(Console.ReadLine());

            Manager manager = Lists.managers.Find(x => x.Id == demoteId);
            Employee employee = new Employee();
            if (manager != null)
            {

                Console.WriteLine("Enter New Emplyee Id: ");
                employee.Id = int.Parse(Console.ReadLine());

                employee.Name = manager.Name;

                employee.LastName = manager.LastName;

                employee.Salary = manager.Salary;

                Lists.employees.Add(employee);
                Lists.managers.Remove(manager);

                Console.WriteLine("the Demotion is successfully done!");
            }
            else
            {
                Console.WriteLine("Manager not found!");
            }

        }
    }
}

