using Microsoft.EntityFrameworkCore;
using Task03.Models;

namespace Task03.Data
{
    public class ContactsAPIDbContext : DbContext
    {

        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
