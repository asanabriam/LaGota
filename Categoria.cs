using System;
using System.Collections.Generic;
using System.Text;

namespace LaGota
{
    class Categoria
    {
        private String descripcion, codigo;

        //Constructor vacío
        public Categoria()
        {
            Codigo = "";
            descripcion = "";
        }
        //Constructor con parametros
        public Categoria(string codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        // Setters y Getters de los atributos de la clase
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
