namespace SalaryApp
{
    class Maintanence : Employee
    {
        private const decimal Hardship = 100m;

        public Maintanence(int id, string name, decimal loggedHours, decimal wage) 
            : base(id, name, loggedHours, wage)
        {

        }

        protected override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }
        
        public override string ToString()
        {
            return base.ToString() +
                $"hardship→ ${Math.Round(Hardship, 2):N0}\n" +
                $"Net Salary→ ${Math.Round(this.Calculate(), 2):N0}\n";
        }
    }
}
