using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoAPI.Enums;
using TodoAPI.Models;

namespace TodoAPI.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly BCCPContext _context;
        private readonly ILogger _Logger;
        public ItemsRepository(BCCPContext context, ILoggerFactory loggerFactory)
        {
            _context=context;
            _Logger=loggerFactory.CreateLogger("ItemsRepository");
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await _context.Item.FirstOrDefaultAsync(i=>i.ItemCode==id); 
        }

        public async Task<List<Item>> GetItemsAsync(DateTime? SendingTime)
        {
            // no filter sendingtime
            return await _context.Item.ToListAsync();
        }

        // Get Item by GroupType, SendingTime option
        public async Task<List<Item>> GetItemsAsync(GroupItem groupType, DateTime? SendingTime)
        {
            List<Item> items=null;
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }            
            switch (groupType) 
            {
                case GroupItem.DOMESTIC:
                    items = await _context.Item.Where(i=>i.IsDomestic==true && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.FOREIGN:
                    items = await _context.Item.Where(i=>i.IsDomestic==false && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.HCC:
                    items = await (from i in _context.Item join t in _context.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.SendingTime>=SendingTime) select i).ToListAsync();
                    break;
                case GroupItem.ALL:
                    items = await _context.Item.Where(i=>i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.None: break;
            }            
            return items;
        }

        public async Task<List<Item>> GetItemsAsync(string AcceptancePosCode, DateTime? SendingTime)
        {
            return await _context.Item.Where(i=>i.AcceptancePoscode==AcceptancePosCode).ToListAsync();
        }

        // Get Item by GroupType, AcceptancePosCode, SendingTime option
        public async Task<List<Item>> GetItemsAsync(GroupItem groupType, string AcceptancePosCode, DateTime? SendingTime)
        {
            List<Item> items=null;
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }            
            switch (groupType) 
            {
                case GroupItem.DOMESTIC:
                    items = await _context.Item.Where(i=>i.IsDomestic==true && i.AcceptancePoscode==AcceptancePosCode && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.FOREIGN:
                    items = await _context.Item.Where(i=>i.IsDomestic==false && i.AcceptancePoscode==AcceptancePosCode && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.HCC:
                    items = await (from i in _context.Item join t in _context.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.AcceptancePoscode==AcceptancePosCode && i.SendingTime>=SendingTime) select i).ToListAsync();
                    break;
                case GroupItem.ALL:
                    items = await _context.Item.Where(i=>i.AcceptancePoscode==AcceptancePosCode && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.None: break;
            }            
            return items;            
        }

        // Get paging Item by with SendingTime option
        public async Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, DateTime? SendingTime)
        {
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }
            //var totalRecords = await _context.Item.CountAsync(i=>i.SendingTime>=SendingTime);
            var items = await _context.Item.Where(i=>i.SendingTime>=SendingTime).ToListAsync();
            var totalRecords = items.Count();
            return new PagingResult<Item>(items.Skip((skip-1)*take).Take(take),totalRecords);
        }

        // Get paging Item by GroupType domestic, foreign, hcc, ... SendingTime option
        public async Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, GroupItem groupType, DateTime? SendingTime)
        {
            List<Item> items=null;
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }            
            switch (groupType) 
            {
                case GroupItem.DOMESTIC:
                    items = await _context.Item.Where(i=>i.IsDomestic==true && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.FOREIGN:
                    items = await _context.Item.Where(i=>i.IsDomestic==false && i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.HCC:
                    items = await (from i in _context.Item join t in _context.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.SendingTime>=SendingTime) select i).ToListAsync();
                    break;
                case GroupItem.ALL:
                    items = await _context.Item.Where(i=>i.SendingTime>=SendingTime).ToListAsync();
                    break;
                case GroupItem.None: break;
            }
            return new PagingResult<Item>(items.Skip((skip-1)*take).Take(take),items.Count());
        }

        // Get paging Item by AcceptancePosCode, SendingTime option
        public async Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, string AcceptancePosCode, DateTime? SendingTime)
        {        
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }                        
            //var totalRecords = await _context.Item.CountAsync(i=>i.AcceptancePoscode==AcceptancePosCode);
            var items = await _context.Item.Where(i=>i.AcceptancePoscode==AcceptancePosCode).ToListAsync();
            var totalRecords = items.Count();
            return new PagingResult<Item>(items.OrderBy(i=>i.SendingTime).Skip((skip-1)*take).Take(take),totalRecords);
        }

        // Get paging Item by GroupType, AccetancePosCode, SendingTime option 
        public async Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, string AcceptancePOSCode, GroupItem groupType, DateTime? SendingTime)
        {
           IQueryable<Item> _items=null;
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;
                //Console.WriteLine("Ngay hien tai: "+SendingTime+" Ngày +1: "+SendingTime.Value.AddDays(1));
            }            
            switch (groupType) 
            {
                case GroupItem.DOMESTIC:
                    _items = _context.Item.Where(i=>i.IsDomestic==true && i.AcceptancePoscode==AcceptancePOSCode && i.SendingTime>=SendingTime);
                    break;
                case GroupItem.FOREIGN:
                    _items = _context.Item.Where(i=>i.IsDomestic==false && i.AcceptancePoscode==AcceptancePOSCode && i.SendingTime>=SendingTime);
                    break;
                case GroupItem.HCC:
                    _items = from i in _context.Item join t in _context.ItemType 
                            on i.ItemTypeCode equals t.ItemTypeCode where (t.Type==1 && i.AcceptancePoscode==AcceptancePOSCode && i.SendingTime>=SendingTime) select i;
                    break;
                case GroupItem.ALL:
                    _items = _context.Item.Where(i=>i.AcceptancePoscode==AcceptancePOSCode && i.SendingTime>=SendingTime);
                    break;
                case GroupItem.None: break;
            }

            var totalRecords = await _items.CountAsync();
            var items = await _items.OrderBy(c=>c.SendingTime).Skip((skip-1)*take).Take(take).ToListAsync();            
            return new PagingResult<Item>(items,totalRecords);
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }
        
        public Task<Item> InsertItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Item item)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Item>> GetItemsFromPOAsync(string AcceptancePosCode, DateTime? SendingTime)
        {
            if(SendingTime==null){
                SendingTime=DateTime.Now.Date;                
            }
            var _contextPO=DbContextFactory.Create(AcceptancePosCode);
            var itemsPO = await _contextPO.Item.Where(i=>i.SendingTime>=SendingTime).ToListAsync();
            return itemsPO;
        }
    }
}