namespace EmployeeOOP.Classes
{
    public class SalaryEmployee : Employee
    {
        #region Propierties
        public decimal Salary { get; set; }
        #endregion

        #region Method

        public SalaryEmployee() { }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Salario Devengado: {Salary:C2}\n\t";
        }
        #endregion

    }
}
