namespace DalApi;

using System;
using DO;
public interface ICustomer : ICrud<Customer>
{
    int Create(Func<Customer> convertBoCustomerToDoCustomer);
}
//{
//    int Create(Customer item);
//    Customer? Read(int id);
//    List<Customer> ReadAll();
//    void Update(Customer item);
//    void Delete(int id);

//}
