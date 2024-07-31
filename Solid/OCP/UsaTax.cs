using Solid.OCP.Interfaces;

namespace Solid.OCP
{
   public class UsaTax : ITax
    {
         public decimal CalculateTax(decimal taxableIncome)
        {
            decimal taxAmount = 0;

            if (taxableIncome <= 18)
            {
                taxAmount = 0;
            }
            else
            {
                taxAmount = (taxableIncome - 18) * 6;
            }

            return taxAmount;
        }

       
    
}
   }

