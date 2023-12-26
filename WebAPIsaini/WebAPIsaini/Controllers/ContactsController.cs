using Microsoft.AspNetCore.Mvc;
using WebAPIsaini.Data;

namespace WebAPIsaini.Controllers
{
    [ApiController]
    [Route("api/[contoller]")]

    

    public class ContactsController : Controller
    {
        private readonly ContactsAPIDbcontext _dbcontext;

        public ContactsController(ContactsAPIDbcontext dbcontext) 
        {
                this._dbcontext = dbcontext;
        }

        [HttpGet]

        public IActionResult GetContacts()
        {
            return Ok(_dbcontext.Contacts.ToList());
        }
    }
}
