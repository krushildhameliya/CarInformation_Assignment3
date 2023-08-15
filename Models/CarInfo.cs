using System.ComponentModel.DataAnnotations;

namespace CarInformation_Assignment3.Models
{
    public class CarInfo
    {
        [Key]
        public int carNumber { get; set; } 

        public required string carModel { get; set; }

        public required string carMade { get; set; }

        public required string manufacturedYear { get; set; }

        public required string fuelType { get; set; }

        public required string maxSpeed { get; set; }

    }
}
