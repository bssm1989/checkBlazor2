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
    public class ProvincesOfflineDb : IndexedDbDatabaseModel
    {
        public ProvincesOfflineDb()
        {
            Name = "ProvinceDb";
            Version = 4;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Province>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,
        };

    }
    public class Province
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public ICollection<Amper> Ampers { get; set; }

}
    public class Amper
    {
        public int Id { get; set; }
        public string Fullname { get; set; }

    }
    public class ProvinceContext : IndexedDbInterop
    {
        public ProvinceContext(IJSRuntime jSRuntime, IndexedDbOptions<ProvinceContext> options) : base(jSRuntime, options) { }
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