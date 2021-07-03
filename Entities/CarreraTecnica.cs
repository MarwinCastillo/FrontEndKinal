using System.Collections.Generic;

namespace ApiKalumNotas.Entities
{
    public class CarreraTecnica
    {
        public string CarreraId {get;set;}
        public string Nombre {get;set;}
        public virtual List<Clase> Clases {get;set;}

        public override string ToString()
        {
            return this.Nombre;
        }       
    }
}