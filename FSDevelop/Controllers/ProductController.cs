using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FSDevelop.Models;

namespace FSDevelop.Controllers
{
    [Route("api/[controller]")]
    public class ProductController: Controller
    {
        private MongoContext _context;

        public ProductController(MongoContext context)
        {
            _context = context;
        }

        [Authorize("Bearer")]
        [HttpGet("products")]
        public IActionResult RetrieveAll()
        {
            var prod = _context.RetrieveAllProducts<Produto>();

            if (prod != null)
                return new ObjectResult(prod);
            else
                return NotFound();
        }
    }
}
