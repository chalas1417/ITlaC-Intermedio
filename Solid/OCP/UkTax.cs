using Solid.OCP.Interfaces;

namespace Solid.OCP
{
     public class UkTax :ITax
    {
        public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;

            if (taxableIncome <= 20)
            {
                taxAmount = 0;
            }
            else
            {
                taxAmount = (taxableIncome - 20) * 9;
            }

            return taxAmount;
        }
    }
}
