using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace LaGota
{
    class Cliente : Persona
    {
        private String email;
        private String celular;

        //Constructor vacío
        public Cliente()
        {
            Id = "";
            Nombre = "";
            PrimerApellido = "";
            SegundoApellido ="";
            celular = "";
            email = "";
        }
        //Constructor con parametros
        public Cliente(string id, string nombre, string primerApellido, string segundoApellido, String email, String celular) :
            base(id, nombre, primerApellido, segundoApellido)
        {
            this.celular = celular;
            this.email = email;
        }

        // Setters y Getters de los atributos de la clase
        public string Email { get => celular; set => celular = value; }
        public string Celular { get => email; set => email = value; }

    }
}
