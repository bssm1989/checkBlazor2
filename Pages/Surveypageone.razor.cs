using FirstBlazorApp.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FirstBlazorApp.Pages
{
    public partial class Surveypageone:ComponentBase
    {
		//[Inject]
		//IJSRuntime JSRuntime { get; set; }
		//[Inject]
		//NavigationManager NavigationManager {  get; set; }
		string value1;
		survey_profile recordSurveyProfile = new survey_profile();
		List<province> provinces1 = new List<province>();
		List<district> districts = new List<district>();
		List<tambon> tambons = new List<tambon>();
		string provinceId;
		string districtId;
		string districtId2;
		string tambonId;
		private string threatId = null;
		private string threatId2 = null;
		private string threatId3 = null;
		//EmployeeContext DBContext;
		public string SelectProvinceId
		{
			get { return threatId; }
			set
			{
				threatId = value;
				SelectThreatValueChanged(value);
			}
		}
		public string SelectDistrictId
		{
			get { return threatId2; }
			set
			{

				threatId2 = value;
				if (value != null && value != "")
				{
					SelectDistrictValueChanged(value);
				}
				else
				{
					//	tambons.Clear();
				}

			}
		}
		public string SelectTambonId
		{
			get { return threatId3; }
			set
			{

				threatId3 = value;


			}
		}


		private async void SelectDistrictValueChanged(string id)
{//https://stackoverflow.com/questions/64802201/blazor-matblazor-how-to-catch-the-value-change-of-matselect-component
			int proId = Convert.ToInt32(id);
			if (id != null)
				tambons = await DBContext.GetByIndex<string, tambon>("tambon", id, null, "district_id", false);
			tambonId = "";
			StateHasChanged();


		}
		private async void SelectThreatValueChanged(string id)
{//https://stackoverflow.com/questions/64802201/blazor-matblazor-how-to-catch-the-value-change-of-matselect-component
			int proId = Convert.ToInt32(id);
			tambonId = "";
			districts = await DBContext.GetByIndex<int?, district>("district", proId, 0, "province_id", false);
SelectDistrictId = null;

			tambons = new List<tambon>();
			StateHasChanged();
			//
		}






		protected override async Task OnInitializedAsync()
		{
			provinces1 = await DBContext.GetAll<province>("province");
}
		protected async Task HandleValidSubmit(EditContext context)
		{
			var User = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "name");
await DBContext.OpenIndexedDb();
Random r = new Random();
			int num = r.Next();
			recordSurveyProfile.id = num;
			await DBContext.AddItems<survey_profile>("survey_profile", new List<survey_profile>() { recordSurveyProfile });
//update survey_profile set create_survey='".date("U")."' where HC='$HC'
//districts =await DBContext.GetByIndex<int?,district>("district", proId,0,"province_id",false);
			var getAll = await DBContext.GetAll<survey_profile>("survey_profile");
			List<survey_profile> updateSurPro = await DBContext.GetByIndex<string, survey_profile>("survey_profile", recordSurveyProfile.HC, null, "hc", false);
			updateSurPro.First().create_survey = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
			await DBContext.UpdateItems<survey_profile>("survey_profile", new List<survey_profile> { updateSurPro.First() });
//$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','เพิ่ม $HC')";
			await DBContext.AddItems<log_file>("log_file", new List<log_file>{
		new log_file{
			id=num,
				username=User,
				time1=(int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds,
				detail="เพิ่ม "+recordSurveyProfile.HC
			}
		});
			//$query1="insert into survey_staff (HC,survey_year,survey_no,staff) value('$HC','$survey_year','$survey_no','$staff')";

			NavigationManager.NavigateTo("index2");
			//$log="insert into log_file ( id,username,time1,detail) values('','$username','".date("U") ."','เพิ่ม $HC')";

		}
	}
}
