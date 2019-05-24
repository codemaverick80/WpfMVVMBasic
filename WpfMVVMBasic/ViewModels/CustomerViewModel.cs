using System;
using System.Diagnostics;
using System.Windows.Input;
using WpfMVVMBasic.Commands;
using WpfMVVMBasic.Models;

namespace WpfMVVMBasic.ViewModels
{
   internal class CustomerViewModel
    {
        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class
        /// </summary>
        public CustomerViewModel()
        {
            _Customer = new Customer("Harish Chand");
            UpdateCommand = new CustomerUpdateCommand(this);

        }
        /// <summary>
        /// Gets or sets a System.Boolean value indicating whether the Customer can be updated
        /// </summary>
        public bool CanUpdate
        {
            get
            {
                if (Customer == null)
                {
                    return false;
                }
                return !string.IsNullOrWhiteSpace(Customer.Name);
            }
            
        }

        private Customer _Customer;
        /// <summary>
        /// Get the Customer instance
        /// </summary>
        public Customer Customer {
            get
            {
                return _Customer;
            }
        }

        /// <summary>
        /// Gets the UpdateCommand for the ViewModel.
        /// </summary>
        public ICommand UpdateCommand
        {
            get;
            private set;
        }
       

        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated", Customer.Name));
        }


    }
}
