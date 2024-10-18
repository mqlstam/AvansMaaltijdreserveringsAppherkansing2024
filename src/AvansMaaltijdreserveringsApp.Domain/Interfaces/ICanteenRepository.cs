using System.Collections.Generic;
using System.Threading.Tasks;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.Domain.Interfaces
{
    public interface ICanteenRepository
    {
        Task<IEnumerable<Canteen>> GetAllCanteensAsync();
        Task<Canteen> GetCanteenByIdAsync(int id);
        Task AddCanteenAsync(Canteen canteen);
        Task UpdateCanteenAsync(Canteen canteen);
        Task DeleteCanteenAsync(int id);
        Task GetLocationsAsync();
    }
}