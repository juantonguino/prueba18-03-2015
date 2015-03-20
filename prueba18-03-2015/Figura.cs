using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba18_03_2015
{
    abstract class Figura: IFigura
    {

        protected double area;
        protected double volumen;

        public abstract void calcularArea();
        public abstract void calcualarVolumen();
        public abstract void pintar();
        public abstract void cambiarTexto();
    }
}
