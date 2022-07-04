using iShopCore.Dtos.Configs;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyConfigController : ControllerBase
    {
        private readonly ICompanyConfigService _companyConfigsService;
        public CompanyConfigController( ICompanyConfigService companyConfigService)
        {
             _companyConfigsService=companyConfigService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _companyConfigsService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _companyConfigsService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(CompanyConfigsDto model)
        {
            var response =  await _companyConfigsService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost("edit/{id:int}")]
        public async Task<IActionResult> Update(CompanyConfigsDto model)
        {
            var response = await _companyConfigsService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _companyConfigsService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
