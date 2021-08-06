using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FirstBlazorApp.Pages
{
    public partial class Index2
    {
        Employee emp = new Employee();
        private List<Models.Employee> employees = new List<Employee>();
        private List<Models.survey_profile> survey_profile_list = new List<survey_profile>();
        bool displayValidationErrorMessages = false;
        bool displayUserAddedToDB = false;

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
        private async Task DeleteSurvey_profile(string id)
        {
            var openResult = await DBContext.OpenIndexedDb();
            await DBContext.DeleteByKey<string>("survey_profile", id);

            await Task.Run(() => OnInitializedAsync());
            await Task.CompletedTask;
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
        private void HandleInvalidSubmit(EditContext context)
        {
            displayValidationErrorMessages = true;
            displayUserAddedToDB = false;
        }
        protected override async Task OnInitializedAsync()
        {
            var openResult = await DBContext.OpenIndexedDb();
            survey_profile_list = await DBContext.GetAll<survey_profile>("survey_profile");
            employees = await DBContext.GetAll();
        }
        

    }
}
