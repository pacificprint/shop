using System;
using System.Collections.Generic;

namespace PacificPrint.Shop.Data.Entities;

public partial class Client
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? OptionalName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Street { get; set; } = null!;

    public decimal HouseNumber { get; set; }

    public string Neighborhood { get; set; } = null!;

    public decimal Postalcode { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
