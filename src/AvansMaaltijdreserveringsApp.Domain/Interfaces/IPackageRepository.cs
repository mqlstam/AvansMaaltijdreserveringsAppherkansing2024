using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.Domain.Interfaces
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetAllPackagesAsync();
        Task<Package> GetPackageByIdAsync(int id);
        Task AddPackageAsync(Package package);
        Task UpdatePackageAsync(Package package);
        Task DeletePackageAsync(int id);
        Task<IEnumerable<Package>> GetAvailablePackagesAsync();
        Task<Package> GetReservationForStudentAndDateAsync(int studentId, DateTime date);
        Task<bool> ReservePackageAsync(int packageId, int studentId);
        Task<IEnumerable<string>> GetAllMealTypesAsync();
    }
}
