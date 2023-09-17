namespace EmployeeOOP.Classes
{
    internal class HourlyEmployee : Employee
    {
        #region Properties
        public int Hours { get; set; }
        public decimal HourValue { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() { }

        public override decimal GetValueToPay()
        {
            return HourValue * Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor a Pagar: {HourValue * Hours:C2}\n\t";
        }

        #endregion
    }
}
