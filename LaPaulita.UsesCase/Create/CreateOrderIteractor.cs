using LaPaulita.Sales.BusinessRules.Agregates;
using LaPaulita.Sales.BusinessRules.Interface.Repositories;
using LaPaulita.UsesCase.Specifications;

namespace LaPaulita.Sales.UsesCase.Create
{
    public class CreateOrderIteractor : ICreateOrderInputPort
    {
        readonly ICreateOrderOutputPort _outputPort;
        readonly ISalesCommandRepository _repository;

        public CreateOrderIteractor(ICreateOrderOutputPort outputPort, ISalesCommandRepository repository)
        {
            _outputPort = outputPort;
            _repository = repository;
        }

        public async Task Handle(OrderHeaderDto createOrderDto)
        {
            // Instanciamos un objeto del tipo List<ValidationErrorDto> y le asignamos
            // lo que nos devuelva el método privado ValidateOrder.

            List<ValidationErrorDto> validationErrors = ValidateOrder(createOrderDto);

            // Consultamos si la lista validationErrors posee algún elemento.
            if (validationErrors.Count > 0)
            {
                // Si la lista poseía algún elemento, es que hay por lo menos un error
                // Entonses retormaos el OutputPort al presentador con la lista de errores.
                await _outputPort.ValidationFaild(validationErrors);
                return;
            }

            // Si no hay errores contiunuamos con la ejecución del código y
            // creamos la orden, luego guardamos los cambios y finalmente retornamos
            // el Id del registro creado.

            CreateOrder createOrder = CreateOrder.From(createOrderDto);
            await _repository.CreateOrder(createOrder);
            await _repository.SaveChange();
            await _outputPort.Handle(createOrder.Id);
        }

        private List<ValidationErrorDto> ValidateOrder(OrderHeaderDto createOrderDto)
        {
            List<ValidationErrorDto> errors = new List<ValidationErrorDto>();

            OrderHeaderSpecification validations = new OrderHeaderSpecification(createOrderDto);

            errors = validations.IsValid();

            return errors;
        }
    }
}
