using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoWashingtonBriones3B
{
    public abstract class PROFESORPORNOMBRAMIENTO : PROFESORES
    {
        public class PROFESORPORNOMBRAMIENTO
        {
            int horasextra;
            double sueldomensual, sueldofijo, preciohoraextra;


            public PROFESORPORNOMBRAMIENTO(int horasextra, double sueldomensual, double preciohoraextra)
            {
                int horasextra;
                double sueldomensual, sueldofijo, sueldoanual;
                sueldomensual = sueldofijo + preciohoraextra * horasextra;
            }
            public double getsueldomensual()
            {
                return sueldomensual;
            }
            public void setsueldomensual(double sueldomensual)
            {
                this.sueldomensual = sueldomensual;
            }

        }
    }
}