using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;
using AvansMaaltijdreserveringsApp.Infrastructure.Data;

namespace AvansMaaltijdreserveringsApp.Infrastructure.Repositories
{
    public class CanteenRepository : ICanteenRepository
    {
        private readonly AppDbContext _context;

        public CanteenRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Canteen>> GetAllCanteensAsync()
        {
            return await _context.Canteens.ToListAsync();
        }

        public async Task<Canteen> GetCanteenByIdAsync(int id)
        {
            return await _context.Canteens.FindAsync(id);
        }

        public async Task AddCanteenAsync(Canteen canteen)
        {
            await _context.Canteens.AddAsync(canteen);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCanteenAsync(Canteen canteen)
        {
            _context.Canteens.Update(canteen);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCanteenAsync(int id)
        {
            var canteen = await _context.Canteens.FindAsync(id);
            if (canteen != null)
            {
                _context.Canteens.Remove(canteen);
                await _context.SaveChangesAsync();
            }
        }
    }
}