// See https://aka.ms/new-console-template for more information
using BibliotecaDePeliculas;
using System;

int day, month, year,historial=-1,tipo=1,historialModify;
String nombre;
double nota;
Peliculas[] biblioteca = new Peliculas[50];
Fecha fechaExtreno = new Fecha();

Console.WriteLine("Bienvenido a la biblioteca de peliculas");
while(tipo!=0)
{
    Console.WriteLine("Seleccione la accion a realizar\n" +
                        "1-->Añadir entrada a la biblioteca\n" +
                        "2-->Cambiar una entrada existente\n" +
                        "3-->Mostrar todas las entradas de la biblioteca\n" +
                        "0-->Acabar proceso\n");
    tipo = Convert.ToInt32(Console.ReadLine());
    if (tipo == 0)
    {
        break;
    }
    else if (tipo<1||tipo>3)
    {
        while(tipo!=1&&tipo!=2&&tipo!=3)
        {
            Console.WriteLine("Seleccione la accion valida a realizar\n" +
                    "1-->Añadir entrada a la biblioteca\n" +
                    "2-->Cambiar una entrada existente\n" +
                    "3-->Mostrar todas las entradas de la biblioteca\n" +
                    "0-->Acabar proceso\n");
            tipo = Convert.ToInt32(Console.ReadLine());
        }

    }else
    {
        switch (tipo)
        {
            case 1:
                Console.Write("Intoduzca el nombre de la pelicula: ");
                nombre= Console.ReadLine();
                Console.Write("Introduzca la fecha de estreno\n" +
                              "Dia: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mes: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Año: ");
                year = Convert.ToInt32(Console.ReadLine());
                    while (!Fecha.comprobacionFecha(day, month, year))
                    {
                    Console.Write("Introduzca una fecha de estreno valida\n" +
                                  "Dia: ");
                    day = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Mes: ");
                    month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Año: ");
                    year = Convert.ToInt32(Console.ReadLine());
                }
                
                fechaExtreno = new Fecha(day,month,year);
                Console.Write("Introduzca la nota que le pone a la pelicula: ");
                nota = Convert.ToDouble(Console.ReadLine());
                while (nota<0||nota>10)
                {
                    Console.Write("Introduzca una nota entre 0 y 10: ");
                    nota = Convert.ToDouble(Console.ReadLine());
                }
                historial++;
                biblioteca[historial]=new Peliculas(nombre,fechaExtreno,nota,historial);
                break;
            case 2:
                Console.Write("Introduzca el numero de historial de la entrada a modificar: ");
                historialModify = Convert.ToInt32(Console.ReadLine());
                if(historialModify<1) { break; }
                        Console.Write("Intoduzca el nombre de la pelicula: ");
                        nombre = Console.ReadLine();
                        Console.Write("Introduzca la fecha de estreno\n" +
                                      "Dia: ");
                        day = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Mes: ");
                        month = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Año: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        while (!Fecha.comprobacionFecha(day, month, year))
                        {
                            Console.Write("Introduzca una fecha de estreno valida\n" +
                                          "Dia: ");
                            day = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Mes: ");
                            month = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Año: ");
                            year = Convert.ToInt32(Console.ReadLine());
                        }

                        fechaExtreno = new Fecha(day, month, year);
                        Console.Write("Introduzca la nota que le pone a la pelicula: ");
                        nota = Convert.ToDouble(Console.ReadLine());
                        while (nota < 0 || nota > 10)
                        {
                            Console.Write("Introduzca una nota entre 0 y 10: ");
                            nota = Convert.ToDouble(Console.ReadLine());
                        }
                    biblioteca[historialModify-1].setNombre(nombre);
                    biblioteca[historialModify-1].setfecha(fechaExtreno);
                    biblioteca[historialModify-1].setNota(nota);
                break;
            case 3:
                for (int i = 0; i <= historial; i++)
                {
                    Console.WriteLine(biblioteca[i].toString());
                }
                break;
        }




    }

}