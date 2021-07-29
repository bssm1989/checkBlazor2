﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb : IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb()
        {
            Name = "EmployeeData";
            Version = 40;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private IndexedDbStore _tableFieldStore2 => new TStore<province>();
        private IndexedDbStore _tableFieldStore3 => new TStore<tambon>();
        private IndexedDbStore _tableFieldStore4 => new TStore<district>();

    private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,_tableFieldStore2,_tableFieldStore4,_tableFieldStore3
        
        };
    
}

        public class Employee
    {
        [IndexDbKey(AutoIncrement = true)]
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
        public DateTime? localUpdate { get; set; }
        public DateTime? ServerUpdate { get; set; }
        public string Status { get; set; }
        public string User { get; set; }
    }
    public class EmployeeContext : IndexedDbInterop
    {

        public EmployeeContext(IJSRuntime jSRuntime, IndexedDbOptions<EmployeeContext> options) : base(jSRuntime, options) { }
        public async Task Add(Employee employee)
        {
            Random r = new Random();
            int num = r.Next();
            var openResult = await this.OpenIndexedDb();


            employee.Id = num;
            employee.localUpdate = DateTime.Now;
            //var idMa
            //x = employee.Max(x = x.id);
            _ = toServer(employee);
            var result = await this.AddItems<Employee>("Employee", new List<Employee>() { employee });
        }
        public async Task loadDbFromServer()
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorLoadDb.php?table=district");

                var openResult = await this.OpenIndexedDb();
                var contents = await response.Content.ReadAsStringAsync();
                List<district> DeserializedObjList = (List<district>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<district>));


                var db1Result1 = await this.DeleteAll("district" );
                 var db1Result2 = await this.AddItems<district>("district",DeserializedObjList);


                 response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorLoadDb.php?table=tambon");

               
                 contents = await response.Content.ReadAsStringAsync();
                List<tambon> DeserializedObjList2 = (List<tambon>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<tambon>));


                var db1Result3 = await this.DeleteAll("tambon");
                var db1Result4 = await this.AddItems<tambon>("tambon", DeserializedObjList2);


                response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorLoadDb.php?table=province");


                contents = await response.Content.ReadAsStringAsync();
                List<province> DeserializedObjList3 = (List<province>)Newtonsoft.Json.JsonConvert.DeserializeObject(contents, typeof(List<province>));


                var db1Result5 = await this.DeleteAll("province");
                var db1Result6 = await this.AddItems<province>("province", DeserializedObjList3);




                Random r = new Random();
                int num = r.Next();
                //  var openResult = await this.OpenIndexedDb();

                Employee employee = new Employee();
                employee.Id = num;
                employee.localUpdate = DateTime.Now;
                //var idMa
                //x = employee.Max(x = x.id);
               // _ = toServer(employee);
                var result = await this.AddItems<Employee>("Employee", new List<Employee>() { employee });


            }
        }
        public async Task toServer(Employee employee)
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                using (var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorTest.php?" +
                    "id=" + employee.Id +
                    "&FullName=" + employee.Fullname +
                    "&Email=" + employee.Email +
                    "&MobileNumber=" + employee.MobileNumber +
                    "&localUpdate=" + employee.localUpdate +
                    "&ServerUpdate=" + employee.ServerUpdate +
                    "&User=" + employee.User +
                    "&Status=" + employee.Status))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //ReceivedEmployee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
        }
        public async Task Delete(int id)
        {
            //   var openResult = await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employee");
            Employee emp = await GetByKey<int, Employee>("Employee", id);
           var test=new TStore<district>();
        var resultx = "";
            if (emp.Id > 0)
            {

                resultx = await this.DeleteByKey<int>("Employee", emp.Id);
            }




        }
        public async Task<List<Employee>> GetAll()
        {

            var openResult = await this.OpenIndexedDb();
            Random r = new Random();
            int num = r.Next();


            List<Employee> emp=new List<Employee>();
            emp.Add(new Employee { Id = num, Fullname = "" });

            //var idMa
            //x = employee.Max(x = x.id);
            var result = await this.AddItems<Employee>("Employee", emp) ;


            return await this.GetAll<Employee>("Employee");
        }
        public async Task<Employee> GetById(int id)
        {
            var openResult = await this.OpenIndexedDb();
            var emp = await this.GetAll<Employee>("Employee");
            var empById = emp.Where(x => x.Id == id);
            return (Employee)empById.First();
        }
        public async Task getToHttp()
        {

        }
        public async Task UpdateById(Employee emp)
        {
            await this.OpenIndexedDb();
            List<Employee> employees = await GetAll<Employee>("Employee");
            Employee emp1 = await GetByKey<int, Employee>("Employee", emp.Id);
            var resultx = "";
            if (emp.Id > 0)
            {

                resultx = await this.DeleteByKey<int>("Employee", emp.Id);
                var result = await this.AddItems<Employee>("Employee", new List<Employee>() { emp });
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
