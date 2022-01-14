using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5Zadanie.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LibraryController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Hobbit", "HarryPotter", "Zwiadowcy", "Władcapierścieni", "Unknow"
        };

        private readonly ILogger<LibraryController> _logger;

        public LibraryController(ILogger<LibraryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Librabry> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Librabry
            {
                date_of_borrowing_book = DateTime.Now.AddDays(index),
                title = Summaries[rng.Next(Summaries.Length)],
                pages = rng.Next(0, 600),
                
            })
            .ToArray();
        }
    }
}
