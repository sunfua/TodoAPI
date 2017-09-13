using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;

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
             //var _contextBC = DbContextFactory.Create("DB1");        
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(_context.Customer.Where(c=>c.Poscode.StartsWith("65")).OrderBy(i=>i.CustomerCode).Take(10));
        }
        // GET: api/Customer/id
        [Route("{id}")]
        public IActionResult Get(string id)
        {
            var customer=_context.Customer.Where(c=>c.CustomerCode==id);
            if (customer==null)
            {
                return NotFound();
            }
            return new ObjectResult(customer);
        }
        // GET: api/Customer/pageSize/pageNumber/orderBy(optional) 
        [Route("{pageSize:int}/{pageNumber:int}/{orderBy:alpha?}")]
        public async Task<IActionResult> Get(int pageSize, int pageNumber, string orderBy="")
        {
            var totalCount =_context.Customer.Count();
            var totalPage = Math.Ceiling((double)totalCount/pageSize);
            var sql="SELECT * FROM (SELECT Row_Number() OVER(ORDER BY CustomerCode) As RowID, * FROM Customer WHERE POSCode like '65%') As RowResults "+
                    "WHERE RowID Between {0} AND {1}";            
            var customer = await _context.Customer.FromSql(sql,(pageNumber-1)*pageSize + 1, pageNumber*pageSize).ToArrayAsync();
            //var customer = await _context.Customer.Where(c=>c.Poscode.StartsWith("65")).OrderBy(c=>c.CustomerCode).Skip((pageNumber-1)*pageSize).Take(pageSize).ToListAsync();
            return new ObjectResult(customer);
        }
    }
}