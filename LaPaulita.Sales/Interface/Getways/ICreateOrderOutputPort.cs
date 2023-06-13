using LaPaulita.Sales.BusinessRules.DTOs.ValidatorDTO;

namespace LaPaulita.Sales.BusinessRules.Interface.Getways
{
    public interface ICreateOrderOutputPort
    {
        Task Handle(int orderId);
        Task ValidationFaild(List<ValidationErrorDto> validationError);
    }
}
