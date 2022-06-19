using EShop.Data.EF;
using EShop.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly EShopDbContext _context;
        public StudentsController(EShopDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var student = _context.Students.FirstOrDefault(student => student.Id == id);
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(student);
        }
    }
}
