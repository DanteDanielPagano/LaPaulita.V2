namespace LaPaulita.Sales.BusinessRules.Interface.Presenters
{
    public interface ICreateOrderPresenter : ICreateOrderOutputPort
    {
        int OrderId { get; }
        List<ValidationErrorDto> ErrorsList { get; }
    }
}
