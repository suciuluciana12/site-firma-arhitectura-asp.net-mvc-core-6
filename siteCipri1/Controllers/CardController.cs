using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using siteCipri1.Data;
using siteCipri1.Models;

namespace siteCipri1.Controllers
{
    public class CardController : Controller
    {
        private readonly AppDbContext _context;

        public CardController(AppDbContext context)
        {
            _context = context;
        }

        // GET Cards By menu Item . Id-ul este id-ul MenuItem 
        public IActionResult CardsByMenuItem(int id)
        {
            MenuItem menuItem=_context.MenuItems.Find(id);
            ViewBag.MenuItemHeaderImage = menuItem.HeaderImage;
            ViewBag.MenuItemDescriptionTitle = menuItem.DescriptionTitle;
            ViewBag.MenuItemDescription = menuItem.Description;

            List<Card> cardsList = _context.Cards.Where(c => c.MenuItemId == id).ToList();
            return View(cardsList);
        }

        // GET: Card/Details/5
    

        public IActionResult CardDetails(int id)
        {
            if (id == null || _context.Cards == null)
            {
                return NotFound();
            }

            var card = _context.Cards.Find(id);

            if (card == null)
            {
                return NotFound();
            }
            List<Image> cardImages = _context.Images.Where(i => i.CardId == id).ToList();

            return View(cardImages);

        }
    }
}
