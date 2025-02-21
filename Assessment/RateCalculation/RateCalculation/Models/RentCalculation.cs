using System.ComponentModel.DataAnnotations;

namespace RateCalculation.Models
{
    public class RentCalculation
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string HallOwner { get; set; }
        [Required]
        public int CostPerDay { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateOnly StartDate { get; set; }
        [DataType(DataType.Date)]
        [Required]
        public DateOnly EndDate { get; set; }

    }
}
