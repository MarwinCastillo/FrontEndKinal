using System;
using System.ComponentModel.DataAnnotations;
using ApiKalumNotas.Helpers;

namespace ApiKalumNotas.DTOs
{
    public class AsignacionAlumnoDTO
    {
        public string AsignacionId {get;set;}
        [Required(ErrorMessage = "El campo carné es requerido")]
        [Carne]
        public string Carne {get;set;}
        [Required(ErrorMessage = "El campo ClaseId es requerido")]
        public string ClaseId {get;set;}
        [Required (ErrorMessage = "El campo de la fecha es requerido")]        
        /*[NotMapped]
        public string FechaPrueba;*/
        public DateTime FechaAsignacion {get;set;}
    }
}