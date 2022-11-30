using CustManagQuickGrid.Data;
namespace CustManagQuickGrid.Services;

public interface ICustomerService
{
    Task AddNewCustomer(Customer customer);
    Task<List<Customer>> GetAllCustomers();
    Task DeleteCustomer(int Id);
    Task UpdateCustomer(Customer customer);
}
