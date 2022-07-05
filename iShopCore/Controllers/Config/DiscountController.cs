using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _service;
        public DiscountController(IDiscountService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _service.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(DiscountDto model)
        {
            var response =  await _service.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(DiscountDto model)
        {
            var response = await _service.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _service.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
