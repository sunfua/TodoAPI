using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HtmlAgilityPack;
using System.Net.Http;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]  
    public class ItemController : Controller
    {        
        private readonly BCCPContext _context;
        private BCCPContext context;
        private string url="http://bccp.vnpost.vn/BCCP.aspx?act=Trace&id={0}&pkey=teWeIFQM";
        public ItemController(BCCPContext context)
        {
            _context=context;
            // var optionsBuilder = new DbContextOptionsBuilder();
            // optionsBuilder.UseSqlServer("connectionString");

            // var context1 = new BCCPContext(optionsBuilder.Options);
        }

        [HttpGet("{id}",Name="GetItem")]
        public IActionResult GetById(string id)
        {
            var item = _context.Item.FirstOrDefault(i=>i.ItemCode==id);            
            if (item==null)
            {
                return NotFound();
            }
            return Ok(item);
        }
        [Route("{id}/locate")]
        public IActionResult GetItemLocate(string id)
        {   
            string itemData;
            using (HttpClient client = new HttpClient())
            { 
               itemData=null;
                using (HttpResponseMessage response = client.GetAsync(string.Format(url,id)).Result)
                {
                    var bytes = response.Content.ReadAsByteArrayAsync().Result;                        
                    var result1 = Encoding.UTF8.GetString(bytes);
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;
                        HtmlDocument document = new HtmlDocument();
                        document.LoadHtml(result1);                        
                        var nodes = document.DocumentNode.SelectNodes("//*[@id='MainContent_ctl00_tr_Status_Detail']");
                        //Some work with page....                        
                        //itemData=nodes.ToString();
                        itemData=document.DocumentNode.SelectSingleNode("//*[@id='MainContent_ctl00_grvItemTrace']").InnerHtml;
                    }
                }         
            }
            if (itemData==null)
            {
                return NotFound();
            }
            return Ok(itemData);            
        }

        [HttpGet("GetHCC/{date:datetime}")]
        public IActionResult GetHCC(DateTime date)
        {           
            //return new ObjectResult(new DateTime[] {from, from.AddDays(1)});
            var datelm= date.AddDays(1);
            //var item = from i in _context.Item join t in _context.ItemType 
            //                on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.SendingTime>=date && i.SendingTime<=datelm) select i;            
            var items=_context.Item.Where(a=>a.SendingTime>=date && a.SendingTime<=datelm);
            if (items==null)
            {
                return NotFound();
            }
            return new ObjectResult(items);
        }        
        [HttpGet("GetHCCFromSource/{date:datetime}")]
        public IActionResult GetHCCFromSource(DateTime date)
        {           
            //return new ObjectResult(new DateTime[] {from, from.AddDays(1)});
            var datelm= date.AddDays(1);
            var items = from i in _context.Item join t in _context.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.SendingTime>=date && i.SendingTime<=datelm) select i;            
            if (items==null)
            {
                return NotFound();
            }
            return new ObjectResult(items);
        }
        //[Route("date/{from}/{to}")]
        [HttpGet("GetHCCFromTo/{from}/{to}")]
        public IActionResult GetHCCFromTo(string from, string to)
        {
            DateTime[] arr = new DateTime[] {DateTime.Parse(from).AddDays(1), DateTime.Parse(to)};            
            return new ObjectResult(arr);
        }
    }
}