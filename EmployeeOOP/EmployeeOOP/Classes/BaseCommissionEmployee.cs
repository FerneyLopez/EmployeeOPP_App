using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    internal class BaseCommissionEmployee : CommissionEmployee
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion

        #region Methods

        public BaseCommissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return ((CommisionPercentaje / 100) * Sales) + Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Valor a Pagar Total: {((CommisionPercentaje / 100) * Sales) + Base:C2}\n\t";
        }


        #endregion
    }
}
