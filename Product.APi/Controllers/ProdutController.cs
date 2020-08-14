using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Product.APi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutController : Controller
    {
        private readonly ILogger<ProdutController> _logger;

        public ProdutController(ILogger<ProdutController> logger)
        {
            _logger = logger;
        }
        public IActionResult Get()
        {
            string result = $"【产品服务】{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}--" +
                $"{Request.HttpContext.Connection.LocalIpAddress}{Request.HttpContext.Connection.LocalPort}";
            return Ok(result);
        }
    }
}