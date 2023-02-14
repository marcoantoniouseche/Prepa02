using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Vector
    {
        Punto origen;
        Punto fin;
        double magnitud;

        public Vector()
        {
            origen = new Punto(0,0);
            fin = new Punto(1, 1);
            calcular_magnitud();
        }
        public Vector(Punto _origen, Punto _fin)
        {
            origen = new Punto(_origen.GetX(),_origen.GetY());
            fin = new Punto(_fin.GetX(), _fin.GetY());
            calcular_magnitud();
        }
        public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
        {
            origen = new Punto(x_origen,y_origen);
            fin = new Punto(x_fin, y_fin);
            calcular_magnitud();
        }
        private void calcular_magnitud()
        {
            magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()),2) + Math.Pow((fin.GetY() - origen.GetY()),2));
        }
        public double get_magnitud()
        {
            return magnitud;
        }
        
        public void set_origen(Punto _origen)
        {
            origen = new Punto(_origen.GetX(), _origen.GetY());
            calcular_magnitud();
        }
        public void set_origen(float x, float y)
        {
            origen = new Punto(x,y);
            calcular_magnitud();
        }

        public void set_fin(Punto _fin)
        {
            fin = _fin;
            calcular_magnitud();
        }

        public void set_fin(float x, float y)
        {
            fin.SetX(x);
            fin.SetY(y);
            calcular_magnitud();
        }

        public static Vector operator +(Vector sumando1, Vector sumando2)
        {
            Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(),
                                           sumando1.origen.GetY() + sumando2.origen.GetY());

            Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(),
                                        sumando1.fin.GetY() + sumando2.fin.GetY());


            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static Vector operator -(Vector minuendo, Vector sustraendo)
        {
            Punto nuevo_origen = minuendo.origen - sustraendo.origen;
            Punto nuevo_fin = minuendo.fin - sustraendo.fin;

            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static Vector operator *(Vector multiplicando, float multiplicador)
        {
            Punto nuevo_origen = multiplicando.origen * multiplicador;
            Punto nuevo_fin = multiplicando.fin * multiplicador;
            
            return new Vector(nuevo_origen, nuevo_fin);
        }

        public static float operator *(Vector multiplicando, Vector multiplicador)
        {
            float producto = ((multiplicando.fin.GetX() - multiplicando.origen.GetX()) * 
                (multiplicador.fin.GetX() - multiplicador.origen.GetX())) +
            ((multiplicando.fin.GetY() - multiplicando.origen.GetY()) * 
                (multiplicador.fin.GetY() - multiplicador.origen.GetY()));

            return producto;
        }

        public void DisplayVector()
        {
            Console.WriteLine($"({fin.GetX() - origen.GetX()}, {fin.GetY() - origen.GetY()})");
        }

        //En esta clase podemos utilizar los miembros private origen y fin, porque pertenecen a esta clase y sabemos que
        //el ámbito de todo lo que tenga modificador de acceso private, se delimitará dentro de su misma clase.
    }
}
