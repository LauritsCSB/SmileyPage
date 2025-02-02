namespace SmileyPage.Models
{
    public class Smiley
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public DateTime IssueDate { get; set; }
        public int RestaurantId { get; set; }
    }
}
