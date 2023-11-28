namespace PacificPrint.Shop.Data
{
    public static class ClientDTOMapper
    {
        public static ClientDTO ToDto(this PacificPrint.Shop.Data.Entities.Client client)
        {
            return new ClientDTO
            {
                Id = client.Id,
                FirstName = client.FirstName,
                OptionalName = client.OptionalName,
                MiddleName = client.MiddleName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
                CompanyName = client.CompanyName,
                Street = client.Street,
                HouseNumber = client.HouseNumber,
                Neighborhood = client.Neighborhood,
                PostalCode = client.PostalCode,
                City = client.City,
                State = client.State,
                Country = client.Country,
                CreatedAt = client.CreatedAt,
                UpdatedAt = client.UpdatedAt,
            };
        }

        public static PacificPrint.Shop.Data.Entities.Client ToClientEntity(this ClientDTO model)
        {
            return new PacificPrint.Shop.Data.Entities.Client
            {
                Id = model.Id,
                FirstName = model.FirstName,
                OptionalName = model.OptionalName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                CompanyName = model.CompanyName,
                Street = model.Street,
                HouseNumber = model.HouseNumber,
                Neighborhood = model.Neighborhood,
                PostalCode = model.PostalCode,
                City = model.City,
                State = model.State,
                Country = model.Country,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

    }
}

