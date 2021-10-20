using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webmvc.Context;
using webmvc.Models;

namespace Microsoft.EntityFrameworkCore
{   
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController: ControllerBase
    {
        private ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customer = await _context.CustomerEntity.ToListAsync();
            if (customer == null) return NotFound();
            return Ok(customer);
        }

    }
}