using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CW5.Models;
using CW5.Services;


namespace CW5.Controllers
{
    [Route("api/warehouses")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IDbService DbService;

        public WarehouseController(IDbService DbService)
        {
            this.DbService = DbService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToWarehouse([FromBody] ProductWarehouse productWarehouse)
        {
            int idProductWarehouse;
            try { idProductWarehouse = await DbService.AddProductToWarehouseAsync(productWarehouse); }

            catch (Exception e) { return NotFound(e.Message); }
            return Ok($"Dodane! ID: {idProductWarehouse}!");
        }


    }
}