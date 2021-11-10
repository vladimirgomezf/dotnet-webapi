using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using dotnet_webapi_frontend.Models;
using dotnet_webapi_frontend.Controllers;

namespace dotnet_webapi_frontend.Pages.Persona
{
    public class ListModel : PageModel
    {
        public List<Models.Persona> control = new List<Models.Persona>();

        public async void OnGet()
        {
            List<Models.Persona> EmpInfo = new List<Models.Persona>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44318/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/Persona");
                if (res.IsSuccessStatusCode)
                {
                    var EmpResponse = res.Content.ReadAsStringAsync().Result;
                    EmpInfo = JsonConvert.DeserializeObject<List<Models.Persona>>(EmpResponse);
                }
                control = EmpInfo;
            }
        }        
    }
}
