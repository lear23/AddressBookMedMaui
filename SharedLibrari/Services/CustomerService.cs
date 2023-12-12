using SharedLibrary.Models;

namespace SharedLibrary.Services;


public  class CustomerService
{
    private List<Customer> _customer = [new Customer { Email= "loki@lok.se"}];

    public bool AddCustomerToList(Customer customer)
    {
        if(!string.IsNullOrWhiteSpace(customer.Email))
        {
            _customer.Add(customer);
            return true;
        }
        return false;
    }


    public IEnumerable<Customer> GetCustomers()
    {
        return _customer;   
    }

    
    public bool RemoveCustomer(Customer customer)
    {
        if(!string.IsNullOrWhiteSpace(customer.Email))
        {
            var existingCustomer = _customer.FirstOrDefault(x => x.Email == customer.Email);

            if(existingCustomer != null)
            {
                _customer.Remove(existingCustomer);
                return true;
            }
          
        }
        return false;
    }



}
