using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using static FirstBlazorApp.Pages.Surveypageone;

namespace FirstBlazorApp.Pages
{
    public partial class Index : ComponentBase
    {
        Employee emp = new Employee();
        private List<Models.Employee> employees = new List<Employee>();
        private List<Models.survey_profile> survey_profile_list = new List<survey_profile>();
        bool displayValidationErrorMessages = false;
        bool displayUserAddedToDB = false;

        //**************แบบสำรวจ***********
        private List<Models.staff_jun> re_ce = new List<Models.staff_jun>();
        private List<survey_staff> SurveyStaff= new List<survey_staff>();
        private List<Models.volunteer> name1 = new List<Models.volunteer>();
        private int num_total = 0;
        private string searchHc ="";
        class tableListSurvey
        {
            public survey_staff survey_staff { get; set; }
            public string HC { get; set; }
            public string UserName { get; set; }
            public string nameProvince { get; set; }
        }
        List<tableListSurvey> tableListSurveys= new List<tableListSurvey>();
        

        private List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();
        private List<survey_profile> survey_profiles = new List<survey_profile>();

        public class listTableByHc
		{
            List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();

        }
        

        public async Task synData()
        {
            await DBContext.loadDbFromServer();
        }
        
        // http

        Employee ReceivedEmployee;
        public string FormSubmitMessage { get; set; } = "Reservation Not Created";

        public async Task HandleValidSubmit()
        {
            ReceivedEmployee = new Employee();
            using (var httpClient = new HttpClient())
            {
                //StringContent content = new StringContent(JsonConvert.SerializeObject(employees), Encoding.UTF8, "application/json");



                using (var response = await httpClient.GetAsync("https://www.psutrobon.com/gis_bssm/blazorTest.php?id=9"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //ReceivedEmployee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                }
            }
            FormSubmitMessage = "Reservation Created";
        }

        private async Task GetSavedEmployees()
        { employees = await DBContext.GetAll(); }
        private async Task DeleteEmployee(int id)
        {
            await DBContext.Delete(id);
            await Task.Run(() => GetSavedEmployees());
            await Task.CompletedTask;
        }
        private async Task DeleteSurvey_profile(int? id)
        {
            var openResult = await DBContext.OpenIndexedDb();

            await DBContext.DeleteByKey<int?>("survey_profile", id);
            survey_profile_list = await DBContext.GetAll<survey_profile>("survey_profile");
            //var updateSurPro=await DBContext.GetByIndex<string, survey_profile>("survey_profile", "1", null, "hc", false);

            StateHasChanged();
        }
        private async Task EditEmp(int id)
        {
            emp = await DBContext.GetById(id);
            emp.Fullname = "dfdffd";
        }

        private async Task HandleValidSubmit(EditContext context)
        {
            displayValidationErrorMessages = true;
            displayUserAddedToDB = false;
            await DBContext.Add(new Models.Employee()
            {
                Email = emp.Email,
                Fullname = emp.Fullname,
                MobileNumber = emp.MobileNumber

            });
            emp.Fullname = "";
            emp.Email = "";
            emp.MobileNumber = "";
        }
        private async Task HandleInvalidSubmitAsync(EditContext context)
        {
            displayValidationErrorMessages = true;
            displayUserAddedToDB = false;
           

        }
        private async Task searchHcList()
        {
            //await DBContext.OpenIndexedDb;
            survey_profile_list_by_hc = await DBContext.GetAll<survey_profile>("survey_profile");
            //survey_profile_list_by_hc = survey_profile_list_by_hc
            //    .Where(x=>x.HC.Contains(searchHc) &&
            //    x.survey_year==configSurvey.survey_year &&
            //    x.survey_no== configSurvey.survey_no_num 
            //   ).ToList();
            SurveyStaff = await DBContext.GetAll<survey_staff>("survey_staff");
            var listProfileStaff = from sp in survey_profile_list_by_hc
                                   join st in SurveyStaff on sp.survey_no equals st.HC
                                   select new { sp,st };
            var listByhc = listProfileStaff.ToList();
            //listByhc.ElementAt(0).sp.HC;
        }
        protected override async Task OnInitializedAsync()
        {
            var openResult = await DBContext.OpenIndexedDb();
            survey_profile_list = (await DBContext.GetAll<survey_profile>("survey_profile")).OrderBy(x => x.create_survey).ToList();

            employees = await DBContext.GetAll();
            //************  syn data *********
            var getProvince = await DBContext.GetAll<province>("province");
            if (getProvince.Count == 0)
            {
                await DBContext.loadDbFromServer();
            }

            //**************แบบสำรวจ***********
            //$query_p = "select HC,JUN from        survey_profile where HC='$row->HC'";
            //198: 	$query_st = "select name from   volunteer where username='$row->staff'";
            //202: 	$query_j = "select              province_name_thai from province where province_id='$row_p->JUN'";
            //206: 	$qcheck = "select username from survey_check where HC='$row->HC' and survey_year='$survey_year' and survey_no='$survey_no'";
            var survey_profiles = await DBContext.GetAll<survey_profile>("survey_profile");
            var provinces = await DBContext.GetAll<province>("province");
            var survey_staffs = await DBContext.GetAll<survey_staff>("survey_staff");
            var listProfileStaff = from sp in survey_profiles
                                   join st in survey_staffs  on sp.HC equals st.HC
                                   select new { sp, st };
            var listByhc = listProfileStaff.ToList();
            foreach (var item in listByhc.OrderBy(x=>x.sp.create_survey))
            {
                var provinceName = "";
                var getTxtProvince = await DBContext.GetByIndex<string, province>("province",string.IsNullOrEmpty( item.sp.JUN)?"":item.sp.JUN,"","province_id", false);
               if(getTxtProvince.Count == 0)
                {
                    provinceName = "";
                }
                else
                {
                    provinceName = getTxtProvince.FirstOrDefault().province_name_thai;
                }
                tableListSurveys.Add(new tableListSurvey
                {
                    survey_staff = item.st,
                    UserName = item.st.staff,
                    nameProvince =provinceName,
                    HC = item.sp.HC
                }); 
            }

            num_total =survey_profile_list.Count();


        }
        public static string UnixTimeStampToDateTime(int? unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            if(unixTimeStamp == null)
            {
                return "";
            }
            else
            {
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds((double)unixTimeStamp).ToLocalTime();
                return dateTime.ToString();
            }
            
        }


        private string AddResult = string.Empty;
    }
}
