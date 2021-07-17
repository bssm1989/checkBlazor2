using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb:IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb()
        {
            Name = "EmployeeData";
            Version = 4;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,
        };

    }
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string Fullname { get; set; }
        public string Email { get; set; }
        [Required]
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "UPRN must be numeric")]
        public string MobileNumber { get; set; }
    }
    public class EmployeeContext : IndexedDbInterop
    {
        public EmployeeContext(IJSRuntime jSRuntime, IndexedDbOptions<EmployeeContext> options) : base(jSRuntime, options) { }
        public async Task Add(Employee employee)
        {
            var openResult = await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employees");
            if (employees.Count==0)
            {
                employee.Id = 1;
            }
            else
            {

            var emp = employees.OrderByDescending(i => i.Id).First();
            employee.Id = emp.Id+1;
            }
            //var idMax = employee.Max(x = x.id);
            var result = await this.AddItems<Employee>("Employees", new List<Employee>() { employee });
        }
        public async Task<List<Employee>> GetAll()
        {
            var openResult = await this.OpenIndexedDb();
            return await this.GetAll<Employee>("Employees");
        }
    }
}
