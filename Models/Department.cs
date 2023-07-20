using SalesWeb.Models;
using System.Collections.Generic;
using System;
using System.Linq;
namespace Teste.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSellers(Seller s)
        {
            Sellers.Add(s);
        }
        
        public double TotalSales(DateTime initial, DateTime end)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, end));
        }
    }
}
