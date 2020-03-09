using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A name is required to proceed"), MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter a number and a street name"), MaxLength(100)]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [Required(ErrorMessage = "A city is required"), MaxLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "A State/Region is required"), MaxLength(20)]
        public string Region { get; set; }

        [Required, MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
