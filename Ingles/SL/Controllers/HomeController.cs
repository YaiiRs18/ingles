using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using SL;

namespace SL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44331/");

            var request = clientHttp.GetAsync("api/GetAllAlu").Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Alumnos>>(DatosInfo);
                //var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Alumnos>>(DatosInfo);
                return View(Listado);
            }
            return View();

        }

        public ActionResult Agregar(int id = 0)
        {
            return View(new ML.Entities.Alumnos());
        }

        [HttpPost]
        public ActionResult Agregar(ML.Entities.Alumnos alumnos)
        {


            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44331/");

            var request = clientHttp.PostAsync("api/AddAlu", alumnos, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Alumnos>(DatosInfo);
                if (!ModelState.IsValid)
                {
                    return View(Listado);
                }
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Editar(int ID)
        {
             HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44331/");

            var request = clientHttp.GetAsync("api/GetByIdAlu/" + ID).Result;



            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<List<ML.Entities.Alumnos>>(DatosInfo);


                return View("Editar");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Editar(ML.Entities.Alumnos alumnos)
        {


            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44331/");

            var request = clientHttp.PutAsync("api/UpdateAlu/", alumnos, new JsonMediaTypeFormatter()).Result;

            if (request.IsSuccessStatusCode)
            {
                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Alumnos>(DatosInfo);
                if (!ModelState.IsValid)
                {
                    return View(Listado);
                }
                return RedirectToAction("Index");
            }

            return View();
        }



        [HttpGet]
        public ActionResult Delete(int ID)
        {


            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri("https://localhost:44331/");

            var request = clientHttp.DeleteAsync("api/DeleteAlu/" + ID).Result;


            if (request.IsSuccessStatusCode)
            {

                var DatosInfo = request.Content.ReadAsStringAsync().Result;
                var Listado = JsonConvert.DeserializeObject<ML.Entities.Alumnos>(DatosInfo);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
