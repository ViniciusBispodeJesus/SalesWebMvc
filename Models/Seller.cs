using System;
using System.Collections;
using System.Collections.Generic;
using Teste.Models;
using System.Linq;

namespace SalesWeb.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SallesRecord> Sales { get; set; } = new List<SallesRecord>();
        public Seller() {
        
        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
    }

        public void AddSales(SallesRecord record)
        {
            Sales.Add(record);
        }
        public void RemoveSales(SallesRecord record)
        {
            Sales.Remove(record);
        }

        public double TotalSales(DateTime initial, DateTime end)
        {
            return Sales.Where(record => record.Date >= initial && record.Date <= end).Sum(record => record.Amount);
        }
    }
}
