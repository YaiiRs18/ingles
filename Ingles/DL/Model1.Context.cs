//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class inglesEntities4 : DbContext
    {
        public inglesEntities4()
            : base("name=inglesEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Tipo_Alumno> Tipo_Alumno { get; set; }
    
        public virtual int SP_Alumnos_Add(string nombre, string aPaterno, string aMaterno, string curp, string rFC, string genero, string carrera, string grupo, string tel_Casa, string tel_Celular, string correo, string fecha_Nacimiento, string domicilio, Nullable<int> id_Tipo_Alumno)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var aPaternoParameter = aPaterno != null ?
                new ObjectParameter("APaterno", aPaterno) :
                new ObjectParameter("APaterno", typeof(string));
    
            var aMaternoParameter = aMaterno != null ?
                new ObjectParameter("AMaterno", aMaterno) :
                new ObjectParameter("AMaterno", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var carreraParameter = carrera != null ?
                new ObjectParameter("Carrera", carrera) :
                new ObjectParameter("Carrera", typeof(string));
    
            var grupoParameter = grupo != null ?
                new ObjectParameter("Grupo", grupo) :
                new ObjectParameter("Grupo", typeof(string));
    
            var tel_CasaParameter = tel_Casa != null ?
                new ObjectParameter("Tel_Casa", tel_Casa) :
                new ObjectParameter("Tel_Casa", typeof(string));
    
            var tel_CelularParameter = tel_Celular != null ?
                new ObjectParameter("Tel_Celular", tel_Celular) :
                new ObjectParameter("Tel_Celular", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var fecha_NacimientoParameter = fecha_Nacimiento != null ?
                new ObjectParameter("Fecha_Nacimiento", fecha_Nacimiento) :
                new ObjectParameter("Fecha_Nacimiento", typeof(string));
    
            var domicilioParameter = domicilio != null ?
                new ObjectParameter("Domicilio", domicilio) :
                new ObjectParameter("Domicilio", typeof(string));
    
            var id_Tipo_AlumnoParameter = id_Tipo_Alumno.HasValue ?
                new ObjectParameter("Id_Tipo_Alumno", id_Tipo_Alumno) :
                new ObjectParameter("Id_Tipo_Alumno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Alumnos_Add", nombreParameter, aPaternoParameter, aMaternoParameter, curpParameter, rFCParameter, generoParameter, carreraParameter, grupoParameter, tel_CasaParameter, tel_CelularParameter, correoParameter, fecha_NacimientoParameter, domicilioParameter, id_Tipo_AlumnoParameter);
        }
    
        public virtual int SP_Alumnos_Delete(Nullable<int> id_Alumnos)
        {
            var id_AlumnosParameter = id_Alumnos.HasValue ?
                new ObjectParameter("Id_Alumnos", id_Alumnos) :
                new ObjectParameter("Id_Alumnos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_Alumnos_Delete", id_AlumnosParameter);
        }
    
        public virtual ObjectResult<SP_Alumnos_GetAll_Result> SP_Alumnos_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Alumnos_GetAll_Result>("SP_Alumnos_GetAll");
        }
    
        public virtual ObjectResult<SP_Alumnos_GetById_Result> SP_Alumnos_GetById(Nullable<int> id_Alumnos)
        {
            var id_AlumnosParameter = id_Alumnos.HasValue ?
                new ObjectParameter("Id_Alumnos", id_Alumnos) :
                new ObjectParameter("Id_Alumnos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Alumnos_GetById_Result>("SP_Alumnos_GetById", id_AlumnosParameter);
        }
    
        public virtual int SP_AlumnosUpdate(Nullable<int> id_Alumnos, string nombre, string aPaterno, string aMaterno, string curp, string rFC, string genero, string carrera, string grupo, string tel_Casa, string tel_Celular, string correo, string fecha_Nacimiento, string domicilio, Nullable<int> id_Tipo_Alumno)
        {
            var id_AlumnosParameter = id_Alumnos.HasValue ?
                new ObjectParameter("Id_Alumnos", id_Alumnos) :
                new ObjectParameter("Id_Alumnos", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var aPaternoParameter = aPaterno != null ?
                new ObjectParameter("APaterno", aPaterno) :
                new ObjectParameter("APaterno", typeof(string));
    
            var aMaternoParameter = aMaterno != null ?
                new ObjectParameter("AMaterno", aMaterno) :
                new ObjectParameter("AMaterno", typeof(string));
    
            var curpParameter = curp != null ?
                new ObjectParameter("Curp", curp) :
                new ObjectParameter("Curp", typeof(string));
    
            var rFCParameter = rFC != null ?
                new ObjectParameter("RFC", rFC) :
                new ObjectParameter("RFC", typeof(string));
    
            var generoParameter = genero != null ?
                new ObjectParameter("Genero", genero) :
                new ObjectParameter("Genero", typeof(string));
    
            var carreraParameter = carrera != null ?
                new ObjectParameter("Carrera", carrera) :
                new ObjectParameter("Carrera", typeof(string));
    
            var grupoParameter = grupo != null ?
                new ObjectParameter("Grupo", grupo) :
                new ObjectParameter("Grupo", typeof(string));
    
            var tel_CasaParameter = tel_Casa != null ?
                new ObjectParameter("Tel_Casa", tel_Casa) :
                new ObjectParameter("Tel_Casa", typeof(string));
    
            var tel_CelularParameter = tel_Celular != null ?
                new ObjectParameter("Tel_Celular", tel_Celular) :
                new ObjectParameter("Tel_Celular", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var fecha_NacimientoParameter = fecha_Nacimiento != null ?
                new ObjectParameter("Fecha_Nacimiento", fecha_Nacimiento) :
                new ObjectParameter("Fecha_Nacimiento", typeof(string));
    
            var domicilioParameter = domicilio != null ?
                new ObjectParameter("Domicilio", domicilio) :
                new ObjectParameter("Domicilio", typeof(string));
    
            var id_Tipo_AlumnoParameter = id_Tipo_Alumno.HasValue ?
                new ObjectParameter("Id_Tipo_Alumno", id_Tipo_Alumno) :
                new ObjectParameter("Id_Tipo_Alumno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AlumnosUpdate", id_AlumnosParameter, nombreParameter, aPaternoParameter, aMaternoParameter, curpParameter, rFCParameter, generoParameter, carreraParameter, grupoParameter, tel_CasaParameter, tel_CelularParameter, correoParameter, fecha_NacimientoParameter, domicilioParameter, id_Tipo_AlumnoParameter);
        }
    
        public virtual ObjectResult<SP_Horarios_GetAll_Result> SP_Horarios_GetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Horarios_GetAll_Result>("SP_Horarios_GetAll");
        }
    
        public virtual ObjectResult<SP_Horarios_GetById_Result> SP_Horarios_GetById(Nullable<int> id_Horarios)
        {
            var id_HorariosParameter = id_Horarios.HasValue ?
                new ObjectParameter("Id_Horarios", id_Horarios) :
                new ObjectParameter("Id_Horarios", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Horarios_GetById_Result>("SP_Horarios_GetById", id_HorariosParameter);
        }
    
        public virtual int SP_HorariosAdd(string hora, string nivel, string grupo, Nullable<int> id_Alumnos)
        {
            var horaParameter = hora != null ?
                new ObjectParameter("Hora", hora) :
                new ObjectParameter("Hora", typeof(string));
    
            var nivelParameter = nivel != null ?
                new ObjectParameter("Nivel", nivel) :
                new ObjectParameter("Nivel", typeof(string));
    
            var grupoParameter = grupo != null ?
                new ObjectParameter("Grupo", grupo) :
                new ObjectParameter("Grupo", typeof(string));
    
            var id_AlumnosParameter = id_Alumnos.HasValue ?
                new ObjectParameter("Id_Alumnos", id_Alumnos) :
                new ObjectParameter("Id_Alumnos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_HorariosAdd", horaParameter, nivelParameter, grupoParameter, id_AlumnosParameter);
        }
    
        public virtual int SP_HorariosDelete(Nullable<int> id_Horarios)
        {
            var id_HorariosParameter = id_Horarios.HasValue ?
                new ObjectParameter("id_Horarios", id_Horarios) :
                new ObjectParameter("id_Horarios", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_HorariosDelete", id_HorariosParameter);
        }
    
        public virtual int SP_HorariosUpdate(Nullable<int> id_Horarios, string hora, string nivel, string grupo, Nullable<int> id_Alumnos)
        {
            var id_HorariosParameter = id_Horarios.HasValue ?
                new ObjectParameter("Id_Horarios", id_Horarios) :
                new ObjectParameter("Id_Horarios", typeof(int));
    
            var horaParameter = hora != null ?
                new ObjectParameter("Hora", hora) :
                new ObjectParameter("Hora", typeof(string));
    
            var nivelParameter = nivel != null ?
                new ObjectParameter("Nivel", nivel) :
                new ObjectParameter("Nivel", typeof(string));
    
            var grupoParameter = grupo != null ?
                new ObjectParameter("Grupo", grupo) :
                new ObjectParameter("Grupo", typeof(string));
    
            var id_AlumnosParameter = id_Alumnos.HasValue ?
                new ObjectParameter("Id_Alumnos", id_Alumnos) :
                new ObjectParameter("Id_Alumnos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_HorariosUpdate", id_HorariosParameter, horaParameter, nivelParameter, grupoParameter, id_AlumnosParameter);
        }
    }
}
