using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace siteCipri1.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Src { get; set; }

        [ForeignKey("CardId")]
        public int CardId { get; set; }
        public Card? Card { get; set; }

        [ForeignKey("MenuItemId")]
        public int MenuItemId { get; set; }
        public MenuItem? MenuItem { get; set; }
    }
}
