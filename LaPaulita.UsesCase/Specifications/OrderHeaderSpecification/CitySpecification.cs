namespace LaPaulita.UsesCase.Specifications
{
    public partial class OrderHeaderSpecification : ISpecification<OrderHeaderDto>
    {
        private partial void IsCityValid()
        {
            if (_entity.ShippingCity == 0)
            {
                validationErrors.Add(new ValidationErrorDto
                {
                    PropertyName = "SippingCity",
                    ErrorMessage = "La ciudad de entrega es obligatorio."
                });
            }
            if (_entity.ShippingCity < 0)
            {
                validationErrors.Add(new ValidationErrorDto
                {
                    PropertyName = "SippingCity",
                    ErrorMessage = "El dato suministrado es erroneo."
                });
            }
        }
    }
}
