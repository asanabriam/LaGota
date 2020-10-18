using System;
using System.Collections.Generic;
using System.Text;

namespace LaGota
{
    class Persona
    {
        private String id;
        private String nombre;
        private String primerApellido;
        private String segundoApellido;

        //Constructor vacío
        public Persona() 
        {
            id = "";
            nombre = "";
            primerApellido = "";
            segundoApellido = "";
        }
        //Constructor con parametros
        public Persona(String id, string nombre, string primerApellido, string segundoApellido)
        
        {
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
        }

        // Setters y Getters de los atributos de la clase
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
    }
}
