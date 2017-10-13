using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using TodoAPI.Repository;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    public class TraceItemController:Controller
    {
        private readonly BCCPContext _context;
        public TraceItemController(BCCPContext context)
        {
            _context=context;
        }

        [HttpGet("{id}",Name="GetTraceItem")]
        public IActionResult GetById(string id)
        {
            // var traceItem = _context.TraceItem.LastOrDefault(t=>t.ItemCode==id);
            var traceItem = _context.TraceItem.Where(t=>t.ItemCode==id);
            if (traceItem==null)
            {
                return NotFound();                
            }
            return new ObjectResult(traceItem);
        }
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] TraceItem item)
        {
            if (item==null || item.ItemCode!=id)
            {
                return BadRequest();
            }
            var traceItem = _context.TraceItem.FirstOrDefault(t=>t.ItemCode==id);
            if (traceItem==null)
            {
                return NotFound();
            }
            traceItem.Note=item.Note;
            _context.TraceItem.Update(traceItem);
            _context.SaveChanges();
            return new NoContentResult();

        }
    }
}