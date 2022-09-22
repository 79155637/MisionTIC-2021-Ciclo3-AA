using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
         [Required, StringLength(30)]
        public string Nombre { get; set; }
         [Required, StringLength(30)]
        public string Apellidos { get; set; }
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}
