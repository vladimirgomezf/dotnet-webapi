using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_razor.Helpers;
using dotnet_webapi_razor.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace dotnet_webapi_razor.Controllers
{
    public class HomeController : Controller
    {
        PersonaAPI _api = new PersonaAPI();

        public async Task<IActionResult> Index()
        {
            List<PersonaData> persons = new List<PersonaData>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/persona");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                persons = JsonConvert.DeserializeObject<List<PersonaData>>(results);
            }
            return View(persons);
        }
    }
}
