﻿using System.ComponentModel.DataAnnotations;

namespace SMIS.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string RegistrationNumber { get; set; }
    }
}
