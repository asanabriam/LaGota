using System;
using System.Collections.Generic;
using System.Text;

namespace LaGota
{
    class Funcionario : Persona
    {
        //Constructor vacío
        public Funcionario()
        {
            Id = "";
            Nombre = "";
            PrimerApellido = "";
            SegundoApellido = "";
        }
        //Constructor con parametros
        public Funcionario(string id, string nombre, string primerApellido, string segundoApellido) : 
            base(id, nombre, primerApellido, segundoApellido)
        {

        }
    }
}
