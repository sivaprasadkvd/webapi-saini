using Microsoft.EntityFrameworkCore;
using WebAPIsaini.Models;

namespace WebAPIsaini.Data
{
    public class ContactsAPIDbcontext : DbContext
    {
        public ContactsAPIDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
