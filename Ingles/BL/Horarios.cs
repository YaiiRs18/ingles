using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Horarios
    {
        public static ML.Response.HorariosResponse GetAll()
        {
            ML.Response.HorariosResponse response = new ML.Response.HorariosResponse();
            try
            {
                using (DL.inglesEntities4 context = new DL.inglesEntities4())
                {
                    var GetAll = context.SP_Horarios_GetAll().ToList();
                    if(GetAll != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo Exitoso";
                        response.HorariosList = new List<ML.Entities.Horarios>();

                        foreach(var obj in GetAll)
                        {
                            ML.Entities.Horarios horariosItem = new ML.Entities.Horarios();
                            horariosItem.Id_Horarios = obj.Id_Horarios;
                            horariosItem.Hora = obj.Hora;
                            horariosItem.Nivel = obj.Nivel;
                            horariosItem.Grupo = obj.Grupo;
                            horariosItem.Alumnos = new ML.Entities.Alumnos();
                            horariosItem.Alumnos.Id_Alumnos= obj.Id_Alumnos;
                            response.HorariosList.Add(horariosItem);


                        }
                        return response;

                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Ocurrio un error";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }



                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }


        }

        public static ML.Response.HorariosResponse GetById (ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse response = new ML.Response.HorariosResponse();
            try
            {
                using (DL.inglesEntities4 context = new DL.inglesEntities4())
                {
                    var GetById = context.SP_Horarios_GetById(horarios.Id_Horarios).ToList();
                    if(GetById != null)
                    {
                        response.Code = 100;
                        response.Message = "Mapeo extoso";
                        response.HorariosList = new List<ML.Entities.Horarios>();

                        foreach(var obj in GetById)
                        {
                            ML.Entities.Horarios horariosItem = new ML.Entities.Horarios();
                            horariosItem.Id_Horarios = obj.Id_Horarios;
                            horariosItem.Hora = obj.Hora;
                            horariosItem.Nivel = obj.Nivel;
                            horariosItem.Grupo = obj.Grupo;
                            horariosItem.Alumnos = new ML.Entities.Alumnos();
                            horariosItem.Alumnos.Id_Alumnos = obj.Id_Alumnos;
                            response.HorariosList.Add(horariosItem);

                        }
                        return response;
                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Ocurrio un error";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;

                    }
                }

            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Repota con sistemas"+ ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }

        }
        
        public static ML.Response.HorariosResponse Add(ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse response = new ML.Response.HorariosResponse();
           
            try
            {
                using (DL.inglesEntities4 context = new DL.inglesEntities4())
                {
                   
                    var Add = context.SP_HorariosAdd(horarios.Hora, horarios.Nivel, horarios.Grupo, horarios.Alumnos.Id_Alumnos);
                    if(Add > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se agrego con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;


                    }
                    else
                        response.Code = 50;
                    response.Message = "Error al agregar";
                    response.HorariosList = new List<ML.Entities.Horarios>();
                    return response;



                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }


        }

        public static ML.Response.HorariosResponse Update (ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse response = new ML.Response.HorariosResponse();
            try
            {
                using (DL.inglesEntities4 context = new DL.inglesEntities4())
                {
               
                    var Update = context.SP_HorariosUpdate(horarios.Id_Horarios, horarios.Hora, horarios.Nivel, horarios.Grupo, horarios.Alumnos.Id_Alumnos);
                    if (Update > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se actualizo con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al actualizar";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;
                    }

                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Se actualizo con exito" + ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }


        }

        public static ML.Response.HorariosResponse Delete (ML.Entities.Horarios horarios)
        {
            ML.Response.HorariosResponse response = new ML.Response.HorariosResponse();
            try
            {
                using (DL.inglesEntities4 context = new DL.inglesEntities4())
                {
                    var Delete = context.SP_HorariosDelete(horarios.Id_Horarios);
                    if(Delete > 0)
                    {
                        response.Code = 100;
                        response.Message = "Se elimino con exito";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;


                    }
                    else
                    {
                        response.Code = 50;
                        response.Message = "Error al eliminar";
                        response.HorariosList = new List<ML.Entities.Horarios>();
                        return response;

                    }
                }
            }
            catch (Exception ex)
            {

                response.Code = -100;
                response.Message = "Reporta con sistemas"+ ex;
                response.HorariosList = new List<ML.Entities.Horarios>();
                return response;
            }

        }





    }
}
