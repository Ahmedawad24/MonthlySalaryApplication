namespace SalaryApp
{
    class Employee
    {
        public const int MinLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        protected virtual decimal Calculate()
        {
            return CalculateBasicSalary() + CalculateOvertime();
        }
        private decimal CalculateBasicSalary()
        {
            return (LoggedHours - Wage);
        }
        private decimal CalculateOvertime()
        {
            var additionalHours = ((LoggedHours - MinLoggedHours) > 0 ? (LoggedHours - MinLoggedHours) : 0);
            return (additionalHours * Wage * OverTimeRate);
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("SalaryApp.","");
            return $"{type}\n"+
                   $"Id→ {Id}\n" +
                   $"Name→ {Name}\n" +
                   $"Logged Hours→ {LoggedHours}hrs\n" +
                   $"Wage→ {Wage}$/hr\n" +
                   $"Basic Salary→ ${Math.Round( this.CalculateBasicSalary(),2):N0}\n"+
                   $"Overtime→ ${Math.Round(this.CalculateOvertime(),2):N0}\n";
        }
    }
}
