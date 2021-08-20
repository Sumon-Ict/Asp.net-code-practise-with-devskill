using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BusinessObjects;
using TicketBookingSystem.Training.Exceptions;
using TicketBookingSystem.Training.UnitOfWorks;

namespace TicketBookingSystem.Training.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ITrainingUnitOfWork _trainingUnitOfWork;
        private readonly IMapper _mapper;

        public CustomerService(ITrainingUnitOfWork trainingUnitOfWork, IMapper mapper)
        {
            _trainingUnitOfWork = trainingUnitOfWork;
            _mapper = mapper;

        }
  

        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
                throw new InvalidParameterException("customer is not provided");

            if (IfNameAlraedyExist(customer.Name))

                throw new DuplicateNameException("this name is already exits");

            _trainingUnitOfWork.Customers.Add(_mapper.Map<Entities.Customer>(customer));
            _trainingUnitOfWork.Save();

        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

      
            public (IList<Customer> records, int total, int totalDisplay) GetCustomers(int pageIndex,
                int pageSize, string searchText, string sortText)
            {
                var customerData = _trainingUnitOfWork.Customers.GetDynamic(
                     string.IsNullOrEmpty(searchText) ? null : x => x.Name.Contains(searchText),
                     sortText,
                     string.Empty, pageIndex, pageSize);

                var resultData = (from customer in customerData.data
                                  select _mapper.Map<Customer>(customer)
                                 ).ToList();

                return (resultData, customerData.total, customerData.totalDisplay);

            }
  

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private bool IfNameAlraedyExist(string name)=>
            _trainingUnitOfWork.Customers.GetCount(x => x.Name == name) > 0;


        
    }
}
