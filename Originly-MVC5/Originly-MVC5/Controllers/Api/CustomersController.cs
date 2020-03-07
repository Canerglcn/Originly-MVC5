using AutoMapper;
using Originly_MVC5.Dtos;
using Originly_MVC5.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Originly_MVC5.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            return Ok(_context.Customers
                .Include(c=>c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>));        
        }

        // GET /api/customer/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer,CustomerDto>(customer));
        }

        //Burada Kaldık
        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
           _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri+"/"+customer.Id), customerDto);

        }

        //Put api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            //customerInDb existing object,that's why we can use it => second parameter.
            Mapper.Map(customerDto, customerInDb);

            _context.SaveChanges();
            return Ok();
        }

        //Delete api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();
        }

    }
}
