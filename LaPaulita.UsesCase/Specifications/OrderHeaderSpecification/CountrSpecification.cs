using LaPaulita.Sales.BusinessRules.DTOs;
using LaPaulita.Sales.BusinessRules.Interface;

namespace LaPaulita.UsesCase.Specifications
{
    public partial class OrderHeaderSpecification : ISpecification<OrderHeaderDto>
    {
        private partial void IsCountryValid()
        {
            if (_entity.ShippingCountry <= 0)
            {
                validationErrors.Add(new ValidationErrorDto
                {
                    PropertyName = "SippingCountry",
                    ErrorMessage = "El país de entrega es obligatorio."
                });
            }
        }
    }
}
