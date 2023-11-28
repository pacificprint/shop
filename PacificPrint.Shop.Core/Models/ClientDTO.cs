using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Data
{
    public class ClientDTO
    {
        public Guid Id {get; set;}
        public string FirstName {get; set;}
        public string? OptionalName {get; set;}
        public string? MiddleName {get; set;}
        public string? LastName {get; set;}
        public string PhoneNumber {get; set;}
        public string? CompanyName {get; set;}
        public string Street {get; set;}
        public decimal HouseNumber {get; set;}
        public string Neighborhood {get; set;}
        public decimal PostalCode {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public string Country {get; set;}
        public DateTime CreatedAt {get; set;}
        public DateTime UpdatedAt {get; set;}
    }
}
