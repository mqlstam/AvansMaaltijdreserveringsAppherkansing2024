using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using AvansMaaltijdreserveringsApp.Domain.Entities;

namespace AvansMaaltijdreserveringsApp.Domain.Entities
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PickupDateTime { get; set; }
        public bool IsReserved { get; set; }
        public bool IsAdultsOnly { get; set; }
        public string ReservedById { get; set; }
        public ApplicationUser ReservedBy { get; set; }
    }
}
