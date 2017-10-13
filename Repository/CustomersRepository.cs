using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoAPI.Models;

namespace TodoAPI.Repository
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly BCCPContext _context;
        private readonly ILogger _Logger;
        public CustomersRepository(BCCPContext context, ILoggerFactory loggerFactory)
        {
            _context=context;
            _Logger=loggerFactory.CreateLogger("CustomersRepository");
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _context.Customer.Where(c=>c.Poscode.StartsWith("65")).OrderBy(i=>i.CustomerCode).ToListAsync();
        }

        public async Task<PagingResult<Customer>> GetCustomersPageAsync(int skip, int take)
        {
            // SQL 2008 below
            // var totalCount =_context.Customer.Count();
            // var totalPage = System.Math.Ceiling((double)totalCount/pageSize);
            // var sql="SELECT * FROM (SELECT Row_Number() OVER(ORDER BY CustomerCode) As RowID, * FROM Customer WHERE POSCode like '65%') As RowResults "+
            //         "WHERE RowID Between {0} AND {1}";            
            // var customer = await _context.Customer.FromSql(sql,(pageNumber-1)*pageSize + 1, pageNumber*pageSize).ToArrayAsync();
            //--- SQL 2012 Above
            var totalRecords = await _context.Customer.CountAsync(); 
            var customer = await _context.Customer.Where(c=>c.Poscode.StartsWith("65")).OrderBy(c=>c.CustomerCode).Skip((skip-1)*take).Take(take).ToListAsync();
            return new PagingResult<Customer>(customer,totalRecords);
        }

        public async Task<Customer> GetCustomerAsync(string id)
        {
            return await _context.Customer.FirstOrDefaultAsync(c=>c.CustomerCode==id);
        }
        public async Task<Customer> InsertCustomerAsync(Customer customer)
        {
            _context.Add(customer);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                _Logger.LogError($"Error in {nameof(InsertCustomerAsync)}: "+ex.Message);
            }
            return customer;
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            _context.Customer.Attach(customer);
            _context.Entry(customer).State=EntityState.Modified;
            try
            {
                return (await _context.SaveChangesAsync()>0);
            }
            catch (System.Exception ex)
            {
                _Logger.LogError($"Error in {nameof(UpdateCustomerAsync)}: "+ ex.Message);
            }
            return false;
        }

        public async Task<bool> DeleteCustomerAsync(string id)
        {
            var customer=_context.Customer.SingleOrDefaultAsync(c => c.CustomerCode==id);
            _context.Remove(customer);
            try
            {
                return (await _context.SaveChangesAsync()>0);
            }
            catch(System.Exception ex)
            {
                _Logger.LogError($"Error in {nameof(DeleteCustomerAsync)}: "+ ex.Message);
            }
            return false;
        }
    }
}