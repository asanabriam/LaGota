using System;
using System.Collections.Generic;
using System.Text;

namespace LaGota
{
    class Datos
    {
        private Cliente[] arregloClientes;
        private Funcionario[] arregloFuncionarios;
        private Categoria[] arregloCategorias;
        private Hidrometro[] arregloHidrometros;
        int indiceClientes, indiceFuncionarios, indiceCategorias, indiceHidrometros;

        internal Cliente[] ArregloClientes { get => arregloClientes; }
        internal Funcionario[] ArregloFuncionarios { get => arregloFuncionarios;  }
        internal Categoria[] ArregloCategorias { get => arregloCategorias;  }
        internal Hidrometro[] ArregloHidrometros { get => arregloHidrometros;  }
        public int IndiceClientes { get => indiceClientes;  }
        public int IndiceFuncionarios { get => indiceFuncionarios;  }
        public int IndiceCategorias { get => indiceCategorias; }
        public int IndiceHidrometros { get => indiceHidrometros;  }

        public Datos()
        {
            arregloClientes = new Cliente[10];
            arregloFuncionarios = new Funcionario[10];
            arregloCategorias = new Categoria[10];
            arregloHidrometros = new Hidrometro[10];
            indiceClientes = indiceFuncionarios = indiceCategorias = indiceHidrometros = 0;

        }

        public void RegistrarCliente(string id, string nombre, string primerApellido, string segundoApellido, String email, String celular)
        {
            Cliente c = new Cliente(id, nombre, primerApellido, segundoApellido, email, celular);
            arregloClientes[indiceClientes] = c;
            indiceClientes++;
        }

        public void RegistrarFuncionario(string id, string nombre, string primerApellido, string segundoApellido)
        {
            Funcionario f = new Funcionario(id, nombre, primerApellido, segundoApellido);
            arregloFuncionarios[indiceFuncionarios] = f;
            indiceFuncionarios++;
        }

        public void RegistraHidrometro(string nis, string marcara, string serie, Categoria categoria, Cliente cliente)
        {
            Hidrometro h = new Hidrometro(nis, marcara, serie, categoria, cliente);
            arregloHidrometros[indiceHidrometros] = h;
            indiceHidrometros++;
        }

        public void RegistroCategoria(string codigo, string descripcion)
        {
            Categoria c = new Categoria(codigo, descripcion);
            arregloCategorias[indiceCategorias] = c;
            indiceCategorias++;
        }


        public Categoria BuscaCategoria(string idCategoria)
        {
            Categoria c = new Categoria();

            for (int i = 0; i < indiceCategorias; i++)
            {
                if (idCategoria == arregloCategorias[i].Codigo)
                {
                    c = arregloCategorias[i];
                }
            }
            return c;
        }
        public Cliente BuscaCliente(string idCliente)
        {
            Cliente c = new Cliente();
            for (int i = 0; i < indiceClientes; i++)
            {
                if (idCliente == arregloClientes[i].Id)
                {
                    c = arregloClientes[i];
                }
            }
            return c;
        }

    }
}
