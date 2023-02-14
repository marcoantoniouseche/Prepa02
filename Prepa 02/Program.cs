using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        Punto my_punto = new Punto();
                        Punto my_punto_2 = new Punto(6,8);

                        my_punto.SetX(10);
                        my_punto.SetY(5);

                        my_punto_2.SetX(20);
                        my_punto_2.SetY(45);

                        Console.WriteLine($"Mi valor en x es: {my_punto.GetX()}\nMi valor en y es: {my_punto.GetY()}");
                        Console.WriteLine("Mi valor en x es: {0}\nMi valor en y es: {1}", my_punto_2.GetX(), my_punto_2.GetY());
            */

            Vector my_vector = new Vector(0, 0, 4, 3);
            Vector my_vector_2 = new Vector(0, 0, 4, 3);

            Vector my_vector_3 = my_vector + my_vector_2;
            my_vector += my_vector_2;


            Console.WriteLine($"Mi magnitud es de: {my_vector_3.get_magnitud()}");

            //Testeo del set fin
            Vector vector_a = new Vector();
            vector_a.DisplayVector();

            Punto punto_a = new Punto(8, 4);
            vector_a.set_fin(punto_a);
            vector_a.DisplayVector();

            vector_a.set_fin(5, 5);
            vector_a.DisplayVector();

            //Testeo de la sobrecarga operador resta
            Vector vector_b = new Vector(0, 0, 7, 9);
            Vector vector_c = vector_a - vector_b;
            vector_c.DisplayVector();

            //Testeo de la multiplicación de un vector por un escalar
            vector_c = vector_b * 3;
            vector_c.DisplayVector();

            //Testeo del producto punto
            float producto_punto = vector_a * vector_b;
            Console.WriteLine(producto_punto);
            Console.ReadLine();
        }
    }
}
