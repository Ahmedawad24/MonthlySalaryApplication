namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1000, "Ahmed", 180, 10);   
            Maintanence maintanence = new Maintanence(1001,"Awad",182,8);
            Sales sales = new Sales(1002, "Aser", 176, 6, 0.05m, 10000m);
            Developer developer = new Developer(1003, "Issam", 186, 15, true);

            Employee[] employees = { manager, maintanence, sales, developer };
            foreach (Employee employee in employees)
            {
                Console.WriteLine("\n-----------------");
                Console.WriteLine(employee);
            }

                Console.ReadLine();

        }
    }
}
