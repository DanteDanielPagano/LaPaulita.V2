using LaPaulita.Sales.BusinessRules.DTOs;

namespace LaPaulita.Sales.BusinessRules.Interface.Controllers
{
    public interface ICreateOrderController
    {
        Task<int> CreateOrder(OrderHeaderDto order);
    }
}
