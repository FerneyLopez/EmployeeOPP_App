namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Propierties
        public decimal Sales { get; set; }
        public decimal CommisionPercentaje { get; set; }
        #endregion

        #region Method

        public CommissionEmployee() { }
        public override decimal GetValueToPay()
        {
            return (CommisionPercentaje / 100) * Sales;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor a Pagar por Comisiones: {(CommisionPercentaje / 100) * Sales:C2}\n\t";
        }
        #endregion
    }
}
