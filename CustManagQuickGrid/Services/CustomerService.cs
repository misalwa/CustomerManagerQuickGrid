using CustManagQuickGrid.Data;
using Microsoft.EntityFrameworkCore;

namespace CustManagQuickGrid.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task AddNewCustomer(Customer customer)
        {
            using (var context = new CustomerDbContext())
            {
                await context.Customers.AddAsync(customer);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteCustomer(int Id)
        {
            using (var context = new CustomerDbContext())
            {
                var customerToDelete = await context.Customers.FindAsync(Id);
                if (customerToDelete != null)
                {
                    context.Customers.Remove(customerToDelete);
                    await context.SaveChangesAsync();
                }
            }
        }



        public async Task<List<Customer>> GetAllCustomers()
        {
            using (var context = new CustomerDbContext())
            {
               return await context.Customers.ToListAsync();
            }
        }

        public async Task UpdateCustomer(Customer customer)
        {
            using (var context = new CustomerDbContext())
            {
                context.Customers.Update(customer);
                await context.SaveChangesAsync();
            }
        }
    }
}
