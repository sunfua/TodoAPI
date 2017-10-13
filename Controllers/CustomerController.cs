using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TodoAPI.Models;
using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;
using TodoAPI.Repository;
using Microsoft.Extensions.Logging;
using TodoAPI.Util;
using System.Collections.Generic;

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]  
    public class CustomerController : Controller
    {        
        ICustomersRepository _CustomersRepository;
        ILogger _Logger;

        public CustomerController(ICustomersRepository customersRepo, ILoggerFactory loggerFactory)
        {
            this._CustomersRepository=customersRepo;    
            this._Logger=loggerFactory.CreateLogger(nameof(CustomerController));    
        }

        [HttpGet]
        [NoCache]
        public async Task<ActionResult> Customers()
        {
            try
            {
                var customers = await _CustomersRepository.GetCustomersAsync();
                return Ok(customers);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); // BadRequest(new ApiResponse { Status = false });
            }
        }
         // GET: api/Customer/page/skip/take/orderBy(optional) 
        [Route("page/{skip:int}/{take:int}/{orderBy:alpha?}")]
        [NoCache]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> CustomersPage(int skip, int take)
        {
            try
            {
                var pagingResult = await _CustomersRepository.GetCustomersPageAsync(skip, take);
                Response.Headers.Add("X-InlineCount", pagingResult.TotalRecords.ToString());
                return Ok(pagingResult.Records);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }
        }
        // GET api/customers/5
        [HttpGet("{id}", Name = "GetCustomerRoute")]
        [NoCache]
        [ProducesResponseType(typeof(Customer), 200)]
//        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Customers(string id)
        {
            try
            {
                var customer = await _CustomersRepository.GetCustomerAsync(id);
                return Ok(customer);
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest(); //(new ApiResponse { Status = false });
            }
        }
        // POST api/customers
        [HttpPost]
        [ValidateAntiForgeryToken]
        // [ProducesResponseType(typeof(ApiResponse), 201)]
        // [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> CreateCustomer([FromBody]Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();//(new ApiResponse { Status = false, ModelState = ModelState });
            }

            try
            {
                var newCustomer = await _CustomersRepository.InsertCustomerAsync(customer);
                if (newCustomer == null)
                {
                    return BadRequest();//(new ApiResponse { Status = false });
                }
                return CreatedAtRoute("GetCustomerRoute", new { id = newCustomer.CustomerCode }, newCustomer);//, new ApiResponse { Status = true, Customer = newCustomer });
            }
            catch (Exception exp)
            {
                _Logger.LogError(exp.Message);
                return BadRequest();//(new ApiResponse { Status = false });
            }
        }        
    }
}