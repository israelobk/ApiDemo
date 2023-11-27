using ApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Context
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<Contact> Contacts {   get; set; }
    }
}
