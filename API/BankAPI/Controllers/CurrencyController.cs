﻿using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace BankAPI.Controllers
{
    [ApiController]
    [Route("Bank/[controller]/[action]")]
    public class CurrencyController : Controller
    {
        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }
        private ILogger<CurrencyController> _logger;
        [HttpGet]
        public async Task<Currency?> Get(Guid idCurrency)
        {
            return await new CurrencyService().Get(idCurrency);
        }
        [HttpPost]
        public async Task Add(Currency currency)
        {
            await new CurrencyService().Add(currency);
        }
        [HttpPut]
        public async Task Update(Currency currency)
        {
            await new CurrencyService().Update(currency);
        }
        [HttpDelete]
        public async Task Delete(Guid idCurrency)
        {
            await new CurrencyService().Delete(idCurrency);
        }
    }
}
