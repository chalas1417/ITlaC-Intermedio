using Solid.OCP.Interfaces;

namespace Solid.OCP
{
    public class IndiaTax : ITax
    {
       public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;

            if (taxableIncome <= 10)
            {
                taxAmount = 0;
            }
            else
            {
                decimal v = (taxableIncome - 10) * 4;
                taxAmount = 0;
            }

            return taxAmount;
        }
    }
}
