using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]  
    public class CustomerController : Controller
    {        
        private readonly BCCPContext _context;
        //private BCCPContext context;

        public CustomerController(BCCPContext context)
        {
            this._context=context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_context.Customer.Where(c=>c.Poscode.StartsWith("65")).Take(10));
        }
    }
}