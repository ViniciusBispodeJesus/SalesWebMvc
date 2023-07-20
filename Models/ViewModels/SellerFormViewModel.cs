﻿using System.Collections;
using System.Collections.Generic;
using Teste.Models;

namespace SalesWeb.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
