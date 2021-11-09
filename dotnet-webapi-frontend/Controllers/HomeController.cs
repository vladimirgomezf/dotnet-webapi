using dotnet_webapi_frontend.Helpers;
using dotnet_webapi_frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dotnet_webapi_frontend.Controllers
{
    public class HomeController : Controller
    {
        PersonaAPI _api = new PersonaAPI();

        public async Task<IActionResult> Index()
        {
            List<Persona> per = new List<Persona>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/persona");
            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                per = JsonConvert.DeserializeObject<List<Persona>>(results);
            }
            return View(per);
        }
    }
}
