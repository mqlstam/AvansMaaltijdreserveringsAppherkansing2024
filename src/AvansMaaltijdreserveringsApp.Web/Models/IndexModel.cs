using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AvansMaaltijdreserveringsApp.Web.Models
{
    public class IndexModel
    {
        // List of available meal packages
        public List<MealPackage> AvailablePackages { get; set; }

        // List of reserved meal packages by the user
        public List<MealPackage> ReservedPackages { get; set; }

        // List of locations
        public List<string> Locations { get; set; }

        // List of meal types
        public List<string> MealTypes { get; set; }

        // Selected location
        public string SelectedLocation { get; set; }

        // Selected meal type
        public string SelectedMealType { get; set; }

        // SelectList for location
        public SelectList LocationSelectList { get; set; }

        // SelectList for meal type
        public SelectList MealTypeSelectList { get; set; }

        // Constructor to initialize the lists
        public IndexModel()
        {
            AvailablePackages = new List<MealPackage>();
            ReservedPackages = new List<MealPackage>();
            Locations = new List<string>();
            MealTypes = new List<string>();
        }
    }

    // Example of a MealPackage class
    public class MealPackage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Canteen { get; set; } = string.Empty;
        public DateTime PickupDateTime { get; set; }
        public DateTime PickupDeadline { get; set; }
        public bool Is18Plus { get; set; }
        public decimal Price { get; set; }
        public string MealType { get; set; } = string.Empty;
    }
}
