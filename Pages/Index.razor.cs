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

        private List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();
        private List<survey_profile> survey_profiles = new List<survey_profile>();

        public class listTableByHc
		{
            List<Models.survey_profile> survey_profile_list_by_hc = new List<survey_profile>();

        }
        string currentInputValue;

        public async Task synData()
        {
            await DBContext.loadDbFromServer();
        }
        public async Task Save()
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", "name", currentInputValue);
        }

        public async Task Read()
        {
            currentInputValue = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name");
        }

        public async Task Delete()
        {
            await JSRuntime.InvokeAsync<string>("localStorage.removeItem", "name");
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

            //**************แบบสำรวจ***********
            re_ce = await DBContext.GetByIndex<string, staff_jun>("staff_jun", "bassam","", "username",false);
            name1 = await DBContext.GetByIndex<string, volunteer>("volunteer", "bassam","", "username",false);


            num_total=survey_profile_list.Count();


        }
       

        private string AddResult = string.Empty;
    }
}
