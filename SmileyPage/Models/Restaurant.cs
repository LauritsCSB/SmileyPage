using System.ComponentModel.DataAnnotations;

namespace SmileyPage.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Smiley>? Smilies { get; set; }
    }
}
