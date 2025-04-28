using DBOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CurrencyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCurrencies()
        {
            //var result = await _appDbContext.Currencies.ToListAsync();
            var result = await (from currencies in _appDbContext.Currencies
                         select currencies).ToListAsync();
            return Ok(result);
        }
    }
}
