using PacificPrint.Shop.Core.Models;

namespace PacificPrint.Shop.Core.Mappers
{
    public static class ProductDTOMapper
    {
        public static ProductDTO ToDto(this PacificPrint.Shop.Data.Entities.Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                UnitValue = product.UnitValue,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt,
            };
        }

        public static PacificPrint.Shop.Data.Entities.Product ToProductEntity(this ProductDTO model)
        {
            return new PacificPrint.Shop.Data.Entities.Product
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Category = model.Category,
                UnitValue = model.UnitValue,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

    }
}

