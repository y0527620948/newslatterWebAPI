using Microsoft.AspNetCore.Mvc;
using newslatterWebAPI.Models;

namespace newslatterWebAPI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetContacts()
        {
            var contacts = new List<Contact>
            {
                new Contact { Id = 1, Name = "דוד כהן", Email = "david@example.com" },
                new Contact { Id = 2, Name = "שרה לוי", Email = "sarah@example.com" },
                new Contact { Id = 3, Name = "יוסי מזרחי", Email = "yossi@example.com" },
                new Contact { Id = 4, Name = "נועה אברהם", Email = "noa@example.com" },
                new Contact { Id = 5, Name = "רון ישראלי", Email = "ron@example.com" },
                new Contact { Id = 6, Name = "מיכל פרץ", Email = "michal@example.com" }
            };

            return Ok(contacts);
        }
    }
}
