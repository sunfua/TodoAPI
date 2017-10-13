using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HtmlAgilityPack;
using System.Net.Http;
using TodoAPI.Repository;
using TodoAPI.Util;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;
using TodoAPI.Enums;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]  
    public class ItemController : Controller
    {        
        //private readonly BCCPContext _context;
        IItemsRepository _iItemsRepository;
        ILogger _Logger;
        private string url="http://bccp.vnpost.vn/BCCP.aspx?act=Trace&id={0}&pkey=teWeIFQM";
        public ItemController(IItemsRepository iItemsRepository, ILoggerFactory loggerFactory)
        {          
            _iItemsRepository=iItemsRepository;
            _Logger=loggerFactory.CreateLogger(nameof(ItemController));
        }

        #region GET list: api/item/id
        [HttpGet("{id}",Name="GetItem")]
        [NoCache]
        [ProducesResponseType(typeof(Item), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> Items(string id)
        {
            try
            {
                var item= await _iItemsRepository.GetItemAsync(id);
                return Ok(item);
            }            
            catch(Exception ex)
            {
               _Logger.LogError(ex.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }
        }
        #endregion

        #region GET list: api/item/SendingTime(option)
        [Route("{SendingTime:datetime?}")]
        [HttpGet("GetItemsList/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsList(DateTime? SendingTime)
        {
            try
            {
                var items=await _iItemsRepository.GetItemsAsync(SendingTime);
                return Ok(items);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }
        #endregion

        #region GET list: api/item/itemType/SendingTime(option)
        [Route("{itemType:alpha}/{SendingTime:datetime?}")]
        [HttpGet("GetItemsList/{itemType:alpha}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsList(string itemType, DateTime? SendingTime)
        {
            try
            {
                var groupType=Enum.Parse<GroupItem>(itemType.ToUpper());
                var items=await _iItemsRepository.GetItemsAsync(groupType, SendingTime);
                return Ok(items);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }
        #endregion

        #region GET list: api/item/AcceptancePosCode/SendingTime(option)
        [Route("pos/{AcceptancePosCode:length(6)}/{SendingTime:datetime?}")]
        [HttpGet("GetItemsPOList/{AcceptancePosCode:length(6)}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsPOList(string AcceptancePosCode, DateTime? SendingTime)
        {
            try
            {
                var items=await _iItemsRepository.GetItemsAsync(AcceptancePosCode,SendingTime);
                return Ok(items);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }
        #endregion

        #region GET list: api/item/AcceptancePosCode/itemType/SendingTime(option)
        [Route("{AcceptancePosCode:length(6)}/{itemType:alpha}/{SendingTime:datetime?}")]
        [HttpGet("GetItemsList/{AcceptancePosCode:length(6)}/{itemType:alpha}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsList(string AcceptancePosCode, string itemType, DateTime? SendingTime)
        {
            try
            {
                var groupType=Enum.Parse<GroupItem>(itemType.ToUpper());
                var items=await _iItemsRepository.GetItemsAsync(groupType,AcceptancePosCode,SendingTime);
                return Ok(items);
            }
            catch (Exception ex)
            {
                _Logger.LogError(ex.Message);
                return BadRequest();
            }
        }
        #endregion

        #region GET page: api/item/page/skip/take/sendingtime(optional) 
        [Route("page/{skip:int}/{take:int}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsPage(int skip, int take, DateTime? SendingTime)
        {
            try
            {
                var pagingResult = await _iItemsRepository.GetItemsPageAsync(skip, take, SendingTime);
                Response.Headers.Add("X-InlineCount", pagingResult.TotalRecords.ToString());
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }            
        }
        #endregion
        
        #region GET page: api/item/page/skip/take/type/itemType/sendingTime(optional) 
        [Route("page/{skip:int}/{take:int}/type/{itemType:alpha}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsTypePage(int skip, int take, string itemType, DateTime? SendingTime)
        {
            try
            {
                var groupType=Enum.Parse<GroupItem>(itemType.ToUpper());
                var pagingResult = await _iItemsRepository.GetItemsPageAsync(skip, take, groupType, SendingTime);
                Response.Headers.Add("X-InlineCount", pagingResult.TotalRecords.ToString());
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }
        }
        #endregion
          
        #region GET page: api/item/page/skip/take/pos/acceptanceposcode/sendingTime(optional)
        [Route("page/{skip:int}/{take:int}/pos/{AcceptancePosCode:length(6)}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsPOPage(int skip, int take, string AcceptancePosCode, DateTime? SendingTime)
        {
            try
            {
                var pagingResult = await _iItemsRepository.GetItemsPageAsync(skip, take, AcceptancePosCode, SendingTime);
                Response.Headers.Add("X-InlineCount", pagingResult.TotalRecords.ToString());
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }            
        }
        #endregion

        #region GET page: api/item/page/skip/take/pos/acceptanceposcode/itemType/sendingTime(optional) 
        [Route("page/{skip:int}/{take:int}/pos/{AcceptancePosCode:length(6)}/{itemType:alpha}/{SendingTime:datetime?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Item>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetItemsPage(int skip, int take, string AcceptancePosCode, string itemType, DateTime? SendingTime)
        {
            try
            {
                var groupType=Enum.Parse<GroupItem>(itemType.ToUpper());
                var pagingResult = await _iItemsRepository.GetItemsPageAsync(skip, take, AcceptancePosCode, groupType, SendingTime);
                Response.Headers.Add("X-InlineCount", pagingResult.TotalRecords.ToString());
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }
        }
        #endregion
       
/*
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
        // GET: api/Item/isDomestic/AcceptancePOSCode/SendingTime(option)
        [Route("{isDomestic:int}/{AcceptancePOSCode:length(6)}/{SendingTime:datetime?}")]
        [HttpGet("GetItems/{isDomestic:int}/{AcceptancePOSCode:length(6)}/{SendingTime:datetime?}")]
        public IActionResult GetItems(int isDomestic, string AcceptancePOSCode, DateTime? SendingTime)
        {            
            var _contextPO = DbContextFactory.Create(AcceptancePOSCode);
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }
            var items = _contextPO.Item.Where(a=>a.IsDomestic==(isDomestic==1) && a.AcceptancePoscode==AcceptancePOSCode && a.SendingTime>=SendingTime);
            if (items==null)
            {
                return NotFound();
            }
            return new ObjectResult(items);
        }

        // GET: api/Item/AcceptancePOSCode/SendingTime(option)
        [Route("{AcceptancePOSCode:length(6)}/{SendingTime:datetime?}")]
        [HttpGet("GetHCC/{AcceptancePOSCode:length(6)}/{SendingTime:datetime?}")]
        public IActionResult GetHCC(string AcceptancePOSCode, DateTime? SendingTime)
        {             
             var _contextPO = DbContextFactory.Create(AcceptancePOSCode);          
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;                
            }
            var items = from i in _contextPO.Item join t in _contextPO.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.SendingTime>=SendingTime) select i;            
            
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
*/        
    }
}