using System.ComponentModel.DataAnnotations;

namespace SmileyPage.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? CurrrentSmiley { get; set; }
        public string? SecondSmiley { get; set; }
        public string? ThirdSmiley { get; set; }
    }
}
