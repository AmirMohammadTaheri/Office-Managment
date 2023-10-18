using Human;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Employee");
                    Console.WriteLine("2. Manager");
                    int response = int.Parse(Console.ReadLine());
                    switch (response)
                    {
                        case 1:

                            Console.WriteLine("1. Add Employee");
                            Console.WriteLine("2. Update Employee Information");
                            Console.WriteLine("3. Show Employee Details");
                            Console.WriteLine("4. Promote Employee");
                            Console.WriteLine("5. Fire Employee");
                            Console.WriteLine("Enter your answer: ");
                            int answer = int.Parse(Console.ReadLine());
                            switch (answer)
                            {
                                case 1:
                                    HRemployee.HireEmployee();
                                    break;

                                case 2:
                                    HRemployee.UpdateEmployee();
                                    break;

                                case 3:
                                    HRemployee.ShowEmployee();
                                    break;

                                case 4:
                                    HRemployee.PromoteEmployee();
                                    break;

                                case 5:
                                    HRemployee.FireEmployee();
                                    break;

                                default:
                                    Console.WriteLine("Invalid answer!");
                                    break;
                            }
                            break;

                        case 2:

                            Console.WriteLine("1. Add Manager");
                            Console.WriteLine("2. Update Manager Information");
                            Console.WriteLine("3. Show Manager Details");
                            Console.WriteLine("4. Demote  Manager");
                            Console.WriteLine("5. Fire  Manager");
                            Console.WriteLine("Enter your answer: ");
                            int answer2 = int.Parse(Console.ReadLine());
                            switch (answer2)
                            {
                                case 1:
                                    HRmanager.Hire();
                                    break;

                                case 2:
                                    HRmanager.Update();
                                    break;

                                case 3:
                                    HRmanager.Show();
                                    break;

                                case 4:
                                    HRmanager.DemoteManager();
                                    break;

                                case 5:
                                    HRmanager.Fire();
                                    break;

                                default:
                                    Console.WriteLine("Invalid answer!");
                                    break;
                            }
                            break;

                            default:
                            Console.WriteLine("Invalid Position");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("---------------------------");
                    throw;
                }
            }



        }
    }
}