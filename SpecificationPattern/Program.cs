// See https://aka.ms/new-console-template for more information
using SpecificationPattern;

var customer = new Customer
{
    Age = 32,
    Firstname = "Michal",
    Lastname = "Kowalski",
    IsAdmin= false,
};

var canAccessToAcount = new CustomerAdult()
    .And(new CustomerNotTooOld())
    .And(new CustomerStartWithM())
    .Or(new CustomerIsAdmin());

var customerHaveAccess = canAccessToAcount.IsSatisfiedBy(customer);

Console.WriteLine(customerHaveAccess);