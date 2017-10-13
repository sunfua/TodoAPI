using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoAPI.Enums;
using TodoAPI.Models;

namespace TodoAPI.Repository
{
    public interface IItemsRepository
    {
        Task<List<Item>> GetItemsAsync(DateTime? SendingTime);
        Task<List<Item>> GetItemsAsync(GroupItem groupType, DateTime? SendingTime);        
        Task<List<Item>> GetItemsAsync(string AcceptancePosCode, DateTime? SendingTime);
        Task<List<Item>> GetItemsAsync(GroupItem groupType, string AcceptancePosCode, DateTime? SendingTime);
        Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, DateTime? SendingTime);
        Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, GroupItem groupType, DateTime? SendingTime);
        Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, string AcceptancePosCode, DateTime? SendingTime);
        Task<PagingResult<Item>> GetItemsPageAsync(int skip, int take, string AcceptancePosCode, GroupItem groupType, DateTime? SendingTime);        
        Task<List<Item>> GetItemsFromPOAsync(string AcceptancePosCode, DateTime? SendingTime);
        Task<Item> GetItemAsync(string id);
        Task<Item> InsertItemAsync(Item item);
        Task<bool> UpdateItemAsync(Item item);
        Task<bool> DeleteItemAsync(string id);
    }
}
// Insert Items From PO to BR
// Insert Item 