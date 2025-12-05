using ApiCrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public HomeController(DatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var data = _context.tblContacts.ToList();
            return Ok(data);
        }
        [HttpGet("ContactID")]
        public IActionResult GetContactById(int id)
        {
            var data = _context.tblContacts.Find(id);
            return Ok(data);

        }
        [HttpPost]
        public IActionResult AddNewContact(tblContact contact)
        {
            _context.tblContacts.Add(contact);
            _context.SaveChanges();
            return Ok("Contact Added");
        }
        [HttpPut]
        public IActionResult UpdateContact(tblContact contact)
        {
            _context.tblContacts.Update(contact);
            _context.SaveChanges();
            return Ok("Contact Updated");

        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var data = _context.tblContacts.Find(id);
            if (data == null)
            {
                return NotFound("Contact Not Found");
            }
            _context.tblContacts.Remove(data);
            _context.SaveChanges();
            return Ok("Contact Deleted");
        }
    }
}
