using PacificPrint.Shop.Core.Models;

namespace PacificPrint.Shop.Core.Mappers
{
    public static class UserDTOMapper
    {
        public static UserDTO ToDto(this PacificPrint.Shop.Data.Entities.User user)
        {
            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                OptionalName = user.OptionalName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.Username,
                Password = user.Password,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                UpdatedAt = user.UpdatedAt,
            };
        }

        public static PacificPrint.Shop.Data.Entities.User ToUserEntity(this UserDTO model)
        {
            return new PacificPrint.Shop.Data.Entities.User
            {
                Id = model.Id,
                FirstName = model.FirstName,
                OptionalName = model.OptionalName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Email = model.Email,
                Username = model.Username,
                Password = model.Password,
                Role = model.Role,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

    }
}

