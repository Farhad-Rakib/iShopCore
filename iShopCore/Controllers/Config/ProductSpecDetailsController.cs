using iShopCore.Dtos.Configs;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSpecDetailsController : ControllerBase
    {
        private readonly IProductSpecDeatilsService _productSpecDeatilsService;
        public ProductSpecDetailsController(IProductSpecDeatilsService productSpecDeatilsService)
        {
            _productSpecDeatilsService = productSpecDeatilsService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productSpecDeatilsService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _productSpecDeatilsService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(ProductSpecDetailsDto model)
        {
            var response =  await _productSpecDeatilsService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(ProductSpecDetailsDto model)
        {
            var response = await _productSpecDeatilsService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _productSpecDeatilsService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
