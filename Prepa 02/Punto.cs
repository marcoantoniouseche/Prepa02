using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Punto
    {
        private float x;
        private float y;
        public Punto()
        {

        }
        public Punto(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public void SetX(float _x)
        {
            x = _x;
        }
        public void SetY(float _y)
        {
            y = _y;
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }

        public static Punto operator +(Punto sumando1, Punto sumando2)
        { 
            float nuevoX = sumando1.GetX() + sumando2.GetX();
            float nuevoY = sumando1.GetY() + sumando2.GetY();

            return new Punto(nuevoX, nuevoY); 
        }

        public static Punto operator -(Punto minuendo, Punto sustraendo)
        {
            float nuevoX = minuendo.GetX() - sustraendo.GetX();
            float nuevoY = minuendo.GetY() - sustraendo.GetY();

            return new Punto(nuevoX, nuevoY);
        }

        public static Punto operator *(Punto multiplicando, Punto multiplicador)
        {
            float nuevoX = multiplicando.GetX() * multiplicador.GetX();
            float nuevoY = multiplicando.GetY() * multiplicador.GetY();

            return new Punto(nuevoX, nuevoY); 
        }

        public static Punto operator *(Punto multiplicando, float multiplicador)
        {
            float nuevoX = multiplicador * multiplicando.GetX();
            float nuevoY = multiplicador * multiplicando.GetY();
            
            return new Punto(nuevoX, nuevoY); 
        }

        ~Punto()
        {
            Console.WriteLine($"\nMe estoy destruyendo ({x},{y})");
            //Console.ReadLine();
        }
    }
}
