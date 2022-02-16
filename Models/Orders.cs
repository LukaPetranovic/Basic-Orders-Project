using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Basic_Orders_Project.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }


        [Required, Display(Name = "Ime")]
        public string Name { get; set; }


        [Display(Name = "Klijent")]
        public List<Customer> Customer { get; set; }


        [Required, Display(Name = "Datum")]
        public DateTime CreatedDate { get; set; }


        [Required, Display(Name = "Opis")]
        public string Description { get; set; }


        [Required, Display(Name = "Cijena")]
        public decimal Price { get; set; }
    }
}
