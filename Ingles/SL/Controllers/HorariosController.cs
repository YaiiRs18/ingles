using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class HorariosController : ApiController
    {
        [HttpGet]
        [Route ("api/GetAll")]
        public IHttpActionResult GetAll()
        {
            ML.Response.HorariosResponse request = BL.Horarios.GetAll();
            return Ok(request);


        }
        [HttpGet]
        [Route("api/GetById")]
        public IHttpActionResult GetById(ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse request = BL.Horarios.GetById(horarios);
            return Ok(request);


        }
        [HttpPost]
        [Route("api/Add")]
        public IHttpActionResult Add(ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse request = BL.Horarios.Add(horarios);
            return Ok(request);


        }

        [HttpPut]
        [Route("api/Update")]
        public IHttpActionResult Update(ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse request = BL.Horarios.Update(horarios);
            return Ok(request);


        }

        [HttpDelete]
        [Route("api/Delete")]
        public IHttpActionResult Delete(ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse request = BL.Horarios.Delete(horarios);
            return Ok(request);


        }



    }
}
