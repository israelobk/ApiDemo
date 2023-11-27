using ApiDemo.Context;
using ApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private ContactsAPIDbContext dbcontext;
        public ContactsController(ContactsAPIDbContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbcontext.Contacts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddContact (Contact contact)
        {

            dbcontext.Contacts.Add(contact);
            await dbcontext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContacts), new { contact.id }, contact);

            /*  var contact = new Contact()
              {
                  id = Guid.NewGuid(),
                  Name = addContactRequest.Name,
                  Address = addContactRequest.Address,
                  Email = addContactRequest.Email,
                  Phone = addContactRequest.Phone,
              };*/


          /*  await dbcontext.Contacts.AddAsync(contact);
            await dbcontext.SaveChangesAsync();
            return Ok(contact);*/
        }
    }
}
