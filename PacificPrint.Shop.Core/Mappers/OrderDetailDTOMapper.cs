using PacificPrint.Shop.Core.Models;

namespace PacificPrint.Shop.Core.Mappers
{
    public static class OrderDetailDTOMapper
    {
        public static OrderDetailDTO ToDto(this PacificPrint.Shop.Data.Entities.OrderDetail orderdetail)
        {
            return new OrderDetailDTO
            {
                Id = orderdetail.Id,
                OrderId = orderdetail.OrderId,
                ProductId = orderdetail.ProductId,
                Quantity = orderdetail.Quantity,
                UnitValue = orderdetail.UnitValue,
                TotalValue = orderdetail.TotalValue,
                CreatedAt = orderdetail.CreatedAt,
                UpdatedAt = orderdetail.UpdatedAt,
            };
        }

        public static PacificPrint.Shop.Data.Entities.OrderDetail ToOrderDetailEntity(this OrderDetailDTO model)
        {
            return new PacificPrint.Shop.Data.Entities.OrderDetail
            {
                Id = model.Id,
                OrderId = model.OrderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitValue = model.UnitValue,
                TotalValue = model.TotalValue,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

    }
}

