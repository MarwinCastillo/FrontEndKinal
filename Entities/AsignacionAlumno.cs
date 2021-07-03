using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiKalumNotas.Helpers;
using Newtonsoft.Json;

namespace ApiKalumNotas.Entities
{
    public class AsignacionAlumno // : IValidatableObject
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
        public virtual Alumno Alumno {get;set;}
        public virtual Clase Clase {get;set;}

        /*public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //string fechaAuxiliar = FechaAsignacion.ToShortDateString();
            if(!string.IsNullOrEmpty(FechaPrueba))
            {
                DateTime fechaSalida;
                if(!DateTime.TryParse(FechaPrueba,out fechaSalida))
                {
                    yield return new ValidationResult("La fecha de asignación es invalida", new string[]{nameof(FechaAsignacion)});
                }            
            }
        }*/
    }
}