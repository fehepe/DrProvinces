using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrProvincesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DrProvincesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProvinceController> _logger;

        public ProvinceController(ILogger<ProvinceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Province> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Province
            {
                Name = "Santo Domingo",

            })
            .ToArray();
        }
    }
}
