using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.AdminAPI.Services;
namespace StockMarket.AdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        CompanyService service = new CompanyService();
        [HttpGet]
        [Route("GetCompanies")]
        public IActionResult Get()
        {
            return Ok(service.GetCompanies());
        }
    }
}
