using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using dotnet_webapi_frontend.Models;
using System.Net.Http.Headers;

namespace dotnet_webapi_frontend.Pages.Persona
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public Models.Persona persona { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            Models.Persona obj = new() { Nombre = persona.Nombre, Edad = persona.Edad };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44318/");
                var stringData = JsonConvert.SerializeObject(obj);
                var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync("api/Persona", contentData);
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToPage("/Persona/List");
                }
            }
            return RedirectToPage("/Persona/Add");
        }
    }
}
