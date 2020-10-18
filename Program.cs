using System;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;


namespace LaGota
{
    class Program
    {
        static Datos datos;
        static void Main(string[] args)
        {
             datos = new Datos();
            menuPrincipal();
        }

        static void pantalla()
        {
            Console.Title = "Sistema Automatizado de Recaudación y Facturación - SARF v1.0";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            escribePantalla(12, 1, " ╔══════════════════════════════════════════════════════════════════════════════════════════════╗");
            escribePantalla(12, 2, " ║                                            TAREA 1                                           ║");
            escribePantalla(12, 3, " ║                            ACUEDUCTOS Y ALCANTARILLADOS LA GOTA                              ║");
            escribePantalla(12, 4, " ║                                        CURSO UNED 830                                        ║");
            escribePantalla(12, 5, " ╚══════════════════════════════════════════════════════════════════════════════════════════════╝");
            escribePantalla(12, 27, " ═══════════════════════════════════════════════════════════════════════════════════════════════");
            escribePantalla(12, 28, "                                                                   Victor Sanabria Ced 205850984");
            escribePantalla(12, 29, "");
            //Console.ReadKey();
        }
        static void escribePantalla(int x, int y, string letra)
        { // función creada para imprimir en la pantalla una cadena de caracteres en un coordenada determinada
            gotoxy(x, y);
            Console.Write(letra);
        }

        static void gotoxy(int x, int y)
        { // función creada para imprimir en la pantalla una cadena de caracteres en un coordenada determinada
            System.Console.SetCursorPosition(x, y);
        }

        //Método que contine todas las funciones del menú
        static void menuPrincipal()
        {
            int m = 0; // Variable para almacenar la opción del usuario
            string opcion = "";// Variable para almacenar la opción del usuario
            do
            {
                pantalla();
                escribePantalla(26, 7, "----------- MENÚ PRINCIPAL -----------");
                escribePantalla(27, 10, "1. REGISTROS");
                escribePantalla(27, 11, "2. REPORTES");
                escribePantalla(27, 12, "3.  ");
                escribePantalla(27, 13, "4. INFORMACIÓN");
                escribePantalla(27, 14, "5. SALIR DEL SISTEMA");
                escribePantalla(27, 16, "Opción: [ ]");
                escribePantalla(70, 7, "╔═════════════════════════════════════╗");
                escribePantalla(70, 8, "║    _____         _____  ______      ║");
                escribePantalla(70, 9, "║   / ____|  /\\   |  __ \\|  ____|     ║");
                escribePantalla(70, 10, "║  | (___   /  \\  | |__) | |__        ║");
                escribePantalla(70, 11, "║   \\___ \\ / /\\ \\ |  _  /|  __|       ║");
                escribePantalla(70, 12, "║   ____) / ____ \\| | \\ \\| |          ║");
                escribePantalla(70, 13, "║  |_____/_/    \\_\\_|  \\_\\_|  Ver1.0  ║");
                escribePantalla(70, 14, "╚═════════════════════════════════════╝");
                gotoxy(36, 16);

                // Se lee la opcion del usuario y se valida
                try
                {
                    m = int.Parse(Console.ReadLine()); // se almacena la opción
                }
                catch (Exception)
                {
                    m = -1;
                }

                switch (m)
                {
                case 1:
                    do
                    {
                        System.Console.Clear();
                        pantalla();
                        escribePantalla(26, 7, "--------- REGISTROS ---------");
                        escribePantalla(27, 10, "1. Registro de clientes");
                        escribePantalla(27, 11, "2. Registro de funcionarios");
                        escribePantalla(27, 12, "3. Registro de hidrómetros");
                        escribePantalla(27, 13, "4. Registro de categorías de servicios");
                        escribePantalla(27, 14, "5. Atrás");
                        escribePantalla(27, 16, "Opción: [ ]");
                        escribePantalla(70, 9, "╔═══════════════════════════╗");
                        escribePantalla(70, 10, "║ ╦═╗╔═╗╔═╗╦╔═╗╔╦╗╦═╗╔═╗╔═╗ ║");
                        escribePantalla(70, 11, "║ ╠╦╝║╣ ║ ╦║╚═╗ ║ ╠╦╝║ ║╚═╗ ║");
                        escribePantalla(70, 12, "║ ╩╚═╚═╝╚═╝╩╚═╝ ╩ ╩╚═╚═╝╚═╝ ║");
                        escribePantalla(70, 13, "╚═══════════════════════════╝");
                        gotoxy(36, 16);
                        // Se lee la opcion del usuario y se valida
                        try
                        {
                            m = int.Parse(Console.ReadLine()); // se almacena la opción
                        }
                        catch
                        {
                            m = -1;
                        }
                        switch (m)
                        {
                            case 1: RegistroDeClientes(); break;
                            case 2: RegistroDeFuncionaros(); break;

                            case 3: RegistroDeHidrometros(); break;

                            case 4: RegistroDeCategorias(); break;

                            case 5: break;

                            default:

                                System.Console.Clear();
                                pantalla();
                                escribePantalla(28, 9, "***** OPCIÓN INCORRECTA *****");
                                System.Console.ReadKey(); break;
                        }
                    }
                    while (m != 5); // termina el ciclo si la opción es 4
                    m = 0;
                    break;
                case 2:
                    do
                    {
                        System.Console.Clear();
                        pantalla();
                        escribePantalla(26, 7, "----------- REPORTES DE REGISTROS -----------");
                        escribePantalla(27, 10, "1. Lista de clientes");
                        escribePantalla(27, 11, "2. Lista de funcionarios");
                        escribePantalla(27, 12, "3. Lista de hidrómetros");
                        escribePantalla(27, 13, "4. Listar todas las categorías");
                        escribePantalla(27, 14, "5. Atrás");
                        escribePantalla(27, 16, "Opción: [ ]");
                        escribePantalla(70, 9, "╔══════════════════════════╗");
                        escribePantalla(70, 10, "║ ╦═╗╔═╗╔═╗╔═╗╦═╗╔╦╗╔═╗╔═╗ ║");
                        escribePantalla(70, 11, "║ ╠╦╝║╣ ╠═╝║ ║╠╦╝ ║ ║╣ ╚═╗ ║");
                        escribePantalla(70, 12, "║ ╩╚═╚═╝╩  ╚═╝╩╚═ ╩ ╚═╝╚═╝ ║");
                        escribePantalla(70, 13, "╚══════════════════════════╝");
                        gotoxy(36, 16);


                        // Se lee la opcion del usuario y se valida
                        try
                        {
                            m = int.Parse(Console.ReadLine()); // se almacena la opción
                        }
                        catch
                        {
                            m = -1;
                        }
                        switch (m)
                        {
                            case 1: MostrarListaClientes(); break;

                            case 2: MostrarListaFuncionarios(); break;

                            case 3: MostarListaHidrometros(); break;

                            case 4: MostrarListaCategorias(); break;

                            case 5: break;

                            default:
                                System.Console.Clear();
                                pantalla();
                                escribePantalla(28, 9, "***** OPCIÓN INCORRECTA *****");
                                System.Console.ReadKey(); break;
                        }
                    }
                    while (m != 5); // termina el ciclo si la opción es 3
                    m = 0;
                    break;
                case 3:; break;

                case 4:; break;

                case 5:
                    System.Console.Clear();
                    pantalla();

                        do
                        {
                            System.Console.Clear();
                            pantalla();
                            escribePantalla(18, 18, "***** ¿Desea Salir del sistema? *****");
                            escribePantalla(18, 19, "      Digite 'S' para salir, o 'N' para continuar: [ ]");
                            gotoxy(104, 19);
                            opcion = Console.ReadLine();

                            if (opcion == "S" || opcion == "s"){
                                System.Console.Clear();
                                pantalla();
                                escribePantalla(28, 9, "***** FIN DEL PROGRAMA *****");
                                gotoxy(0, 25);
                                break;
                            }

                            else if (opcion == "N" || opcion == "n")
                            {
                                m = 0;
                            }
                            else
                            {
                                pantalla();
                                escribePantalla(18, 18, "***** Opción No valida *****");
                                m = 1;
                                System.Console.ReadKey(); 
                                
                            }


                        } while (m!=5 && m!=0);
                        break;
                default:

                    System.Console.Clear();
                    pantalla();
                    escribePantalla(28, 9, "***** OPCIÓN INCORRECTA *****");
                    System.Console.ReadKey(); break;
                }
            }
            while (m != 5);
        }
        //Método que solicita los datos del cliente y se encarga de almacenarlos
        static void RegistroDeClientes()
        {
        String id, nom, ape1, ape2, email, cel, opcion;
        Boolean continuar = true;

        do
        {
            pantalla();
            escribePantalla(20, 8, "INGRESO REGISTRO DE CLIENTE");
            escribePantalla(25, 10, "Número identificación...[                         ]");
            escribePantalla(25, 11, "Nombre..................[                         ]");
            escribePantalla(25, 12, "Apellido1...............[                         ]");
            escribePantalla(25, 13, "Apellido2...............[                         ]");
            escribePantalla(25, 14, "Email...................[                         ]");
            escribePantalla(25, 15, "Celular.................[                         ]");
            gotoxy(50, 10);
            id = Console.ReadLine();
            gotoxy(50, 11);
            nom = Console.ReadLine();
            gotoxy(50, 12);
            ape1 = Console.ReadLine();
            gotoxy(50, 13);
            ape2 = Console.ReadLine();
            gotoxy(50, 14);
            email = Console.ReadLine();
            gotoxy(50, 15);
            cel = Console.ReadLine();

            try
            {
                datos.RegistrarCliente(id, nom, ape1, ape2, email, cel);
                escribePantalla(28, 18, "***** CLIENTE REGISTRADO *****");
                escribePantalla(18, 20, "***** ¿Desea realizar otro registro? *****");
                escribePantalla(18, 21, "      Digite '1' para registrar otro Cliente, o cualquier otra letra para continuar: [ ]");
                gotoxy(104, 21);
                opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                escribePantalla(28, 20, "***** NO SE PUDO REGISTRAR EL CLIENTE - MEMORIA LLENA*****");
                System.Console.ReadKey();
            }
        }
        while (continuar);
    }
        
        //Método que solicita los datos del funcionario y se encarga de almacenarlos
        static void RegistroDeFuncionaros()  
        {
            String id, nom, ape1, ape2, opcion;
            Boolean continuar  = true ;

            do
            {
                pantalla();
                escribePantalla(20, 8, "INGRESO REGISTRO DE FUNCIONARIO");
                escribePantalla(25, 10, "Número identificación...[                         ]");
                escribePantalla(25, 11, "Nombre..................[                         ]");
                escribePantalla(25, 12, "Apellido1...............[                         ]");
                escribePantalla(25, 13, "Apellido2...............[                         ]");
                gotoxy(50, 10);
                id = Console.ReadLine();
                gotoxy(50, 11);
                nom = Console.ReadLine();
                gotoxy(50, 12);
                ape1 = Console.ReadLine();
                gotoxy(50, 13);
                ape2 = Console.ReadLine();

                try
                {
                    datos.RegistrarFuncionario(id, nom, ape1, ape2);
                    escribePantalla(28, 16, "***** FUNCIONARIO REGISTRADO *****");
                    escribePantalla(18, 18, "***** Desea realizar otro registro? *****");
                    escribePantalla(18, 19, "      Digite '1' para registrar otro Funcionario, o cualquier otra letra para continuar: [ ]");
                    gotoxy(104, 19);
                    opcion = Console.ReadLine();

                    if (opcion != "1")
                    {
                        continuar = false;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    escribePantalla(28, 20, "***** NO SE PUDO REGISTRAR EL FUNCIONARIO - MEMORIA LLENA*****");
                    System.Console.ReadKey();
                }
            }
            while (continuar);
        }
        
        //Método que solicita los datos del hidrómetro y se encarga de almacenarlos
        static void RegistroDeHidrometros()
        {
            string nis, marca, serie, cat, cli, opcion;

            cat =nis = marca = serie = cli = opcion = "";
            Boolean continuar = true;
            Boolean control = true;

            if (datos.IndiceCategorias != 0 && datos.IndiceClientes != 0)
            {
                do
                {
                    pantalla();
                    escribePantalla(20, 8, "INGRESO REGISTRO DE HIDROMETRO");
                    escribePantalla(12, 10, "Número de NIS....[                  ]");
                    escribePantalla(12, 11, "Marca............[                  ]");
                    escribePantalla(12, 12, "Número de serie..[                  ]");
                    escribePantalla(12, 13, "Código categoría.[                  ]");
                    escribePantalla(12, 14, "Id de Cliente....[                  ]");
                    gotoxy(30, 10);
                    nis = Console.ReadLine();
                    gotoxy(30, 11);
                    marca = Console.ReadLine();
                    gotoxy(30, 12);
                    serie = Console.ReadLine();
                    MostrarListaCategorias2();
                    gotoxy(30, 13);
                    while (control)
                    {
                        cat = Console.ReadLine();
                        if (datos.BuscaCategoria(cat).Codigo != "")
                        {
                            control = false;
                        }
                        else
                        {
                            escribePantalla(12, 20, "ERROR - ID DE CATEGORIA NO ENCONTADO");
                            System.Console.ReadKey();
                            escribePantalla(12, 20, "                                    ");
                            escribePantalla(12, 13, "Código categoría.[                  ]");
                            gotoxy(30, 13);
                        }

                    }

                    BorrarBloqueDerecho();
                    MostrarListaClientes2();
                    gotoxy(30, 14);
                    control = true;
                    while (control)
                    {
                        cli = Console.ReadLine();
                        if (datos.BuscaCliente(cli).Id != "")
                        {
                            control = false;
                        }
                        else
                        {
                            escribePantalla(12, 20, "ERROR - ID DE CLIENTE NO ENCONTRADO");
                            System.Console.ReadKey();
                            escribePantalla(12, 20, "                                    ");
                            escribePantalla(12, 14, "Id de Cliente....[                  ]");
                            gotoxy(30, 14);
                        }

                    }
                    try
                    {
                        Categoria categoria = datos.BuscaCategoria(cat);
                        Cliente cliente = datos.BuscaCliente(cli);
                        
                        datos.RegistraHidrometro(nis, marca, serie, categoria, cliente);
                        escribePantalla(28, 18, "***** HIDRÓMETRO REGISTRADO *****");
                        escribePantalla(18, 20, "*****¿Desea realizar otro registro?*****");
                        escribePantalla(18, 21, "      Digite '1' para registrar otro Hidrómetro, o cualquier otra letra para continuar: [ ]");
                        gotoxy(107, 21);
                        opcion = Console.ReadLine();

                        if (opcion != "1")
                        {
                            continuar = false;
                        }
                    }
                    catch(IndexOutOfRangeException)
                    {
                        escribePantalla(28, 20, "***** NO SE PUDO REGISTRAR EL HIDRÓMETRO - MEMORIA LLENA *****");
                        System.Console.ReadKey();
                    }
                }
                while (continuar);
            }

            else if (datos.IndiceCategorias == 0)
            {
                System.Console.Clear();
                pantalla();
                escribePantalla(28, 9, "***** ES NECESARIO PRIMERO AGREGAR UNA CATEGORÍA *****");
                System.Console.ReadKey();
            }

            else if (datos.IndiceClientes == 0)
            {
                System.Console.Clear();
                pantalla();
                escribePantalla(28, 9, "***** ES NECESARIO PRIMERO AGREGAR UN CLIENTE *****");
                System.Console.ReadKey();
            }

        }

        //Método que solicita los datos de la categoría y se encarga de almacenarlos
        static void RegistroDeCategorias()
        {
            {
                String cod, des, opcion;
                Boolean continuar = true;

                do
                {
                    pantalla();
                    escribePantalla(20, 8, "INGRESO REGISTRO DE CATEGORÍAS");
                    escribePantalla(25, 10, "Código..................[                         ]");
                    escribePantalla(25, 11, "Descripción.............[                         ]");
                    gotoxy(50, 10);
                    cod = Console.ReadLine();
                    gotoxy(50, 11);
                    des = Console.ReadLine();

                    try
                    {
                        datos.RegistroCategoria(cod, des);
                        escribePantalla(28, 14, "***** CATEGORÍA REGISTRADA *****");
                        escribePantalla(18, 16, "***** Desea realizar otro registro? *****");
                        escribePantalla(18, 17, "      Digite '1' para registrar otra Categoría, o cualquier otra letra para continuar: [ ]");
                        gotoxy(106, 17);
                        opcion = Console.ReadLine();

                        if (opcion != "1")
                        {
                            continuar = false;
                        }
                    }
                    catch(IndexOutOfRangeException)
                    {
                        escribePantalla(28, 20, "***** NO SE PUDO REGISTRAR LA CATEGORÍA - MEMORIA LLENA *****");
                        System.Console.ReadKey();
                    }
                }
                while (continuar);
            }
        }

        //Método que muestra la lista de clientes registrados en el sistema 
        static void MostrarListaClientes()
        {
            pantalla();
            escribePantalla(52, 7, "LISTA DE CLIENTES");
            escribePantalla(13, 8, "╔═══════════╦═══════════╦═══════════════╦═══════════════╦═══════════╦══════════════════════════╗");
            escribePantalla(13, 9, "║    ID     ║   NOMBRE  ║  1° APELLIDO  ║  2° APELLIDO  ║  CELULAR  ║  EMAIL                   ║");
            escribePantalla(13, 10, "╠═══════════╬═══════════╬═══════════════╬═══════════════╬═══════════╬══════════════════════════╣");
            for (int i = 1; i < 11; i++)
            {
                escribePantalla(13, 10 + i, "║           ║           ║               ║               ║           ║                          ║ ");
            }
            escribePantalla(13, 21, "╚═══════════╩═══════════╩═══════════════╩═══════════════╩═══════════╩══════════════════════════╝");

            for (int i = 0; i < datos.IndiceClientes; i++)
            {
                escribePantalla(13, 11 + i, "║" + datos.ArregloClientes[i].Id);
                escribePantalla(25, 11 + i, "║" + datos.ArregloClientes[i].Nombre);
                escribePantalla(37, 11 + i, "║" + datos.ArregloClientes[i].PrimerApellido);
                escribePantalla(53, 11 + i, "║" + datos.ArregloClientes[i].SegundoApellido);
                escribePantalla(69, 11 + i, "║" + datos.ArregloClientes[i].Email);
                escribePantalla(81, 11 + i, "║" + datos.ArregloClientes[i].Celular);
            }
            System.Console.ReadKey();
        }
       
        //Método que muestra la lista de funcionarios registrados en el sistema 
        static void MostrarListaFuncionarios()
        {
            pantalla();
            escribePantalla(29, 7, "LISTA DE FUNCIONARIOS");
            escribePantalla(13, 8, "╔═════════════╦═════════════╦═════════════════╦═════════════════╗");
            escribePantalla(13, 9, "║     ID      ║    NOMBRE   ║   1° APELLIDO   ║   2° APELLIDO   ║");
            escribePantalla(13, 10, "╠═════════════╬═════════════╬═════════════════╬═════════════════╣");
            for (int i = 1; i < 11; i++)
            {
                escribePantalla(13, 10 + i, "║             ║             ║                 ║                 ║ ");
            }
            escribePantalla(13, 21, "╚═════════════╩═════════════╩═════════════════╩═════════════════╝");

            for (int i = 0; i < datos.IndiceFuncionarios; i++)
            {
                escribePantalla(13, 11 + i, "║" + datos.ArregloFuncionarios[i].Id);
                escribePantalla(27, 11 + i, "║" + datos.ArregloFuncionarios[i].Nombre);
                escribePantalla(41, 11 + i, "║" + datos.ArregloFuncionarios[i].PrimerApellido);
                escribePantalla(59, 11 + i, "║" + datos.ArregloFuncionarios[i].SegundoApellido);
            }
            System.Console.ReadKey();
        }

        //Método que muestra la lista de Hidrómetros registrados en el sistema
        static void MostarListaHidrometros()
        {
            pantalla();
            escribePantalla(35, 7, "LISTA DE HIDRÓMETROS");
            escribePantalla(13, 8, "╔══════════════╦═════════════════╦═══════════════════════════════╗");
            escribePantalla(13, 9, "║     NIS      ║      MARCA      ║          CATEGORÍA            ║");
            escribePantalla(13, 10, "╠══════════════╬═════════════════╬═══════════════════════════════╣");
            for (int i = 1; i < 11; i++)
            {
                escribePantalla(13, 10 + i, "║              ║                 ║                               ║ ");
            }
            escribePantalla(13, 21, "╚══════════════╩═════════════════╩═══════════════════════════════╝");

            for (int i = 0; i < datos.IndiceHidrometros; i++)
            {
                escribePantalla(13, 11 + i, "║" + datos.ArregloHidrometros[i].Nis);
                escribePantalla(28, 11 + i, "║" + datos.ArregloHidrometros[i].Marca);
                escribePantalla(46, 11 + i, "║" + datos.ArregloHidrometros[i].Categoria.Descripcion);
            }
            System.Console.ReadKey();
        }
        
        //Método que muestra la lista de categorías registrados en el sistema
        static void MostrarListaCategorias()
        {
            pantalla();
            escribePantalla(29, 7, "LISTA DE CATEGORÍAS");
            escribePantalla(13, 8, "╔══════════════╦════════════════════════════════════╗");
            escribePantalla(13, 9, "║    CÓDIGO    ║   DESCRIPCIÓN                      ║");
            escribePantalla(13, 10, "╠══════════════╬════════════════════════════════════╣");
            for (int i = 1; i < 11; i++)
            {
                escribePantalla(13, 10 + i, "║              ║                                    ║ ");
            }
            escribePantalla(13, 21, "╚══════════════╩════════════════════════════════════╝");

            for (int i = 0; i < datos.IndiceCategorias; i++)
            {
                escribePantalla(13, 11 + i, "║" + datos.ArregloCategorias[i].Codigo);
                escribePantalla(28, 11 + i, "║" + datos.ArregloCategorias[i].Descripcion);
            }
            System.Console.ReadKey();

        }

        //Método que muestra la lista de categorías registrados en la parte derecha de la consola
        static void MostrarListaCategorias2()
        {
            escribePantalla(75, 7, "LISTA DE CATEGORIAS");
            escribePantalla(56, 8, "╔══════════════╦════════════════════════════════════╗");
            escribePantalla(56, 9, "║    CODIGO    ║   DESCRIPCION                      ║");
            escribePantalla(56, 10, "╠══════════════╬════════════════════════════════════╣");
            for (int i = 1; i < datos.IndiceCategorias + 1; i++)
            {
                escribePantalla(56, 10 + i, "║              ║                                    ║ ");
            }
            escribePantalla(56, 11 + datos.IndiceCategorias, "╚══════════════╩════════════════════════════════════╝");

            for (int i = 0; i < datos.IndiceCategorias; i++)
            {
                escribePantalla(56, 11 + i, "║" + datos.ArregloCategorias[i].Codigo);
                escribePantalla(71, 11 + i, "║" + datos.ArregloCategorias[i].Descripcion);
            }
        }

        //Método que muestra la lista de clientes registrados en la parte derecha de la consola
        static void MostrarListaClientes2()
        {
            escribePantalla(75, 7, "LISTA DE CLIENTES");
            escribePantalla(56, 8, "╔══════════════╦════════════════════════════════════╗");
            escribePantalla(56, 9, "║      ID      ║   NOMBRE                           ║");
            escribePantalla(56, 10, "╠══════════════╬════════════════════════════════════╣");
            for (int i = 1; i < datos.IndiceClientes + 1; i++)
            {
                escribePantalla(56, 10 + i, "║              ║                                    ║ ");
            }
            escribePantalla(56, 11 + datos.IndiceClientes, "╚══════════════╩════════════════════════════════════╝");

            for (int i = 0; i < datos.IndiceClientes; i++)
            {
                escribePantalla(56, 11 + i, "║" + datos.ArregloClientes[i].Id);
                escribePantalla(71, 11 + i, "║" + datos.ArregloClientes[i].Nombre +" " + datos.ArregloClientes[i].PrimerApellido );
            }
        }

        //Método utilizado para reemplazar los caracteres que se encuentran impresos en la parte derecha de la consola
        static void BorrarBloqueDerecho()
        {
            for (int i = 1; i<17; i++){
                for (int n = 1; n < 55; n++)
                {
                    escribePantalla(55+n, 6+i, " ");
                }
            }
        }
    }
}
