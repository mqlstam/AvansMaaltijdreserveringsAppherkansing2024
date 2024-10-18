using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvansMaaltijdreserveringsApp.Web.Models;
using System.Linq;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPackageRepository _packageRepository;
    private readonly ICanteenRepository _canteenRepository;

    public HomeController(ILogger<HomeController> logger, IPackageRepository packageRepository, ICanteenRepository canteenRepository)
    {
        _logger = logger;
        _packageRepository = packageRepository;
        _canteenRepository = canteenRepository;
    }

    public async Task<IActionResult> Index(string location, string mealType)
    {
        try
        {
            var availablePackages = await _packageRepository.GetAvailablePackagesAsync();
            var locations = await _canteenRepository.GetCanteenLocationsAsync(); // Updated to GetCanteenLocationsAsync
            var mealTypes = await _packageRepository.GetAllMealTypesAsync();

            // Apply filters
            if (!string.IsNullOrEmpty(location))
            {
                availablePackages = availablePackages.Where(p => p.City == location);
            }

            if (!string.IsNullOrEmpty(mealType))
            {
                availablePackages = availablePackages.Where(p => p.MealType == mealType);
            }

            var model = new IndexModel
            {
                AvailablePackages = availablePackages.Select(p => new MealPackage
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    City = p.City,
                    Canteen = p.Canteen,
                    PickupDateTime = p.PickupDateTime,
                    PickupDeadline = p.PickupDeadline,
                    Price = p.Price,
                    MealType = p.MealType,
                    Is18Plus = p.Is18Plus
                }).ToList(),
                Locations = locations.ToList(),
                MealTypes = mealTypes.ToList(),
                SelectedLocation = location,
                SelectedMealType = mealType
            };

            model.LocationSelectList = new SelectList(model.Locations, model.SelectedLocation);
            model.MealTypeSelectList = new SelectList(model.MealTypes, model.SelectedMealType);

            // Set the user's city as the default location if no location is selected
            if (string.IsNullOrEmpty(location) && User.Identity.IsAuthenticated)
            {
                // For now, we'll skip setting the user's city as it's not implemented in the IPackageRepository
                // You may want to add this functionality to a user service or repository later
                // model.SelectedLocation = await _userService.GetUserCityAsync(User.Identity.Name);
            }

            return View(model);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving package data");
            return View("Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private List<MealPackage> GetAvailablePackages()
    {
        try
        {
            // This should be replaced with actual data from a repository or service
            return new List<MealPackage>
            {
                new MealPackage
                {
                    Id = 1,
                    Name = "Vegetarian Delight",
                    Description = "A delicious vegetarian meal with fresh vegetables and tofu",
                    City = "Breda",
                    Canteen = "LD",
                    PickupDateTime = DateTime.Parse("2024-03-15 18:00"),
                    PickupDeadline = DateTime.Parse("2024-03-15 17:30"),
                    Price = 5.99m,
                    MealType = "Warm Meal",
                    Is18Plus = false
                },
                new MealPackage
                {
                    Id = 2,
                    Name = "Chicken Surprise",
                    Description = "A tasty chicken-based meal with rice and vegetables",
                    City = "Tilburg",
                    Canteen = "TL",
                    PickupDateTime = DateTime.Parse("2024-03-15 17:30"),
                    PickupDeadline = DateTime.Parse("2024-03-15 17:00"),
                    Price = 6.99m,
                    MealType = "Cold Meal",
                    Is18Plus = false
                },
                // Add more sample packages here
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while retrieving available packages");
            throw; // Re-throw the exception to be caught in the Index action
        }
    }

    private List<MealPackage> GetReservedPackages()
    {
        // This should be replaced with actual data from a repository or service
        return new List<MealPackage>
        {
            new MealPackage
            {
                Id = 3,
                Name = "Fish and Chips",
                Description = "Classic fish and chips meal with tartar sauce",
                City = "Den Bosch",
                Canteen = "DB",
                PickupDateTime = DateTime.Parse("2024-03-16 12:30"),
                PickupDeadline = DateTime.Parse("2024-03-16 12:00"),
                Price = 7.50m,
                MealType = "Warm Meal",
                Is18Plus = false
            }
        };
    }

    private List<string> GetLocations()
    {
        return new List<string> { "Breda", "Tilburg", "Den Bosch" };
    }

    private List<string> GetMealTypes()
    {
        return new List<string> { "Warm Meal", "Cold Meal" };
    }
}
