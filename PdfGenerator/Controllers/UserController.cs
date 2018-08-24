using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PdfGenerator.Models;

namespace PdfGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly PdfGeneratorContext _context;

        public UserController(PdfGeneratorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            if (_context.Users.Count() < 1)
            {
                return NoContent();
            }

            return _context.Users.ToList();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public ActionResult<User> GetById(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return CreatedAtRoute("GetUser", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User item)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            user.Active = item.Active;
            user.Name = item.Name;
            user.Email = item.Email;
            user.Password = item.Password;
            user.UpdatedAt = DateTime.Now;

            _context.Users.Update(user);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return NoContent();
        }

    }
}