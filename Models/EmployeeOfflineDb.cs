using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Helpers;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.Data.SqlClient;
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
            //var idMa
            //x = employee.Max(x = x.id);
            var result = await this.AddItems<Employee>("Employees", new List<Employee>() { employee });
        }

        public async Task Delete(int id)
        {
         //   var openResult = await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employees");
            Employee emp = await GetByKey<int,Employee>("Employees", id);
            var resultx="";
            if (emp.Id>0)
            {
                
                 resultx = await this.DeleteByKey<int>("Employees", emp.Id);
            }
        }
        public async Task<List<Employee>> GetAll()
        {
            var openResult = await this.OpenIndexedDb();
            return await this.GetAll<Employee>("Employees");
        }
        public async Task<Employee> GetById(int id)
        {
            var openResult = await this.OpenIndexedDb();
            var emp= await this.GetAll<Employee>("Employees");
            var empById= emp.Where(x => x.Id == id);
            return (Employee)empById.First();
        }
        public async Task getToHttp()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://119.59.125.182/gis_bssm/blazorTest.php?id=2");
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write("gg:22");
                streamWriter.Flush();
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        }
        public async Task UpdateById(Employee emp)
        {
            await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employees");
            Employee emp1 = await GetByKey<int, Employee>("Employees", emp.Id);
            var resultx = "";
            if (emp.Id > 0)
            {

                resultx = await this.DeleteByKey<int>("Employees", emp.Id);
                var result = await this.AddItems<Employee>("Employees", new List<Employee>() { emp });
            }

           
            //var transaction = db.transaction("Employees", IDBTransaction.READ_WRITE);
            //var objectStore = transaction.objectStore("MyObjectStore");
            //var request = objectStore.add({ Name: Name, Email: Email, Location: Location});
            //request.onsuccess = function(e) {
            //    // do something when the add succeeded                              
            //};
            //transaction.oncomplete = function(e) {
            //    // do something after the transaction completed      
            //};
            //transaction.onabort = function(e) {
            //    // do something after the transaction aborted     
            //};
            //transaction.onerrort = function(e) {
            //    // do something after the transaction canceled    
            //};



            //var openResult = await this.OpenIndexedDb();
            //openResult.transaction =
            //string strConnString = "myconnectionstring"; // get it from Web.config file    
            //SqlTransaction objTrans = null;

            //using (SqlConnection objConn = new SqlConnection(strConnString))
            //{
            //    objConn.Open();
            //    objTrans = objConn.BeginTransaction();
            //        try
            //    {
            //        List<Employee> employees = await GetAll<Employee>("Employees");
            //        Employee emp1 = await GetByKey<int, Employee>("Employees", emp.Id);
            //        var resultx = "";
            //        if (emp.Id > 0)
            //        {

            //            resultx = await this.DeleteByKey<int>("Employees", emp.Id);
            //        }
            //        var result = await this.AddItems<Employee>("Employees", new List<Employee>() { emp });
            //        objTrans.Commit();
            //    }
            //    catch (Exception)
            //    {
            //        objTrans.Rollback();
            //    }
            //    finally
            //    {
            //        objConn.Close();
            //    }
            // }

        }
    }
}
