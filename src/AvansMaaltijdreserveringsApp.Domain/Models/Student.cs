using System;

namespace AvansMaaltijdreserveringsApp.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }
        public string StudyCity { get; set; }
        public string PhoneNumber { get; set; }
    }
}
