using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;

namespace siteCipri1.Models
{
    public class Card
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ThumbnailImage { get; set; }

        public string? Location { get; set; }
        [ForeignKey("MenuItemId")]
        public int MenuItemId { get; set; }
        public MenuItem? MenuItem { get; set; }
        public List<Image>? CardImages { get; set; }
    }
}
