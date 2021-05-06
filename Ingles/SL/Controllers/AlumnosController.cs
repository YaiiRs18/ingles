using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class AlumnosController : ApiController
    {

        [HttpGet]
        [Route("api/GetAllAlu")]
        public IHttpActionResult GetAll()
        {
            ML.Response.AlumnosResponse request = BL.Alumnos.GetAll();
            return Ok(request.AlumnosList);


        }
        [HttpGet]
        [Route("api/GetByIdAlu/{ID}")]
        public IHttpActionResult GetById(int ID)
        {
            ML.Response.AlumnosResponse request = BL.Alumnos.GetById(ID);
            return Ok(request.AlumnosList);


        }
        [HttpPost]
        [Route("api/AddAlu")]
        public IHttpActionResult Add(ML.Entities.Alumnos alumnos)
        {
            ML.Response.AlumnosResponse request = BL.Alumnos.Add(alumnos);
            return Ok(request);


        }

        [HttpPut]
        [Route("api/UpdateAlu")]
        public IHttpActionResult Update(ML.Entities.Alumnos alumnos)
        {
            ML.Response.AlumnosResponse request = BL.Alumnos.Update(alumnos);
            return Ok(request);


        }

        [HttpDelete]
        [Route("api/DeleteAlu/{ID}")]
        public IHttpActionResult Delete(int ID)
        {
            ML.Response.AlumnosResponse request  = BL.Alumnos.Delete(ID);
            return Ok(request);


        }


    }
}
