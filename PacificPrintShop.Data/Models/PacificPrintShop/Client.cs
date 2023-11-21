using System;
using System.Collections.Generic;

namespace PacificPrintShop.Data.Models.PacificPrintShop;

public partial class Client
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? OptionalName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int HouseNumber { get; set; }

    public string Neighborhood { get; set; } = null!;

    public int PostalCode { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;
}
