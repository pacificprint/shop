using PacificPrint.Shop.Core.Models;

namespace PacificPrint.Shop.Core.Mappers
{
    public static class OrderDTOMapper
    {
        public static OrderDTO ToDto(this PacificPrint.Shop.Data.Entities.Order order)
        {
            return new OrderDTO
            {
                Id = order.Id,
                ClientId = order.ClientId,
                UserId = order.UserId,
                Status = order.Status,
                Payment = order.Payment,
                PaymentValue = order.PaymentValue,
                TotalValue = order.TotalValue,
                CreatedAt = order.CreatedAt,
                UpdatedAt = order.UpdatedAt,
            };
        }

        public static PacificPrint.Shop.Data.Entities.Order ToOrderEntity(this OrderDTO model)
        {
            return new PacificPrint.Shop.Data.Entities.Order
            {
                Id = model.Id,
                ClientId = model.ClientId,
                UserId = model.UserId,
                Status = model.Status,
                Payment = model.Payment,
                PaymentValue = model.PaymentValue,
                TotalValue = model.TotalValue,
                CreatedAt = model.CreatedAt,
                UpdatedAt = model.UpdatedAt,
            };
        }

    }
}

