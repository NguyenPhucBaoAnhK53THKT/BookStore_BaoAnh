﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Shared
{
    public interface ICustomerService
    {
        Task<Customer[]> GetAllCustomer();
    }
}
