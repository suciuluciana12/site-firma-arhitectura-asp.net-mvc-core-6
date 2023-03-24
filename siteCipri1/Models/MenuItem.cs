using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;

namespace siteCipri1.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? HeaderImage  { get; set; }

        public string? DescriptionTitle { get; set; }
        public string? Description  { get; set; }
        public List<Card>? MenuItemCards { get; set; }
        public List<Image>? MenuItemImages { get; set; }
    }
}
