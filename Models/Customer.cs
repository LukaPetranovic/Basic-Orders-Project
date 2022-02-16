using System.ComponentModel.DataAnnotations;

namespace Basic_Orders_Project.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Ime")]
        public string Name { get; set; }

        [Display(Name = "Adresa")]
        public string Address { get; set; }

        [Display(Name = "Grad")]
        public string City { get; set; }

        [DataType(DataType.PostalCode), Display(Name = "Poštanski broj")]
        public int ZipCode { get; set; }

        [Required, Display(Name = "OIB")]
        public string OIB { get; set; }
    }
}
