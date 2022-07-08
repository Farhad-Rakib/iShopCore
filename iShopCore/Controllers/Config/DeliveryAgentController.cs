using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryAgentController : ControllerBase
    {
        private readonly IDeliveryAgentService _deliveryAgentService;
        public DeliveryAgentController(IDeliveryAgentService deliveryAgentService)
        {
            _deliveryAgentService = deliveryAgentService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _deliveryAgentService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _deliveryAgentService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(DeliveryAgentDto model)
        {
            var response =  await _deliveryAgentService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(DeliveryAgentDto model)
        {
            var response = await _deliveryAgentService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _deliveryAgentService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
