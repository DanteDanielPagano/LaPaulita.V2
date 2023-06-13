using LaPaulita.Sales.BusinessRules.DTOs;
using LaPaulita.Sales.BusinessRules.Interface;

namespace LaPaulita.UsesCase.Specifications
{
    public partial class OrderHeaderSpecification : ISpecification<OrderHeaderDto>
    {
        private partial void IsCityValid()
        {
            if (entity.ShippingCity <= 0)
            {
                validationErrors.Add(new ValidationErrorDto
                {
                    PropertyName = "SippingCity",
                    ErrorMessage = "La ciudad de entrega es obligatorio."
                });
            }
        }
    }
}
