namespace LaPaulita.UsesCase.Specifications
{
    public partial class OrderHeaderSpecification : ISpecification<OrderHeaderDto>
    {
        readonly List<ValidationErrorDto> validationErrors = new List<ValidationErrorDto>();
        readonly OrderHeaderDto _entity;

        public OrderHeaderSpecification(OrderHeaderDto entity)
        {
            this._entity = entity;
        }

        public List<ValidationErrorDto> IsValid()
        {
            IsAddressValid();
            IsCityValid();
            IsCountryValid();
            IsZipValid();

            return validationErrors;
        }

        private partial void IsAddressValid();
        private partial void IsCityValid();
        private partial void IsCountryValid();
        private partial void IsZipValid();

    }
}
