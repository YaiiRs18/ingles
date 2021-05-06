using ML.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumnos
    {
        public static ML.Response.AlumnosResponse GetAll()
        {
            ML.Response.AlumnosResponse response = new ML.Response.AlumnosResponse();
            try
            {
                using (DL.InglesEntities3 context = new DL.InglesEntities3())
                {
                    var GetAll = context.SP_Alumnos_GetAll().ToList();

                    if (GetAll != null)
                    {

                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();

                        foreach (var obj in GetAll)
                        {
                            ML.Entities.Alumnos alumnosItem = new ML.Entities.Alumnos();
                            alumnosItem.Id_Alumnos = obj.Id_Alumnos;
                            alumnosItem.Nombre = obj.Nombre;
                            alumnosItem.APaterno = obj.APaterno;
                            alumnosItem.AMaterno = obj.AMaterno;
                            alumnosItem.Curp = obj.Curp;
                            alumnosItem.RFC = obj.RFC;
                            alumnosItem.Genero = obj.Genero;
                            alumnosItem.Carrera = obj.Carrera;
                            alumnosItem.Grupo = obj.Grupo;
                            alumnosItem.Tel_Casa = obj.Tel_Casa;
                            alumnosItem.Tel_Celular = obj.Tel_Celular;
                            alumnosItem.Correo = obj.Correo;
                            alumnosItem.Fecha_Nacimiento = obj.Fecha_Nacimiento;
                            alumnosItem.Domicilio= obj.Domicilio;
                            alumnosItem.Id_Tipo_Alumno = obj.Id_Tipo_Alumno;
                            response.AlumnosList.Add(alumnosItem);


                        }

                        return response;
                    }

                    else
                    {
                        response.Code = 50;
                        response.Message = "Ocrrio un error";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;

                    }

                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.AlumnosList = new List<ML.Entities.Alumnos>();
                return response;
            }


        }

        public static  ML.Response.AlumnosResponse GetById(int ID)
        {
            ML.Response.AlumnosResponse response = new ML.Response.AlumnosResponse();
            try
            {
                using (DL.InglesEntities3 context = new DL.InglesEntities3())
                {
                    var GetById = context.SP_Alumnos_GetById(ID).ToList();
                    
                    if(GetById != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();

                        foreach(var obj in GetById)
                        {
                            ML.Entities.Alumnos alumnosItem = new ML.Entities.Alumnos();
                            alumnosItem.Id_Alumnos = obj.Id_Alumnos;
                            alumnosItem.Nombre = obj.Nombre;
                            alumnosItem.APaterno = obj.APaterno;
                            alumnosItem.AMaterno = obj.AMaterno;
                            alumnosItem.Curp = obj.Curp;
                            alumnosItem.RFC = obj.RFC;
                            alumnosItem.Genero = obj.Genero;
                            alumnosItem.Carrera = obj.Carrera;
                            alumnosItem.Grupo = obj.Grupo;
                            alumnosItem.Tel_Casa = obj.Tel_Casa;
                            alumnosItem.Tel_Celular = obj.Tel_Celular;
                            alumnosItem.Correo = obj.Correo;
                            alumnosItem.Fecha_Nacimiento = obj.Fecha_Nacimiento;
                            alumnosItem.Domicilio = obj.Domicilio;
                            alumnosItem.Id_Tipo_Alumno = obj.Id_Tipo_Alumno;
                            response.AlumnosList.Add(alumnosItem);



                        }
                        return response;


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Ocurrio un error";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;

                    }


                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sitemas" + ex;
                response.AlumnosList = new List<ML.Entities.Alumnos>();
                return response;
            }



        }


        public static ML.Response.AlumnosResponse Add(ML.Entities.Alumnos alumnos)
        {
            ML.Response.AlumnosResponse response = new ML.Response.AlumnosResponse();
            try
            {
                using (DL.InglesEntities3 context = new DL.InglesEntities3())
                {
                    var Add = context.SP_Alumnos_Add(alumnos.Nombre, alumnos.APaterno, alumnos.AMaterno, alumnos.Curp, alumnos.RFC,
                                                     alumnos.Genero, alumnos.Carrera, alumnos.Grupo, alumnos.Tel_Casa, alumnos.Tel_Celular,
                                                     alumnos.Correo, alumnos.Fecha_Nacimiento, alumnos.Domicilio, alumnos.Id_Tipo_Alumno);
                    if (Add > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se agrego con exito";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;
                        


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al agregar";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;

                    }



                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.AlumnosList = new List<ML.Entities.Alumnos>();
                return response;
            }



        }

        public static ML.Response.AlumnosResponse Update( ML.Entities.Alumnos alumnos)
        {
            ML.Response.AlumnosResponse response = new ML.Response.AlumnosResponse();
            try
            {
                using (DL.InglesEntities3 context = new DL.InglesEntities3())
                {
                    var Update = context.SP_AlumnosUpdate(alumnos.Id_Alumnos, alumnos.Nombre, alumnos.APaterno, alumnos.AMaterno, alumnos.Curp, alumnos.RFC,
                                                     alumnos.Genero, alumnos.Carrera, alumnos.Grupo, alumnos.Tel_Casa, alumnos.Tel_Celular,
                                                     alumnos.Correo, alumnos.Fecha_Nacimiento, alumnos.Domicilio, alumnos.Id_Tipo_Alumno);
                    if(Update > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se actualizo con exito";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;



                    }

                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al actualizar";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;


                    }

                }
            }
            catch (Exception ex)
            {
                response.Code = -100;
                response.Message = "Se actualizo con exito"+ex;
                response.AlumnosList = new List<ML.Entities.Alumnos>();
                return response;
            }





        }

        public static ML.Response.AlumnosResponse Delete(int ID)
        {
            ML.Response.AlumnosResponse response = new ML.Response.AlumnosResponse();
            try
            {
                using (DL.InglesEntities3 context = new DL.InglesEntities3())
                {
                    var Delete = context.SP_Alumnos_Delete(ID);

                    if(Delete> 0)
                    {
                        response.Code = 100;
                        response.Message = "Se elimino con exito";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;



                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al eliminar";
                        response.AlumnosList = new List<ML.Entities.Alumnos>();
                        return response;

                    }
                        

                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Se elimino con exito" + ex;
                response.AlumnosList = new List<ML.Entities.Alumnos>();
                return response;
            }

        }

       


    }
}
