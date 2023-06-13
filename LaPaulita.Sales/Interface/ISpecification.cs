using LaPaulita.Sales.BusinessRules.DTOs.ValidatorDTO;

namespace LaPaulita.Sales.BusinessRules.Interface
{
    public interface ISpecification<T> where T : class
    {
        List<ValidationErrorDto> IsValid();
    }
}
