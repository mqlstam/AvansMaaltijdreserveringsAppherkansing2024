using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IPackageRepository _packageRepository;

        public PackagesController(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Package>>> GetPackages()
        {
            var packages = await _packageRepository.GetAllPackagesAsync();
            return Ok(packages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Package>> GetPackage(int id)
        {
            var package = await _packageRepository.GetPackageByIdAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            return Ok(package);
        }

        [HttpPost]
        public async Task<ActionResult<Package>> CreatePackage(Package package)
        {
            await _packageRepository.AddPackageAsync(package);
            return CreatedAtAction(nameof(GetPackage), new { id = package.Id }, package);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePackage(int id, Package package)
        {
            if (id != package.Id)
            {
                return BadRequest();
            }
            await _packageRepository.UpdatePackageAsync(package);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePackage(int id)
        {
            await _packageRepository.DeletePackageAsync(id);
            return NoContent();
        }
    }
}