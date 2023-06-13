namespace LaPaulita.Sales.Presenters
{
    public class CreateOrderPresenter : ICreateOrderPresenter
    {
        public int OrderId { get; private set; }

        public List<ValidationErrorDto> ErrorsList { get; private set; }

        public Task Handle(int orderId)
        {
            OrderId = orderId;
            return Task.CompletedTask;
        }

        public Task ValidationFaild(List<ValidationErrorDto> validationError)
        {
            ErrorsList = validationError;
            return Task.CompletedTask;
        }
    }
}
