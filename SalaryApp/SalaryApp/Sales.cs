namespace SalaryApp
{
    class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Comission { get; set; }
        public Sales(int id, string name, decimal loggedHours, decimal wage,decimal salesVolume, decimal comission) 
            : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesVolume;
            this.Comission = comission;
        }
        private decimal CalculateBonus()
        {
            return SalesVolume * Comission;
        }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                $"Bonus→ ${Math.Round(CalculateBonus(), 2):N0}\n" +
                $"Net Salary→ ${Math.Round(this.Calculate(), 2):N0}\n";
        }
    }
}
