using System;
using System.Collections.Generic;
using System.Text;

namespace LaGota
{
    class Hidrometro
    {
        private string nis;
        private string marca;
        private string serie;
        private Categoria categoria;
        private Cliente cliente;

        //Constructor vacío.
        public Hidrometro()
        {
            nis = "";
            marca = "";
            serie = "";
            categoria = new Categoria();
            cliente = new Cliente();
        }
        //Constructor con parametros.
        public Hidrometro(string nis, string marca, string serie, Categoria categoria, Cliente cliente)
        {
            this.nis = nis;
            this.marca = marca;
            this.serie = serie;
            this.categoria = categoria;
            this.cliente = cliente;
        }

        // Setters y Getters de los atributos de la clase.
        public string Nis { get => nis; set => nis = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Serie { get => serie; set => serie = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
