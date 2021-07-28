using System;
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
            Version = 5;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private IndexedDbStore _tableFieldStore2 => new TStore<Province>();
        private IndexedDbStore _tableFieldStore3 => new TStore<Amper>();
   
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,_tableFieldStore2,_tableFieldStore3
        };

    }
    public class district
    {
        public string district_id { get; set; }
        public int province_id { get; set; }
        public string district_name_thai { get; set; }
        public string district_name_eng { get; set; }
        public int comment { get; set; }

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
            var result = await this.AddItems<Employee>("Employees", new List<Employee>() { employee });
        }
        public async Task loadDbFromServer()
        {

            using (var httpClient = new HttpClient())
            {
                // StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorLoadDb.php");
                

                    var contents = await response.Content.ReadAsStringAsync();
                contents = "";
                    //ReceivedEmployee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                
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
            List<Employee> employees = await GetAll<Employee>("Employees");
            Employee emp = await GetByKey<int, Employee>("Employees", id);
            var resultx = "";
            if (emp.Id > 0)
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
            var emp = await this.GetAll<Employee>("Employees");
            var empById = emp.Where(x => x.Id == id);
            return (Employee)empById.First();
        }
        public async Task getToHttp()
        {

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
