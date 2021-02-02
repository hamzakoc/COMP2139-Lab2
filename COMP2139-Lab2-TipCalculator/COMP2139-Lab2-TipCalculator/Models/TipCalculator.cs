
using System.ComponentModel.DataAnnotations;

namespace COMP2139_Lab2_TipCalculator.Models
{
    public class TipCalculator
    {

        [Required(ErrorMessage = "Please enter a value for the cost of your meal.")]
        [Range(0.0,10000.0,ErrorMessage="Cost of meal must be greater than zero")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percent)
        {

            if (MealCost.HasValue)
            {
                var tip = MealCost.Value * percent;
                return tip;
            }
            else
            {
                return 0;
            }

        }


    }
}
