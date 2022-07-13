using iShopCore.Dtos.Configs;
using iShopCore.Entities.config;
using iShopCore.Services.Interfaces.Configs;
using Microsoft.AspNetCore.Mvc;

namespace iShopCore.Controllers.Config
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTypeController : ControllerBase
    {
        private readonly IAccountTypeService _accountTypeService;
        public AccountTypeController(IAccountTypeService accountTypeService)
        {
            _accountTypeService = accountTypeService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _accountTypeService.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        [Route("get/{id:int}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await _accountTypeService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add(AccountTypeDto model)
        {
            var response =  await _accountTypeService.AddAsync(model);
            return Ok(new { data = response});
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Update(AccountTypeDto model)
        {
            var response = await _accountTypeService.UpdateAsync(model);
            return Ok(new { data = response });
        }

        [HttpPost]
        [Route("delete/{id:int}")]
        public async Task<IActionResult> Delete(long id)
        {
            var response =  await _accountTypeService.DeleteAsync(id);
            return Ok(new { data = response });
        }
    }
}
