﻿using migo_be.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Alliance_API.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
 
        public string CityAddress { get; set; } = string.Empty;

        public string CityContactNumber { get; set; } = string.Empty;
       
        public int NumberOfDependents { get; set; } = 0;

        public string? CivicClubAffiliation { get; set; }

        public string Religion { get; set; } = string.Empty;

        public string BloodType { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

        public string Sex { get; set; } = string.Empty;

        public string CivilStatus { get; set; } = string.Empty;

        public string Birthdate { get; set; } = string.Empty;

        public string Profession { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public int YearsOfExperience { get; set; } = 0;

        public string ContractType { get; set; } = string.Empty;

        public string PositionApplied { get; set; } = string.Empty;

        public string PositionCode { get; set; } = string.Empty;

        public string DateJoined { get; set; } = string.Empty;

        public string EmergencyName { get; set; } = string.Empty;

        public string EmergencyAddress { get; set; } = string.Empty;

        public string EmergencyContactNumber { get; set; } = string.Empty;

        public string EmergencyRelationship { get; set; } = string.Empty;
  
        public List<Project>? AssignedProjects { get; set; }
        public List<EmployeeTimeLogs>? EmployeeTimeLogs { get; set; }
    }
}

