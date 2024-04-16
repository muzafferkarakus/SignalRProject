using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.DataAccesLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCaseDal _moneyCaseDal;

        public MoneyCasesController(IMoneyCaseDal moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }
        [HttpGet]
        public IActionResult TotalMoneyCaseAmount()
        {
            return Ok(_moneyCaseDal.TotalMoneyCaseAmount());
        }
    }
}
