using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_frontend.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace dotnet_webapi_frontend.Controllers
{
    public class PersonaController : Controller
    {
        string Baseurl = "https://localhost:44318/";

        public async Task<List<Persona>> ListPersonas()
        {
            List<Persona> EmpInfo = new List<Persona>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/persona");
                if (res.IsSuccessStatusCode)
                {
                    var EmpResponse = res.Content.ReadAsStringAsync().Result;
                    EmpInfo = JsonConvert.DeserializeObject<List<Persona>>(EmpResponse);
                }
                return EmpInfo;
            }
        }
    }
}
