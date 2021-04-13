using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CW5.Models;

namespace CW5.Services
{
    public interface IDbService
    {
        Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse);
    }
}