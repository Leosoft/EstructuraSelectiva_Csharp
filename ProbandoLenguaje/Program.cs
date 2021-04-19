using System;

namespace ProbandoLenguaje
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Introduzca su edad: ");
            String texto;
            texto = Console.ReadLine();
            Console.WriteLine("El texto ingresado es " + texto);*/

            int edad;
            Console.WriteLine("Introduzca su edad: ");
            edad = int.Parse(Console.ReadLine());
            


            if (edad <= 0)
            {
                Console.WriteLine("se encuentra en periodo prenatal");
            }
            else if(edad <= 3)
            {
                Console.WriteLine("se encuentra en periodo de primera infancia");
            }
            else if(edad >= 3 && edad < 6)
            {
                Console.WriteLine("se encuentra en periodo de niñez temprana");
            }
            else if(edad >= 6 && edad < 12)
            {
                Console.WriteLine("se encuentra en niñez intermedia");
            }    
            else if(edad >= 12 && edad < 18)
            {
                Console.WriteLine("se encuentra en periodo de la adolescencia");
            }
            else if(edad >= 18 && edad < 35)
            {
                Console.WriteLine("se encuentra en periodo de la juventud");
            }
            else if(edad >= 35 && edad < 50)
            {
                Console.WriteLine("se encuentra en periodo de la madurez");
            }
            else if(edad >= 50 && edad <= 60)
            {
                Console.WriteLine("se encuentra en periodo de la adultez");
            }
            else if(edad >= 61 && edad <= 120)
            {
                Console.WriteLine("se encuentra en periodo de la vejez");
            }
            else
            {
                Console.WriteLine("la persona ya murio");
            }
        }
        }
    }

