using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Controllers.Helpers;
using api.Dtos.Stock;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);

        Task<Stock?> GetByIdAsync(int id);

        Task<Stock?> CreateASync(Stock stockModel);

        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);

        Task<Stock?> DeleteAsync(string companyname);
        Task<bool> SotckExists(int id);

    }
}