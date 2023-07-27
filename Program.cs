using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ejercicio_veterinaria.models;

namespace ejercicio_veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1;
            Gato g1;
            Tortuga t1;
            UnionToAnimales a1;

            p1 = new Perro();
            g1 = new Gato();
            t1 = new Tortuga();
            a1 = new UnionToAnimales();

            Console.WriteLine("Hola, bienvenidos a la veterinaria Max, contamos con Perros, Gatos y Tortugas.");
            Console.WriteLine("¿Que animal deseas adoptar? (Perro, Gato o Tortuga)");
            string especie = Console.ReadLine();

            switch (especie)
            {
                case "perro":


                    Console.WriteLine("¿Buscas una mascota o un canino laboral?");
                    string venta = Console.ReadLine();
                    if (venta.Equals("mascota"))
                    {
                        Console.WriteLine("¿Que raza quieres de tu peludito");
                        a1.Raza = Console.ReadLine();
                        Console.WriteLine("¿De que color lo quieres?");
                        a1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        a1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        a1.Genero = Console.ReadLine();
                        Console.WriteLine("¿De que edad estas buscando?");
                        a1.Edad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Haz elegido un peludito con las siguientes caracteristicas:");
                        Console.WriteLine("raza {0}, color {1}, de {2} centimetros, {3} y de {4} meses", a1.Raza, a1.Color, a1.Altura, a1.Genero, a1.Edad);

                    }
                    else if (venta.Equals("canino laboral"))
                    {
                        Console.WriteLine("¿Es canino para seguridad? y/n");
                        bool guardian = true;
                        string input = Console.ReadLine();

                        while (guardian)
                        {
                            if (input.ToUpper() == "Y")
                            {
                                guardian = true;
                                p1.Guardian = guardian;
                                break;
                            }
                            else if (input.ToUpper() == "N")
                            {
                                guardian = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }

                        Console.WriteLine("¿Es para pastoreo? y/n");
                        bool pastoreo = true;
                        string input2 = Console.ReadLine();

                        while (pastoreo)
                        {
                            if (input2.ToUpper() == "Y")
                            {
                                pastoreo = true;
                                p1.Pastoreo = pastoreo;
                                break;
                            }
                            else if (input2.ToUpper() == "N")
                            {
                                pastoreo = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }

                        Console.WriteLine("¿Será perro guía? y/n");
                        bool guia = true;
                        string input3 = Console.ReadLine();

                        while (guia)
                        {
                            if (input3.ToUpper() == "Y")
                            {
                                guia = true;
                                p1.Guia = guia;
                                break;
                            }
                            else if (input3.ToUpper() == "N")
                            {
                                guia = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }

                        Console.WriteLine("¿Que raza quieres de tu peludito");
                        p1.Raza = Console.ReadLine();
                        Console.WriteLine("¿De que color lo quieres?");
                        p1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        p1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        p1.Genero = Console.ReadLine();
                        Console.WriteLine("¿De que edad estas buscando?");
                        p1.Edad = Convert.ToDouble(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine("Haz elegido un peludito con las siguientes caracteristicas:");
                        Console.WriteLine("{0} es guardia, {1} es de pastoreo, {2} es de guía, de raza {3}, {4}, de {5} centimetros, {6} y  de {7} meses", p1.Guardian ? "si" : "no", p1.Pastoreo ? "si" : "no", p1.Guia ? "si" : "no", p1.Raza, p1.Color, p1.Altura, p1.Genero, p1.Edad);
                    }
                    break;

                case "gato":

                    Console.WriteLine("¿Buscas una mascota o un gato laboral?");
                    venta = Console.ReadLine();
                    if (venta.Equals("mascota"))
                    {
                        Console.WriteLine("¿Que raza quieres de tu peludito");
                        a1.Raza = (Console.ReadLine());
                        Console.WriteLine("¿De que color lo quieres?");
                        a1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        a1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        a1.Genero = (Console.ReadLine());
                        Console.WriteLine("¿De que edad estas buscando?");
                        a1.Edad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Haz elegido un peludito con las siguientes caracteristicas:");
                        Console.WriteLine("caza {0}, color {1}, de {2} centimetros, {3} y de {4} meses", a1.Raza, a1.Color, a1.Altura, a1.Genero, a1.Edad);
                    }
                    else if (venta.Equals("gato laboral"))
                    {
                        Console.WriteLine("¿Es gato de caza? y/n");
                        bool caza = true;
                        string input = Console.ReadLine();

                        while (caza)
                        {
                            if (input.ToUpper() == "Y")
                            {
                                caza = true;
                                g1.Caza = caza;
                                break;
                            }
                            else if (input.ToUpper() == "N")
                            {
                                caza = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }

                        Console.WriteLine("¿Es gato para tratamienta de alergias? y/n");
                        bool alergias = true;
                        string input2 = Console.ReadLine();

                        while (alergias)
                        {
                            if (input2.ToUpper() == "Y")
                            {
                                alergias = true;
                                g1.Alergias = alergias;
                                break;
                            }
                            else if (input2.ToUpper() == "N")
                            {
                                alergias = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }
                        Console.WriteLine("¿Que raza quieres de tu peludito");
                        g1.Raza = (Console.ReadLine());
                        Console.WriteLine("¿De que color lo quieres?");
                        g1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        g1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        g1.Genero = (Console.ReadLine());
                        Console.WriteLine("¿De que edad estas buscando?");
                        g1.Edad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Haz elegido un peludito con las siguientes caracteristicas:");
                        Console.WriteLine("{0} es para caza, {1} es para tratamiento de alergias, de raza {2}, color {3}, de {4} centimetros, {5} y de {6} meses", g1.Caza ? "si" : "no", g1.Alergias ? "si" : "no", g1.Raza, g1.Color, g1.Altura, g1.Genero, g1.Edad);
                    }
                        break;

                case "tortuga":

                    Console.WriteLine("¿Buscas una mascota o para fines laborales?");
                    venta = Console.ReadLine();
                    if (venta.Equals("mascota"))
                    {
                        Console.WriteLine("¿Que raza quieres de tu mascota");
                        a1.Raza = (Console.ReadLine());
                        Console.WriteLine("¿De que color lo quieres?");
                        a1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        a1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        a1.Genero = (Console.ReadLine());
                        Console.WriteLine("¿De que edad estas buscando?");
                        a1.Edad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Haz elegido un peludito con las siguientes caracteristicas:");
                        Console.WriteLine("Raza {0}, color {1}, de {2} centimetros, {3} y de {4} meses", a1.Raza, a1.Color, a1.Altura, a1.Genero, a1.Edad);
                    }
                    else if (venta.Equals("fines laborales"))
                    {
                        Console.WriteLine("¿Es para platillos? y/n");
                        bool platillo = true;
                        string input = Console.ReadLine();

                        while (platillo)
                        {
                            if (input.ToUpper() == "Y")
                            {
                                platillo = true;
                                t1.Platillo = platillo;
                                break;
                            }
                            else if (input.ToUpper() == "N")
                            {
                                platillo = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }

                        Console.WriteLine("¿Es tortuga para un vivero? y/n");
                        bool vivero = true;
                        string input2 = Console.ReadLine();

                        while (vivero)
                        {
                            if (input2.ToUpper() == "Y")
                            {
                                vivero = true;
                                t1.Vivero = vivero;
                                break;
                            }
                            else if (input2.ToUpper() == "N")
                            {
                                vivero = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Por favor, escribe y/n");
                            }
                        }
                        Console.WriteLine("¿Que raza quieres de tu peludito");
                        t1.Raza = (Console.ReadLine());
                        Console.WriteLine("¿De que color lo quieres?");
                        t1.Color = Console.ReadLine();
                        Console.WriteLine("¿De que altura sera?");
                        t1.Altura = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("¿Cuál será su genero?");
                        t1.Genero = (Console.ReadLine());
                        Console.WriteLine("¿De que edad estas buscando?");
                        t1.Edad = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Haz elegido un pedido de tortuga con las siguientes caracteristicas:");
                        Console.WriteLine("{0} es para platillo, {1} es para vivero, de raza {2}, color {3}, de {4} centimetros, {5} y de {6} meses", t1.Platillo ? "si" : "no", t1.Vivero ? "si" : "no", t1.Raza, t1.Color, t1.Altura, t1.Genero, t1.Edad);
                    }
                    break;

                default:
                    Console.WriteLine("No tenemos esa especie");
                    break;
            }

            Console.ReadLine();
        }
    }
}
