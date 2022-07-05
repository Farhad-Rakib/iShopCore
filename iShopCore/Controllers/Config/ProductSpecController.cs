using iShopCore.Dtos.Configs;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSpecController : ControllerBase
    {
        private readonly IProductSpecService _productSpecService;
        public ProductSpecController(IProductSpecService productSpecService)
        {
            _productSpecService = productSpecService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productSpecService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _productSpecService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(ProductSpecDto model)
        {
            var response =  await _productSpecService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(ProductSpecDto model)
        {
            var response = await _productSpecService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _productSpecService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
