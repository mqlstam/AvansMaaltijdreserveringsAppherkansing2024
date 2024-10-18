using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;
using AvansMaaltijdreserveringsApp.Infrastructure.Data;

namespace AvansMaaltijdreserveringsApp.Infrastructure.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private readonly AppDbContext _context;

        public PackageRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Package>> GetAllPackagesAsync()
        {
            return await _context.Packages.Include(p => p.Products).ToListAsync();
        }

        public async Task<Package> GetPackageByIdAsync(int id)
        {
            return await _context.Packages.Include(p => p.Products).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddPackageAsync(Package package)
        {
            await _context.Packages.AddAsync(package);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePackageAsync(Package package)
        {
            _context.Packages.Update(package);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePackageAsync(int id)
        {
            var package = await _context.Packages.FindAsync(id);
            if (package != null)
            {
                _context.Packages.Remove(package);
                await _context.SaveChangesAsync();
            }
        }

        // Implement the GetAvailablePackagesAsync method
        public async Task<IEnumerable<Package>> GetAvailablePackagesAsync()
        {
            return await _context.Packages
                .Include(p => p.Products)
                .Where(p => p.ReservedById == null && p.PickupDateTime > DateTime.Now)
                .ToListAsync();
        }

        // You might also need to implement these methods based on your PackageController
        public async Task<Package> GetReservationForStudentAndDateAsync(int studentId, DateTime date)
        {
            return await _context.Packages
                .FirstOrDefaultAsync(p => p.ReservedById == studentId && p.PickupDateTime.Date == date.Date);
        }

        public async Task<bool> ReservePackageAsync(int packageId, int studentId)
        {
            var package = await _context.Packages.FindAsync(packageId);
            if (package == null || package.ReservedById != null)
            {
                return false;
            }

            package.ReservedById = studentId;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<string>> GetAllMealTypesAsync()
        {
            return await _context.Packages
                .Select(p => p.MealType)
                .Distinct()
                .ToListAsync();
        }
    }
}
