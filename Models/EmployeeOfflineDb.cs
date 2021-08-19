using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;
using static FirstBlazorApp.Models.compute_hc4;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb : IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb()
        {
            Name = "EmployeeData";
            Version = 62;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private IndexedDbStore _tableFieldStore2 => new TStore<province>();
        private IndexedDbStore _tableFieldStore3 => new TStore<tambon>();
        private IndexedDbStore _tableFieldStore4 => new TStore<district>();
        private IndexedDbStore _tableFieldStore71 => new TStore<ch2_gis>();
        private IndexedDbStore _tableFieldStore5 => new TStore<ch2_gis2>();
        private IndexedDbStore _tableFieldStore6 => new TStore<compute_hc1>();
        private IndexedDbStore _tableFieldStore7 => new TStore<compute_hc2>();
        private IndexedDbStore _tableFieldStore8 => new TStore<compute_hc3>();
        private IndexedDbStore _tableFieldStore9 => new TStore<compute_hc4>();
        private IndexedDbStore _tableFieldStore11 => new TStore<employee>();
        private IndexedDbStore _tableFieldStore12 => new TStore<hc_result>();
        private IndexedDbStore _tableFieldStore13 => new TStore<hc_sum>();
        private IndexedDbStore _tableFieldStore14 => new TStore<hc_sum1>();
        private IndexedDbStore _tableFieldStore15 => new TStore<hc_sum2>();
        private IndexedDbStore _tableFieldStore16 => new TStore<hc_sum3>();
        private IndexedDbStore _tableFieldStore17 => new TStore<hc_sum4>();
        private IndexedDbStore _tableFieldStore18 => new TStore<hc_sum5>();
        private IndexedDbStore _tableFieldStore19 => new TStore<hc_sum6>();
        private IndexedDbStore _tableFieldStore20 => new TStore<hc_sum_check1>();
        private IndexedDbStore _tableFieldStore21 => new TStore<hc_sum_check2>();
        private IndexedDbStore _tableFieldStore22 => new TStore<income>();
        private IndexedDbStore _tableFieldStore23 => new TStore<income_edit>();
        private IndexedDbStore _tableFieldStore24 => new TStore<income_eef>();
        private IndexedDbStore _tableFieldStore25 => new TStore<insert_hc>();
        private IndexedDbStore _tableFieldStore26 => new TStore<jun_finish>();
        private IndexedDbStore _tableFieldStore27 => new TStore<jun_level_detail>();
        private IndexedDbStore _tableFieldStore28 => new TStore<jun_location>();
        private IndexedDbStore _tableFieldStore29 => new TStore<line_poor_rich>();
        private IndexedDbStore _tableFieldStore30 => new TStore<livingon_tpmap>();
        private IndexedDbStore _tableFieldStore31 => new TStore<livingon_tpmap2>();
        private IndexedDbStore _tableFieldStore32 => new TStore<livingon_tpmap3>();
        private IndexedDbStore _tableFieldStore33 => new TStore<livingon_tpmap4>();
        private IndexedDbStore _tableFieldStore34 => new TStore<log_file>();
        private IndexedDbStore _tableFieldStore35 => new TStore<log_file_2>();
        private IndexedDbStore _tableFieldStore36 => new TStore<mm>();
        private IndexedDbStore _tableFieldStore37 => new TStore<poverty>();
        private IndexedDbStore _tableFieldStore38 => new TStore<poverty_pattani>();
        private IndexedDbStore _tableFieldStore39 => new TStore<province>();
        private IndexedDbStore _tableFieldStore40 => new TStore<region>();
        private IndexedDbStore _tableFieldStore41 => new TStore<snapshot>();
        private IndexedDbStore _tableFieldStore42 => new TStore<staff_jun>();
        private IndexedDbStore _tableFieldStore43 => new TStore<survey_a1>();
        private IndexedDbStore _tableFieldStore44 => new TStore<survey_a2>();
        private IndexedDbStore _tableFieldStore45 => new TStore<survey_b1>();
        private IndexedDbStore _tableFieldStore46 => new TStore<survey_b2>();
        private IndexedDbStore _tableFieldStore47 => new TStore<survey_b3>();
        private IndexedDbStore _tableFieldStore48 => new TStore<survey_c1>();
        private IndexedDbStore _tableFieldStore49 => new TStore<survey_c2>();
        private IndexedDbStore _tableFieldStore50 => new TStore<survey_check>();
        private IndexedDbStore _tableFieldStore51 => new TStore<survey_d1>();
        private IndexedDbStore _tableFieldStore52 => new TStore<survey_d2>();
        private IndexedDbStore _tableFieldStore53 => new TStore<survey_d3>();
        private IndexedDbStore _tableFieldStore54 => new TStore<survey_e1>();
        private IndexedDbStore _tableFieldStore55 => new TStore<survey_e2>();
        private IndexedDbStore _tableFieldStore56 => new TStore<survey_e3>();
        private IndexedDbStore _tableFieldStore57 => new TStore<survey_f1>();
        private IndexedDbStore _tableFieldStore58 => new TStore<survey_profile>();
        private IndexedDbStore _tableFieldStore59 => new TStore<survey_staff>();
        private IndexedDbStore _tableFieldStore60 => new TStore<surwaya_tmp>();
        private IndexedDbStore _tableFieldStore61 => new TStore<tambon>();
        private IndexedDbStore _tableFieldStore62 => new TStore<tasaban>();
        private IndexedDbStore _tableFieldStore63 => new TStore<tpmap>();
        private IndexedDbStore _tableFieldStore64 => new TStore<tpmap_pattani>();
        private IndexedDbStore _tableFieldStore65 => new TStore<tpmap_pattani2>();
        private IndexedDbStore _tableFieldStore66 => new TStore<t_tambon>();
        private IndexedDbStore _tableFieldStore67 => new TStore<update_hc>();
        private IndexedDbStore _tableFieldStore68 => new TStore<upload_pic>();
        private IndexedDbStore _tableFieldStore69 => new TStore<users>();
        private IndexedDbStore _tableFieldStore70 => new TStore<volunteer>();

        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,_tableFieldStore2,_tableFieldStore4,_tableFieldStore3,_tableFieldStore5,
            _tableFieldStore6,_tableFieldStore7,_tableFieldStore8,_tableFieldStore9,_tableFieldStore11,
            _tableFieldStore12,_tableFieldStore13,_tableFieldStore14,_tableFieldStore15,_tableFieldStore16,_tableFieldStore17,
            _tableFieldStore18,_tableFieldStore19,_tableFieldStore20,_tableFieldStore21,_tableFieldStore22,_tableFieldStore23,
            _tableFieldStore24,_tableFieldStore25,_tableFieldStore26,_tableFieldStore27,_tableFieldStore28,_tableFieldStore29,
            _tableFieldStore30,_tableFieldStore31,_tableFieldStore32,_tableFieldStore33,_tableFieldStore34,_tableFieldStore35,
            _tableFieldStore36,_tableFieldStore37,_tableFieldStore38,_tableFieldStore40,_tableFieldStore41,
            _tableFieldStore42,_tableFieldStore43,_tableFieldStore44,_tableFieldStore45,_tableFieldStore46,_tableFieldStore47,
            _tableFieldStore48,_tableFieldStore49,_tableFieldStore50,_tableFieldStore51,_tableFieldStore52,_tableFieldStore53,
            _tableFieldStore54,_tableFieldStore55,_tableFieldStore56,_tableFieldStore57,_tableFieldStore58,_tableFieldStore59,
            _tableFieldStore60,_tableFieldStore62,_tableFieldStore63,_tableFieldStore64,_tableFieldStore65,
            _tableFieldStore66,_tableFieldStore67,_tableFieldStore68,_tableFieldStore69,_tableFieldStore70,_tableFieldStore71

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
        public string STATUS { get; set; }
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
                    "&Status=" + employee.STATUS))
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
        public async Task<List<province>> GetAll_survey1_provinces()
        {
            var openResult = await this.OpenIndexedDb();
            return await this.GetAll<province>("province");
        }
        public  List<district> GetAll_survey1_district(int province_id)
        {
            var openResult =  this.OpenIndexedDb();
            var result = this.GetAll<district>("district");
            return (List<district>)result.Result.Where(x => x.province_id == province_id);
        }
        public int randomNum()
        {
            Random r = new Random();
     int num = r.Next();
            return num;
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
        //public async Task getToHttp()
        //{

        //}
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
