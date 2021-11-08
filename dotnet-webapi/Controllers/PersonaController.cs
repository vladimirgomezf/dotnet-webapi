using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("permitir")]
    public class PersonaController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.TestCrudContext db = new Models.TestCrudContext())
            {
                var list = (from i in db.Personas
                            select i).ToList();
                return Ok(list);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.PersonaRequest model)
        {
            using (Models.TestCrudContext db = new Models.TestCrudContext())
            {
                Models.Persona oPersona = new Models.Persona();
                oPersona.Nombre = model.Nombre;
                oPersona.Edad = model.Edad;
                db.Personas.Add(oPersona);
                db.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Models.Request.PersonaEditRequest model)
        {
            using (Models.TestCrudContext db = new Models.TestCrudContext())
            {
                Models.Persona oPersona = db.Personas.Find(model.Id);
                oPersona.Nombre = model.Nombre;
                oPersona.Edad = model.Edad;
                db.Entry(oPersona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            using (Models.TestCrudContext db = new Models.TestCrudContext())
            {
                Models.Persona oPersona = db.Personas.Find(Id);
                db.Personas.Remove(oPersona);
                db.SaveChanges();
            }
            return Ok();
        }
    }
}
