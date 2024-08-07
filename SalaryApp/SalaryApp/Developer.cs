namespace SalaryApp
{
    class Developer : Employee
    {
        private const decimal CommisionRate = 0.03m;
        protected bool isTaskCompleted { get; set; }
        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskcomplete) 
            : base(id, name, loggedHours, wage)
        {
            this.isTaskCompleted = taskcomplete;
           
        }
        private decimal CalculateBonus()
        {
            if (isTaskCompleted)
                return base.Calculate() * CommisionRate;
            return 0;
            
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Task Completed?→ {(isTaskCompleted ? "Yes" : "No")}\n"+
                $"Bonus→ {Math.Round(CalculateBonus(), 2):N0}\n" +
                $"Net Salary→ {Math.Round(this.Calculate(), 2):N0}\n";
        }
    }
}
