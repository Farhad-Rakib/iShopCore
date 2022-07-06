using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentGatewayApiController : ControllerBase
    {
        private readonly IPaymentGatewayApiService _paymentGatewayApiService;
        public PaymentGatewayApiController(IPaymentGatewayApiService paymentGatewayApiService)
        {
            _paymentGatewayApiService = paymentGatewayApiService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _paymentGatewayApiService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _paymentGatewayApiService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(PaymentGatewayAPIDto model)
        {
            var response =  await _paymentGatewayApiService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(PaymentGatewayAPIDto model)
        {
            var response = await _paymentGatewayApiService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _paymentGatewayApiService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
