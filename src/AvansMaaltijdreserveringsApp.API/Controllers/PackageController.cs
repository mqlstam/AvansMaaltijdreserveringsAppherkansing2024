using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;
using System.Security.Claims;

namespace AvansMaaltijdreserveringsApp.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository _packageRepository;
        private readonly IStudentRepository _studentRepository;

        public PackageController(IPackageRepository packageRepository, IStudentRepository studentRepository)
        {
            _packageRepository = packageRepository;
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Student,CanteenEmployee")]
        public async Task<IActionResult> GetAvailablePackages()
        {
            var packages = await _packageRepository.GetAvailablePackagesAsync();
            return Ok(packages);
        }

        [HttpPost]
        [Authorize(Roles = "CanteenEmployee")]
        public async Task<IActionResult> CreatePackage([FromBody] AvansMaaltijdreserveringsApp.Domain.Models.Package package)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _packageRepository.AddPackageAsync(package);
            return CreatedAtAction(nameof(GetPackage), new { id = package.Id }, package);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Student,CanteenEmployee")]
        public async Task<IActionResult> GetPackage(int id)
        {
            var package = await _packageRepository.GetPackageByIdAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            return Ok(package);
        }

        [HttpPost("{id}/reserve")]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> ReservePackage(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return BadRequest("User not found");
            }

            if (!int.TryParse(userId, out int parsedUserId))
            {
                return BadRequest("Invalid user ID");
            }

            var student = await _studentRepository.GetStudentByIdAsync(parsedUserId);
            if (student == null)
            {
                return BadRequest("Student not found");
            }

            var package = await _packageRepository.GetPackageByIdAsync(id);
            if (package == null)
            {
                return NotFound();
            }

            if (package.Is18Plus && student.DateOfBirth.AddYears(18) > DateTime.Now)
            {
                return BadRequest("You must be 18 or older to reserve this package");
            }

            var existingReservation = await _packageRepository.GetReservationForStudentAndDateAsync(student.Id, package.PickupDateTime.Date);
            if (existingReservation != null)
            {
                return BadRequest("You have already reserved a package for this day");
            }

            var result = await _packageRepository.ReservePackageAsync(id, student.Id);
            if (!result)
            {
                return BadRequest("Unable to reserve the package. It may have already been reserved.");
            }

            return Ok("Package reserved successfully");
        }
    }
}
