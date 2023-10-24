using System;

namespace DibujarLineasApp
{
    internal class clsLinea
    {
        private int x_inicio;
        private int y_inicio;
        private int x_final;
        private int y_final;

        private static int contador = 0;

        public clsLinea()
        {
            // Constructor vacío
        }

        public clsLinea(double xInicio, double yInicio, double xFinal, double yFinal)
        {
            this.x_inicio = (int)xInicio;
            this.y_inicio = (int)yInicio;
            this.x_final = (int)xFinal;
            this.y_final = (int)yFinal;
        }

        public int ObtenerXInicio()
        {
            return x_inicio;
        }

        public int ObtenerYInicio()
        {
            return y_inicio;
        }

        public int ObtenerXFinal()
        {
            return x_final;
        }

        public int ObtenerYFinal()
        {
            return y_final;
        }

        public static int ObtenerCuenta()
        {
            contador += 1;
            return contador;
        }
    }
}
