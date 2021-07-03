using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiKalumNotas.Entities
{
    public class Alumno
    {
        public string Carne {get;set;}
        public string NoExpediente {get;set;}
        public string Apellidos {get;set;}
        public string Nombres {get;set;}
        public string Email {get;set;}
        public virtual List<AsignacionAlumno> Asignaciones {get;set;}
    }
}